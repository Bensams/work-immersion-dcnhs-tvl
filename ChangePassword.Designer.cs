namespace NoteView
{
  partial class ChangePassword
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lbl_OldPassword = new System.Windows.Forms.Label();
      this.lbl_NewPassword = new System.Windows.Forms.Label();
      this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
      this.txt_OldPassword = new System.Windows.Forms.TextBox();
      this.cmd_ChangePassword = new System.Windows.Forms.Button();
      this.txt_NewPassword = new System.Windows.Forms.TextBox();
      this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
      this.lbl_Error = new System.Windows.Forms.Label();
      this.bwork_PasswordChange = new System.ComponentModel.BackgroundWorker();
      this.cb_ShowPass1 = new System.Windows.Forms.CheckBox();
      this.cb_ShowPass2 = new System.Windows.Forms.CheckBox();
      this.cb_ShowPass3 = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // lbl_OldPassword
      // 
      this.lbl_OldPassword.AutoSize = true;
      this.lbl_OldPassword.BackColor = System.Drawing.Color.Transparent;
      this.lbl_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_OldPassword.ForeColor = System.Drawing.SystemColors.Control;
      this.lbl_OldPassword.Location = new System.Drawing.Point(47, 90);
      this.lbl_OldPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lbl_OldPassword.Name = "lbl_OldPassword";
      this.lbl_OldPassword.Size = new System.Drawing.Size(95, 15);
      this.lbl_OldPassword.TabIndex = 0;
      this.lbl_OldPassword.Text = "Old Password";
      // 
      // lbl_NewPassword
      // 
      this.lbl_NewPassword.AutoSize = true;
      this.lbl_NewPassword.BackColor = System.Drawing.Color.Transparent;
      this.lbl_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_NewPassword.ForeColor = System.Drawing.SystemColors.Control;
      this.lbl_NewPassword.Location = new System.Drawing.Point(42, 136);
      this.lbl_NewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lbl_NewPassword.Name = "lbl_NewPassword";
      this.lbl_NewPassword.Size = new System.Drawing.Size(101, 15);
      this.lbl_NewPassword.TabIndex = 1;
      this.lbl_NewPassword.Text = "New Password";
      // 
      // lbl_ConfirmPassword
      // 
      this.lbl_ConfirmPassword.AutoSize = true;
      this.lbl_ConfirmPassword.BackColor = System.Drawing.Color.Transparent;
      this.lbl_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_ConfirmPassword.ForeColor = System.Drawing.SystemColors.Control;
      this.lbl_ConfirmPassword.Location = new System.Drawing.Point(22, 183);
      this.lbl_ConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
      this.lbl_ConfirmPassword.Size = new System.Drawing.Size(123, 15);
      this.lbl_ConfirmPassword.TabIndex = 2;
      this.lbl_ConfirmPassword.Text = "Confirm Password";
      // 
      // txt_OldPassword
      // 
      this.txt_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_OldPassword.Location = new System.Drawing.Point(160, 90);
      this.txt_OldPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txt_OldPassword.Name = "txt_OldPassword";
      this.txt_OldPassword.Size = new System.Drawing.Size(176, 19);
      this.txt_OldPassword.TabIndex = 3;
      this.txt_OldPassword.UseSystemPasswordChar = true;
      this.txt_OldPassword.TextChanged += new System.EventHandler(this.txt_OldPassword_TextChanged);
      // 
      // cmd_ChangePassword
      // 
      this.cmd_ChangePassword.Enabled = false;
      this.cmd_ChangePassword.Location = new System.Drawing.Point(124, 262);
      this.cmd_ChangePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cmd_ChangePassword.Name = "cmd_ChangePassword";
      this.cmd_ChangePassword.Size = new System.Drawing.Size(112, 24);
      this.cmd_ChangePassword.TabIndex = 4;
      this.cmd_ChangePassword.Text = "Change Password";
      this.cmd_ChangePassword.UseVisualStyleBackColor = true;
      this.cmd_ChangePassword.Click += new System.EventHandler(this.cmd_ChangePassword_Click);
      // 
      // txt_NewPassword
      // 
      this.txt_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_NewPassword.Location = new System.Drawing.Point(160, 136);
      this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txt_NewPassword.Name = "txt_NewPassword";
      this.txt_NewPassword.Size = new System.Drawing.Size(176, 19);
      this.txt_NewPassword.TabIndex = 5;
      this.txt_NewPassword.UseSystemPasswordChar = true;
      this.txt_NewPassword.TextChanged += new System.EventHandler(this.txt_NewPassword_TextChanged);
      // 
      // txt_ConfirmPassword
      // 
      this.txt_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_ConfirmPassword.Location = new System.Drawing.Point(160, 183);
      this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
      this.txt_ConfirmPassword.Size = new System.Drawing.Size(176, 19);
      this.txt_ConfirmPassword.TabIndex = 6;
      this.txt_ConfirmPassword.UseSystemPasswordChar = true;
      this.txt_ConfirmPassword.TextChanged += new System.EventHandler(this.txt_ConfirmPassword_TextChanged);
      // 
      // lbl_Error
      // 
      this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Error.ForeColor = System.Drawing.Color.Red;
      this.lbl_Error.Location = new System.Drawing.Point(0, 232);
      this.lbl_Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lbl_Error.Name = "lbl_Error";
      this.lbl_Error.Size = new System.Drawing.Size(362, 19);
      this.lbl_Error.TabIndex = 7;
      this.lbl_Error.Text = "<content>";
      this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_Error.Visible = false;
      // 
      // bwork_PasswordChange
      // 
      this.bwork_PasswordChange.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_PasswordChange_DoWork);
      this.bwork_PasswordChange.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_PasswordChange_RunWorkerCompleted);
      // 
      // cb_ShowPass1
      // 
      this.cb_ShowPass1.AutoSize = true;
      this.cb_ShowPass1.BackColor = System.Drawing.Color.Transparent;
      this.cb_ShowPass1.Location = new System.Drawing.Point(160, 108);
      this.cb_ShowPass1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cb_ShowPass1.Name = "cb_ShowPass1";
      this.cb_ShowPass1.Size = new System.Drawing.Size(102, 17);
      this.cb_ShowPass1.TabIndex = 8;
      this.cb_ShowPass1.Text = "Show Password";
      this.cb_ShowPass1.UseVisualStyleBackColor = false;
      this.cb_ShowPass1.CheckedChanged += new System.EventHandler(this.cb_ShowPass1_CheckedChanged);
      // 
      // cb_ShowPass2
      // 
      this.cb_ShowPass2.AutoSize = true;
      this.cb_ShowPass2.BackColor = System.Drawing.Color.Transparent;
      this.cb_ShowPass2.Location = new System.Drawing.Point(160, 154);
      this.cb_ShowPass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cb_ShowPass2.Name = "cb_ShowPass2";
      this.cb_ShowPass2.Size = new System.Drawing.Size(102, 17);
      this.cb_ShowPass2.TabIndex = 9;
      this.cb_ShowPass2.Text = "Show Password";
      this.cb_ShowPass2.UseVisualStyleBackColor = false;
      this.cb_ShowPass2.CheckedChanged += new System.EventHandler(this.cb_ShowPass2_CheckedChanged);
      // 
      // cb_ShowPass3
      // 
      this.cb_ShowPass3.AutoSize = true;
      this.cb_ShowPass3.BackColor = System.Drawing.Color.Transparent;
      this.cb_ShowPass3.Location = new System.Drawing.Point(160, 201);
      this.cb_ShowPass3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cb_ShowPass3.Name = "cb_ShowPass3";
      this.cb_ShowPass3.Size = new System.Drawing.Size(102, 17);
      this.cb_ShowPass3.TabIndex = 10;
      this.cb_ShowPass3.Text = "Show Password";
      this.cb_ShowPass3.UseVisualStyleBackColor = false;
      this.cb_ShowPass3.CheckedChanged += new System.EventHandler(this.cb_ShowPass3_CheckedChanged);
      // 
      // ChangePassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::NoteView.Properties.Resources.bg;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(362, 366);
      this.Controls.Add(this.cb_ShowPass3);
      this.Controls.Add(this.cb_ShowPass2);
      this.Controls.Add(this.cb_ShowPass1);
      this.Controls.Add(this.lbl_Error);
      this.Controls.Add(this.txt_ConfirmPassword);
      this.Controls.Add(this.txt_NewPassword);
      this.Controls.Add(this.cmd_ChangePassword);
      this.Controls.Add(this.txt_OldPassword);
      this.Controls.Add(this.lbl_ConfirmPassword);
      this.Controls.Add(this.lbl_NewPassword);
      this.Controls.Add(this.lbl_OldPassword);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChangePassword";
      this.Text = "Change Password";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_OldPassword;
    private System.Windows.Forms.Label lbl_NewPassword;
    private System.Windows.Forms.Label lbl_ConfirmPassword;
    private System.Windows.Forms.TextBox txt_OldPassword;
    private System.Windows.Forms.Button cmd_ChangePassword;
    private System.Windows.Forms.TextBox txt_NewPassword;
    private System.Windows.Forms.TextBox txt_ConfirmPassword;
    private System.Windows.Forms.Label lbl_Error;
    private System.ComponentModel.BackgroundWorker bwork_PasswordChange;
    private System.Windows.Forms.CheckBox cb_ShowPass1;
    private System.Windows.Forms.CheckBox cb_ShowPass2;
    private System.Windows.Forms.CheckBox cb_ShowPass3;
  }
}