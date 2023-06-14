namespace NoteView
{
  partial class SystemConfiguration
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemConfiguration));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pcmd_RoomClear = new NoteView.PictureButton();
      this.cmd_RoomAdd = new System.Windows.Forms.Button();
      this.txt_RoomCapacity = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txt_RoomRate = new System.Windows.Forms.TextBox();
      this.txt_RoomType = new System.Windows.Forms.TextBox();
      this.txt_RoomNo = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cmd_RoomRemove = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.pcmd_RoomSearch = new NoteView.PictureButton();
      this.txt_RoomSearch = new System.Windows.Forms.TextBox();
      this.gb_RoomTable = new System.Windows.Forms.GroupBox();
      this.dgv_Rooms = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bwork_RoomFetcher = new System.ComponentModel.BackgroundWorker();
      this.bwork_RoomDeleter = new System.ComponentModel.BackgroundWorker();
      this.sc_SysConfig = new System.Windows.Forms.SplitContainer();
      this.fpnl_SysConfigChooser = new System.Windows.Forms.FlowLayoutPanel();
      this.lbl_Room = new System.Windows.Forms.Label();
      this.lbl_Service = new System.Windows.Forms.Label();
      this.pnl_Service = new System.Windows.Forms.Panel();
      this.gb_Services = new System.Windows.Forms.GroupBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.pcmd_ServiceClear = new NoteView.PictureButton();
      this.cmd_ServiceAdd = new System.Windows.Forms.Button();
      this.txt_ServiceCapacity = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txt_ServiceRate = new System.Windows.Forms.TextBox();
      this.txt_ServiceGroup = new System.Windows.Forms.TextBox();
      this.txt_ServiceName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.cmd_ServiceRemove = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.pcmd_ServiceSearch = new NoteView.PictureButton();
      this.txt_ServiceSearch = new System.Windows.Forms.TextBox();
      this.gb_ServiceTable = new System.Windows.Forms.GroupBox();
      this.dgv_Services = new System.Windows.Forms.DataGridView();
      this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ServiceGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ServiceRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ServiceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnl_Room = new System.Windows.Forms.Panel();
      this.bwork_RoomAdder = new System.ComponentModel.BackgroundWorker();
      this.ttip_Tip = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_RoomClear)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_RoomSearch)).BeginInit();
      this.gb_RoomTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sc_SysConfig)).BeginInit();
      this.sc_SysConfig.Panel1.SuspendLayout();
      this.sc_SysConfig.Panel2.SuspendLayout();
      this.sc_SysConfig.SuspendLayout();
      this.fpnl_SysConfigChooser.SuspendLayout();
      this.pnl_Service.SuspendLayout();
      this.gb_Services.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_ServiceClear)).BeginInit();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_ServiceSearch)).BeginInit();
      this.gb_ServiceTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).BeginInit();
      this.pnl_Room.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.cmd_RoomRemove);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.gb_RoomTable);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(145, 91);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Room";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.pcmd_RoomClear);
      this.panel1.Controls.Add(this.cmd_RoomAdd);
      this.panel1.Controls.Add(this.txt_RoomCapacity);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.txt_RoomRate);
      this.panel1.Controls.Add(this.txt_RoomType);
      this.panel1.Controls.Add(this.txt_RoomNo);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(16, 23);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(285, 188);
      this.panel1.TabIndex = 5;
      // 
      // pcmd_RoomClear
      // 
      this.pcmd_RoomClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcmd_RoomClear.BackgroundImage")));
      this.pcmd_RoomClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pcmd_RoomClear.Location = new System.Drawing.Point(19, 153);
      this.pcmd_RoomClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pcmd_RoomClear.Name = "pcmd_RoomClear";
      this.pcmd_RoomClear.Size = new System.Drawing.Size(29, 27);
      this.pcmd_RoomClear.TabIndex = 9;
      this.pcmd_RoomClear.TabStop = false;
      this.ttip_Tip.SetToolTip(this.pcmd_RoomClear, "Clear fields");
      this.pcmd_RoomClear.Click += new System.EventHandler(this.pcmd_RoomClear_Click);
      // 
      // cmd_RoomAdd
      // 
      this.cmd_RoomAdd.Location = new System.Drawing.Point(93, 153);
      this.cmd_RoomAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cmd_RoomAdd.Name = "cmd_RoomAdd";
      this.cmd_RoomAdd.Size = new System.Drawing.Size(100, 28);
      this.cmd_RoomAdd.TabIndex = 8;
      this.cmd_RoomAdd.Text = "Add Room";
      this.cmd_RoomAdd.UseVisualStyleBackColor = true;
      this.cmd_RoomAdd.Click += new System.EventHandler(this.cmd_RoomAdd_Click);
      // 
      // txt_RoomCapacity
      // 
      this.txt_RoomCapacity.Location = new System.Drawing.Point(105, 108);
      this.txt_RoomCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_RoomCapacity.Name = "txt_RoomCapacity";
      this.txt_RoomCapacity.Size = new System.Drawing.Size(160, 22);
      this.txt_RoomCapacity.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(33, 112);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 16);
      this.label4.TabIndex = 6;
      this.label4.Text = "Capacity";
      // 
      // txt_RoomRate
      // 
      this.txt_RoomRate.Location = new System.Drawing.Point(105, 76);
      this.txt_RoomRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_RoomRate.Name = "txt_RoomRate";
      this.txt_RoomRate.Size = new System.Drawing.Size(160, 22);
      this.txt_RoomRate.TabIndex = 5;
      // 
      // txt_RoomType
      // 
      this.txt_RoomType.Location = new System.Drawing.Point(105, 44);
      this.txt_RoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_RoomType.Name = "txt_RoomType";
      this.txt_RoomType.Size = new System.Drawing.Size(160, 22);
      this.txt_RoomType.TabIndex = 4;
      // 
      // txt_RoomNo
      // 
      this.txt_RoomNo.Location = new System.Drawing.Point(105, 11);
      this.txt_RoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_RoomNo.Name = "txt_RoomNo";
      this.txt_RoomNo.Size = new System.Drawing.Size(160, 22);
      this.txt_RoomNo.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(57, 80);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 16);
      this.label3.TabIndex = 2;
      this.label3.Text = "Rate";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 48);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Room Type";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 15);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Room No.";
      // 
      // cmd_RoomRemove
      // 
      this.cmd_RoomRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cmd_RoomRemove.Location = new System.Drawing.Point(-220, -326);
      this.cmd_RoomRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cmd_RoomRemove.Name = "cmd_RoomRemove";
      this.cmd_RoomRemove.Size = new System.Drawing.Size(100, 28);
      this.cmd_RoomRemove.TabIndex = 9;
      this.cmd_RoomRemove.Text = "Remove";
      this.cmd_RoomRemove.UseVisualStyleBackColor = true;
      this.cmd_RoomRemove.Click += new System.EventHandler(this.cmd_RoomRemove_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.pcmd_RoomSearch);
      this.groupBox2.Controls.Add(this.txt_RoomSearch);
      this.groupBox2.Location = new System.Drawing.Point(-111, -341);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Size = new System.Drawing.Size(248, 50);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Search Room Type or Room No.";
      // 
      // pcmd_RoomSearch
      // 
      this.pcmd_RoomSearch.BackgroundImage = global::NoteView.Properties.Resources.search;
      this.pcmd_RoomSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pcmd_RoomSearch.Location = new System.Drawing.Point(15, 23);
      this.pcmd_RoomSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pcmd_RoomSearch.Name = "pcmd_RoomSearch";
      this.pcmd_RoomSearch.Size = new System.Drawing.Size(24, 22);
      this.pcmd_RoomSearch.TabIndex = 3;
      this.pcmd_RoomSearch.TabStop = false;
      this.pcmd_RoomSearch.Click += new System.EventHandler(this.pcmd_RoomSearch_Click);
      // 
      // txt_RoomSearch
      // 
      this.txt_RoomSearch.Location = new System.Drawing.Point(47, 21);
      this.txt_RoomSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_RoomSearch.Name = "txt_RoomSearch";
      this.txt_RoomSearch.Size = new System.Drawing.Size(192, 22);
      this.txt_RoomSearch.TabIndex = 2;
      // 
      // gb_RoomTable
      // 
      this.gb_RoomTable.Controls.Add(this.dgv_Rooms);
      this.gb_RoomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.gb_RoomTable.Location = new System.Drawing.Point(4, -288);
      this.gb_RoomTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_RoomTable.Name = "gb_RoomTable";
      this.gb_RoomTable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_RoomTable.Size = new System.Drawing.Size(137, 375);
      this.gb_RoomTable.TabIndex = 1;
      this.gb_RoomTable.TabStop = false;
      this.gb_RoomTable.Text = "Existing Rooms";
      // 
      // dgv_Rooms
      // 
      this.dgv_Rooms.AllowUserToAddRows = false;
      this.dgv_Rooms.AllowUserToDeleteRows = false;
      this.dgv_Rooms.AllowUserToResizeColumns = false;
      this.dgv_Rooms.AllowUserToResizeRows = false;
      this.dgv_Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgv_Rooms.ColumnHeadersHeight = 29;
      this.dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.roomNumber,
            this.roomType,
            this.roomRate,
            this.roomCapacity});
      this.dgv_Rooms.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_Rooms.Location = new System.Drawing.Point(4, 19);
      this.dgv_Rooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_Rooms.Name = "dgv_Rooms";
      this.dgv_Rooms.ReadOnly = true;
      this.dgv_Rooms.RowHeadersWidth = 51;
      this.dgv_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Rooms.Size = new System.Drawing.Size(129, 352);
      this.dgv_Rooms.TabIndex = 0;
      // 
      // id
      // 
      this.id.HeaderText = "Room ID";
      this.id.MinimumWidth = 6;
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 89;
      // 
      // roomNumber
      // 
      this.roomNumber.HeaderText = "Room No.";
      this.roomNumber.MinimumWidth = 6;
      this.roomNumber.Name = "roomNumber";
      this.roomNumber.ReadOnly = true;
      this.roomNumber.Width = 97;
      // 
      // roomType
      // 
      this.roomType.HeaderText = "Room Type";
      this.roomType.MinimumWidth = 6;
      this.roomType.Name = "roomType";
      this.roomType.ReadOnly = true;
      this.roomType.Width = 108;
      // 
      // roomRate
      // 
      this.roomRate.HeaderText = "Rate";
      this.roomRate.MinimumWidth = 6;
      this.roomRate.Name = "roomRate";
      this.roomRate.ReadOnly = true;
      this.roomRate.Width = 65;
      // 
      // roomCapacity
      // 
      this.roomCapacity.HeaderText = "Capacity";
      this.roomCapacity.MinimumWidth = 6;
      this.roomCapacity.Name = "roomCapacity";
      this.roomCapacity.ReadOnly = true;
      this.roomCapacity.Width = 89;
      // 
      // bwork_RoomFetcher
      // 
      this.bwork_RoomFetcher.WorkerReportsProgress = true;
      this.bwork_RoomFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_RoomFetcher_DoWork);
      this.bwork_RoomFetcher.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwork_RoomFetcher_ProgressChanged);
      this.bwork_RoomFetcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_RoomFetcher_RunWorkerCompleted);
      // 
      // bwork_RoomDeleter
      // 
      this.bwork_RoomDeleter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_RoomDeleter_DoWork);
      this.bwork_RoomDeleter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_RoomDeleter_RunWorkerCompleted);
      // 
      // sc_SysConfig
      // 
      this.sc_SysConfig.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sc_SysConfig.IsSplitterFixed = true;
      this.sc_SysConfig.Location = new System.Drawing.Point(0, 0);
      this.sc_SysConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.sc_SysConfig.Name = "sc_SysConfig";
      // 
      // sc_SysConfig.Panel1
      // 
      this.sc_SysConfig.Panel1.Controls.Add(this.fpnl_SysConfigChooser);
      // 
      // sc_SysConfig.Panel2
      // 
      this.sc_SysConfig.Panel2.Controls.Add(this.pnl_Service);
      this.sc_SysConfig.Panel2.Controls.Add(this.pnl_Room);
      this.sc_SysConfig.Size = new System.Drawing.Size(1047, 608);
      this.sc_SysConfig.SplitterDistance = 186;
      this.sc_SysConfig.SplitterWidth = 1;
      this.sc_SysConfig.TabIndex = 10;
      // 
      // fpnl_SysConfigChooser
      // 
      this.fpnl_SysConfigChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fpnl_SysConfigChooser.AutoScroll = true;
      this.fpnl_SysConfigChooser.Controls.Add(this.lbl_Room);
      this.fpnl_SysConfigChooser.Controls.Add(this.lbl_Service);
      this.fpnl_SysConfigChooser.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.fpnl_SysConfigChooser.Location = new System.Drawing.Point(0, 34);
      this.fpnl_SysConfigChooser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.fpnl_SysConfigChooser.Name = "fpnl_SysConfigChooser";
      this.fpnl_SysConfigChooser.Size = new System.Drawing.Size(186, 574);
      this.fpnl_SysConfigChooser.TabIndex = 0;
      // 
      // lbl_Room
      // 
      this.lbl_Room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_Room.AutoSize = true;
      this.lbl_Room.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Room.Location = new System.Drawing.Point(4, 0);
      this.lbl_Room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Room.Name = "lbl_Room";
      this.lbl_Room.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.lbl_Room.Size = new System.Drawing.Size(120, 32);
      this.lbl_Room.TabIndex = 1;
      this.lbl_Room.Text = "<rooms>";
      this.lbl_Room.Click += new System.EventHandler(this.lbl_Room_Click);
      // 
      // lbl_Service
      // 
      this.lbl_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_Service.AutoSize = true;
      this.lbl_Service.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Service.Location = new System.Drawing.Point(4, 32);
      this.lbl_Service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Service.Name = "lbl_Service";
      this.lbl_Service.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.lbl_Service.Size = new System.Drawing.Size(120, 32);
      this.lbl_Service.TabIndex = 2;
      this.lbl_Service.Text = "<services>";
      this.lbl_Service.Click += new System.EventHandler(this.lbl_Service_Click);
      // 
      // pnl_Service
      // 
      this.pnl_Service.Controls.Add(this.gb_Services);
      this.pnl_Service.Location = new System.Drawing.Point(11, 7);
      this.pnl_Service.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pnl_Service.Name = "pnl_Service";
      this.pnl_Service.Size = new System.Drawing.Size(149, 91);
      this.pnl_Service.TabIndex = 5;
      // 
      // gb_Services
      // 
      this.gb_Services.Controls.Add(this.panel2);
      this.gb_Services.Controls.Add(this.cmd_ServiceRemove);
      this.gb_Services.Controls.Add(this.groupBox3);
      this.gb_Services.Controls.Add(this.gb_ServiceTable);
      this.gb_Services.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gb_Services.Location = new System.Drawing.Point(0, 0);
      this.gb_Services.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_Services.Name = "gb_Services";
      this.gb_Services.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_Services.Size = new System.Drawing.Size(149, 91);
      this.gb_Services.TabIndex = 0;
      this.gb_Services.TabStop = false;
      this.gb_Services.Text = "Service";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.pcmd_ServiceClear);
      this.panel2.Controls.Add(this.cmd_ServiceAdd);
      this.panel2.Controls.Add(this.txt_ServiceCapacity);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.txt_ServiceRate);
      this.panel2.Controls.Add(this.txt_ServiceGroup);
      this.panel2.Controls.Add(this.txt_ServiceName);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label8);
      this.panel2.Location = new System.Drawing.Point(16, 23);
      this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(284, 188);
      this.panel2.TabIndex = 5;
      // 
      // pcmd_ServiceClear
      // 
      this.pcmd_ServiceClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcmd_ServiceClear.BackgroundImage")));
      this.pcmd_ServiceClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pcmd_ServiceClear.Location = new System.Drawing.Point(27, 153);
      this.pcmd_ServiceClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pcmd_ServiceClear.Name = "pcmd_ServiceClear";
      this.pcmd_ServiceClear.Size = new System.Drawing.Size(29, 27);
      this.pcmd_ServiceClear.TabIndex = 9;
      this.pcmd_ServiceClear.TabStop = false;
      // 
      // cmd_ServiceAdd
      // 
      this.cmd_ServiceAdd.Location = new System.Drawing.Point(101, 153);
      this.cmd_ServiceAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cmd_ServiceAdd.Name = "cmd_ServiceAdd";
      this.cmd_ServiceAdd.Size = new System.Drawing.Size(100, 28);
      this.cmd_ServiceAdd.TabIndex = 8;
      this.cmd_ServiceAdd.Text = "Add Service";
      this.cmd_ServiceAdd.UseVisualStyleBackColor = true;
      // 
      // txt_ServiceCapacity
      // 
      this.txt_ServiceCapacity.Location = new System.Drawing.Point(113, 108);
      this.txt_ServiceCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_ServiceCapacity.Name = "txt_ServiceCapacity";
      this.txt_ServiceCapacity.Size = new System.Drawing.Size(160, 22);
      this.txt_ServiceCapacity.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(44, 112);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 16);
      this.label5.TabIndex = 6;
      this.label5.Text = "Quantity";
      // 
      // txt_ServiceRate
      // 
      this.txt_ServiceRate.Location = new System.Drawing.Point(113, 76);
      this.txt_ServiceRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_ServiceRate.Name = "txt_ServiceRate";
      this.txt_ServiceRate.Size = new System.Drawing.Size(160, 22);
      this.txt_ServiceRate.TabIndex = 5;
      // 
      // txt_ServiceGroup
      // 
      this.txt_ServiceGroup.Location = new System.Drawing.Point(113, 44);
      this.txt_ServiceGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_ServiceGroup.Name = "txt_ServiceGroup";
      this.txt_ServiceGroup.Size = new System.Drawing.Size(160, 22);
      this.txt_ServiceGroup.TabIndex = 4;
      // 
      // txt_ServiceName
      // 
      this.txt_ServiceName.Location = new System.Drawing.Point(113, 11);
      this.txt_ServiceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_ServiceName.Name = "txt_ServiceName";
      this.txt_ServiceName.Size = new System.Drawing.Size(160, 22);
      this.txt_ServiceName.TabIndex = 3;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(65, 80);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(36, 16);
      this.label6.TabIndex = 2;
      this.label6.Text = "Rate";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(57, 48);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(44, 16);
      this.label7.TabIndex = 1;
      this.label7.Text = "Group";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(8, 15);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(93, 16);
      this.label8.TabIndex = 0;
      this.label8.Text = "Service Name";
      // 
      // cmd_ServiceRemove
      // 
      this.cmd_ServiceRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cmd_ServiceRemove.Location = new System.Drawing.Point(-216, -326);
      this.cmd_ServiceRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cmd_ServiceRemove.Name = "cmd_ServiceRemove";
      this.cmd_ServiceRemove.Size = new System.Drawing.Size(100, 28);
      this.cmd_ServiceRemove.TabIndex = 9;
      this.cmd_ServiceRemove.Text = "Remove";
      this.cmd_ServiceRemove.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.pcmd_ServiceSearch);
      this.groupBox3.Controls.Add(this.txt_ServiceSearch);
      this.groupBox3.Location = new System.Drawing.Point(-107, -341);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Size = new System.Drawing.Size(248, 50);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Search Group or Service";
      // 
      // pcmd_ServiceSearch
      // 
      this.pcmd_ServiceSearch.BackgroundImage = global::NoteView.Properties.Resources.search;
      this.pcmd_ServiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pcmd_ServiceSearch.Location = new System.Drawing.Point(15, 23);
      this.pcmd_ServiceSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pcmd_ServiceSearch.Name = "pcmd_ServiceSearch";
      this.pcmd_ServiceSearch.Size = new System.Drawing.Size(24, 22);
      this.pcmd_ServiceSearch.TabIndex = 3;
      this.pcmd_ServiceSearch.TabStop = false;
      // 
      // txt_ServiceSearch
      // 
      this.txt_ServiceSearch.Location = new System.Drawing.Point(47, 21);
      this.txt_ServiceSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_ServiceSearch.Name = "txt_ServiceSearch";
      this.txt_ServiceSearch.Size = new System.Drawing.Size(192, 22);
      this.txt_ServiceSearch.TabIndex = 2;
      // 
      // gb_ServiceTable
      // 
      this.gb_ServiceTable.Controls.Add(this.dgv_Services);
      this.gb_ServiceTable.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.gb_ServiceTable.Location = new System.Drawing.Point(4, -288);
      this.gb_ServiceTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_ServiceTable.Name = "gb_ServiceTable";
      this.gb_ServiceTable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_ServiceTable.Size = new System.Drawing.Size(141, 375);
      this.gb_ServiceTable.TabIndex = 1;
      this.gb_ServiceTable.TabStop = false;
      this.gb_ServiceTable.Text = "<service_table>";
      // 
      // dgv_Services
      // 
      this.dgv_Services.AllowUserToAddRows = false;
      this.dgv_Services.AllowUserToDeleteRows = false;
      this.dgv_Services.AllowUserToResizeColumns = false;
      this.dgv_Services.AllowUserToResizeRows = false;
      this.dgv_Services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgv_Services.ColumnHeadersHeight = 29;
      this.dgv_Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.ServiceGroup,
            this.ServiceRate,
            this.ServiceQuantity});
      this.dgv_Services.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_Services.Location = new System.Drawing.Point(4, 19);
      this.dgv_Services.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_Services.Name = "dgv_Services";
      this.dgv_Services.ReadOnly = true;
      this.dgv_Services.RowHeadersWidth = 51;
      this.dgv_Services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Services.Size = new System.Drawing.Size(133, 352);
      this.dgv_Services.TabIndex = 0;
      // 
      // ServiceID
      // 
      this.ServiceID.HeaderText = "Service ID";
      this.ServiceID.MinimumWidth = 6;
      this.ServiceID.Name = "ServiceID";
      this.ServiceID.ReadOnly = true;
      this.ServiceID.Width = 98;
      // 
      // ServiceName
      // 
      this.ServiceName.HeaderText = "Service Name";
      this.ServiceName.MinimumWidth = 6;
      this.ServiceName.Name = "ServiceName";
      this.ServiceName.ReadOnly = true;
      this.ServiceName.Width = 122;
      // 
      // ServiceGroup
      // 
      this.ServiceGroup.HeaderText = "Service Group";
      this.ServiceGroup.MinimumWidth = 6;
      this.ServiceGroup.Name = "ServiceGroup";
      this.ServiceGroup.ReadOnly = true;
      this.ServiceGroup.Width = 122;
      // 
      // ServiceRate
      // 
      this.ServiceRate.HeaderText = "Rate";
      this.ServiceRate.MinimumWidth = 6;
      this.ServiceRate.Name = "ServiceRate";
      this.ServiceRate.ReadOnly = true;
      this.ServiceRate.Width = 65;
      // 
      // ServiceQuantity
      // 
      this.ServiceQuantity.HeaderText = "Quantity";
      this.ServiceQuantity.MinimumWidth = 6;
      this.ServiceQuantity.Name = "ServiceQuantity";
      this.ServiceQuantity.ReadOnly = true;
      this.ServiceQuantity.Width = 84;
      // 
      // pnl_Room
      // 
      this.pnl_Room.Controls.Add(this.groupBox1);
      this.pnl_Room.Location = new System.Drawing.Point(168, 9);
      this.pnl_Room.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pnl_Room.Name = "pnl_Room";
      this.pnl_Room.Size = new System.Drawing.Size(145, 91);
      this.pnl_Room.TabIndex = 1;
      // 
      // bwork_RoomAdder
      // 
      this.bwork_RoomAdder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_RoomAdder_DoWork);
      this.bwork_RoomAdder.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_RoomAdder_RunWorkerCompleted);
      // 
      // SystemConfiguration
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1047, 608);
      this.Controls.Add(this.sc_SysConfig);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "SystemConfiguration";
      this.Text = "Configure System";
      this.Load += new System.EventHandler(this.SystemConfiguration_Load);
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_RoomClear)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_RoomSearch)).EndInit();
      this.gb_RoomTable.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).EndInit();
      this.sc_SysConfig.Panel1.ResumeLayout(false);
      this.sc_SysConfig.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.sc_SysConfig)).EndInit();
      this.sc_SysConfig.ResumeLayout(false);
      this.fpnl_SysConfigChooser.ResumeLayout(false);
      this.fpnl_SysConfigChooser.PerformLayout();
      this.pnl_Service.ResumeLayout(false);
      this.gb_Services.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_ServiceClear)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_ServiceSearch)).EndInit();
      this.gb_ServiceTable.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).EndInit();
      this.pnl_Room.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dgv_Rooms;
    private System.Windows.Forms.GroupBox gb_RoomTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomRate;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomCapacity;
    private System.Windows.Forms.TextBox txt_RoomSearch;
    private System.Windows.Forms.GroupBox groupBox2;
    private PictureButton pcmd_RoomSearch;
    private System.ComponentModel.BackgroundWorker bwork_RoomFetcher;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txt_RoomRate;
    private System.Windows.Forms.TextBox txt_RoomType;
    private System.Windows.Forms.TextBox txt_RoomNo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txt_RoomCapacity;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button cmd_RoomRemove;
    private System.Windows.Forms.Button cmd_RoomAdd;
    private System.ComponentModel.BackgroundWorker bwork_RoomDeleter;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.SplitContainer sc_SysConfig;
    private System.Windows.Forms.FlowLayoutPanel fpnl_SysConfigChooser;
    private System.Windows.Forms.Label lbl_Room;
    private System.Windows.Forms.Panel pnl_Room;
    private System.ComponentModel.BackgroundWorker bwork_RoomAdder;
    private PictureButton pcmd_RoomClear;
    private System.Windows.Forms.ToolTip ttip_Tip;
    private System.Windows.Forms.Label lbl_Service;
    private System.Windows.Forms.Panel pnl_Service;
    private System.Windows.Forms.GroupBox gb_Services;
    private System.Windows.Forms.Panel panel2;
    private PictureButton pcmd_ServiceClear;
    private System.Windows.Forms.Button cmd_ServiceAdd;
    private System.Windows.Forms.TextBox txt_ServiceCapacity;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txt_ServiceRate;
    private System.Windows.Forms.TextBox txt_ServiceGroup;
    private System.Windows.Forms.TextBox txt_ServiceName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button cmd_ServiceRemove;
    private System.Windows.Forms.GroupBox groupBox3;
    private PictureButton pcmd_ServiceSearch;
    private System.Windows.Forms.TextBox txt_ServiceSearch;
    private System.Windows.Forms.GroupBox gb_ServiceTable;
    private System.Windows.Forms.DataGridView dgv_Services;
    private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
    private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
    private System.Windows.Forms.DataGridViewTextBoxColumn ServiceGroup;
    private System.Windows.Forms.DataGridViewTextBoxColumn ServiceRate;
    private System.Windows.Forms.DataGridViewTextBoxColumn ServiceQuantity;
  }
}