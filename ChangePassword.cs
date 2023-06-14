using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
  public partial class ChangePassword : Form
  {
    public ChangePassword()
    {
      InitializeComponent();
    }

    private void ShowError(string err)
    {
      lbl_Error.ForeColor = Color.Red;
      lbl_Error.Text = err;
      lbl_Error.Show();
    }

    private void ShowMessage(string msg)
    {
      lbl_Error.ForeColor = Color.White;
      lbl_Error.Text = msg;
      lbl_Error.Show();
    }

    private void SetControls(bool state)
    {
      txt_OldPassword.Enabled = state;
      txt_NewPassword.Enabled = state;
      txt_ConfirmPassword.Enabled = state;
      cmd_ChangePassword.Enabled = state;
    }

    private void CheckPasswords()
    {
      if (Program.session.password != txt_OldPassword.Text)
      {
        ShowError("Incorrect password");
        cmd_ChangePassword.Enabled = false;
        return;
      }

      if (txt_OldPassword.Text == txt_NewPassword.Text)
      {
        ShowError("Enter a new password");
        cmd_ChangePassword.Enabled = false;
        return;
      }
      
      if (txt_NewPassword.Text.Length > Util.MaximumPasswordLength)
      {
        ShowError("New password is too long");
        cmd_ChangePassword.Enabled = false;
        return;
      }
      if (txt_NewPassword.Text.Length < Util.MinimumPasswordLength)
      {
        ShowError("New password is too short");
        cmd_ChangePassword.Enabled = false;
        return;
      }

      if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
      {
        ShowError("Password does not match");
        cmd_ChangePassword.Enabled = false;
        return;
      }

      lbl_Error.Hide();
      cmd_ChangePassword.Enabled = true;
    }

    private void txt_OldPassword_TextChanged(object sender, EventArgs e)
    {
      CheckPasswords();
    }

    private void txt_NewPassword_TextChanged(object sender, EventArgs e)
    {
      CheckPasswords();
    }

    private void txt_ConfirmPassword_TextChanged(object sender, EventArgs e)
    {
      CheckPasswords();
    }

    private void cmd_ChangePassword_Click(object sender, EventArgs e)
    {
      SetControls(false);
      ShowMessage("Changing password");
      bwork_PasswordChange.RunWorkerAsync();
    }

    private void bwork_PasswordChange_DoWork(object sender, DoWorkEventArgs e)
    {
      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        cmd.CommandText = $"UPDATE UserInfo SET password = '{txt_NewPassword.Text}' WHERE id = {Program.session.userId};";
        cmd.ExecuteNonQuery();
      }
    }

    private void bwork_PasswordChange_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null)
      {
        ShowMessage("Changed password");
        Program.session = Program.session.ChangePassword(txt_NewPassword.Text);
        MessageBox.Show("Password changed successfully");
        Close();
      }
      else
      {
        ShowError($"{e.Error.Message}");
        SetControls(true);
      }
    }

    private void cb_ShowPass1_CheckedChanged(object sender, EventArgs e)
    {
      txt_OldPassword.UseSystemPasswordChar = !txt_OldPassword.UseSystemPasswordChar;
    }

    private void cb_ShowPass2_CheckedChanged(object sender, EventArgs e)
    {
      txt_NewPassword.UseSystemPasswordChar = !txt_NewPassword.UseSystemPasswordChar;
    }

    private void cb_ShowPass3_CheckedChanged(object sender, EventArgs e)
    {
      txt_ConfirmPassword.UseSystemPasswordChar = ! txt_ConfirmPassword.UseSystemPasswordChar;
    }
    private void ChangePassword_MouseLeave(object sender, EventArgs e)
    {
      Close();
    }
  }
}
