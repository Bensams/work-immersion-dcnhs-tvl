using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteView
{
  public partial class AddUser : Form
  {
    private bool sd_hasEmphasizedFields = false;
    private bool su_hasEmphasizedFields = false;

    private Session session;

    public AddUser()
    {
      InitializeComponent();
    }

    private void SwapBoxes()
    {
      gbx_AdminAuth.Visible = !gbx_AdminAuth.Visible;
      gbx_SignUp.Visible = !gbx_SignUp.Visible;
    }

    // Admin Authentication Group Box

    private void TryAAAuth()
    {
      string uname = tb_AAusername.Text.Trim();
      string pword = tb_AApass.Text;

      session = Session.LoginAccount(uname, pword);

      if (!session.adminMode) throw new InvalidOperationException("Account is unauthorized");
    }

    private void AAShowError(string msg)
    {
      lbl_AAAuthMessage.Text = msg;
      lbl_AAAuthMessage.ForeColor = Color.Red;
      lbl_AAAuthMessage.Show();
    }

    private void AAShowMessage(string msg)
    {
      lbl_AAAuthMessage.Text = msg;
      lbl_AAAuthMessage.ForeColor = Color.White;
      lbl_AAAuthMessage.Show();
    }

    private void btn_AAlogin_Click(object sender, EventArgs e)
    {
      if (Util.HasEmpty(tb_AAusername.Text, tb_AApass.Text))
      {
        AAShowError("Missing required field/s");
        if (!sd_hasEmphasizedFields)
        {
          Util.EmphasizeRequiredFields(lbl_AAusername, lbl_AApass);
          sd_hasEmphasizedFields = true;
        }
        return;
      }

      btn_AAlogin.Enabled = false;
      bwork_Auth.RunWorkerAsync();
    }

    private void chb_AAshowpass_CheckedChanged(object sender, EventArgs e)
    {
      tb_AApass.UseSystemPasswordChar = !tb_AApass.UseSystemPasswordChar;
    }

    // Sign Up Group Box

    private void SUReturn()
    {
      SwapBoxes();
      lbl_AAAuthMessage.Hide();
      tb_AAusername.Text = "";
      tb_AApass.Text = "";
      lbl_AdminMessage.Hide();
      SUClearFields();
    }

    private void SUClearFields()
    {
      tbx_SignUpUid.Text = "";
      tbx_SignUpFirstName.Text = "";
      tbx_SignUpLastName.Text = "";
      tbx_SignUpPass1.Text = "";
      tbx_SignUpPass2.Text = "";
      cb_AdminCheck.Checked = false;
      lbl_SignUpMsg.Hide();
    }

    private void SUTrySignUp()
    {
      string uname = tbx_SignUpUid.Text.Trim();
      string fname = tbx_SignUpFirstName.Text.Trim();
      string lname = tbx_SignUpLastName.Text.Trim();
      string pword = tbx_SignUpPass1.Text;
      string confirmPword = tbx_SignUpPass2.Text;
      bool isAdmin = cb_AdminCheck.Checked;

      if (pword != confirmPword)
      {
        throw new ArgumentException("Password does not match");
      }

      Session.RegisterAccount(isAdmin, uname, pword, fname, lname);
    }

    private void SUShowError(string msg)
    {
      lbl_SignUpMsg.Text = msg;
      lbl_SignUpMsg.ForeColor = Color.Red;
      lbl_SignUpMsg.Show();
    }

    private void SUShowMessage(string msg)
    {
      lbl_SignUpMsg.Text = msg;
      lbl_SignUpMsg.ForeColor = Color.White;
      lbl_SignUpMsg.Show();
    }

    private void btn_SignUp_Click(object sender, EventArgs e)
    {
      if (Util.HasEmpty(tbx_SignUpUid.Text, tbx_SignUpFirstName.Text, tbx_SignUpLastName.Text, tbx_SignUpPass1.Text, tbx_SignUpPass2.Text))
      {
        SUShowError("Missing required field/s");
        if (!su_hasEmphasizedFields)
        {
          Util.EmphasizeRequiredFields(lbl_SignUpUid, lbl_SignUpFirstName, lbl_SignUpLastName, lbl_SignUpPass1, lbl_SignUpPass2 );
          su_hasEmphasizedFields = true;
        }
        return;
      }

      btn_SignUp.Enabled = false;
      bwork_SignUp.RunWorkerAsync();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      tbx_SignUpPass1.UseSystemPasswordChar = !tbx_SignUpPass1.UseSystemPasswordChar;
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      tbx_SignUpPass2.UseSystemPasswordChar = !tbx_SignUpPass2.UseSystemPasswordChar;
    }

    private void llbl_GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SUReturn();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SUClearFields();
    }

    private void bwork_Auth_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      TryAAAuth();
    }

    private void bwork_Auth_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null)
      {
        AAShowMessage("Welcome admin");
        SwapBoxes();
        lbl_AdminMessage.Text = $"Authenticated as {session.lastName}, {session.firstName} ({session.username})";
        lbl_AdminMessage.Visible = true;
      }
      else
      {
        if (e.Error is ArgumentException || e.Error is InvalidOperationException)
        {
          AAShowError(e.Error.Message);
        }
      }
      btn_AAlogin.Enabled = true;
    }

    private void bwork_SignUp_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      SUTrySignUp();
    }

    private void bwork_SignUp_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null)
      {
        SUShowMessage("Account added");
      }
      else if (e.Error is ArgumentException || e.Error is InvalidOperationException)
      {
        SUShowError(e.Error.Message);
      }
      btn_SignUp.Enabled = true;
    }

    private void llbl_AA_GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Close();
    }
  }
}
