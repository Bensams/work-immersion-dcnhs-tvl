namespace NoteView
{
  partial class SetupDB
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDB));
      this.bwork_Connection = new System.ComponentModel.BackgroundWorker();
      this.pcb_Welcome = new System.Windows.Forms.PictureBox();
      this.gb_dbcnnct = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cb_ForceConnect = new System.Windows.Forms.CheckBox();
      this.lbl_ConnectOutput = new System.Windows.Forms.Label();
      this.btn_Connect = new System.Windows.Forms.Button();
      this.txt_DB = new System.Windows.Forms.TextBox();
      this.txt_Password = new System.Windows.Forms.TextBox();
      this.txt_Username = new System.Windows.Forms.TextBox();
      this.txt_Port = new System.Windows.Forms.TextBox();
      this.txt_Server = new System.Windows.Forms.TextBox();
      this.lbl_datab = new System.Windows.Forms.Label();
      this.lbl_password = new System.Windows.Forms.Label();
      this.lbl_user = new System.Windows.Forms.Label();
      this.lbl_port = new System.Windows.Forms.Label();
      this.lbl_Server = new System.Windows.Forms.Label();
      this.pnl_setUpDB = new System.Windows.Forms.Panel();
      this.lbl_ErrorDetails = new System.Windows.Forms.Label();
      this.gbx_FASetup = new System.Windows.Forms.GroupBox();
      this.cb_ShowPass2 = new System.Windows.Forms.CheckBox();
      this.cb_ShowPass = new System.Windows.Forms.CheckBox();
      this.lbl_SignUpOutput = new System.Windows.Forms.Label();
      this.cmd_SignUp = new System.Windows.Forms.Button();
      this.txt_SU_Pword2 = new System.Windows.Forms.TextBox();
      this.txt_SU_Pword = new System.Windows.Forms.TextBox();
      this.txt_SU_Lname = new System.Windows.Forms.TextBox();
      this.txt_SU_Fname = new System.Windows.Forms.TextBox();
      this.txt_SU_Username = new System.Windows.Forms.TextBox();
      this.lbl_SU_Pword2 = new System.Windows.Forms.Label();
      this.lbl_SU_Pword = new System.Windows.Forms.Label();
      this.lbl_SU_Lname = new System.Windows.Forms.Label();
      this.lbl_SU_Fname = new System.Windows.Forms.Label();
      this.lbl_SU_Uname = new System.Windows.Forms.Label();
      this.bwork_SignUp = new System.ComponentModel.BackgroundWorker();
      this.tt_ForceConnectHint = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pcb_Welcome)).BeginInit();
      this.gb_dbcnnct.SuspendLayout();
      this.pnl_setUpDB.SuspendLayout();
      this.gbx_FASetup.SuspendLayout();
      this.SuspendLayout();
      // 
      // bwork_Connection
      // 
      this.bwork_Connection.WorkerReportsProgress = true;
      this.bwork_Connection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_Connection_DoWork);
      this.bwork_Connection.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwork_Connection_ProgressChanged);
      this.bwork_Connection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_Connection_RunWorkerCompleted);
      // 
      // pcb_Welcome
      // 
      this.pcb_Welcome.BackColor = System.Drawing.Color.Transparent;
      this.pcb_Welcome.Image = global::NoteView.Properties.Resources.willkommen;
      this.pcb_Welcome.Location = new System.Drawing.Point(12, 102);
      this.pcb_Welcome.Name = "pcb_Welcome";
      this.pcb_Welcome.Size = new System.Drawing.Size(372, 206);
      this.pcb_Welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pcb_Welcome.TabIndex = 25;
      this.pcb_Welcome.TabStop = false;
      // 
      // gb_dbcnnct
      // 
      this.gb_dbcnnct.BackColor = System.Drawing.Color.Transparent;
      this.gb_dbcnnct.Controls.Add(this.label1);
      this.gb_dbcnnct.Controls.Add(this.cb_ForceConnect);
      this.gb_dbcnnct.Controls.Add(this.lbl_ConnectOutput);
      this.gb_dbcnnct.Controls.Add(this.btn_Connect);
      this.gb_dbcnnct.Controls.Add(this.txt_DB);
      this.gb_dbcnnct.Controls.Add(this.txt_Password);
      this.gb_dbcnnct.Controls.Add(this.txt_Username);
      this.gb_dbcnnct.Controls.Add(this.txt_Port);
      this.gb_dbcnnct.Controls.Add(this.txt_Server);
      this.gb_dbcnnct.Controls.Add(this.lbl_datab);
      this.gb_dbcnnct.Controls.Add(this.lbl_password);
      this.gb_dbcnnct.Controls.Add(this.lbl_user);
      this.gb_dbcnnct.Controls.Add(this.lbl_port);
      this.gb_dbcnnct.Controls.Add(this.lbl_Server);
      this.gb_dbcnnct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_dbcnnct.ForeColor = System.Drawing.Color.White;
      this.gb_dbcnnct.Location = new System.Drawing.Point(396, 50);
      this.gb_dbcnnct.Name = "gb_dbcnnct";
      this.gb_dbcnnct.Size = new System.Drawing.Size(376, 311);
      this.gb_dbcnnct.TabIndex = 26;
      this.gb_dbcnnct.TabStop = false;
      this.gb_dbcnnct.Text = "Set-up Database Connection";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(162, 189);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(175, 12);
      this.label1.TabIndex = 48;
      this.label1.Text = "Defaults to \"noteview\" if left unspecified";
      // 
      // cb_ForceConnect
      // 
      this.cb_ForceConnect.AutoSize = true;
      this.cb_ForceConnect.Checked = true;
      this.cb_ForceConnect.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cb_ForceConnect.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cb_ForceConnect.Location = new System.Drawing.Point(161, 201);
      this.cb_ForceConnect.Name = "cb_ForceConnect";
      this.cb_ForceConnect.Size = new System.Drawing.Size(97, 18);
      this.cb_ForceConnect.TabIndex = 47;
      this.cb_ForceConnect.Text = "Force Connect";
      this.tt_ForceConnectHint.SetToolTip(this.cb_ForceConnect, "Uncheck to create a database if it does not exist");
      this.cb_ForceConnect.UseVisualStyleBackColor = true;
      this.cb_ForceConnect.CheckedChanged += new System.EventHandler(this.cb_ForceConnect_CheckedChanged);
      // 
      // lbl_ConnectOutput
      // 
      this.lbl_ConnectOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_ConnectOutput.Location = new System.Drawing.Point(0, 228);
      this.lbl_ConnectOutput.Name = "lbl_ConnectOutput";
      this.lbl_ConnectOutput.Size = new System.Drawing.Size(376, 15);
      this.lbl_ConnectOutput.TabIndex = 46;
      this.lbl_ConnectOutput.Text = "lbl_ConnectOutput";
      this.lbl_ConnectOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_ConnectOutput.Visible = false;
      // 
      // btn_Connect
      // 
      this.btn_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.btn_Connect.Location = new System.Drawing.Point(131, 246);
      this.btn_Connect.Name = "btn_Connect";
      this.btn_Connect.Size = new System.Drawing.Size(114, 28);
      this.btn_Connect.TabIndex = 45;
      this.btn_Connect.Text = "Connect";
      this.btn_Connect.UseVisualStyleBackColor = true;
      this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
      // 
      // txt_DB
      // 
      this.txt_DB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_DB.Location = new System.Drawing.Point(162, 166);
      this.txt_DB.Name = "txt_DB";
      this.txt_DB.Size = new System.Drawing.Size(204, 21);
      this.txt_DB.TabIndex = 44;
      // 
      // txt_Password
      // 
      this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Password.Location = new System.Drawing.Point(162, 139);
      this.txt_Password.Name = "txt_Password";
      this.txt_Password.Size = new System.Drawing.Size(204, 21);
      this.txt_Password.TabIndex = 43;
      this.txt_Password.UseSystemPasswordChar = true;
      // 
      // txt_Username
      // 
      this.txt_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Username.Location = new System.Drawing.Point(162, 112);
      this.txt_Username.Name = "txt_Username";
      this.txt_Username.Size = new System.Drawing.Size(204, 21);
      this.txt_Username.TabIndex = 42;
      // 
      // txt_Port
      // 
      this.txt_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Port.Location = new System.Drawing.Point(162, 85);
      this.txt_Port.Name = "txt_Port";
      this.txt_Port.Size = new System.Drawing.Size(204, 21);
      this.txt_Port.TabIndex = 41;
      // 
      // txt_Server
      // 
      this.txt_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Server.Location = new System.Drawing.Point(162, 57);
      this.txt_Server.Name = "txt_Server";
      this.txt_Server.Size = new System.Drawing.Size(204, 21);
      this.txt_Server.TabIndex = 40;
      // 
      // lbl_datab
      // 
      this.lbl_datab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_datab.AutoSize = true;
      this.lbl_datab.BackColor = System.Drawing.Color.Transparent;
      this.lbl_datab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_datab.ForeColor = System.Drawing.Color.White;
      this.lbl_datab.Location = new System.Drawing.Point(11, 166);
      this.lbl_datab.Name = "lbl_datab";
      this.lbl_datab.Size = new System.Drawing.Size(77, 17);
      this.lbl_datab.TabIndex = 39;
      this.lbl_datab.Text = "Database";
      // 
      // lbl_password
      // 
      this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_password.AutoSize = true;
      this.lbl_password.BackColor = System.Drawing.Color.Transparent;
      this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_password.ForeColor = System.Drawing.Color.White;
      this.lbl_password.Location = new System.Drawing.Point(11, 139);
      this.lbl_password.Name = "lbl_password";
      this.lbl_password.Size = new System.Drawing.Size(77, 17);
      this.lbl_password.TabIndex = 38;
      this.lbl_password.Text = "Password";
      // 
      // lbl_user
      // 
      this.lbl_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_user.AutoSize = true;
      this.lbl_user.BackColor = System.Drawing.Color.Transparent;
      this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_user.ForeColor = System.Drawing.Color.White;
      this.lbl_user.Location = new System.Drawing.Point(11, 112);
      this.lbl_user.Name = "lbl_user";
      this.lbl_user.Size = new System.Drawing.Size(42, 17);
      this.lbl_user.TabIndex = 37;
      this.lbl_user.Text = "User";
      // 
      // lbl_port
      // 
      this.lbl_port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_port.AutoSize = true;
      this.lbl_port.BackColor = System.Drawing.Color.Transparent;
      this.lbl_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_port.ForeColor = System.Drawing.Color.White;
      this.lbl_port.Location = new System.Drawing.Point(11, 85);
      this.lbl_port.Name = "lbl_port";
      this.lbl_port.Size = new System.Drawing.Size(38, 17);
      this.lbl_port.TabIndex = 36;
      this.lbl_port.Text = "Port";
      // 
      // lbl_Server
      // 
      this.lbl_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_Server.AutoSize = true;
      this.lbl_Server.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Server.ForeColor = System.Drawing.Color.White;
      this.lbl_Server.Location = new System.Drawing.Point(11, 57);
      this.lbl_Server.Name = "lbl_Server";
      this.lbl_Server.Size = new System.Drawing.Size(56, 17);
      this.lbl_Server.TabIndex = 35;
      this.lbl_Server.Text = "Server";
      // 
      // pnl_setUpDB
      // 
      this.pnl_setUpDB.BackgroundImage = global::NoteView.Properties.Resources.bg_noteview;
      this.pnl_setUpDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pnl_setUpDB.Controls.Add(this.lbl_ErrorDetails);
      this.pnl_setUpDB.Controls.Add(this.gbx_FASetup);
      this.pnl_setUpDB.Controls.Add(this.gb_dbcnnct);
      this.pnl_setUpDB.Controls.Add(this.pcb_Welcome);
      this.pnl_setUpDB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_setUpDB.ForeColor = System.Drawing.Color.White;
      this.pnl_setUpDB.Location = new System.Drawing.Point(0, 0);
      this.pnl_setUpDB.Name = "pnl_setUpDB";
      this.pnl_setUpDB.Size = new System.Drawing.Size(784, 411);
      this.pnl_setUpDB.TabIndex = 12;
      // 
      // lbl_ErrorDetails
      // 
      this.lbl_ErrorDetails.AutoSize = true;
      this.lbl_ErrorDetails.BackColor = System.Drawing.Color.Transparent;
      this.lbl_ErrorDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lbl_ErrorDetails.ForeColor = System.Drawing.Color.White;
      this.lbl_ErrorDetails.Location = new System.Drawing.Point(0, 398);
      this.lbl_ErrorDetails.Name = "lbl_ErrorDetails";
      this.lbl_ErrorDetails.Size = new System.Drawing.Size(77, 13);
      this.lbl_ErrorDetails.TabIndex = 48;
      this.lbl_ErrorDetails.Text = "lbl_ErrorDetails";
      this.lbl_ErrorDetails.Visible = false;
      // 
      // gbx_FASetup
      // 
      this.gbx_FASetup.BackColor = System.Drawing.Color.Transparent;
      this.gbx_FASetup.Controls.Add(this.cb_ShowPass2);
      this.gbx_FASetup.Controls.Add(this.cb_ShowPass);
      this.gbx_FASetup.Controls.Add(this.lbl_SignUpOutput);
      this.gbx_FASetup.Controls.Add(this.cmd_SignUp);
      this.gbx_FASetup.Controls.Add(this.txt_SU_Pword2);
      this.gbx_FASetup.Controls.Add(this.txt_SU_Pword);
      this.gbx_FASetup.Controls.Add(this.txt_SU_Lname);
      this.gbx_FASetup.Controls.Add(this.txt_SU_Fname);
      this.gbx_FASetup.Controls.Add(this.txt_SU_Username);
      this.gbx_FASetup.Controls.Add(this.lbl_SU_Pword2);
      this.gbx_FASetup.Controls.Add(this.lbl_SU_Pword);
      this.gbx_FASetup.Controls.Add(this.lbl_SU_Lname);
      this.gbx_FASetup.Controls.Add(this.lbl_SU_Fname);
      this.gbx_FASetup.Controls.Add(this.lbl_SU_Uname);
      this.gbx_FASetup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbx_FASetup.ForeColor = System.Drawing.Color.White;
      this.gbx_FASetup.Location = new System.Drawing.Point(396, 50);
      this.gbx_FASetup.Name = "gbx_FASetup";
      this.gbx_FASetup.Size = new System.Drawing.Size(376, 311);
      this.gbx_FASetup.TabIndex = 47;
      this.gbx_FASetup.TabStop = false;
      this.gbx_FASetup.Text = "Set-up First Account";
      this.gbx_FASetup.Visible = false;
      // 
      // cb_ShowPass2
      // 
      this.cb_ShowPass2.AutoSize = true;
      this.cb_ShowPass2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cb_ShowPass2.Location = new System.Drawing.Point(163, 206);
      this.cb_ShowPass2.Name = "cb_ShowPass2";
      this.cb_ShowPass2.Size = new System.Drawing.Size(108, 18);
      this.cb_ShowPass2.TabIndex = 48;
      this.cb_ShowPass2.Text = "Show Password";
      this.cb_ShowPass2.UseVisualStyleBackColor = true;
      this.cb_ShowPass2.CheckedChanged += new System.EventHandler(this.cb_ShowPass2_CheckedChanged);
      // 
      // cb_ShowPass
      // 
      this.cb_ShowPass.AutoSize = true;
      this.cb_ShowPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cb_ShowPass.Location = new System.Drawing.Point(163, 161);
      this.cb_ShowPass.Name = "cb_ShowPass";
      this.cb_ShowPass.Size = new System.Drawing.Size(108, 18);
      this.cb_ShowPass.TabIndex = 47;
      this.cb_ShowPass.Text = "Show Password";
      this.cb_ShowPass.UseVisualStyleBackColor = true;
      this.cb_ShowPass.CheckedChanged += new System.EventHandler(this.cb_ShowPass_CheckedChanged);
      // 
      // lbl_SignUpOutput
      // 
      this.lbl_SignUpOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SignUpOutput.Location = new System.Drawing.Point(0, 228);
      this.lbl_SignUpOutput.Name = "lbl_SignUpOutput";
      this.lbl_SignUpOutput.Size = new System.Drawing.Size(376, 30);
      this.lbl_SignUpOutput.TabIndex = 46;
      this.lbl_SignUpOutput.Text = "lbl_SignUpOutput";
      this.lbl_SignUpOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_SignUpOutput.Visible = false;
      // 
      // cmd_SignUp
      // 
      this.cmd_SignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmd_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmd_SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.cmd_SignUp.Location = new System.Drawing.Point(134, 254);
      this.cmd_SignUp.Name = "cmd_SignUp";
      this.cmd_SignUp.Size = new System.Drawing.Size(114, 28);
      this.cmd_SignUp.TabIndex = 45;
      this.cmd_SignUp.Text = "Sign-Up";
      this.cmd_SignUp.UseVisualStyleBackColor = true;
      this.cmd_SignUp.Click += new System.EventHandler(this.cmd_SignUp_Click);
      // 
      // txt_SU_Pword2
      // 
      this.txt_SU_Pword2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_SU_Pword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_SU_Pword2.Location = new System.Drawing.Point(162, 184);
      this.txt_SU_Pword2.Name = "txt_SU_Pword2";
      this.txt_SU_Pword2.Size = new System.Drawing.Size(204, 22);
      this.txt_SU_Pword2.TabIndex = 44;
      this.txt_SU_Pword2.UseSystemPasswordChar = true;
      // 
      // txt_SU_Pword
      // 
      this.txt_SU_Pword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_SU_Pword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_SU_Pword.Location = new System.Drawing.Point(162, 139);
      this.txt_SU_Pword.Name = "txt_SU_Pword";
      this.txt_SU_Pword.Size = new System.Drawing.Size(204, 22);
      this.txt_SU_Pword.TabIndex = 43;
      this.txt_SU_Pword.UseSystemPasswordChar = true;
      // 
      // txt_SU_Lname
      // 
      this.txt_SU_Lname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_SU_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_SU_Lname.Location = new System.Drawing.Point(162, 112);
      this.txt_SU_Lname.Name = "txt_SU_Lname";
      this.txt_SU_Lname.Size = new System.Drawing.Size(204, 22);
      this.txt_SU_Lname.TabIndex = 42;
      // 
      // txt_SU_Fname
      // 
      this.txt_SU_Fname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_SU_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_SU_Fname.Location = new System.Drawing.Point(162, 85);
      this.txt_SU_Fname.Name = "txt_SU_Fname";
      this.txt_SU_Fname.Size = new System.Drawing.Size(204, 22);
      this.txt_SU_Fname.TabIndex = 41;
      // 
      // txt_SU_Username
      // 
      this.txt_SU_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_SU_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_SU_Username.Location = new System.Drawing.Point(162, 57);
      this.txt_SU_Username.Name = "txt_SU_Username";
      this.txt_SU_Username.Size = new System.Drawing.Size(204, 22);
      this.txt_SU_Username.TabIndex = 40;
      // 
      // lbl_SU_Pword2
      // 
      this.lbl_SU_Pword2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_SU_Pword2.AutoSize = true;
      this.lbl_SU_Pword2.BackColor = System.Drawing.Color.Transparent;
      this.lbl_SU_Pword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SU_Pword2.ForeColor = System.Drawing.Color.White;
      this.lbl_SU_Pword2.Location = new System.Drawing.Point(11, 184);
      this.lbl_SU_Pword2.Name = "lbl_SU_Pword2";
      this.lbl_SU_Pword2.Size = new System.Drawing.Size(137, 17);
      this.lbl_SU_Pword2.TabIndex = 39;
      this.lbl_SU_Pword2.Text = "Confirm Password";
      // 
      // lbl_SU_Pword
      // 
      this.lbl_SU_Pword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_SU_Pword.AutoSize = true;
      this.lbl_SU_Pword.BackColor = System.Drawing.Color.Transparent;
      this.lbl_SU_Pword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SU_Pword.ForeColor = System.Drawing.Color.White;
      this.lbl_SU_Pword.Location = new System.Drawing.Point(11, 139);
      this.lbl_SU_Pword.Name = "lbl_SU_Pword";
      this.lbl_SU_Pword.Size = new System.Drawing.Size(77, 17);
      this.lbl_SU_Pword.TabIndex = 38;
      this.lbl_SU_Pword.Text = "Password";
      // 
      // lbl_SU_Lname
      // 
      this.lbl_SU_Lname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_SU_Lname.AutoSize = true;
      this.lbl_SU_Lname.BackColor = System.Drawing.Color.Transparent;
      this.lbl_SU_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SU_Lname.ForeColor = System.Drawing.Color.White;
      this.lbl_SU_Lname.Location = new System.Drawing.Point(11, 112);
      this.lbl_SU_Lname.Name = "lbl_SU_Lname";
      this.lbl_SU_Lname.Size = new System.Drawing.Size(85, 17);
      this.lbl_SU_Lname.TabIndex = 37;
      this.lbl_SU_Lname.Text = "Last Name";
      // 
      // lbl_SU_Fname
      // 
      this.lbl_SU_Fname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_SU_Fname.AutoSize = true;
      this.lbl_SU_Fname.BackColor = System.Drawing.Color.Transparent;
      this.lbl_SU_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SU_Fname.ForeColor = System.Drawing.Color.White;
      this.lbl_SU_Fname.Location = new System.Drawing.Point(11, 85);
      this.lbl_SU_Fname.Name = "lbl_SU_Fname";
      this.lbl_SU_Fname.Size = new System.Drawing.Size(86, 17);
      this.lbl_SU_Fname.TabIndex = 36;
      this.lbl_SU_Fname.Text = "First Name";
      // 
      // lbl_SU_Uname
      // 
      this.lbl_SU_Uname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_SU_Uname.AutoSize = true;
      this.lbl_SU_Uname.BackColor = System.Drawing.Color.Transparent;
      this.lbl_SU_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SU_Uname.ForeColor = System.Drawing.Color.White;
      this.lbl_SU_Uname.Location = new System.Drawing.Point(11, 57);
      this.lbl_SU_Uname.Name = "lbl_SU_Uname";
      this.lbl_SU_Uname.Size = new System.Drawing.Size(81, 17);
      this.lbl_SU_Uname.TabIndex = 35;
      this.lbl_SU_Uname.Text = "Username";
      // 
      // bwork_SignUp
      // 
      this.bwork_SignUp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_SignUp_DoWork);
      this.bwork_SignUp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_SignUp_RunWorkerCompleted);
      // 
      // tt_ForceConnectHint
      // 
      this.tt_ForceConnectHint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.tt_ForceConnectHint.ToolTipTitle = "Force Connect?";
      // 
      // SetupDB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(784, 411);
      this.Controls.Add(this.pnl_setUpDB);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "SetupDB";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Connect to a Database";
      this.Shown += new System.EventHandler(this.SetupDB_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.pcb_Welcome)).EndInit();
      this.gb_dbcnnct.ResumeLayout(false);
      this.gb_dbcnnct.PerformLayout();
      this.pnl_setUpDB.ResumeLayout(false);
      this.pnl_setUpDB.PerformLayout();
      this.gbx_FASetup.ResumeLayout(false);
      this.gbx_FASetup.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
        private System.ComponentModel.BackgroundWorker bwork_Connection;
    private System.Windows.Forms.PictureBox pcb_Welcome;
    private System.Windows.Forms.GroupBox gb_dbcnnct;
    private System.Windows.Forms.Label lbl_ConnectOutput;
    private System.Windows.Forms.Button btn_Connect;
    private System.Windows.Forms.TextBox txt_DB;
    private System.Windows.Forms.TextBox txt_Password;
    private System.Windows.Forms.TextBox txt_Username;
    private System.Windows.Forms.TextBox txt_Port;
    private System.Windows.Forms.TextBox txt_Server;
    private System.Windows.Forms.Label lbl_datab;
    private System.Windows.Forms.Label lbl_password;
    private System.Windows.Forms.Label lbl_user;
    private System.Windows.Forms.Label lbl_port;
    private System.Windows.Forms.Label lbl_Server;
    private System.Windows.Forms.Panel pnl_setUpDB;
    private System.Windows.Forms.GroupBox gbx_FASetup;
    private System.Windows.Forms.Label lbl_SignUpOutput;
    private System.Windows.Forms.Button cmd_SignUp;
    private System.Windows.Forms.TextBox txt_SU_Pword2;
    private System.Windows.Forms.TextBox txt_SU_Pword;
    private System.Windows.Forms.TextBox txt_SU_Lname;
    private System.Windows.Forms.TextBox txt_SU_Fname;
    private System.Windows.Forms.TextBox txt_SU_Username;
    private System.Windows.Forms.Label lbl_SU_Pword2;
    private System.Windows.Forms.Label lbl_SU_Pword;
    private System.Windows.Forms.Label lbl_SU_Lname;
    private System.Windows.Forms.Label lbl_SU_Fname;
    private System.Windows.Forms.Label lbl_SU_Uname;
    private System.Windows.Forms.CheckBox cb_ShowPass2;
    private System.Windows.Forms.CheckBox cb_ShowPass;
    private System.ComponentModel.BackgroundWorker bwork_SignUp;
    private System.Windows.Forms.CheckBox cb_ForceConnect;
    private System.Windows.Forms.ToolTip tt_ForceConnectHint;
    private System.Windows.Forms.Label lbl_ErrorDetails;
    private System.Windows.Forms.Label label1;
  }
}