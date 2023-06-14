namespace NoteView
{
    partial class UserLogin
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
      this.panel1 = new System.Windows.Forms.Panel();
      this.gb_login = new System.Windows.Forms.GroupBox();
      this.llbl_AddAcc = new System.Windows.Forms.LinkLabel();
      this.lbl_AuthMessage = new System.Windows.Forms.Label();
      this.chb_showpass = new System.Windows.Forms.CheckBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btn_login = new System.Windows.Forms.Button();
      this.tb_pass = new System.Windows.Forms.TextBox();
      this.tb_username = new System.Windows.Forms.TextBox();
      this.lbl_pass = new System.Windows.Forms.Label();
      this.lbl_username = new System.Windows.Forms.Label();
      this.bwork_Authentication = new System.ComponentModel.BackgroundWorker();
      this.tt_AddAccHov = new System.Windows.Forms.ToolTip(this.components);
      this.panel1.SuspendLayout();
      this.gb_login.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
      this.panel1.Controls.Add(this.gb_login);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1067, 554);
      this.panel1.TabIndex = 0;
      // 
      // gb_login
      // 
      this.gb_login.BackColor = System.Drawing.Color.Transparent;
      this.gb_login.Controls.Add(this.llbl_AddAcc);
      this.gb_login.Controls.Add(this.lbl_AuthMessage);
      this.gb_login.Controls.Add(this.chb_showpass);
      this.gb_login.Controls.Add(this.pictureBox1);
      this.gb_login.Controls.Add(this.btn_login);
      this.gb_login.Controls.Add(this.tb_pass);
      this.gb_login.Controls.Add(this.tb_username);
      this.gb_login.Controls.Add(this.lbl_pass);
      this.gb_login.Controls.Add(this.lbl_username);
      this.gb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_login.ForeColor = System.Drawing.SystemColors.Control;
      this.gb_login.Location = new System.Drawing.Point(304, 27);
      this.gb_login.Margin = new System.Windows.Forms.Padding(4);
      this.gb_login.Name = "gb_login";
      this.gb_login.Padding = new System.Windows.Forms.Padding(4);
      this.gb_login.Size = new System.Drawing.Size(459, 474);
      this.gb_login.TabIndex = 0;
      this.gb_login.TabStop = false;
      this.gb_login.Text = "Log-In";
      // 
      // llbl_AddAcc
      // 
      this.llbl_AddAcc.ActiveLinkColor = System.Drawing.Color.White;
      this.llbl_AddAcc.AutoSize = true;
      this.llbl_AddAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.llbl_AddAcc.Location = new System.Drawing.Point(176, 434);
      this.llbl_AddAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.llbl_AddAcc.Name = "llbl_AddAcc";
      this.llbl_AddAcc.Size = new System.Drawing.Size(85, 15);
      this.llbl_AddAcc.TabIndex = 8;
      this.llbl_AddAcc.TabStop = true;
      this.llbl_AddAcc.Text = "Add Account";
      this.llbl_AddAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_AddAcc_LinkClicked);
      // 
      // lbl_AuthMessage
      // 
      this.lbl_AuthMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_AuthMessage.Location = new System.Drawing.Point(8, 356);
      this.lbl_AuthMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_AuthMessage.Name = "lbl_AuthMessage";
      this.lbl_AuthMessage.Size = new System.Drawing.Size(443, 21);
      this.lbl_AuthMessage.TabIndex = 7;
      this.lbl_AuthMessage.Text = "lbl_AuthMessage";
      this.lbl_AuthMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_AuthMessage.Visible = false;
      // 
      // chb_showpass
      // 
      this.chb_showpass.AutoSize = true;
      this.chb_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chb_showpass.ForeColor = System.Drawing.Color.AliceBlue;
      this.chb_showpass.Location = new System.Drawing.Point(183, 324);
      this.chb_showpass.Margin = new System.Windows.Forms.Padding(4);
      this.chb_showpass.Name = "chb_showpass";
      this.chb_showpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chb_showpass.Size = new System.Drawing.Size(142, 21);
      this.chb_showpass.TabIndex = 6;
      this.chb_showpass.Text = "Show Password";
      this.chb_showpass.UseVisualStyleBackColor = true;
      this.chb_showpass.CheckedChanged += new System.EventHandler(this.chb_showpass_CheckedChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::NoteView.Properties.Resources.noteview_icon;
      this.pictureBox1.Location = new System.Drawing.Point(129, 46);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(200, 182);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // btn_login
      // 
      this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.btn_login.Location = new System.Drawing.Point(180, 380);
      this.btn_login.Margin = new System.Windows.Forms.Padding(4);
      this.btn_login.Name = "btn_login";
      this.btn_login.Size = new System.Drawing.Size(100, 33);
      this.btn_login.TabIndex = 4;
      this.btn_login.Text = "Log-In";
      this.btn_login.UseVisualStyleBackColor = true;
      this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
      // 
      // tb_pass
      // 
      this.tb_pass.Location = new System.Drawing.Point(183, 289);
      this.tb_pass.Margin = new System.Windows.Forms.Padding(4);
      this.tb_pass.Name = "tb_pass";
      this.tb_pass.Size = new System.Drawing.Size(204, 26);
      this.tb_pass.TabIndex = 3;
      this.tb_pass.UseSystemPasswordChar = true;
      // 
      // tb_username
      // 
      this.tb_username.Location = new System.Drawing.Point(183, 249);
      this.tb_username.Margin = new System.Windows.Forms.Padding(4);
      this.tb_username.Name = "tb_username";
      this.tb_username.Size = new System.Drawing.Size(204, 26);
      this.tb_username.TabIndex = 2;
      // 
      // lbl_pass
      // 
      this.lbl_pass.AutoSize = true;
      this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_pass.ForeColor = System.Drawing.Color.White;
      this.lbl_pass.Location = new System.Drawing.Point(77, 293);
      this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_pass.Name = "lbl_pass";
      this.lbl_pass.Size = new System.Drawing.Size(83, 18);
      this.lbl_pass.TabIndex = 1;
      this.lbl_pass.Text = "Password";
      // 
      // lbl_username
      // 
      this.lbl_username.AutoSize = true;
      this.lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_username.ForeColor = System.Drawing.Color.White;
      this.lbl_username.Location = new System.Drawing.Point(72, 252);
      this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_username.Name = "lbl_username";
      this.lbl_username.Size = new System.Drawing.Size(85, 18);
      this.lbl_username.TabIndex = 0;
      this.lbl_username.Text = "Username";
      // 
      // bwork_Authentication
      // 
      this.bwork_Authentication.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_Authentication_DoWork);
      this.bwork_Authentication.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_Authentication_RunWorkerCompleted);
      // 
      // UserLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 554);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "UserLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "User Log-In";
      this.panel1.ResumeLayout(false);
      this.gb_login.ResumeLayout(false);
      this.gb_login.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chb_showpass;
    private System.Windows.Forms.Label lbl_AuthMessage;
        private System.Windows.Forms.LinkLabel llbl_AddAcc;
    private System.ComponentModel.BackgroundWorker bwork_Authentication;
    private System.Windows.Forms.ToolTip tt_AddAccHov;
  }
}