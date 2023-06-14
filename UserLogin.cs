using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteView
{
  public partial class UserLogin : Form
  {
    private readonly Staller staller = new Staller();
    private bool hasEmphasizedFields = false;
    private readonly AddUser addUserForm = new AddUser();

    public UserLogin()
    {
      InitializeComponent();
    }

    private void SetControls(bool state)
    {
      tb_username.Enabled = state;
      tb_pass.Enabled = state;
      btn_login.Enabled = state;
    }

    private void ShowMessage(string msg)
    {
      lbl_AuthMessage.ForeColor = Color.White;
      lbl_AuthMessage.Text = msg;
      lbl_AuthMessage.Show();
    }

    private void ShowError(string msg)
    {
      lbl_AuthMessage.ForeColor = Color.Red;
      lbl_AuthMessage.Text = msg;
      lbl_AuthMessage.Show();
    }
    private void btn_login_Click(object sender, EventArgs e)
    {
      if (Util.HasEmpty(tb_pass.Text, tb_username.Text))
      {
        ShowError("Missing required field/s");
        if (!hasEmphasizedFields)
        {
          Util.EmphasizeRequiredFields(lbl_username, lbl_pass);
          hasEmphasizedFields = true; 
        }
        return;
      }

      SetControls(false);
      bwork_Authentication.RunWorkerAsync();
    }

    private void chb_showpass_CheckedChanged(object sender, EventArgs e)
    {
      tb_pass.UseSystemPasswordChar = !tb_pass.UseSystemPasswordChar;
    }

    private void llbl_AddAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      addUserForm.ShowDialog();
    }

    private void bwork_Authentication_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      Program.session = Session.LoginAccount(tb_username.Text.Trim(), tb_pass.Text.Trim());
    }

    private void bwork_Authentication_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null)
      {
        ShowMessage("Authenticated");
        staller.RunWorkerAsync((Staller.Done)(() => Close()));
      }
      else if (e.Error is InvalidOperationException || e.Error is ArgumentException)
      {
        ShowError(e.Error.Message);
        SetControls(true);
      }
    }
  }
}
