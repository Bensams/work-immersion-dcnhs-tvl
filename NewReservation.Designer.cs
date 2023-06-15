using System.Drawing;
using System.Windows.Forms;

namespace NoteView
{
  partial class NewReservation
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tb_Info = new System.Windows.Forms.TabControl();
            this.tp_Calendar = new System.Windows.Forms.TabPage();
            this.cb_enableRestrictOverride = new System.Windows.Forms.CheckBox();
            this.cb_enableOverBook = new System.Windows.Forms.CheckBox();
            this.cb_EnableRateOverride = new System.Windows.Forms.CheckBox();
            this.dgv_calendar = new System.Windows.Forms.DataGridView();
            this.book_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToday_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTom_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextTom_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestInfoPage = new System.Windows.Forms.TabPage();
            this.tb_State_Province = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.cb_PostDepo = new System.Windows.Forms.CheckBox();
            this.lbl_PostDepo = new System.Windows.Forms.Label();
            this.gb_PaymentMethod = new System.Windows.Forms.GroupBox();
            this.btn_CreditCards = new System.Windows.Forms.Button();
            this.tb_CardHolder = new System.Windows.Forms.TextBox();
            this.lbl_CardHolder = new System.Windows.Forms.Label();
            this.lbl_MMDD = new System.Windows.Forms.Label();
            this.tb_ExpiryDate = new System.Windows.Forms.TextBox();
            this.lbl_ExpiryDate = new System.Windows.Forms.Label();
            this.tb_CardNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_CardType = new System.Windows.Forms.ComboBox();
            this.lbl_CardType = new System.Windows.Forms.Label();
            this.gb_Vehicle = new System.Windows.Forms.GroupBox();
            this.tb_Color = new System.Windows.Forms.TextBox();
            this.tb_Brand = new System.Windows.Forms.TextBox();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_License = new System.Windows.Forms.Label();
            this.tb_License = new System.Windows.Forms.TextBox();
            this.tb_GuestNote = new System.Windows.Forms.TextBox();
            this.lbl_GuestNote = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tb_TelephoneNum = new System.Windows.Forms.TextBox();
            this.tb_MobileNum = new System.Windows.Forms.TextBox();
            this.lbl_MobileNum = new System.Windows.Forms.Label();
            this.lbl_TelephoneNum = new System.Windows.Forms.Label();
            this.lbl_Province_State = new System.Windows.Forms.Label();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.cb_Nationality = new System.Windows.Forms.ComboBox();
            this.lbl_Nationality = new System.Windows.Forms.Label();
            this.cb_Country = new System.Windows.Forms.ComboBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.tb_ZipCode = new System.Windows.Forms.TextBox();
            this.lbl_ZipCode = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.Services = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ServiceTotalCost = new System.Windows.Forms.Label();
            this.lbl_SericeTaxesCost = new System.Windows.Forms.Label();
            this.lbl_ServiceChargeCost = new System.Windows.Forms.Label();
            this.lbl_ServiceTotal = new System.Windows.Forms.Label();
            this.lbl_ServiceTaxes = new System.Windows.Forms.Label();
            this.lbl_ServiceCharges = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clm_ServiceNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Grouping = new System.Windows.Forms.ComboBox();
            this.lbl_Grouping = new System.Windows.Forms.Label();
            this.cb_Style = new System.Windows.Forms.ComboBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.lbl_FetchResID = new System.Windows.Forms.Label();
            this.lbl_ResID = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.dtp_coTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_Departure = new System.Windows.Forms.DateTimePicker();
            this.dtp_Arrival = new System.Windows.Forms.DateTimePicker();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Other = new System.Windows.Forms.TextBox();
            this.tb_Taxes = new System.Windows.Forms.TextBox();
            this.tb_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Other = new System.Windows.Forms.Label();
            this.lbl_Taxes = new System.Windows.Forms.Label();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.lbl_coTime = new System.Windows.Forms.Label();
            this.nud_Nights = new System.Windows.Forms.NumericUpDown();
            this.lbl_Nights = new System.Windows.Forms.Label();
            this.nud_Child = new System.Windows.Forms.NumericUpDown();
            this.lbl_Child = new System.Windows.Forms.Label();
            this.nud_Adult = new System.Windows.Forms.NumericUpDown();
            this.cb_RoomCharge = new System.Windows.Forms.ComboBox();
            this.cb_ClientType = new System.Windows.Forms.ComboBox();
            this.cb_WaitList = new System.Windows.Forms.CheckBox();
            this.cb_Guarantee = new System.Windows.Forms.CheckBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Adults = new System.Windows.Forms.Label();
            this.lbl_Departure = new System.Windows.Forms.Label();
            this.lbl_Arrival = new System.Windows.Forms.Label();
            this.lbl_RoomCharge = new System.Windows.Forms.Label();
            this.lbl_ClientType = new System.Windows.Forms.Label();
            this.RightSidePanel = new System.Windows.Forms.Panel();
            this.cb_RoomNumber = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cb_LockOff = new System.Windows.Forms.CheckBox();
            this.cb_EnableAssignment = new System.Windows.Forms.CheckBox();
            this.lbl_RoomNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Info.SuspendLayout();
            this.tp_Calendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).BeginInit();
            this.GuestInfoPage.SuspendLayout();
            this.gb_PaymentMethod.SuspendLayout();
            this.gb_Vehicle.SuspendLayout();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Nights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Child)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adult)).BeginInit();
            this.RightSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Info
            // 
            this.tb_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Info.Controls.Add(this.tp_Calendar);
            this.tb_Info.Controls.Add(this.GuestInfoPage);
            this.tb_Info.Controls.Add(this.Services);
            this.tb_Info.Location = new System.Drawing.Point(10, 175);
            this.tb_Info.Name = "tb_Info";
            this.tb_Info.SelectedIndex = 0;
            this.tb_Info.Size = new System.Drawing.Size(927, 490);
            this.tb_Info.TabIndex = 0;
            this.tb_Info.Selected += new System.Windows.Forms.TabControlEventHandler(this.tb_Info_Selected);
            // 
            // tp_Calendar
            // 
            this.tp_Calendar.Controls.Add(this.cb_enableRestrictOverride);
            this.tp_Calendar.Controls.Add(this.cb_enableOverBook);
            this.tp_Calendar.Controls.Add(this.cb_EnableRateOverride);
            this.tp_Calendar.Controls.Add(this.dgv_calendar);
            this.tp_Calendar.Location = new System.Drawing.Point(4, 22);
            this.tp_Calendar.Name = "tp_Calendar";
            this.tp_Calendar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Calendar.Size = new System.Drawing.Size(919, 464);
            this.tp_Calendar.TabIndex = 0;
            this.tp_Calendar.Text = "Calendar";
            this.tp_Calendar.UseVisualStyleBackColor = true;
            // 
            // cb_enableRestrictOverride
            // 
            this.cb_enableRestrictOverride.AutoSize = true;
            this.cb_enableRestrictOverride.Location = new System.Drawing.Point(277, 444);
            this.cb_enableRestrictOverride.Name = "cb_enableRestrictOverride";
            this.cb_enableRestrictOverride.Size = new System.Drawing.Size(163, 17);
            this.cb_enableRestrictOverride.TabIndex = 3;
            this.cb_enableRestrictOverride.Text = "Enable Restriction Overriding";
            this.cb_enableRestrictOverride.UseVisualStyleBackColor = true;
            // 
            // cb_enableOverBook
            // 
            this.cb_enableOverBook.AutoSize = true;
            this.cb_enableOverBook.Location = new System.Drawing.Point(162, 444);
            this.cb_enableOverBook.Name = "cb_enableOverBook";
            this.cb_enableOverBook.Size = new System.Drawing.Size(109, 17);
            this.cb_enableOverBook.TabIndex = 2;
            this.cb_enableOverBook.Text = "Enable Overbook";
            this.cb_enableOverBook.UseVisualStyleBackColor = true;
            // 
            // cb_EnableRateOverride
            // 
            this.cb_EnableRateOverride.AutoSize = true;
            this.cb_EnableRateOverride.Location = new System.Drawing.Point(20, 444);
            this.cb_EnableRateOverride.Name = "cb_EnableRateOverride";
            this.cb_EnableRateOverride.Size = new System.Drawing.Size(136, 17);
            this.cb_EnableRateOverride.TabIndex = 1;
            this.cb_EnableRateOverride.Text = "Enable Rate Overriding";
            this.cb_EnableRateOverride.UseVisualStyleBackColor = true;
            // 
            // dgv_calendar
            // 
            this.dgv_calendar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_column,
            this.roomType_column,
            this.dateToday_column,
            this.dateTom_column,
            this.nextTom_column});
            this.dgv_calendar.Location = new System.Drawing.Point(6, 4);
            this.dgv_calendar.Name = "dgv_calendar";
            this.dgv_calendar.Size = new System.Drawing.Size(542, 346);
            this.dgv_calendar.TabIndex = 0;
            // 
            // book_column
            // 
            this.book_column.HeaderText = "Book";
            this.book_column.Name = "book_column";
            this.book_column.ReadOnly = true;
            // 
            // roomType_column
            // 
            this.roomType_column.HeaderText = "Room Type";
            this.roomType_column.Name = "roomType_column";
            this.roomType_column.ReadOnly = true;
            // 
            // dateToday_column
            // 
            this.dateToday_column.HeaderText = "<Date Today>";
            this.dateToday_column.Name = "dateToday_column";
            this.dateToday_column.ReadOnly = true;
            // 
            // dateTom_column
            // 
            this.dateTom_column.HeaderText = "<Date Tom>";
            this.dateTom_column.Name = "dateTom_column";
            this.dateTom_column.ReadOnly = true;
            // 
            // nextTom_column
            // 
            this.nextTom_column.HeaderText = "<Date Next Tom>";
            this.nextTom_column.Name = "nextTom_column";
            this.nextTom_column.ReadOnly = true;
            // 
            // GuestInfoPage
            // 
            this.GuestInfoPage.Controls.Add(this.tb_State_Province);
            this.GuestInfoPage.Controls.Add(this.btn_Clear);
            this.GuestInfoPage.Controls.Add(this.tb_Amount);
            this.GuestInfoPage.Controls.Add(this.cb_PostDepo);
            this.GuestInfoPage.Controls.Add(this.lbl_PostDepo);
            this.GuestInfoPage.Controls.Add(this.gb_PaymentMethod);
            this.GuestInfoPage.Controls.Add(this.gb_Vehicle);
            this.GuestInfoPage.Controls.Add(this.tb_GuestNote);
            this.GuestInfoPage.Controls.Add(this.lbl_GuestNote);
            this.GuestInfoPage.Controls.Add(this.tb_Email);
            this.GuestInfoPage.Controls.Add(this.lbl_Email);
            this.GuestInfoPage.Controls.Add(this.tb_TelephoneNum);
            this.GuestInfoPage.Controls.Add(this.tb_MobileNum);
            this.GuestInfoPage.Controls.Add(this.lbl_MobileNum);
            this.GuestInfoPage.Controls.Add(this.lbl_TelephoneNum);
            this.GuestInfoPage.Controls.Add(this.lbl_Province_State);
            this.GuestInfoPage.Controls.Add(this.tb_City);
            this.GuestInfoPage.Controls.Add(this.lbl_City);
            this.GuestInfoPage.Controls.Add(this.cb_Nationality);
            this.GuestInfoPage.Controls.Add(this.lbl_Nationality);
            this.GuestInfoPage.Controls.Add(this.cb_Country);
            this.GuestInfoPage.Controls.Add(this.lbl_Country);
            this.GuestInfoPage.Controls.Add(this.tb_ZipCode);
            this.GuestInfoPage.Controls.Add(this.lbl_ZipCode);
            this.GuestInfoPage.Controls.Add(this.tb_Address);
            this.GuestInfoPage.Controls.Add(this.tb_LastName);
            this.GuestInfoPage.Controls.Add(this.tb_FirstName);
            this.GuestInfoPage.Controls.Add(this.lbl_Address);
            this.GuestInfoPage.Controls.Add(this.lbl_LastName);
            this.GuestInfoPage.Controls.Add(this.lbl_FirstName);
            this.GuestInfoPage.Location = new System.Drawing.Point(4, 22);
            this.GuestInfoPage.Name = "GuestInfoPage";
            this.GuestInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.GuestInfoPage.Size = new System.Drawing.Size(919, 464);
            this.GuestInfoPage.TabIndex = 1;
            this.GuestInfoPage.Text = "Guest Info";
            this.GuestInfoPage.UseVisualStyleBackColor = true;
            this.GuestInfoPage.Click += new System.EventHandler(this.GuestInfoPage_Click);
            // 
            // tb_State_Province
            // 
            this.tb_State_Province.Location = new System.Drawing.Point(327, 154);
            this.tb_State_Province.Name = "tb_State_Province";
            this.tb_State_Province.Size = new System.Drawing.Size(121, 20);
            this.tb_State_Province.TabIndex = 53;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.AutoSize = true;
            this.btn_Clear.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Clear.Location = new System.Drawing.Point(787, 5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(60, 35);
            this.btn_Clear.TabIndex = 51;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_Amount
            // 
            this.tb_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Amount.Enabled = false;
            this.tb_Amount.Location = new System.Drawing.Point(669, 201);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(111, 20);
            this.tb_Amount.TabIndex = 50;
            // 
            // cb_PostDepo
            // 
            this.cb_PostDepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_PostDepo.AutoSize = true;
            this.cb_PostDepo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PostDepo.Location = new System.Drawing.Point(580, 200);
            this.cb_PostDepo.Name = "cb_PostDepo";
            this.cb_PostDepo.Size = new System.Drawing.Size(98, 22);
            this.cb_PostDepo.TabIndex = 49;
            this.cb_PostDepo.Text = "Amount: ";
            this.cb_PostDepo.UseVisualStyleBackColor = true;
            this.cb_PostDepo.CheckedChanged += new System.EventHandler(this.cb_PostDepo_CheckedChanged);
            // 
            // lbl_PostDepo
            // 
            this.lbl_PostDepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PostDepo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PostDepo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_PostDepo.Location = new System.Drawing.Point(538, 201);
            this.lbl_PostDepo.Name = "lbl_PostDepo";
            this.lbl_PostDepo.Size = new System.Drawing.Size(57, 18);
            this.lbl_PostDepo.TabIndex = 48;
            this.lbl_PostDepo.Text = "Post Deposit:";
            // 
            // gb_PaymentMethod
            // 
            this.gb_PaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_PaymentMethod.Controls.Add(this.btn_CreditCards);
            this.gb_PaymentMethod.Controls.Add(this.tb_CardHolder);
            this.gb_PaymentMethod.Controls.Add(this.lbl_CardHolder);
            this.gb_PaymentMethod.Controls.Add(this.lbl_MMDD);
            this.gb_PaymentMethod.Controls.Add(this.tb_ExpiryDate);
            this.gb_PaymentMethod.Controls.Add(this.lbl_ExpiryDate);
            this.gb_PaymentMethod.Controls.Add(this.tb_CardNumber);
            this.gb_PaymentMethod.Controls.Add(this.label4);
            this.gb_PaymentMethod.Controls.Add(this.cb_CardType);
            this.gb_PaymentMethod.Controls.Add(this.lbl_CardType);
            this.gb_PaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_PaymentMethod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gb_PaymentMethod.Location = new System.Drawing.Point(523, 237);
            this.gb_PaymentMethod.Name = "gb_PaymentMethod";
            this.gb_PaymentMethod.Size = new System.Drawing.Size(338, 163);
            this.gb_PaymentMethod.TabIndex = 44;
            this.gb_PaymentMethod.TabStop = false;
            this.gb_PaymentMethod.Text = "Payment Method";
            // 
            // btn_CreditCards
            // 
            this.btn_CreditCards.AutoSize = true;
            this.btn_CreditCards.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_CreditCards.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_CreditCards.Location = new System.Drawing.Point(226, 118);
            this.btn_CreditCards.Name = "btn_CreditCards";
            this.btn_CreditCards.Size = new System.Drawing.Size(98, 26);
            this.btn_CreditCards.TabIndex = 33;
            this.btn_CreditCards.Text = "Credit Cards";
            this.btn_CreditCards.UseVisualStyleBackColor = true;
            // 
            // tb_CardHolder
            // 
            this.tb_CardHolder.Location = new System.Drawing.Point(99, 118);
            this.tb_CardHolder.Name = "tb_CardHolder";
            this.tb_CardHolder.Size = new System.Drawing.Size(111, 25);
            this.tb_CardHolder.TabIndex = 47;
            // 
            // lbl_CardHolder
            // 
            this.lbl_CardHolder.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_CardHolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CardHolder.Location = new System.Drawing.Point(15, 121);
            this.lbl_CardHolder.Name = "lbl_CardHolder";
            this.lbl_CardHolder.Size = new System.Drawing.Size(89, 21);
            this.lbl_CardHolder.TabIndex = 46;
            this.lbl_CardHolder.Text = "Card Holder";
            // 
            // lbl_MMDD
            // 
            this.lbl_MMDD.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_MMDD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_MMDD.Location = new System.Drawing.Point(148, 86);
            this.lbl_MMDD.Name = "lbl_MMDD";
            this.lbl_MMDD.Size = new System.Drawing.Size(72, 17);
            this.lbl_MMDD.TabIndex = 45;
            this.lbl_MMDD.Text = "(MM/DD)";
            // 
            // tb_ExpiryDate
            // 
            this.tb_ExpiryDate.Location = new System.Drawing.Point(99, 83);
            this.tb_ExpiryDate.Name = "tb_ExpiryDate";
            this.tb_ExpiryDate.Size = new System.Drawing.Size(45, 25);
            this.tb_ExpiryDate.TabIndex = 44;
            // 
            // lbl_ExpiryDate
            // 
            this.lbl_ExpiryDate.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_ExpiryDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ExpiryDate.Location = new System.Drawing.Point(15, 86);
            this.lbl_ExpiryDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            this.lbl_ExpiryDate.Size = new System.Drawing.Size(87, 25);
            this.lbl_ExpiryDate.TabIndex = 43;
            this.lbl_ExpiryDate.Text = "Expiry Date";
            // 
            // tb_CardNumber
            // 
            this.tb_CardNumber.Location = new System.Drawing.Point(99, 54);
            this.tb_CardNumber.Name = "tb_CardNumber";
            this.tb_CardNumber.Size = new System.Drawing.Size(121, 25);
            this.tb_CardNumber.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(37, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Number";
            // 
            // cb_CardType
            // 
            this.cb_CardType.FormattingEnabled = true;
            this.cb_CardType.Location = new System.Drawing.Point(99, 26);
            this.cb_CardType.Name = "cb_CardType";
            this.cb_CardType.Size = new System.Drawing.Size(121, 25);
            this.cb_CardType.TabIndex = 40;
            // 
            // lbl_CardType
            // 
            this.lbl_CardType.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_CardType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CardType.Location = new System.Drawing.Point(19, 26);
            this.lbl_CardType.Name = "lbl_CardType";
            this.lbl_CardType.Size = new System.Drawing.Size(83, 21);
            this.lbl_CardType.TabIndex = 39;
            this.lbl_CardType.Text = "Card Type";
            // 
            // gb_Vehicle
            // 
            this.gb_Vehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Vehicle.Controls.Add(this.tb_Color);
            this.gb_Vehicle.Controls.Add(this.tb_Brand);
            this.gb_Vehicle.Controls.Add(this.tb_Model);
            this.gb_Vehicle.Controls.Add(this.lbl_Brand);
            this.gb_Vehicle.Controls.Add(this.lbl_Color);
            this.gb_Vehicle.Controls.Add(this.lbl_Model);
            this.gb_Vehicle.Controls.Add(this.lbl_License);
            this.gb_Vehicle.Controls.Add(this.tb_License);
            this.gb_Vehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_Vehicle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gb_Vehicle.Location = new System.Drawing.Point(42, 314);
            this.gb_Vehicle.Name = "gb_Vehicle";
            this.gb_Vehicle.Size = new System.Drawing.Size(409, 85);
            this.gb_Vehicle.TabIndex = 43;
            this.gb_Vehicle.TabStop = false;
            this.gb_Vehicle.Text = "Vehicle";
            // 
            // tb_Color
            // 
            this.tb_Color.Location = new System.Drawing.Point(72, 49);
            this.tb_Color.Name = "tb_Color";
            this.tb_Color.Size = new System.Drawing.Size(121, 25);
            this.tb_Color.TabIndex = 40;
            // 
            // tb_Brand
            // 
            this.tb_Brand.Location = new System.Drawing.Point(72, 18);
            this.tb_Brand.Name = "tb_Brand";
            this.tb_Brand.Size = new System.Drawing.Size(121, 25);
            this.tb_Brand.TabIndex = 39;
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(271, 18);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.Size = new System.Drawing.Size(121, 25);
            this.tb_Model.TabIndex = 38;
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Brand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Brand.Location = new System.Drawing.Point(21, 23);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(49, 17);
            this.lbl_Brand.TabIndex = 31;
            this.lbl_Brand.Text = "Brand";
            // 
            // lbl_Color
            // 
            this.lbl_Color.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Color.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Color.Location = new System.Drawing.Point(21, 50);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(49, 19);
            this.lbl_Color.TabIndex = 32;
            this.lbl_Color.Text = "Color";
            // 
            // lbl_Model
            // 
            this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Model.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Model.Location = new System.Drawing.Point(217, 24);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(48, 19);
            this.lbl_Model.TabIndex = 33;
            this.lbl_Model.Text = "Model";
            // 
            // lbl_License
            // 
            this.lbl_License.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_License.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_License.Location = new System.Drawing.Point(208, 50);
            this.lbl_License.Name = "lbl_License";
            this.lbl_License.Size = new System.Drawing.Size(57, 18);
            this.lbl_License.TabIndex = 34;
            this.lbl_License.Text = "License";
            // 
            // tb_License
            // 
            this.tb_License.Location = new System.Drawing.Point(271, 49);
            this.tb_License.Name = "tb_License";
            this.tb_License.Size = new System.Drawing.Size(121, 25);
            this.tb_License.TabIndex = 37;
            // 
            // tb_GuestNote
            // 
            this.tb_GuestNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_GuestNote.Location = new System.Drawing.Point(114, 223);
            this.tb_GuestNote.Multiline = true;
            this.tb_GuestNote.Name = "tb_GuestNote";
            this.tb_GuestNote.Size = new System.Drawing.Size(337, 63);
            this.tb_GuestNote.TabIndex = 29;
            // 
            // lbl_GuestNote
            // 
            this.lbl_GuestNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_GuestNote.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_GuestNote.Location = new System.Drawing.Point(30, 229);
            this.lbl_GuestNote.Name = "lbl_GuestNote";
            this.lbl_GuestNote.Size = new System.Drawing.Size(91, 21);
            this.lbl_GuestNote.TabIndex = 28;
            this.lbl_GuestNote.Text = "Guest Note";
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Email.Location = new System.Drawing.Point(563, 68);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(171, 20);
            this.tb_Email.TabIndex = 25;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Email.Location = new System.Drawing.Point(521, 72);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(40, 16);
            this.lbl_Email.TabIndex = 24;
            this.lbl_Email.Text = "Email";
            // 
            // tb_TelephoneNum
            // 
            this.tb_TelephoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TelephoneNum.Location = new System.Drawing.Point(563, 44);
            this.tb_TelephoneNum.Name = "tb_TelephoneNum";
            this.tb_TelephoneNum.Size = new System.Drawing.Size(171, 20);
            this.tb_TelephoneNum.TabIndex = 23;
            // 
            // tb_MobileNum
            // 
            this.tb_MobileNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MobileNum.Location = new System.Drawing.Point(563, 19);
            this.tb_MobileNum.Name = "tb_MobileNum";
            this.tb_MobileNum.Size = new System.Drawing.Size(171, 20);
            this.tb_MobileNum.TabIndex = 22;
            // 
            // lbl_MobileNum
            // 
            this.lbl_MobileNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MobileNum.AutoSize = true;
            this.lbl_MobileNum.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_MobileNum.Location = new System.Drawing.Point(508, 21);
            this.lbl_MobileNum.Name = "lbl_MobileNum";
            this.lbl_MobileNum.Size = new System.Drawing.Size(54, 16);
            this.lbl_MobileNum.TabIndex = 21;
            this.lbl_MobileNum.Text = "Mobile";
            // 
            // lbl_TelephoneNum
            // 
            this.lbl_TelephoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TelephoneNum.AutoSize = true;
            this.lbl_TelephoneNum.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_TelephoneNum.Location = new System.Drawing.Point(488, 44);
            this.lbl_TelephoneNum.Name = "lbl_TelephoneNum";
            this.lbl_TelephoneNum.Size = new System.Drawing.Size(74, 16);
            this.lbl_TelephoneNum.TabIndex = 20;
            this.lbl_TelephoneNum.Text = "Telephone";
            // 
            // lbl_Province_State
            // 
            this.lbl_Province_State.AutoSize = true;
            this.lbl_Province_State.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Province_State.Location = new System.Drawing.Point(222, 157);
            this.lbl_Province_State.Name = "lbl_Province_State";
            this.lbl_Province_State.Size = new System.Drawing.Size(106, 16);
            this.lbl_Province_State.TabIndex = 16;
            this.lbl_Province_State.Text = "State/Province";
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(327, 129);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(121, 20);
            this.tb_City.TabIndex = 15;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_City.Location = new System.Drawing.Point(293, 131);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(33, 16);
            this.lbl_City.TabIndex = 14;
            this.lbl_City.Text = "City";
            // 
            // cb_Nationality
            // 
            this.cb_Nationality.FormattingEnabled = true;
            this.cb_Nationality.Items.AddRange(new object[] {
            "eut1",
            "eut2",
            "eut3",
            "eut4",
            "eut5"});
            this.cb_Nationality.Location = new System.Drawing.Point(93, 179);
            this.cb_Nationality.Name = "cb_Nationality";
            this.cb_Nationality.Size = new System.Drawing.Size(121, 21);
            this.cb_Nationality.TabIndex = 13;
            // 
            // lbl_Nationality
            // 
            this.lbl_Nationality.AutoSize = true;
            this.lbl_Nationality.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Nationality.Location = new System.Drawing.Point(18, 181);
            this.lbl_Nationality.Name = "lbl_Nationality";
            this.lbl_Nationality.Size = new System.Drawing.Size(77, 16);
            this.lbl_Nationality.TabIndex = 12;
            this.lbl_Nationality.Text = "Nationality";
            // 
            // cb_Country
            // 
            this.cb_Country.FormattingEnabled = true;
            this.cb_Country.Items.AddRange(new object[] {
            "eut1",
            "eut2",
            "eut3",
            "eut4",
            "eut5"});
            this.cb_Country.Location = new System.Drawing.Point(93, 154);
            this.cb_Country.Name = "cb_Country";
            this.cb_Country.Size = new System.Drawing.Size(121, 21);
            this.cb_Country.TabIndex = 11;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Country.Location = new System.Drawing.Point(35, 156);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(59, 16);
            this.lbl_Country.TabIndex = 10;
            this.lbl_Country.Text = "Country";
            // 
            // tb_ZipCode
            // 
            this.tb_ZipCode.Location = new System.Drawing.Point(93, 129);
            this.tb_ZipCode.Name = "tb_ZipCode";
            this.tb_ZipCode.Size = new System.Drawing.Size(121, 20);
            this.tb_ZipCode.TabIndex = 9;
            // 
            // lbl_ZipCode
            // 
            this.lbl_ZipCode.AutoSize = true;
            this.lbl_ZipCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_ZipCode.Location = new System.Drawing.Point(61, 131);
            this.lbl_ZipCode.Name = "lbl_ZipCode";
            this.lbl_ZipCode.Size = new System.Drawing.Size(29, 16);
            this.lbl_ZipCode.TabIndex = 8;
            this.lbl_ZipCode.Text = "Zip";
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(93, 68);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(355, 57);
            this.tb_Address.TabIndex = 7;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(93, 42);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(355, 20);
            this.tb_LastName.TabIndex = 6;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(93, 19);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(355, 20);
            this.tb_FirstName.TabIndex = 5;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lbl_Address.Location = new System.Drawing.Point(37, 68);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(59, 16);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_LastName.Location = new System.Drawing.Point(9, 44);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(84, 16);
            this.lbl_LastName.TabIndex = 3;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_FirstName.Location = new System.Drawing.Point(6, 21);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(86, 16);
            this.lbl_FirstName.TabIndex = 2;
            this.lbl_FirstName.Text = "First Name";
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.LightGray;
            this.Services.Controls.Add(this.dataGridView2);
            this.Services.Controls.Add(this.lbl_ServiceTotalCost);
            this.Services.Controls.Add(this.lbl_SericeTaxesCost);
            this.Services.Controls.Add(this.lbl_ServiceChargeCost);
            this.Services.Controls.Add(this.lbl_ServiceTotal);
            this.Services.Controls.Add(this.lbl_ServiceTaxes);
            this.Services.Controls.Add(this.lbl_ServiceCharges);
            this.Services.Controls.Add(this.dataGridView1);
            this.Services.Controls.Add(this.cb_Grouping);
            this.Services.Controls.Add(this.lbl_Grouping);
            this.Services.Controls.Add(this.cb_Style);
            this.Services.Controls.Add(this.lbl_Style);
            this.Services.Location = new System.Drawing.Point(4, 22);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(3);
            this.Services.Size = new System.Drawing.Size(919, 464);
            this.Services.TabIndex = 2;
            this.Services.Text = "Services";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(697, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(213, 418);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Service Names";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // lbl_ServiceTotalCost
            // 
            this.lbl_ServiceTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ServiceTotalCost.AutoSize = true;
            this.lbl_ServiceTotalCost.Location = new System.Drawing.Point(625, 412);
            this.lbl_ServiceTotalCost.Name = "lbl_ServiceTotalCost";
            this.lbl_ServiceTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ServiceTotalCost.Size = new System.Drawing.Size(38, 13);
            this.lbl_ServiceTotalCost.TabIndex = 13;
            this.lbl_ServiceTotalCost.Text = "₱ 0.00";
            this.lbl_ServiceTotalCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_SericeTaxesCost
            // 
            this.lbl_SericeTaxesCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SericeTaxesCost.AutoSize = true;
            this.lbl_SericeTaxesCost.Location = new System.Drawing.Point(625, 390);
            this.lbl_SericeTaxesCost.Name = "lbl_SericeTaxesCost";
            this.lbl_SericeTaxesCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_SericeTaxesCost.Size = new System.Drawing.Size(38, 13);
            this.lbl_SericeTaxesCost.TabIndex = 12;
            this.lbl_SericeTaxesCost.Text = "₱ 0.00";
            this.lbl_SericeTaxesCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ServiceChargeCost
            // 
            this.lbl_ServiceChargeCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ServiceChargeCost.AutoSize = true;
            this.lbl_ServiceChargeCost.Location = new System.Drawing.Point(625, 368);
            this.lbl_ServiceChargeCost.Name = "lbl_ServiceChargeCost";
            this.lbl_ServiceChargeCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ServiceChargeCost.Size = new System.Drawing.Size(38, 13);
            this.lbl_ServiceChargeCost.TabIndex = 11;
            this.lbl_ServiceChargeCost.Text = "₱ 0.00";
            this.lbl_ServiceChargeCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ServiceTotal
            // 
            this.lbl_ServiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ServiceTotal.AutoSize = true;
            this.lbl_ServiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServiceTotal.Location = new System.Drawing.Point(560, 412);
            this.lbl_ServiceTotal.Name = "lbl_ServiceTotal";
            this.lbl_ServiceTotal.Size = new System.Drawing.Size(40, 13);
            this.lbl_ServiceTotal.TabIndex = 10;
            this.lbl_ServiceTotal.Text = "Total:";
            // 
            // lbl_ServiceTaxes
            // 
            this.lbl_ServiceTaxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ServiceTaxes.AutoSize = true;
            this.lbl_ServiceTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServiceTaxes.Location = new System.Drawing.Point(555, 390);
            this.lbl_ServiceTaxes.Name = "lbl_ServiceTaxes";
            this.lbl_ServiceTaxes.Size = new System.Drawing.Size(45, 13);
            this.lbl_ServiceTaxes.TabIndex = 9;
            this.lbl_ServiceTaxes.Text = "Taxes:";
            // 
            // lbl_ServiceCharges
            // 
            this.lbl_ServiceCharges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ServiceCharges.AutoSize = true;
            this.lbl_ServiceCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServiceCharges.Location = new System.Drawing.Point(496, 368);
            this.lbl_ServiceCharges.Name = "lbl_ServiceCharges";
            this.lbl_ServiceCharges.Size = new System.Drawing.Size(104, 13);
            this.lbl_ServiceCharges.TabIndex = 8;
            this.lbl_ServiceCharges.Text = "Service Charges:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_ServiceNames,
            this.clm_Price,
            this.clm_Voucher});
            this.dataGridView1.Location = new System.Drawing.Point(4, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 315);
            this.dataGridView1.TabIndex = 5;
            // 
            // clm_ServiceNames
            // 
            this.clm_ServiceNames.HeaderText = "Service Names";
            this.clm_ServiceNames.Name = "clm_ServiceNames";
            this.clm_ServiceNames.ReadOnly = true;
            this.clm_ServiceNames.Width = 275;
            // 
            // clm_Price
            // 
            this.clm_Price.HeaderText = "Price";
            this.clm_Price.Name = "clm_Price";
            this.clm_Price.ReadOnly = true;
            // 
            // clm_Voucher
            // 
            this.clm_Voucher.HeaderText = "Voucher";
            this.clm_Voucher.Name = "clm_Voucher";
            this.clm_Voucher.ReadOnly = true;
            this.clm_Voucher.Width = 225;
            // 
            // cb_Grouping
            // 
            this.cb_Grouping.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_Grouping.FormattingEnabled = true;
            this.cb_Grouping.Location = new System.Drawing.Point(782, 13);
            this.cb_Grouping.Name = "cb_Grouping";
            this.cb_Grouping.Size = new System.Drawing.Size(123, 21);
            this.cb_Grouping.TabIndex = 4;
            // 
            // lbl_Grouping
            // 
            this.lbl_Grouping.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Grouping.AutoSize = true;
            this.lbl_Grouping.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Grouping.Location = new System.Drawing.Point(726, 16);
            this.lbl_Grouping.Name = "lbl_Grouping";
            this.lbl_Grouping.Size = new System.Drawing.Size(50, 13);
            this.lbl_Grouping.TabIndex = 3;
            this.lbl_Grouping.Text = "Grouping";
            // 
            // cb_Style
            // 
            this.cb_Style.FormattingEnabled = true;
            this.cb_Style.Location = new System.Drawing.Point(49, 13);
            this.cb_Style.Name = "cb_Style";
            this.cb_Style.Size = new System.Drawing.Size(121, 21);
            this.cb_Style.TabIndex = 1;
            // 
            // lbl_Style
            // 
            this.lbl_Style.AutoSize = true;
            this.lbl_Style.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Style.Location = new System.Drawing.Point(13, 16);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(30, 13);
            this.lbl_Style.TabIndex = 0;
            this.lbl_Style.Text = "Style";
            // 
            // lbl_FetchResID
            // 
            this.lbl_FetchResID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FetchResID.AutoSize = true;
            this.lbl_FetchResID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FetchResID.Location = new System.Drawing.Point(59, 664);
            this.lbl_FetchResID.Name = "lbl_FetchResID";
            this.lbl_FetchResID.Size = new System.Drawing.Size(55, 13);
            this.lbl_FetchResID.TabIndex = 7;
            this.lbl_FetchResID.Text = "<res_id>";
            // 
            // lbl_ResID
            // 
            this.lbl_ResID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ResID.AutoSize = true;
            this.lbl_ResID.Location = new System.Drawing.Point(17, 664);
            this.lbl_ResID.Name = "lbl_ResID";
            this.lbl_ResID.Size = new System.Drawing.Size(40, 13);
            this.lbl_ResID.TabIndex = 6;
            this.lbl_ResID.Text = "ResID:";
            // 
            // TopPanel
            // 
            this.TopPanel.AutoSize = true;
            this.TopPanel.Controls.Add(this.dtp_coTime);
            this.TopPanel.Controls.Add(this.dtp_Departure);
            this.TopPanel.Controls.Add(this.dtp_Arrival);
            this.TopPanel.Controls.Add(this.tb_Total);
            this.TopPanel.Controls.Add(this.tb_Other);
            this.TopPanel.Controls.Add(this.tb_Taxes);
            this.TopPanel.Controls.Add(this.tb_Rate);
            this.TopPanel.Controls.Add(this.lbl_Total);
            this.TopPanel.Controls.Add(this.lbl_Other);
            this.TopPanel.Controls.Add(this.lbl_Taxes);
            this.TopPanel.Controls.Add(this.lbl_Rate);
            this.TopPanel.Controls.Add(this.lbl_coTime);
            this.TopPanel.Controls.Add(this.nud_Nights);
            this.TopPanel.Controls.Add(this.lbl_Nights);
            this.TopPanel.Controls.Add(this.nud_Child);
            this.TopPanel.Controls.Add(this.lbl_Child);
            this.TopPanel.Controls.Add(this.nud_Adult);
            this.TopPanel.Controls.Add(this.cb_RoomCharge);
            this.TopPanel.Controls.Add(this.cb_ClientType);
            this.TopPanel.Controls.Add(this.cb_WaitList);
            this.TopPanel.Controls.Add(this.cb_Guarantee);
            this.TopPanel.Controls.Add(this.btn_Refresh);
            this.TopPanel.Controls.Add(this.lbl_Adults);
            this.TopPanel.Controls.Add(this.lbl_Departure);
            this.TopPanel.Controls.Add(this.lbl_Arrival);
            this.TopPanel.Controls.Add(this.lbl_RoomCharge);
            this.TopPanel.Controls.Add(this.lbl_ClientType);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1164, 166);
            this.TopPanel.TabIndex = 1;
            // 
            // dtp_coTime
            // 
            this.dtp_coTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_coTime.CustomFormat = "";
            this.dtp_coTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_coTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_coTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_coTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtp_coTime.Location = new System.Drawing.Point(304, 104);
            this.dtp_coTime.MinDate = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            this.dtp_coTime.Name = "dtp_coTime";
            this.dtp_coTime.ShowUpDown = true;
            this.dtp_coTime.Size = new System.Drawing.Size(98, 21);
            this.dtp_coTime.TabIndex = 33;
            this.dtp_coTime.Value = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            // 
            // dtp_Departure
            // 
            this.dtp_Departure.CustomFormat = "";
            this.dtp_Departure.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Departure.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtp_Departure.Location = new System.Drawing.Point(136, 106);
            this.dtp_Departure.MinDate = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            this.dtp_Departure.Name = "dtp_Departure";
            this.dtp_Departure.Size = new System.Drawing.Size(91, 20);
            this.dtp_Departure.TabIndex = 32;
            this.dtp_Departure.Value = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            this.dtp_Departure.ValueChanged += new System.EventHandler(this.dtp_Departure_ValueChanged);
            // 
            // dtp_Arrival
            // 
            this.dtp_Arrival.CustomFormat = "MM-DD-YYYY";
            this.dtp_Arrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Arrival.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtp_Arrival.Location = new System.Drawing.Point(136, 73);
            this.dtp_Arrival.MinDate = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            this.dtp_Arrival.Name = "dtp_Arrival";
            this.dtp_Arrival.Size = new System.Drawing.Size(91, 20);
            this.dtp_Arrival.TabIndex = 15;
            this.dtp_Arrival.Value = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Total.Location = new System.Drawing.Point(667, 100);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.ReadOnly = true;
            this.tb_Total.Size = new System.Drawing.Size(126, 20);
            this.tb_Total.TabIndex = 31;
            this.tb_Total.Text = "₱0.00";
            this.tb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Other
            // 
            this.tb_Other.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Other.Location = new System.Drawing.Point(667, 74);
            this.tb_Other.Name = "tb_Other";
            this.tb_Other.ReadOnly = true;
            this.tb_Other.Size = new System.Drawing.Size(126, 20);
            this.tb_Other.TabIndex = 30;
            this.tb_Other.Text = "₱0.00";
            this.tb_Other.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Taxes
            // 
            this.tb_Taxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Taxes.Location = new System.Drawing.Point(667, 48);
            this.tb_Taxes.Name = "tb_Taxes";
            this.tb_Taxes.ReadOnly = true;
            this.tb_Taxes.Size = new System.Drawing.Size(126, 20);
            this.tb_Taxes.TabIndex = 29;
            this.tb_Taxes.Text = "₱0.00";
            this.tb_Taxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Rate
            // 
            this.tb_Rate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Rate.Location = new System.Drawing.Point(667, 23);
            this.tb_Rate.Name = "tb_Rate";
            this.tb_Rate.ReadOnly = true;
            this.tb_Rate.Size = new System.Drawing.Size(126, 20);
            this.tb_Rate.TabIndex = 28;
            this.tb_Rate.Text = "₱0.00";
            this.tb_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Total.Location = new System.Drawing.Point(621, 101);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(43, 16);
            this.lbl_Total.TabIndex = 27;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Other
            // 
            this.lbl_Other.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Other.AutoSize = true;
            this.lbl_Other.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Other.Location = new System.Drawing.Point(617, 75);
            this.lbl_Other.Name = "lbl_Other";
            this.lbl_Other.Size = new System.Drawing.Size(48, 16);
            this.lbl_Other.TabIndex = 26;
            this.lbl_Other.Text = "Other";
            // 
            // lbl_Taxes
            // 
            this.lbl_Taxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Taxes.AutoSize = true;
            this.lbl_Taxes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Taxes.Location = new System.Drawing.Point(615, 48);
            this.lbl_Taxes.Name = "lbl_Taxes";
            this.lbl_Taxes.Size = new System.Drawing.Size(50, 16);
            this.lbl_Taxes.TabIndex = 25;
            this.lbl_Taxes.Text = "Taxes";
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Rate.AutoSize = true;
            this.lbl_Rate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Rate.Location = new System.Drawing.Point(624, 24);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(40, 16);
            this.lbl_Rate.TabIndex = 24;
            this.lbl_Rate.Text = "Rate";
            // 
            // lbl_coTime
            // 
            this.lbl_coTime.AutoSize = true;
            this.lbl_coTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_coTime.Location = new System.Drawing.Point(226, 108);
            this.lbl_coTime.Name = "lbl_coTime";
            this.lbl_coTime.Size = new System.Drawing.Size(72, 16);
            this.lbl_coTime.TabIndex = 22;
            this.lbl_coTime.Text = "C/OTime";
            // 
            // nud_Nights
            // 
            this.nud_Nights.AllowDrop = true;
            this.nud_Nights.AutoSize = true;
            this.nud_Nights.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nud_Nights.Location = new System.Drawing.Point(300, 73);
            this.nud_Nights.Name = "nud_Nights";
            this.nud_Nights.ReadOnly = true;
            this.nud_Nights.Size = new System.Drawing.Size(41, 20);
            this.nud_Nights.TabIndex = 21;
            this.nud_Nights.ValueChanged += new System.EventHandler(this.nud_Nights_ValueChanged);
            // 
            // lbl_Nights
            // 
            this.lbl_Nights.AutoSize = true;
            this.lbl_Nights.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Nights.Location = new System.Drawing.Point(240, 74);
            this.lbl_Nights.Name = "lbl_Nights";
            this.lbl_Nights.Size = new System.Drawing.Size(53, 16);
            this.lbl_Nights.TabIndex = 20;
            this.lbl_Nights.Text = "Nights";
            // 
            // nud_Child
            // 
            this.nud_Child.AutoSize = true;
            this.nud_Child.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nud_Child.Location = new System.Drawing.Point(229, 139);
            this.nud_Child.Name = "nud_Child";
            this.nud_Child.Size = new System.Drawing.Size(41, 20);
            this.nud_Child.TabIndex = 19;
            // 
            // lbl_Child
            // 
            this.lbl_Child.AutoSize = true;
            this.lbl_Child.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Child.Location = new System.Drawing.Point(184, 141);
            this.lbl_Child.Name = "lbl_Child";
            this.lbl_Child.Size = new System.Drawing.Size(43, 16);
            this.lbl_Child.TabIndex = 18;
            this.lbl_Child.Text = "Child";
            // 
            // nud_Adult
            // 
            this.nud_Adult.AutoSize = true;
            this.nud_Adult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nud_Adult.Location = new System.Drawing.Point(136, 139);
            this.nud_Adult.Name = "nud_Adult";
            this.nud_Adult.Size = new System.Drawing.Size(41, 20);
            this.nud_Adult.TabIndex = 17;
            // 
            // cb_RoomCharge
            // 
            this.cb_RoomCharge.FormattingEnabled = true;
            this.cb_RoomCharge.Location = new System.Drawing.Point(136, 42);
            this.cb_RoomCharge.Name = "cb_RoomCharge";
            this.cb_RoomCharge.Size = new System.Drawing.Size(157, 21);
            this.cb_RoomCharge.TabIndex = 14;
            // 
            // cb_ClientType
            // 
            this.cb_ClientType.FormattingEnabled = true;
            this.cb_ClientType.Location = new System.Drawing.Point(136, 11);
            this.cb_ClientType.Name = "cb_ClientType";
            this.cb_ClientType.Size = new System.Drawing.Size(157, 21);
            this.cb_ClientType.TabIndex = 13;
            // 
            // cb_WaitList
            // 
            this.cb_WaitList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_WaitList.AutoSize = true;
            this.cb_WaitList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cb_WaitList.Location = new System.Drawing.Point(1059, 43);
            this.cb_WaitList.Name = "cb_WaitList";
            this.cb_WaitList.Size = new System.Drawing.Size(75, 21);
            this.cb_WaitList.TabIndex = 12;
            this.cb_WaitList.Text = "Wait List";
            this.cb_WaitList.UseVisualStyleBackColor = true;
            // 
            // cb_Guarantee
            // 
            this.cb_Guarantee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Guarantee.AutoSize = true;
            this.cb_Guarantee.Checked = true;
            this.cb_Guarantee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Guarantee.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cb_Guarantee.Location = new System.Drawing.Point(1059, 20);
            this.cb_Guarantee.Name = "cb_Guarantee";
            this.cb_Guarantee.Size = new System.Drawing.Size(87, 21);
            this.cb_Guarantee.TabIndex = 11;
            this.cb_Guarantee.Text = "Guarantee";
            this.cb_Guarantee.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_Refresh.Location = new System.Drawing.Point(978, 125);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(156, 38);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Adults
            // 
            this.lbl_Adults.AutoSize = true;
            this.lbl_Adults.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Adults.Location = new System.Drawing.Point(60, 140);
            this.lbl_Adults.Name = "lbl_Adults";
            this.lbl_Adults.Size = new System.Drawing.Size(53, 16);
            this.lbl_Adults.TabIndex = 5;
            this.lbl_Adults.Text = "Adults";
            // 
            // lbl_Departure
            // 
            this.lbl_Departure.AutoSize = true;
            this.lbl_Departure.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Departure.Location = new System.Drawing.Point(35, 107);
            this.lbl_Departure.Name = "lbl_Departure";
            this.lbl_Departure.Size = new System.Drawing.Size(80, 16);
            this.lbl_Departure.TabIndex = 4;
            this.lbl_Departure.Text = "Departure";
            // 
            // lbl_Arrival
            // 
            this.lbl_Arrival.AutoSize = true;
            this.lbl_Arrival.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Arrival.Location = new System.Drawing.Point(59, 75);
            this.lbl_Arrival.Name = "lbl_Arrival";
            this.lbl_Arrival.Size = new System.Drawing.Size(55, 16);
            this.lbl_Arrival.TabIndex = 3;
            this.lbl_Arrival.Text = "Arrival";
            // 
            // lbl_RoomCharge
            // 
            this.lbl_RoomCharge.AutoSize = true;
            this.lbl_RoomCharge.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RoomCharge.Location = new System.Drawing.Point(12, 43);
            this.lbl_RoomCharge.Name = "lbl_RoomCharge";
            this.lbl_RoomCharge.Size = new System.Drawing.Size(104, 16);
            this.lbl_RoomCharge.TabIndex = 2;
            this.lbl_RoomCharge.Text = "Room Charge";
            // 
            // lbl_ClientType
            // 
            this.lbl_ClientType.AutoSize = true;
            this.lbl_ClientType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_ClientType.Location = new System.Drawing.Point(33, 13);
            this.lbl_ClientType.Name = "lbl_ClientType";
            this.lbl_ClientType.Size = new System.Drawing.Size(84, 16);
            this.lbl_ClientType.TabIndex = 1;
            this.lbl_ClientType.Text = "ClientType";
            // 
            // RightSidePanel
            // 
            this.RightSidePanel.Controls.Add(this.cb_RoomNumber);
            this.RightSidePanel.Controls.Add(this.btn_submit);
            this.RightSidePanel.Controls.Add(this.btn_Cancel);
            this.RightSidePanel.Controls.Add(this.cb_LockOff);
            this.RightSidePanel.Controls.Add(this.cb_EnableAssignment);
            this.RightSidePanel.Controls.Add(this.lbl_RoomNumber);
            this.RightSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSidePanel.Location = new System.Drawing.Point(939, 166);
            this.RightSidePanel.Name = "RightSidePanel";
            this.RightSidePanel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.RightSidePanel.Size = new System.Drawing.Size(225, 515);
            this.RightSidePanel.TabIndex = 2;
            // 
            // cb_RoomNumber
            // 
            this.cb_RoomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_RoomNumber.FormattingEnabled = true;
            this.cb_RoomNumber.Location = new System.Drawing.Point(34, 35);
            this.cb_RoomNumber.Name = "cb_RoomNumber";
            this.cb_RoomNumber.Size = new System.Drawing.Size(161, 21);
            this.cb_RoomNumber.TabIndex = 8;
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_submit.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_submit.Location = new System.Drawing.Point(34, 415);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(161, 38);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "OK";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_Cancel.Location = new System.Drawing.Point(34, 459);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(161, 38);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // cb_LockOff
            // 
            this.cb_LockOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_LockOff.AutoSize = true;
            this.cb_LockOff.Enabled = false;
            this.cb_LockOff.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cb_LockOff.Location = new System.Drawing.Point(34, 95);
            this.cb_LockOff.Name = "cb_LockOff";
            this.cb_LockOff.Size = new System.Drawing.Size(75, 21);
            this.cb_LockOff.TabIndex = 10;
            this.cb_LockOff.Text = "Lock Off";
            this.cb_LockOff.UseVisualStyleBackColor = true;
            // 
            // cb_EnableAssignment
            // 
            this.cb_EnableAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_EnableAssignment.AutoSize = true;
            this.cb_EnableAssignment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cb_EnableAssignment.Location = new System.Drawing.Point(34, 64);
            this.cb_EnableAssignment.Name = "cb_EnableAssignment";
            this.cb_EnableAssignment.Size = new System.Drawing.Size(137, 21);
            this.cb_EnableAssignment.TabIndex = 9;
            this.cb_EnableAssignment.Text = "Enable Assignment";
            this.cb_EnableAssignment.UseVisualStyleBackColor = true;
            // 
            // lbl_RoomNumber
            // 
            this.lbl_RoomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RoomNumber.AutoSize = true;
            this.lbl_RoomNumber.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lbl_RoomNumber.Location = new System.Drawing.Point(31, 5);
            this.lbl_RoomNumber.Name = "lbl_RoomNumber";
            this.lbl_RoomNumber.Size = new System.Drawing.Size(124, 18);
            this.lbl_RoomNumber.TabIndex = 7;
            this.lbl_RoomNumber.Text = "Room Number:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "<res_id>";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Created By:";
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.RightSidePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.tb_Info);
            this.Controls.Add(this.lbl_FetchResID);
            this.Controls.Add(this.lbl_ResID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1180, 720);
            this.Name = "NewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Reservation";
            this.Load += new System.EventHandler(this.NewReservation_Load);
            this.tb_Info.ResumeLayout(false);
            this.tp_Calendar.ResumeLayout(false);
            this.tp_Calendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).EndInit();
            this.GuestInfoPage.ResumeLayout(false);
            this.GuestInfoPage.PerformLayout();
            this.gb_PaymentMethod.ResumeLayout(false);
            this.gb_PaymentMethod.PerformLayout();
            this.gb_Vehicle.ResumeLayout(false);
            this.gb_Vehicle.PerformLayout();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Nights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Child)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adult)).EndInit();
            this.RightSidePanel.ResumeLayout(false);
            this.RightSidePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TabControl tb_Info;
    private TabPage tp_Calendar;
    private TabPage GuestInfoPage;
    private Panel TopPanel;
    private TabPage Services;
    private Label lbl_Adults;
    private Label lbl_Departure;
    private Label lbl_Arrival;
    private Label lbl_RoomCharge;
    private Label lbl_ClientType;
    private Panel RightSidePanel;
    private Label lbl_RoomNumber;
    private Label lbl_Child;
    private NumericUpDown nud_Adult;
    private ComboBox cb_RoomCharge;
    private ComboBox cb_ClientType;
    private CheckBox cb_WaitList;
    private CheckBox cb_Guarantee;
    private CheckBox cb_LockOff;
    private CheckBox cb_EnableAssignment;
    private ComboBox cb_RoomNumber;
    private Label lbl_Nights;
    private NumericUpDown nud_Child;
    private Label lbl_coTime;
    private NumericUpDown nud_Nights;
    private TextBox tb_Total;
    private TextBox tb_Other;
    private TextBox tb_Taxes;
    private TextBox tb_Rate;
    private Label lbl_Total;
    private Label lbl_Other;
    private Label lbl_Taxes;
    private Label lbl_Rate;
    private ComboBox cb_Country;
    private Label lbl_Country;
    private TextBox tb_ZipCode;
    private Label lbl_ZipCode;
    private TextBox tb_Address;
    private TextBox tb_LastName;
    private TextBox tb_FirstName;
    private Label lbl_Address;
    private Label lbl_LastName;
    private Label lbl_FirstName;
    private ComboBox cb_Nationality;
    private Label lbl_Nationality;
    private TextBox tb_City;
    private Label lbl_City;
    private TextBox tb_Email;
    private Label lbl_Email;
    private TextBox tb_TelephoneNum;
    private TextBox tb_MobileNum;
    private Label lbl_MobileNum;
    private Label lbl_TelephoneNum;
    private Label lbl_GuestNote;
    private TextBox tb_GuestNote;
    private GroupBox gb_Vehicle;
    private Label lbl_Brand;
    private Label lbl_Color;
    private Label lbl_Model;
    private Label lbl_License;
    private TextBox tb_License;
    private GroupBox gb_PaymentMethod;
    private TextBox tb_ExpiryDate;
    private Label lbl_ExpiryDate;
    private TextBox tb_CardNumber;
    private Label label4;
    private ComboBox cb_CardType;
    private Label lbl_CardType;
    private Button btn_Clear;
    private TextBox tb_Amount;
    private CheckBox cb_PostDepo;
    private Label lbl_PostDepo;
    private Button btn_CreditCards;
    private TextBox tb_CardHolder;
    private Label lbl_CardHolder;
    private Label lbl_MMDD;
    private Button btn_submit;
    private Button btn_Cancel;
    private TextBox tb_State_Province;
    private TextBox tb_Color;
    private TextBox tb_Brand;
    private TextBox tb_Model;
    private Label lbl_Province_State;
    private Button btn_Refresh;
    private PictureButton pictureButton1;
    private ComboBox cb_Style;
    private Label lbl_Style;
    private DataGridView dataGridView1;
    private ComboBox cb_Grouping;
    private Label lbl_Grouping;
    private Label lbl_ResID;
    private Label lbl_ServiceTotalCost;
    private Label lbl_SericeTaxesCost;
    private Label lbl_ServiceChargeCost;
    private Label lbl_ServiceTotal;
    private Label lbl_ServiceTaxes;
    private Label lbl_ServiceCharges;
    private Label lbl_FetchResID;
    private DataGridViewTextBoxColumn clm_ServiceNames;
    private DataGridViewTextBoxColumn clm_Price;
    private DataGridViewTextBoxColumn clm_Voucher;
    private PictureButton btn_DeleteService;
    private PictureButton btn_AddService;
    private Label label1;
    private Label label2;
    private DataGridView dataGridView2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private PictureButton pictureButton2;
    private PictureButton pictureButton3;
    private PictureButton pictureButton4;
    private DateTimePicker dtp_Arrival;
    private DateTimePicker dtp_Departure;
        private DateTimePicker dtp_coTime;
        private CheckBox cb_enableRestrictOverride;
        private CheckBox cb_enableOverBook;
        private CheckBox cb_EnableRateOverride;
        private DataGridView dgv_calendar;
        private DataGridViewTextBoxColumn book_column;
        private DataGridViewTextBoxColumn roomType_column;
        private DataGridViewTextBoxColumn dateToday_column;
        private DataGridViewTextBoxColumn dateTom_column;
        private DataGridViewTextBoxColumn nextTom_column;
    }
}