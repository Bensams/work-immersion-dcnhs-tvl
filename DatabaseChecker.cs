using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using MySql.Data.MySqlClient;

namespace NoteView
{
  internal class DatabaseChecker
  {
    private readonly TableParser parser = new TableParser();
    private readonly MySqlConnection conn;
    private readonly string dbName;
    private MySqlCommand command;

    private List<Table> GetAllTables()
    {
      List<Table> tables = new List<Table>();

      foreach (Util.TableInfo info in Util.tableOrder)
      {
        parser.Parse(tables, info.schema);
      }

      return tables;
    }

    private static void error(string table, string cause)
    {
      throw new ValidationException($"At {table}, {cause}");
    }

    private void AssertTableEquality(Table table)
    {
      // Check if the table itself exists
      command.CommandText = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{dbName}' AND TABLE_NAME = '{table.name}';";
      using (MySqlDataReader dr = command.ExecuteReader())
      {
        if (!dr.HasRows) error(dbName, $"Missing table '{table.name}'");
      }

      // Check if the fields are present
      command.CommandText = "SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, EXTRA FROM INFORMATION_SCHEMA.COLUMNS "
                            + $"WHERE TABLE_SCHEMA = '{dbName}' AND TABLE_NAME = '{table.name}';";

      using (MySqlDataReader dr = command.ExecuteReader())
      {
        int numFields = table.fields.Count;
        int foundFields = 0;

        while (dr.Read())
        {
          string name = dr.GetString("COLUMN_NAME");
          string type = dr.GetString("DATA_TYPE");
          bool required = dr.GetString("IS_NULLABLE") == "NO";
          bool autoIncr = dr.GetString("EXTRA") == "auto_increment";

          if (table.Seek(name, type, required, autoIncr) != -1) ++foundFields;
          else error(table.name, $"Cannot find field '{name}' of type '{type}'");
        }

        
        if (foundFields != numFields) error(table.name, $"Missing {numFields - foundFields} field/s");
      }

      // Check references and primary keys
      command.CommandText = "SELECT COLUMN_NAME, CONSTRAINT_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE "
                            + $"WHERE REFERENCED_TABLE_SCHEMA = '{dbName}' AND TABLE_SCHEMA = '{dbName}' AND TABLE_NAME = '{table.name}';";
      using (MySqlDataReader dr = command.ExecuteReader())
      {
        while (dr.Read())
        {
          string field = dr.GetString("COLUMN_NAME");
          int i = table.Seek(field);
          if (i == -1) continue;

          Field theField = table.fields[i];

          // Is invariantly not null
          string constraint = dr.GetString("CONSTRAINT_NAME");
          string refTable = dr.GetString("REFERENCED_TABLE_NAME");
          string refField = dr.GetString("REFERENCED_COLUMN_NAME");

          // theField.refTable and theField.refField must be both null if one is null

          if (theField.refTable == null)
          {
            if (!dr.IsDBNull(dr.GetOrdinal("REFERENCED_TABLE_NAME")))
            {
              error(table.name, "Must not reference a foreign key");
            }
          }
          else if (dr.IsDBNull(dr.GetOrdinal("REFERENCED_TABLE_NAME")))
          {
            error(table.name, "Must reference a foreign key");
          }
          else if (theField.refTable.EqualsIgnoreCase(refTable))
          {
            if (!theField.refField.EqualsIgnoreCase(refField))
            {
              error(table.name, "Foreign key reference mismatch");
            }
          }
          else
          {
            error(table.name, "Foreign table reference mismatch");
          }
        }
      }
    }

    private DatabaseChecker(MySqlConnection conn)
    {
      dbName = conn.Database;
      this.conn = conn;
      List<Table> tables = GetAllTables();

      using (command = conn.CreateCommand())
      {
        foreach (Table table in tables)
        {
          AssertTableEquality(table);
        }
      }
    }

    public static void Check(MySqlConnection conn)
    {
      new DatabaseChecker(conn);
    }
  }
}
