using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using System.IO;

namespace NoteView
{
  public partial class SetupDB : Form
  {
    // Connect DB Set-up
    private bool sd_hasEmphasizedRequiredFields = false;
    private readonly Staller staller = new Staller();

    public SetupDB()
    {
      InitializeComponent();
    }

    private void SetupDB_Shown(object sender, EventArgs e)
    {
      try
      {
        if (File.Exists(DBConnectionSave.GetSavePath()))
        {
          DBConnectionSave sav = DBConnectionSave.Deserialize();

          SDShowMessage("Save file detected");
          SDSetControls(false);
          txt_Server.Text = sav.connData.server;
          if (sav.connData.port != null) txt_Port.Text = sav.connData.port;
          txt_Username.Text = sav.connData.username;
          txt_Password.Text = sav.connData.password;
          txt_DB.Text = sav.connData.database;

          bwork_Connection.RunWorkerAsync(sav.connData);
          return;
        }
      }
      catch (Exception ex)
      {
        SDShowError("Cannot load save", ex.Message);
      }
    }

    private void SDShowMessage(string msg)
    {
      lbl_ConnectOutput.ForeColor = Color.White;
      lbl_ConnectOutput.Text = msg;
      lbl_ConnectOutput.Show();
      lbl_ErrorDetails.Hide();
    }
    private void SDShowError(string msg, string details = null)
    {
      lbl_ConnectOutput.ForeColor = Color.Red;
      lbl_ConnectOutput.Text = msg;
      lbl_ConnectOutput.Show();
      if (details != null)
      {
        lbl_ErrorDetails.Text = details;
        lbl_ErrorDetails.Show();
      }
    }

    private void SDSetControls(bool state)
    {
      txt_Server.Enabled = state;
      txt_Port.Enabled = state;
      txt_Username.Enabled = state;
      txt_Password.Enabled = state;
      txt_DB.Enabled = state;
      btn_Connect.Enabled = state;
      cb_ForceConnect.Enabled = state;
    }

    private void btn_Connect_Click(object sender, EventArgs e)
    {
      SDShowMessage("Connecting to database..");

      ConnectionArgs cargs = new ConnectionArgs(
        txt_Server.Text, string.IsNullOrEmpty(txt_Port.Text) ? null : txt_Port.Text,
        txt_Username.Text, txt_Password.Text, string.IsNullOrEmpty(txt_DB.Text) ? "noteview" : txt_DB.Text
      );

      if (Util.HasEmpty(cargs.server, cargs.username, cargs.password))
      {
        SDShowError("Missing field/s");
        if (!sd_hasEmphasizedRequiredFields)
        {
          Util.EmphasizeRequiredFields(lbl_Server, lbl_user, lbl_password);
          sd_hasEmphasizedRequiredFields = true;
        }
        return;
      }

      SDSetControls(false);
      bwork_Connection.RunWorkerAsync(cargs);
    }

    private void bwork_Connection_DoWork(object sender, DoWorkEventArgs e)
    {
      var cargs = (ConnectionArgs) e.Argument;
      e.Result = Util.CreateOrConnectDB(cargs, cb_ForceConnect.Checked, (p, msg) => bwork_Connection.ReportProgress(p, msg));
    }

    private void bwork_Connection_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      SDShowMessage($"Setting up.. ({e.ProgressPercentage}%) {e.UserState}");
    }

    private void bwork_Connection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {

      if (e.Error == null)
      {
        var res = (Util.CreateOrConnectDBResult) e.Result;

        Session.conn = res.conn;
        SDShowMessage("Connected");

        var sav = new DBConnectionSave
        {
          connData = res.args
        };

        sav.Serialize();

        if (res.hasAccount)
        {
          staller.RunWorkerAsync((Staller.Done)(() => Close()));
          Program.dbConnOk = true;
        }
        else
        {
          SUSwapBoxes();
        }
      }
      else
      {
        switch (e.Error)
        {
          case MySqlException exc:
            SDShowError($"Database connection error", exc.Message);
            break;
          case ValidationException exc:
            SDShowError($"Validation failed", exc.Message);
            break;
          case ArgumentException exc:
            SDShowError("A field contained invalid value");
            break;
        }
        SDSetControls(true);
      }
    }

    // First Account Set-up
    private bool su_hasEmphasizedRequiredFields = false;

    private void SUShowMessage(string msg)
    {
      lbl_SignUpOutput.Text = msg;
      lbl_SignUpOutput.ForeColor = Color.White;
      lbl_SignUpOutput.Show();
    }

    private void SUShowError(string msg)
    {
      lbl_SignUpOutput.Text = msg;
      lbl_SignUpOutput.ForeColor = Color.Red;
      lbl_SignUpOutput.Show();
    }

    private void SUSwapBoxes()
    {
      gbx_FASetup.Visible = !gbx_FASetup.Visible;
      gb_dbcnnct.Visible = !gb_dbcnnct.Visible;
    }

    private void SUSetControls(bool state)
    {
      txt_SU_Username.Enabled = state;
      txt_SU_Fname.Enabled = state;
      txt_SU_Lname.Enabled = state;
      txt_SU_Pword.Enabled = state;
      txt_SU_Pword2.Enabled = state;
      cb_ShowPass.Enabled = state;
      cb_ShowPass2.Enabled = state;
      cmd_SignUp.Enabled = state;
    }

    private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
    {
      txt_SU_Pword.UseSystemPasswordChar = !txt_SU_Pword.UseSystemPasswordChar;
    }

    private void cb_ShowPass2_CheckedChanged(object sender, EventArgs e)
    {
      txt_SU_Pword2.UseSystemPasswordChar = !txt_SU_Pword2.UseSystemPasswordChar;
    }

    private void cmd_SignUp_Click(object sender, EventArgs e)
    {
      if (Util.HasEmpty(txt_SU_Username.Text, txt_SU_Fname.Text, txt_SU_Lname.Text, txt_SU_Pword.Text, txt_SU_Pword2.Text))
      {
        SUShowError("Missing required field/s");
        if (!su_hasEmphasizedRequiredFields)
        {
          Util.EmphasizeRequiredFields(lbl_SU_Uname, lbl_SU_Fname, lbl_SU_Lname, lbl_SU_Pword, lbl_SU_Pword2);
          su_hasEmphasizedRequiredFields = true;
        }
        return;
      }

      string uname = txt_SU_Username.Text;
      string fname = txt_SU_Fname.Text;
      string lname = txt_SU_Lname.Text;
      string pword = txt_SU_Pword.Text;

      if (txt_SU_Pword2.Text != pword)
      {
        SUShowError("Password does not match");
        return;
      }

      SUSetControls(false);
      bwork_SignUp.RunWorkerAsync(new object[] { true, uname, pword, fname, lname });
    }

    private void bwork_SignUp_DoWork(object sender, DoWorkEventArgs e)
    {
      object[] args = (object[])e.Argument;
      Session.RegisterAccount((bool)args[0], (string)args[1], (string)args[2], (string)args[3], (string)args[4]);
    }

    private void bwork_SignUp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        if (e.Error is ArgumentException || e.Error is InvalidOperationException || e.Error is MySqlException)
        {
          SUShowError(e.Error.Message);
        }
      }
      else
      {
        SUShowMessage("Account added");
        staller.RunWorkerAsync((Staller.Done)(() => Close()));
        Program.dbConnOk = true;
        return;
      }

      SUSetControls(true);
    }

    private void cb_ForceConnect_CheckedChanged(object sender, EventArgs e)
    {
      if (cb_ForceConnect.Checked)
      {
        tt_ForceConnectHint.SetToolTip(cb_ForceConnect, "Uncheck to create a database if does not exist");
      }
      else
      {
        tt_ForceConnectHint.SetToolTip(cb_ForceConnect, "Check if connecting to an existing database");
      }
    }
  }
}
