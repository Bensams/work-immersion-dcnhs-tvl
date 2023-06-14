using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NoteView
{
  [Serializable]
  internal readonly struct ConnectionArgs
  {
    public readonly string server;
    public readonly string port;
    public readonly string username;
    public readonly string password;
    public readonly string database;

    public ConnectionArgs(string server, string port, string username, string password, string database = null)
    {
      this.server = server;
      this.port = port;
      this.username = username;
      this.password = password;
      this.database = database;
    }

    public string ConnectionString(bool includeDB)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append($"Server={server};");
      if (port != null)
      {
        sb.Append($"Port={port};");
      }
      sb.Append($"Uid={username};");
      sb.Append($"Pwd={password};");
      if (includeDB)
      {
        sb.Append($"Database={database};");
      }
      return sb.ToString();
    }
  };

  public class ValidationException : Exception
  {
    public ValidationException(string msg) : base(msg) { }
  }

  internal static class Util
  {
    public const int MinimumUsernameLength = 8;
    public const int MaximumUsernameLength = 35;

    public const int MinimumPasswordLength = 8;
    public const int MaximumPasswordLength = 16;

    public static readonly Regex unameRegex = new Regex("^[_a-zA-Z][\\._a-zA-Z0-9]*$");
    public static readonly Regex nameRegex = new Regex("^[a-zA-Z]+( [a-zA-Z]+)*$");

    public static bool HasEmpty(params string[] strs)
    {
      foreach (string str in strs)
      {
        if (str.Trim().Length == 0) return true;
      }
      return false;
    }
    public static void EmphasizeRequiredFields(params Label[] lbls)
    {
      foreach (Label lbl in lbls)
      {
        lbl.Text += "*";
        lbl.ForeColor = Color.Red;
      }
    }

    public static bool DBExists(this MySqlConnection conn, string dbName)
    {
      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = $"SELECT DISTINCT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{dbName}';";
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          return rd.HasRows;
        }
      }
    }

    public static void AssertValidity(string uname, string pword)
    {
      if (uname.Length < MinimumUsernameLength)
      {
        throw new ArgumentException("Username is too short");
      }

      if (uname.Length > MaximumUsernameLength)
      {
        throw new ArgumentException("Username is too long");
      }

      if (pword.Length < MinimumPasswordLength)
      {
        throw new ArgumentException("Password is too short");
      }

      if (pword.Length > MaximumPasswordLength)
      {
        throw new ArgumentException("Password is too long");
      }

      if (!unameRegex.IsMatch(uname))
      {
        throw new ArgumentException("Username has invalid character/s");
      }
    }

    public static void AssertValidity(string uname, string pword, string fname, string lname)
    {
      AssertValidity(uname, pword);

      if (!nameRegex.IsMatch(fname))
      {
        throw new ArgumentException("First name has invalid character/s");
      }

      if (!nameRegex.IsMatch(lname))
      {
        throw new ArgumentException("Last name has invalid character/s");
      }
    }

    public static bool IsValidPassword(string password)
    {
      return MinimumPasswordLength <= password.Length && password.Length <= MaximumPasswordLength; 
    }

    internal readonly struct CreateOrConnectDBResult
    {
      public readonly bool hasAccount;
      public readonly ConnectionArgs args;
      public readonly MySqlConnection conn;

      public CreateOrConnectDBResult(bool hasAccount, ConnectionArgs args, MySqlConnection conn)
      {
        this.hasAccount = hasAccount;
        this.args = args;
        this.conn = conn;
      }
    }

    internal delegate void CreateOrConnectProgressReporter(int percent, object indicator);

    internal static CreateOrConnectDBResult CreateOrConnectDB(ConnectionArgs args, bool forceConnect, CreateOrConnectProgressReporter progress = null)
    {
      // Test if db exists first.
      string connString = args.ConnectionString(false);
      Console.WriteLine(connString);

      var conn = new MySqlConnection(connString);
      conn.Open();
      progress?.Invoke(20, "Checking database");

      if (forceConnect || conn.DBExists(args.database))
      {
        // DB exists. Validate and connect
        conn.ChangeDatabase(args.database);
        progress?.Invoke(50, $"Found '{args.database}'. Validating database");
        DatabaseChecker.Check(conn);
      }
      else
      {
        // DB does not exist. Create db
        progress?.Invoke(30, "No database found. Creating database");
        using (MySqlCommand cmd = conn.CreateCommand())
        {
          cmd.CommandText = $"CREATE DATABASE {args.database};";
          cmd.ExecuteNonQuery();
          cmd.CommandText = $"USE {args.database};";
          cmd.ExecuteNonQuery();
        }
        progress?.Invoke(40, "Database created. Creating tables");

        int percent = 40;
        int step = 60 / Util.tableOrder.Length;
        using (MySqlCommand cmd = conn.CreateCommand())
        {
          foreach (Util.TableInfo info in Util.tableOrder)
          {
            progress?.Invoke(percent, $"Creating {info.name}");
            percent += step;
            cmd.CommandText = info.schema;
            cmd.ExecuteNonQuery();
          }
        }
      }

      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = $"SELECT COUNT(id) AS numAcc FROM UserInfo;";
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          rd.Read();
          return new CreateOrConnectDBResult(rd.GetInt32(0) != 0, args, conn);
        }
      }
    }

    public struct TableInfo
    {
      public string name, schema;

      public TableInfo(string name, string schema)
      {
        this.name = name;
        this.schema = schema;
      }
    }

    // README! Make sure the SQL schemas are in order
    public static readonly TableInfo[] tableOrder =
    {
      new TableInfo("UserInfo", Properties.Resources.user_info),
      new TableInfo("Roon", Properties.Resources.room)
    };

  }
}
