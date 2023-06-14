namespace NoteView
{
    partial class AddUser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
      this.pnl_SignUp = new System.Windows.Forms.Panel();
      this.lbl_AdminMessage = new System.Windows.Forms.Label();
      this.gbx_AdminAuth = new System.Windows.Forms.GroupBox();
      this.llbl_AA_GoBack = new System.Windows.Forms.LinkLabel();
      this.lbl_AAAuthMessage = new System.Windows.Forms.Label();
      this.chb_AAshowpass = new System.Windows.Forms.CheckBox();
      this.btn_AAlogin = new System.Windows.Forms.Button();
      this.tb_AApass = new System.Windows.Forms.TextBox();
      this.tb_AAusername = new System.Windows.Forms.TextBox();
      this.lbl_AApass = new System.Windows.Forms.Label();
      this.lbl_AAusername = new System.Windows.Forms.Label();
      this.gbx_SignUp = new System.Windows.Forms.GroupBox();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.llbl_GoBack = new System.Windows.Forms.LinkLabel();
      this.cb_AdminCheck = new System.Windows.Forms.CheckBox();
      this.lbl_SignUpMsg = new System.Windows.Forms.Label();
      this.btn_SignUp = new System.Windows.Forms.Button();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.tbx_SignUpPass2 = new System.Windows.Forms.TextBox();
      this.tbx_SignUpPass1 = new System.Windows.Forms.TextBox();
      this.tbx_SignUpLastName = new System.Windows.Forms.TextBox();
      this.tbx_SignUpFirstName = new System.Windows.Forms.TextBox();
      this.tbx_SignUpUid = new System.Windows.Forms.TextBox();
      this.lbl_SignUpLastName = new System.Windows.Forms.Label();
      this.lbl_SignUpFirstName = new System.Windows.Forms.Label();
      this.lbl_SignUpPass2 = new System.Windows.Forms.Label();
      this.lbl_SignUpPass1 = new System.Windows.Forms.Label();
      this.lbl_SignUpUid = new System.Windows.Forms.Label();
      this.bwork_Auth = new System.ComponentModel.BackgroundWorker();
      this.bwork_SignUp = new System.ComponentModel.BackgroundWorker();
      this.pnl_SignUp.SuspendLayout();
      this.gbx_AdminAuth.SuspendLayout();
      this.gbx_SignUp.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnl_SignUp
      // 
      this.pnl_SignUp.BackgroundImage = global::NoteView.Properties.Resources.bg_admin;
      this.pnl_SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pnl_SignUp.Controls.Add(this.lbl_AdminMessage);
      this.pnl_SignUp.Controls.Add(this.gbx_AdminAuth);
      this.pnl_SignUp.Controls.Add(this.gbx_SignUp);
      this.pnl_SignUp.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_SignUp.Location = new System.Drawing.Point(0, 0);
      this.pnl_SignUp.Name = "pnl_SignUp";
      this.pnl_SignUp.Size = new System.Drawing.Size(800, 450);
      this.pnl_SignUp.TabIndex = 0;
      // 
      // lbl_AdminMessage
      // 
      this.lbl_AdminMessage.AutoSize = true;
      this.lbl_AdminMessage.BackColor = System.Drawing.Color.Transparent;
      this.lbl_AdminMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lbl_AdminMessage.ForeColor = System.Drawing.SystemColors.Control;
      this.lbl_AdminMessage.Location = new System.Drawing.Point(0, 437);
      this.lbl_AdminMessage.Name = "lbl_AdminMessage";
      this.lbl_AdminMessage.Size = new System.Drawing.Size(95, 13);
      this.lbl_AdminMessage.TabIndex = 15;
      this.lbl_AdminMessage.Text = "lbl_AdminMessage";
      this.lbl_AdminMessage.Visible = false;
      // 
      // gbx_AdminAuth
      // 
      this.gbx_AdminAuth.BackColor = System.Drawing.Color.Transparent;
      this.gbx_AdminAuth.Controls.Add(this.llbl_AA_GoBack);
      this.gbx_AdminAuth.Controls.Add(this.lbl_AAAuthMessage);
      this.gbx_AdminAuth.Controls.Add(this.chb_AAshowpass);
      this.gbx_AdminAuth.Controls.Add(this.btn_AAlogin);
      this.gbx_AdminAuth.Controls.Add(this.tb_AApass);
      this.gbx_AdminAuth.Controls.Add(this.tb_AAusername);
      this.gbx_AdminAuth.Controls.Add(this.lbl_AApass);
      this.gbx_AdminAuth.Controls.Add(this.lbl_AAusername);
      this.gbx_AdminAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbx_AdminAuth.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.gbx_AdminAuth.Location = new System.Drawing.Point(38, 43);
      this.gbx_AdminAuth.Name = "gbx_AdminAuth";
      this.gbx_AdminAuth.Size = new System.Drawing.Size(390, 351);
      this.gbx_AdminAuth.TabIndex = 14;
      this.gbx_AdminAuth.TabStop = false;
      this.gbx_AdminAuth.Text = "Admin Authentication";
      // 
      // llbl_AA_GoBack
      // 
      this.llbl_AA_GoBack.ActiveLinkColor = System.Drawing.Color.Blue;
      this.llbl_AA_GoBack.AutoSize = true;
      this.llbl_AA_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.llbl_AA_GoBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.llbl_AA_GoBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.llbl_AA_GoBack.LinkColor = System.Drawing.Color.White;
      this.llbl_AA_GoBack.Location = new System.Drawing.Point(325, 330);
      this.llbl_AA_GoBack.Name = "llbl_AA_GoBack";
      this.llbl_AA_GoBack.Size = new System.Drawing.Size(62, 15);
      this.llbl_AA_GoBack.TabIndex = 18;
      this.llbl_AA_GoBack.TabStop = true;
      this.llbl_AA_GoBack.Text = "< Go back";
      this.llbl_AA_GoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_AA_GoBack_LinkClicked);
      // 
      // lbl_AAAuthMessage
      // 
      this.lbl_AAAuthMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_AAAuthMessage.Location = new System.Drawing.Point(29, 203);
      this.lbl_AAAuthMessage.Name = "lbl_AAAuthMessage";
      this.lbl_AAAuthMessage.Size = new System.Drawing.Size(332, 17);
      this.lbl_AAAuthMessage.TabIndex = 14;
      this.lbl_AAAuthMessage.Text = "lbl_AuthMessage";
      this.lbl_AAAuthMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_AAAuthMessage.Visible = false;
      // 
      // chb_AAshowpass
      // 
      this.chb_AAshowpass.AutoSize = true;
      this.chb_AAshowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chb_AAshowpass.ForeColor = System.Drawing.Color.AliceBlue;
      this.chb_AAshowpass.Location = new System.Drawing.Point(160, 168);
      this.chb_AAshowpass.Name = "chb_AAshowpass";
      this.chb_AAshowpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chb_AAshowpass.Size = new System.Drawing.Size(115, 17);
      this.chb_AAshowpass.TabIndex = 13;
      this.chb_AAshowpass.Text = "Show Password";
      this.chb_AAshowpass.UseVisualStyleBackColor = true;
      this.chb_AAshowpass.CheckedChanged += new System.EventHandler(this.chb_AAshowpass_CheckedChanged);
      // 
      // btn_AAlogin
      // 
      this.btn_AAlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_AAlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.btn_AAlogin.Location = new System.Drawing.Point(158, 223);
      this.btn_AAlogin.Name = "btn_AAlogin";
      this.btn_AAlogin.Size = new System.Drawing.Size(75, 25);
      this.btn_AAlogin.TabIndex = 12;
      this.btn_AAlogin.Text = "Log-In";
      this.btn_AAlogin.UseVisualStyleBackColor = true;
      this.btn_AAlogin.Click += new System.EventHandler(this.btn_AAlogin_Click);
      // 
      // tb_AApass
      // 
      this.tb_AApass.Location = new System.Drawing.Point(160, 140);
      this.tb_AApass.Name = "tb_AApass";
      this.tb_AApass.Size = new System.Drawing.Size(154, 23);
      this.tb_AApass.TabIndex = 11;
      this.tb_AApass.UseSystemPasswordChar = true;
      // 
      // tb_AAusername
      // 
      this.tb_AAusername.Location = new System.Drawing.Point(160, 100);
      this.tb_AAusername.Name = "tb_AAusername";
      this.tb_AAusername.Size = new System.Drawing.Size(154, 23);
      this.tb_AAusername.TabIndex = 10;
      // 
      // lbl_AApass
      // 
      this.lbl_AApass.AutoSize = true;
      this.lbl_AApass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_AApass.ForeColor = System.Drawing.Color.White;
      this.lbl_AApass.Location = new System.Drawing.Point(81, 143);
      this.lbl_AApass.Name = "lbl_AApass";
      this.lbl_AApass.Size = new System.Drawing.Size(69, 15);
      this.lbl_AApass.TabIndex = 9;
      this.lbl_AApass.Text = "Password";
      // 
      // lbl_AAusername
      // 
      this.lbl_AAusername.AutoSize = true;
      this.lbl_AAusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_AAusername.ForeColor = System.Drawing.Color.White;
      this.lbl_AAusername.Location = new System.Drawing.Point(77, 103);
      this.lbl_AAusername.Name = "lbl_AAusername";
      this.lbl_AAusername.Size = new System.Drawing.Size(73, 15);
      this.lbl_AAusername.TabIndex = 8;
      this.lbl_AAusername.Text = "Username";
      // 
      // gbx_SignUp
      // 
      this.gbx_SignUp.BackColor = System.Drawing.Color.Transparent;
      this.gbx_SignUp.Controls.Add(this.linkLabel1);
      this.gbx_SignUp.Controls.Add(this.llbl_GoBack);
      this.gbx_SignUp.Controls.Add(this.cb_AdminCheck);
      this.gbx_SignUp.Controls.Add(this.lbl_SignUpMsg);
      this.gbx_SignUp.Controls.Add(this.btn_SignUp);
      this.gbx_SignUp.Controls.Add(this.checkBox3);
      this.gbx_SignUp.Controls.Add(this.checkBox1);
      this.gbx_SignUp.Controls.Add(this.tbx_SignUpPass2);
      this.gbx_SignUp.Controls.Add(this.tbx_SignUpPass1);
      this.gbx_SignUp.Controls.Add(this.tbx_SignUpLastName);
      this.gbx_SignUp.Controls.Add(this.tbx_SignUpFirstName);
      this.gbx_SignUp.Controls.Add(this.tbx_SignUpUid);
      this.gbx_SignUp.Controls.Add(this.lbl_SignUpLastName);
      this.gbx_SignUp.Controls.Add(this.lbl_SignUpFirstName);
      this.gbx_SignUp.Controls.Add(this.lbl_SignUpPass2);
      this.gbx_SignUp.Controls.Add(this.lbl_SignUpPass1);
      this.gbx_SignUp.Controls.Add(this.lbl_SignUpUid);
      this.gbx_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbx_SignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.gbx_SignUp.Location = new System.Drawing.Point(38, 43);
      this.gbx_SignUp.Name = "gbx_SignUp";
      this.gbx_SignUp.Size = new System.Drawing.Size(390, 351);
      this.gbx_SignUp.TabIndex = 0;
      this.gbx_SignUp.TabStop = false;
      this.gbx_SignUp.Text = "Add User";
      this.gbx_SignUp.Visible = false;
      // 
      // linkLabel1
      // 
      this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.linkLabel1.LinkColor = System.Drawing.Color.White;
      this.linkLabel1.Location = new System.Drawing.Point(6, 332);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(31, 13);
      this.linkLabel1.TabIndex = 18;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Clear";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // llbl_GoBack
      // 
      this.llbl_GoBack.ActiveLinkColor = System.Drawing.Color.Blue;
      this.llbl_GoBack.AutoSize = true;
      this.llbl_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.llbl_GoBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.llbl_GoBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.llbl_GoBack.LinkColor = System.Drawing.Color.White;
      this.llbl_GoBack.Location = new System.Drawing.Point(325, 330);
      this.llbl_GoBack.Name = "llbl_GoBack";
      this.llbl_GoBack.Size = new System.Drawing.Size(62, 15);
      this.llbl_GoBack.TabIndex = 17;
      this.llbl_GoBack.TabStop = true;
      this.llbl_GoBack.Text = "< Go back";
      this.llbl_GoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_GoBack_LinkClicked);
      // 
      // cb_AdminCheck
      // 
      this.cb_AdminCheck.AutoSize = true;
      this.cb_AdminCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cb_AdminCheck.Location = new System.Drawing.Point(174, 254);
      this.cb_AdminCheck.Name = "cb_AdminCheck";
      this.cb_AdminCheck.Size = new System.Drawing.Size(98, 17);
      this.cb_AdminCheck.TabIndex = 16;
      this.cb_AdminCheck.Text = "Admin Privilege";
      this.cb_AdminCheck.UseVisualStyleBackColor = true;
      // 
      // lbl_SignUpMsg
      // 
      this.lbl_SignUpMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SignUpMsg.Location = new System.Drawing.Point(29, 274);
      this.lbl_SignUpMsg.Name = "lbl_SignUpMsg";
      this.lbl_SignUpMsg.Size = new System.Drawing.Size(332, 17);
      this.lbl_SignUpMsg.TabIndex = 15;
      this.lbl_SignUpMsg.Text = "lbl_SignUpMsg";
      this.lbl_SignUpMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_SignUpMsg.Visible = false;
      // 
      // btn_SignUp
      // 
      this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btn_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.btn_SignUp.Location = new System.Drawing.Point(158, 294);
      this.btn_SignUp.Name = "btn_SignUp";
      this.btn_SignUp.Size = new System.Drawing.Size(75, 28);
      this.btn_SignUp.TabIndex = 13;
      this.btn_SignUp.Text = "Sign-Up";
      this.btn_SignUp.UseVisualStyleBackColor = true;
      this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBox3.Location = new System.Drawing.Point(174, 231);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(102, 17);
      this.checkBox3.TabIndex = 12;
      this.checkBox3.Text = "Show Password";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBox1.Location = new System.Drawing.Point(174, 177);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(102, 17);
      this.checkBox1.TabIndex = 10;
      this.checkBox1.Text = "Show Password";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // tbx_SignUpPass2
      // 
      this.tbx_SignUpPass2.Location = new System.Drawing.Point(174, 202);
      this.tbx_SignUpPass2.Name = "tbx_SignUpPass2";
      this.tbx_SignUpPass2.Size = new System.Drawing.Size(174, 23);
      this.tbx_SignUpPass2.TabIndex = 9;
      this.tbx_SignUpPass2.UseSystemPasswordChar = true;
      // 
      // tbx_SignUpPass1
      // 
      this.tbx_SignUpPass1.Location = new System.Drawing.Point(174, 148);
      this.tbx_SignUpPass1.Name = "tbx_SignUpPass1";
      this.tbx_SignUpPass1.Size = new System.Drawing.Size(174, 23);
      this.tbx_SignUpPass1.TabIndex = 8;
      this.tbx_SignUpPass1.UseSystemPasswordChar = true;
      // 
      // tbx_SignUpLastName
      // 
      this.tbx_SignUpLastName.Location = new System.Drawing.Point(175, 114);
      this.tbx_SignUpLastName.Name = "tbx_SignUpLastName";
      this.tbx_SignUpLastName.Size = new System.Drawing.Size(174, 23);
      this.tbx_SignUpLastName.TabIndex = 7;
      // 
      // tbx_SignUpFirstName
      // 
      this.tbx_SignUpFirstName.Location = new System.Drawing.Point(175, 80);
      this.tbx_SignUpFirstName.Name = "tbx_SignUpFirstName";
      this.tbx_SignUpFirstName.Size = new System.Drawing.Size(174, 23);
      this.tbx_SignUpFirstName.TabIndex = 6;
      // 
      // tbx_SignUpUid
      // 
      this.tbx_SignUpUid.Location = new System.Drawing.Point(175, 46);
      this.tbx_SignUpUid.Name = "tbx_SignUpUid";
      this.tbx_SignUpUid.Size = new System.Drawing.Size(174, 23);
      this.tbx_SignUpUid.TabIndex = 5;
      // 
      // lbl_SignUpLastName
      // 
      this.lbl_SignUpLastName.AutoSize = true;
      this.lbl_SignUpLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SignUpLastName.Location = new System.Drawing.Point(89, 118);
      this.lbl_SignUpLastName.Name = "lbl_SignUpLastName";
      this.lbl_SignUpLastName.Size = new System.Drawing.Size(76, 15);
      this.lbl_SignUpLastName.TabIndex = 4;
      this.lbl_SignUpLastName.Text = "Last Name";
      // 
      // lbl_SignUpFirstName
      // 
      this.lbl_SignUpFirstName.AutoSize = true;
      this.lbl_SignUpFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SignUpFirstName.Location = new System.Drawing.Point(88, 83);
      this.lbl_SignUpFirstName.Name = "lbl_SignUpFirstName";
      this.lbl_SignUpFirstName.Size = new System.Drawing.Size(77, 15);
      this.lbl_SignUpFirstName.TabIndex = 3;
      this.lbl_SignUpFirstName.Text = "First Name";
      // 
      // lbl_SignUpPass2
      // 
      this.lbl_SignUpPass2.AutoSize = true;
      this.lbl_SignUpPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SignUpPass2.Location = new System.Drawing.Point(42, 205);
      this.lbl_SignUpPass2.Name = "lbl_SignUpPass2";
      this.lbl_SignUpPass2.Size = new System.Drawing.Size(123, 15);
      this.lbl_SignUpPass2.TabIndex = 2;
      this.lbl_SignUpPass2.Text = "Confirm Password";
      // 
      // lbl_SignUpPass1
      // 
      this.lbl_SignUpPass1.AutoSize = true;
      this.lbl_SignUpPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SignUpPass1.Location = new System.Drawing.Point(96, 151);
      this.lbl_SignUpPass1.Name = "lbl_SignUpPass1";
      this.lbl_SignUpPass1.Size = new System.Drawing.Size(69, 15);
      this.lbl_SignUpPass1.TabIndex = 1;
      this.lbl_SignUpPass1.Text = "Password";
      // 
      // lbl_SignUpUid
      // 
      this.lbl_SignUpUid.AutoSize = true;
      this.lbl_SignUpUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SignUpUid.Location = new System.Drawing.Point(92, 49);
      this.lbl_SignUpUid.Name = "lbl_SignUpUid";
      this.lbl_SignUpUid.Size = new System.Drawing.Size(73, 15);
      this.lbl_SignUpUid.TabIndex = 0;
      this.lbl_SignUpUid.Text = "Username";
      // 
      // bwork_Auth
      // 
      this.bwork_Auth.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_Auth_DoWork);
      this.bwork_Auth.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_Auth_RunWorkerCompleted);
      // 
      // bwork_SignUp
      // 
      this.bwork_SignUp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_SignUp_DoWork);
      this.bwork_SignUp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_SignUp_RunWorkerCompleted);
      // 
      // AddUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.pnl_SignUp);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "AddUser";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add a User";
      this.pnl_SignUp.ResumeLayout(false);
      this.pnl_SignUp.PerformLayout();
      this.gbx_AdminAuth.ResumeLayout(false);
      this.gbx_AdminAuth.PerformLayout();
      this.gbx_SignUp.ResumeLayout(false);
      this.gbx_SignUp.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SignUp;
        private System.Windows.Forms.GroupBox gbx_SignUp;
        private System.Windows.Forms.Label lbl_SignUpFirstName;
        private System.Windows.Forms.Label lbl_SignUpPass2;
        private System.Windows.Forms.Label lbl_SignUpPass1;
        private System.Windows.Forms.Label lbl_SignUpUid;
        private System.Windows.Forms.Label lbl_SignUpLastName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbx_SignUpPass2;
        private System.Windows.Forms.TextBox tbx_SignUpPass1;
        private System.Windows.Forms.TextBox tbx_SignUpLastName;
        private System.Windows.Forms.TextBox tbx_SignUpFirstName;
        private System.Windows.Forms.TextBox tbx_SignUpUid;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox gbx_AdminAuth;
        private System.Windows.Forms.Label lbl_AAAuthMessage;
        private System.Windows.Forms.CheckBox chb_AAshowpass;
        private System.Windows.Forms.Button btn_AAlogin;
        private System.Windows.Forms.TextBox tb_AApass;
        private System.Windows.Forms.TextBox tb_AAusername;
        private System.Windows.Forms.Label lbl_AApass;
        private System.Windows.Forms.Label lbl_AAusername;
        private System.Windows.Forms.Label lbl_SignUpMsg;
    private System.Windows.Forms.CheckBox cb_AdminCheck;
    private System.Windows.Forms.Label lbl_AdminMessage;
    private System.Windows.Forms.LinkLabel llbl_GoBack;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.ComponentModel.BackgroundWorker bwork_Auth;
    private System.ComponentModel.BackgroundWorker bwork_SignUp;
    private System.Windows.Forms.LinkLabel llbl_AA_GoBack;
  }
}