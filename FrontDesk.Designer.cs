using System.Windows.Forms;

namespace NoteView
{
  partial class FrontDesk
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontDesk));
      this.Ms_NoteView = new System.Windows.Forms.MenuStrip();
      this.toolstrip_NoteView = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip_Transactions = new System.Windows.Forms.ToolStripMenuItem();
      this.postPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.postChargesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.guestFolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.unprocessedCreditCardTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.authorizedTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.folioAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cancelAllNoShowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.processLateFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip_Reservations = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip_Operations = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip_Sc = new System.Windows.Forms.ToolStripMenuItem();
      this.exportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip_Reports = new System.Windows.Forms.ToolStripMenuItem();
      this.advSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gb_frontDesk1 = new System.Windows.Forms.GroupBox();
      this.lbl_Arrival = new System.Windows.Forms.Label();
      this.lbl_Departures = new System.Windows.Forms.Label();
      this.lbl_Waitlist = new System.Windows.Forms.Label();
      this.lbl_cancelled = new System.Windows.Forms.Label();
      this.lbl_Reservations = new System.Windows.Forms.Label();
      this.lbl_checkedOut = new System.Windows.Forms.Label();
      this.lbl_noShows = new System.Windows.Forms.Label();
      this.lbl_space = new System.Windows.Forms.Label();
      this.lbl_inHouse = new System.Windows.Forms.Label();
      this.tab_guestInfo = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.gb_frontDesk2 = new System.Windows.Forms.GroupBox();
      this.txt_vehicleLicense = new System.Windows.Forms.TextBox();
      this.txt_travelAgency = new System.Windows.Forms.TextBox();
      this.lbl_vehicleLicense = new System.Windows.Forms.Label();
      this.lbl_travelAgency = new System.Windows.Forms.Label();
      this.txt_cardHolder = new System.Windows.Forms.TextBox();
      this.txt_cardNumber = new System.Windows.Forms.TextBox();
      this.txt_expiry = new System.Windows.Forms.TextBox();
      this.txt_cardType = new System.Windows.Forms.TextBox();
      this.txt_reservationNote = new System.Windows.Forms.TextBox();
      this.txt_guestNote = new System.Windows.Forms.TextBox();
      this.txt_email = new System.Windows.Forms.TextBox();
      this.txt_mobile = new System.Windows.Forms.TextBox();
      this.txt_telephone = new System.Windows.Forms.TextBox();
      this.txt_source = new System.Windows.Forms.TextBox();
      this.txt_rateCode = new System.Windows.Forms.TextBox();
      this.txt_ClientType = new System.Windows.Forms.TextBox();
      this.txt_postalCode = new System.Windows.Forms.TextBox();
      this.txt_country = new System.Windows.Forms.TextBox();
      this.txt_province = new System.Windows.Forms.TextBox();
      this.txt_City = new System.Windows.Forms.TextBox();
      this.txt_StreetAdress = new System.Windows.Forms.TextBox();
      this.txt_lastName = new System.Windows.Forms.TextBox();
      this.txt_firstName = new System.Windows.Forms.TextBox();
      this.txt_title = new System.Windows.Forms.TextBox();
      this.lbl_cardType = new System.Windows.Forms.Label();
      this.lbl_expiry = new System.Windows.Forms.Label();
      this.lbl_cardNumber = new System.Windows.Forms.Label();
      this.lbl_cardHolder = new System.Windows.Forms.Label();
      this.lbl_reserveationNote = new System.Windows.Forms.Label();
      this.lbl_guestnote = new System.Windows.Forms.Label();
      this.lbl_email = new System.Windows.Forms.Label();
      this.lbl_mobile = new System.Windows.Forms.Label();
      this.lbl_telephone = new System.Windows.Forms.Label();
      this.lbl_source = new System.Windows.Forms.Label();
      this.lbl_postalCode = new System.Windows.Forms.Label();
      this.lbl_rateCode = new System.Windows.Forms.Label();
      this.lbl_country = new System.Windows.Forms.Label();
      this.lbl_clientType = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_province = new System.Windows.Forms.Label();
      this.lbl_city = new System.Windows.Forms.Label();
      this.lbl_streetAddress = new System.Windows.Forms.Label();
      this.lbl_lastName = new System.Windows.Forms.Label();
      this.lbl_firstName = new System.Windows.Forms.Label();
      this.lbl_title = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.gb_Folio = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rb_folioStay = new System.Windows.Forms.RadioButton();
      this.rb_folioNow = new System.Windows.Forms.RadioButton();
      this.label58 = new System.Windows.Forms.Label();
      this.label57 = new System.Windows.Forms.Label();
      this.label56 = new System.Windows.Forms.Label();
      this.label55 = new System.Windows.Forms.Label();
      this.label54 = new System.Windows.Forms.Label();
      this.label53 = new System.Windows.Forms.Label();
      this.label52 = new System.Windows.Forms.Label();
      this.label38 = new System.Windows.Forms.Label();
      this.dgv_folio = new System.Windows.Forms.DataGridView();
      this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cb_folioCategry = new System.Windows.Forms.ComboBox();
      this.btn_folioMove = new System.Windows.Forms.Button();
      this.btn_folioRefresh = new System.Windows.Forms.Button();
      this.btn_folioSelect = new System.Windows.Forms.Button();
      this.panel_InHouse = new System.Windows.Forms.Panel();
      this.label59 = new System.Windows.Forms.Label();
      this.pb_ImHouse_GuestFolio = new System.Windows.Forms.PictureBox();
      this.dgv_InHouse = new System.Windows.Forms.DataGridView();
      this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pb_InHouse_PostPayment = new System.Windows.Forms.PictureBox();
      this.pb_InHouse_PostCharges = new System.Windows.Forms.PictureBox();
      this.pb_InHouse_RegCard = new System.Windows.Forms.PictureBox();
      this.pb_InHouse_ChangeStay = new System.Windows.Forms.PictureBox();
      this.pb_InHouse_CheckOut = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.pb_InHouse_Reservation = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pb_InHouse_NewBooking = new System.Windows.Forms.PictureBox();
      this.panel_Arrivals = new System.Windows.Forms.Panel();
      this.dgv_Arrival = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label17 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.pb_Arrivals_NewBooking = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_PostPayment = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_PostCharges = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_RegistrationCard = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_Confirmation = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_Cancel = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_ChangeReservation = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_CheckIn = new System.Windows.Forms.PictureBox();
      this.pb_Arrivals_Reservation = new System.Windows.Forms.PictureBox();
      this.panel_Departures = new System.Windows.Forms.Panel();
      this.label18 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.label24 = new System.Windows.Forms.Label();
      this.label25 = new System.Windows.Forms.Label();
      this.label26 = new System.Windows.Forms.Label();
      this.pb_Departure_NewBooking = new System.Windows.Forms.PictureBox();
      this.pb_Departures_PostPayment = new System.Windows.Forms.PictureBox();
      this.pb_Departures_PostCharges = new System.Windows.Forms.PictureBox();
      this.pb_Departures_GuestFolio = new System.Windows.Forms.PictureBox();
      this.pb_Departures_RegistrationCard = new System.Windows.Forms.PictureBox();
      this.pb_Departures_ChangeStay = new System.Windows.Forms.PictureBox();
      this.pb_Departures_CheckOut = new System.Windows.Forms.PictureBox();
      this.pb_Departures_Reservation = new System.Windows.Forms.PictureBox();
      this.dgv_Departures = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbl_user = new System.Windows.Forms.Label();
      this.lbl_dateTime = new System.Windows.Forms.Label();
      this.panel_frontDesk = new System.Windows.Forms.Panel();
      this.pb_HideIcon = new System.Windows.Forms.PictureBox();
      this.pb_CloseIcon = new System.Windows.Forms.PictureBox();
      this.pictureBox51 = new System.Windows.Forms.PictureBox();
      this.panel_CheckedOut = new System.Windows.Forms.Panel();
      this.dgv_CheckedOut = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label28 = new System.Windows.Forms.Label();
      this.label29 = new System.Windows.Forms.Label();
      this.label30 = new System.Windows.Forms.Label();
      this.label31 = new System.Windows.Forms.Label();
      this.label32 = new System.Windows.Forms.Label();
      this.label33 = new System.Windows.Forms.Label();
      this.label34 = new System.Windows.Forms.Label();
      this.pb_CheckedOut_NewBooking = new System.Windows.Forms.PictureBox();
      this.pb_Checked_PostPayment = new System.Windows.Forms.PictureBox();
      this.pb_CheckedOut_GuestFolio = new System.Windows.Forms.PictureBox();
      this.pb_ChekedOut_RegisterCard = new System.Windows.Forms.PictureBox();
      this.pb_CheckedOut_Reinstate = new System.Windows.Forms.PictureBox();
      this.pb_CheckedOut_Reservation = new System.Windows.Forms.PictureBox();
      this.pb_CheckedOut_PostCharges = new System.Windows.Forms.PictureBox();
      this.panel_Cancelled = new System.Windows.Forms.Panel();
      this.label51 = new System.Windows.Forms.Label();
      this.pb_Cancelled_Confirmation = new System.Windows.Forms.PictureBox();
      this.label50 = new System.Windows.Forms.Label();
      this.pb_Cancelled_PostPayment = new System.Windows.Forms.PictureBox();
      this.label49 = new System.Windows.Forms.Label();
      this.pb_Cancelled_PostC = new System.Windows.Forms.PictureBox();
      this.label37 = new System.Windows.Forms.Label();
      this.label39 = new System.Windows.Forms.Label();
      this.label40 = new System.Windows.Forms.Label();
      this.pb_Cancelled_NewBooking = new System.Windows.Forms.PictureBox();
      this.dgv_Cancelled = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pb_Cancelled_Reservation = new System.Windows.Forms.PictureBox();
      this.pb_Cancelled_GuestFolio = new System.Windows.Forms.PictureBox();
      this.panel_noShows = new System.Windows.Forms.Panel();
      this.label46 = new System.Windows.Forms.Label();
      this.label48 = new System.Windows.Forms.Label();
      this.pb_NoShows_PostPayment = new System.Windows.Forms.PictureBox();
      this.pb_NoShows_PostCharges = new System.Windows.Forms.PictureBox();
      this.label20 = new System.Windows.Forms.Label();
      this.pb_NoShows_Cancel = new System.Windows.Forms.PictureBox();
      this.label45 = new System.Windows.Forms.Label();
      this.pb_NoShows_ChangeReservation = new System.Windows.Forms.PictureBox();
      this.label27 = new System.Windows.Forms.Label();
      this.label35 = new System.Windows.Forms.Label();
      this.label36 = new System.Windows.Forms.Label();
      this.pb_NoShows_NewBooking = new System.Windows.Forms.PictureBox();
      this.pb_NoShows_Reservation = new System.Windows.Forms.PictureBox();
      this.pb_NoShows_CheckIn = new System.Windows.Forms.PictureBox();
      this.dgv_NoShows = new System.Windows.Forms.DataGridView();
      this.ico_ShareClm = new System.Windows.Forms.DataGridViewImageColumn();
      this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel_WaitList = new System.Windows.Forms.Panel();
      this.label47 = new System.Windows.Forms.Label();
      this.pb_WaitList_ConfirmRequest = new System.Windows.Forms.PictureBox();
      this.label41 = new System.Windows.Forms.Label();
      this.label42 = new System.Windows.Forms.Label();
      this.label43 = new System.Windows.Forms.Label();
      this.label44 = new System.Windows.Forms.Label();
      this.pb_WaitList_NewBooking = new System.Windows.Forms.PictureBox();
      this.dgv_WaitList = new System.Windows.Forms.DataGridView();
      this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pb_WaitList_ChangeReservation = new System.Windows.Forms.PictureBox();
      this.pb_WaitList_Confirmation = new System.Windows.Forms.PictureBox();
      this.pb_WaitList_Cancel = new System.Windows.Forms.PictureBox();
      this.panel_Reservation = new System.Windows.Forms.Panel();
      this.lbl_GF = new System.Windows.Forms.Label();
      this.lbl_Confirmation = new System.Windows.Forms.Label();
      this.lbl_Reservation = new System.Windows.Forms.Label();
      this.lbl_Nb = new System.Windows.Forms.Label();
      this.pb_Reservation_NewBooking = new System.Windows.Forms.PictureBox();
      this.dgv_Reservation = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pb_Reservation_Reservation = new System.Windows.Forms.PictureBox();
      this.pb_Reservation_Confirmation = new System.Windows.Forms.PictureBox();
      this.pb_Reservation_GuestFolio = new System.Windows.Forms.PictureBox();
      this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
      this.pb_ExitIcon = new System.Windows.Forms.PictureBox();
      this.pb_MinimizeIcon = new System.Windows.Forms.PictureBox();
      this.label60 = new System.Windows.Forms.Label();
      this.Ms_NoteView.SuspendLayout();
      this.gb_frontDesk1.SuspendLayout();
      this.tab_guestInfo.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.gb_frontDesk2.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.gb_Folio.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_folio)).BeginInit();
      this.panel_InHouse.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_ImHouse_GuestFolio)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_InHouse)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_PostPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_PostCharges)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_RegCard)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_ChangeStay)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_CheckOut)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_Reservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_NewBooking)).BeginInit();
      this.panel_Arrivals.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Arrival)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_NewBooking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_PostPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_PostCharges)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_RegistrationCard)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_Confirmation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_Cancel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_ChangeReservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_CheckIn)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_Reservation)).BeginInit();
      this.panel_Departures.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departure_NewBooking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_PostPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_PostCharges)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_GuestFolio)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_RegistrationCard)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_ChangeStay)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_CheckOut)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_Reservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Departures)).BeginInit();
      this.panel_frontDesk.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_HideIcon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CloseIcon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
      this.panel_CheckedOut.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_CheckedOut)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_NewBooking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Checked_PostPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_GuestFolio)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_ChekedOut_RegisterCard)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_Reinstate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_Reservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_PostCharges)).BeginInit();
      this.panel_Cancelled.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_Confirmation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_PostPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_PostC)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_NewBooking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Cancelled)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_Reservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_GuestFolio)).BeginInit();
      this.panel_noShows.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_PostPayment)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_PostCharges)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_Cancel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_ChangeReservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_NewBooking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_Reservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_CheckIn)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_NoShows)).BeginInit();
      this.panel_WaitList.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_ConfirmRequest)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_NewBooking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_WaitList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_ChangeReservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_Confirmation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_Cancel)).BeginInit();
      this.panel_Reservation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_NewBooking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_Reservation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_Confirmation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_GuestFolio)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_ExitIcon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_MinimizeIcon)).BeginInit();
      this.SuspendLayout();
      // 
      // Ms_NoteView
      // 
      this.Ms_NoteView.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.Ms_NoteView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_NoteView,
            this.toolStrip_Transactions,
            this.toolStrip_Reservations,
            this.toolStrip_Operations,
            this.toolStrip_Sc,
            this.exportImportToolStripMenuItem,
            this.toolStrip_Reports,
            this.advSearchToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.Ms_NoteView.Location = new System.Drawing.Point(0, 0);
      this.Ms_NoteView.Name = "Ms_NoteView";
      this.Ms_NoteView.Size = new System.Drawing.Size(1822, 24);
      this.Ms_NoteView.TabIndex = 11;
      this.Ms_NoteView.Text = "menuStrip1";
      this.Ms_NoteView.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
      // 
      // toolstrip_NoteView
      // 
      this.toolstrip_NoteView.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolstrip_NoteView.ForeColor = System.Drawing.Color.Navy;
      this.toolstrip_NoteView.Name = "toolstrip_NoteView";
      this.toolstrip_NoteView.Size = new System.Drawing.Size(93, 20);
      this.toolstrip_NoteView.Text = "Front Desk";
      // 
      // toolStrip_Transactions
      // 
      this.toolStrip_Transactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postPaymentToolStripMenuItem,
            this.postChargesToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.guestFolioToolStripMenuItem,
            this.unprocessedCreditCardTransactionsToolStripMenuItem,
            this.authorizedTransactionsToolStripMenuItem,
            this.folioAppearanceToolStripMenuItem,
            this.cancelAllNoShowsToolStripMenuItem,
            this.processLateFeesToolStripMenuItem});
      this.toolStrip_Transactions.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip_Transactions.ForeColor = System.Drawing.Color.Navy;
      this.toolStrip_Transactions.Name = "toolStrip_Transactions";
      this.toolStrip_Transactions.Size = new System.Drawing.Size(105, 20);
      this.toolStrip_Transactions.Text = "Transactions";
      // 
      // postPaymentToolStripMenuItem
      // 
      this.postPaymentToolStripMenuItem.Name = "postPaymentToolStripMenuItem";
      this.postPaymentToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.postPaymentToolStripMenuItem.Text = "Post Payment";
      // 
      // postChargesToolStripMenuItem
      // 
      this.postChargesToolStripMenuItem.Name = "postChargesToolStripMenuItem";
      this.postChargesToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.postChargesToolStripMenuItem.Text = "Post Charges";
      // 
      // moveToolStripMenuItem
      // 
      this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
      this.moveToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.moveToolStripMenuItem.Text = "Move";
      // 
      // guestFolioToolStripMenuItem
      // 
      this.guestFolioToolStripMenuItem.Name = "guestFolioToolStripMenuItem";
      this.guestFolioToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.guestFolioToolStripMenuItem.Text = "Guest Folio Credit Limit";
      this.guestFolioToolStripMenuItem.Click += new System.EventHandler(this.guestFolioToolStripMenuItem_Click);
      // 
      // unprocessedCreditCardTransactionsToolStripMenuItem
      // 
      this.unprocessedCreditCardTransactionsToolStripMenuItem.Name = "unprocessedCreditCardTransactionsToolStripMenuItem";
      this.unprocessedCreditCardTransactionsToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.unprocessedCreditCardTransactionsToolStripMenuItem.Text = "Unprocessed credit card  transactions";
      // 
      // authorizedTransactionsToolStripMenuItem
      // 
      this.authorizedTransactionsToolStripMenuItem.Name = "authorizedTransactionsToolStripMenuItem";
      this.authorizedTransactionsToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.authorizedTransactionsToolStripMenuItem.Text = "Authorized Transactions";
      // 
      // folioAppearanceToolStripMenuItem
      // 
      this.folioAppearanceToolStripMenuItem.Name = "folioAppearanceToolStripMenuItem";
      this.folioAppearanceToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.folioAppearanceToolStripMenuItem.Text = "Folio Appearance";
      // 
      // cancelAllNoShowsToolStripMenuItem
      // 
      this.cancelAllNoShowsToolStripMenuItem.Name = "cancelAllNoShowsToolStripMenuItem";
      this.cancelAllNoShowsToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.cancelAllNoShowsToolStripMenuItem.Text = "Cancel all no shows";
      // 
      // processLateFeesToolStripMenuItem
      // 
      this.processLateFeesToolStripMenuItem.Name = "processLateFeesToolStripMenuItem";
      this.processLateFeesToolStripMenuItem.Size = new System.Drawing.Size(337, 26);
      this.processLateFeesToolStripMenuItem.Text = "Process late fees";
      // 
      // toolStrip_Reservations
      // 
      this.toolStrip_Reservations.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip_Reservations.ForeColor = System.Drawing.Color.Navy;
      this.toolStrip_Reservations.Name = "toolStrip_Reservations";
      this.toolStrip_Reservations.Size = new System.Drawing.Size(107, 20);
      this.toolStrip_Reservations.Text = "Reservations";
      // 
      // toolStrip_Operations
      // 
      this.toolStrip_Operations.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip_Operations.ForeColor = System.Drawing.Color.Navy;
      this.toolStrip_Operations.Name = "toolStrip_Operations";
      this.toolStrip_Operations.Size = new System.Drawing.Size(94, 20);
      this.toolStrip_Operations.Text = "Operations";
      // 
      // toolStrip_Sc
      // 
      this.toolStrip_Sc.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip_Sc.ForeColor = System.Drawing.Color.Navy;
      this.toolStrip_Sc.Name = "toolStrip_Sc";
      this.toolStrip_Sc.Size = new System.Drawing.Size(163, 20);
      this.toolStrip_Sc.Text = "System Configuration";
      // 
      // exportImportToolStripMenuItem
      // 
      this.exportImportToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.exportImportToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
      this.exportImportToolStripMenuItem.Name = "exportImportToolStripMenuItem";
      this.exportImportToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
      this.exportImportToolStripMenuItem.Text = "Export/Import";
      // 
      // toolStrip_Reports
      // 
      this.toolStrip_Reports.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip_Reports.ForeColor = System.Drawing.Color.Navy;
      this.toolStrip_Reports.Name = "toolStrip_Reports";
      this.toolStrip_Reports.Size = new System.Drawing.Size(72, 20);
      this.toolStrip_Reports.Text = "Reports";
      // 
      // advSearchToolStripMenuItem
      // 
      this.advSearchToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.advSearchToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
      this.advSearchToolStripMenuItem.Name = "advSearchToolStripMenuItem";
      this.advSearchToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
      this.advSearchToolStripMenuItem.Text = "Adv. Search";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // gb_frontDesk1
      // 
      this.gb_frontDesk1.BackColor = System.Drawing.Color.White;
      this.gb_frontDesk1.Controls.Add(this.lbl_Arrival);
      this.gb_frontDesk1.Controls.Add(this.lbl_Departures);
      this.gb_frontDesk1.Controls.Add(this.lbl_Waitlist);
      this.gb_frontDesk1.Controls.Add(this.lbl_cancelled);
      this.gb_frontDesk1.Controls.Add(this.lbl_Reservations);
      this.gb_frontDesk1.Controls.Add(this.lbl_checkedOut);
      this.gb_frontDesk1.Controls.Add(this.lbl_noShows);
      this.gb_frontDesk1.Controls.Add(this.lbl_space);
      this.gb_frontDesk1.Controls.Add(this.lbl_inHouse);
      this.gb_frontDesk1.Location = new System.Drawing.Point(1544, 151);
      this.gb_frontDesk1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_frontDesk1.Name = "gb_frontDesk1";
      this.gb_frontDesk1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_frontDesk1.Size = new System.Drawing.Size(265, 315);
      this.gb_frontDesk1.TabIndex = 16;
      this.gb_frontDesk1.TabStop = false;
      this.gb_frontDesk1.Enter += new System.EventHandler(this.gb_frontDesk1_Enter);
      // 
      // lbl_Arrival
      // 
      this.lbl_Arrival.AutoSize = true;
      this.lbl_Arrival.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Arrival.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Arrival.ForeColor = System.Drawing.Color.Black;
      this.lbl_Arrival.Location = new System.Drawing.Point(51, 70);
      this.lbl_Arrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Arrival.Name = "lbl_Arrival";
      this.lbl_Arrival.Size = new System.Drawing.Size(60, 17);
      this.lbl_Arrival.TabIndex = 9;
      this.lbl_Arrival.Text = "Arrivals";
      this.lbl_Arrival.Click += new System.EventHandler(this.lbl_Arrival_Click);
      // 
      // lbl_Departures
      // 
      this.lbl_Departures.AutoSize = true;
      this.lbl_Departures.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Departures.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Departures.ForeColor = System.Drawing.Color.Black;
      this.lbl_Departures.Location = new System.Drawing.Point(51, 101);
      this.lbl_Departures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Departures.Name = "lbl_Departures";
      this.lbl_Departures.Size = new System.Drawing.Size(87, 17);
      this.lbl_Departures.TabIndex = 8;
      this.lbl_Departures.Text = "Departures";
      this.lbl_Departures.Click += new System.EventHandler(this.Departures_Click);
      // 
      // lbl_Waitlist
      // 
      this.lbl_Waitlist.AutoSize = true;
      this.lbl_Waitlist.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Waitlist.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Waitlist.ForeColor = System.Drawing.Color.Black;
      this.lbl_Waitlist.Location = new System.Drawing.Point(51, 255);
      this.lbl_Waitlist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Waitlist.Name = "lbl_Waitlist";
      this.lbl_Waitlist.Size = new System.Drawing.Size(69, 17);
      this.lbl_Waitlist.TabIndex = 6;
      this.lbl_Waitlist.Text = "Wait List";
      this.lbl_Waitlist.Click += new System.EventHandler(this.lbl_Waitlist_Click);
      // 
      // lbl_cancelled
      // 
      this.lbl_cancelled.AutoSize = true;
      this.lbl_cancelled.BackColor = System.Drawing.Color.Transparent;
      this.lbl_cancelled.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_cancelled.ForeColor = System.Drawing.Color.Black;
      this.lbl_cancelled.Location = new System.Drawing.Point(51, 224);
      this.lbl_cancelled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_cancelled.Name = "lbl_cancelled";
      this.lbl_cancelled.Size = new System.Drawing.Size(73, 17);
      this.lbl_cancelled.TabIndex = 5;
      this.lbl_cancelled.Text = "Cancelled";
      this.lbl_cancelled.Click += new System.EventHandler(this.lbl_cancelled_Click);
      // 
      // lbl_Reservations
      // 
      this.lbl_Reservations.AutoSize = true;
      this.lbl_Reservations.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Reservations.Font = new System.Drawing.Font("Verdana", 8F);
      this.lbl_Reservations.ForeColor = System.Drawing.Color.Black;
      this.lbl_Reservations.Location = new System.Drawing.Point(51, 132);
      this.lbl_Reservations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Reservations.Name = "lbl_Reservations";
      this.lbl_Reservations.Size = new System.Drawing.Size(99, 17);
      this.lbl_Reservations.TabIndex = 4;
      this.lbl_Reservations.Text = "Reservations";
      this.lbl_Reservations.Click += new System.EventHandler(this.label6_Click);
      // 
      // lbl_checkedOut
      // 
      this.lbl_checkedOut.AutoSize = true;
      this.lbl_checkedOut.BackColor = System.Drawing.Color.Transparent;
      this.lbl_checkedOut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_checkedOut.ForeColor = System.Drawing.Color.Black;
      this.lbl_checkedOut.Location = new System.Drawing.Point(51, 162);
      this.lbl_checkedOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_checkedOut.Name = "lbl_checkedOut";
      this.lbl_checkedOut.Size = new System.Drawing.Size(98, 17);
      this.lbl_checkedOut.TabIndex = 3;
      this.lbl_checkedOut.Text = "Checked Out";
      this.lbl_checkedOut.Click += new System.EventHandler(this.lbl_checkedOut_Click);
      // 
      // lbl_noShows
      // 
      this.lbl_noShows.AutoSize = true;
      this.lbl_noShows.BackColor = System.Drawing.Color.Transparent;
      this.lbl_noShows.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_noShows.ForeColor = System.Drawing.Color.Black;
      this.lbl_noShows.Location = new System.Drawing.Point(51, 193);
      this.lbl_noShows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_noShows.Name = "lbl_noShows";
      this.lbl_noShows.Size = new System.Drawing.Size(79, 17);
      this.lbl_noShows.TabIndex = 2;
      this.lbl_noShows.Text = "No Shows";
      this.lbl_noShows.Click += new System.EventHandler(this.lbl_noShows_Click);
      // 
      // lbl_space
      // 
      this.lbl_space.AutoSize = true;
      this.lbl_space.BackColor = System.Drawing.Color.Transparent;
      this.lbl_space.Location = new System.Drawing.Point(51, 305);
      this.lbl_space.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_space.Name = "lbl_space";
      this.lbl_space.Size = new System.Drawing.Size(22, 16);
      this.lbl_space.TabIndex = 1;
      this.lbl_space.Text = ".....";
      // 
      // lbl_inHouse
      // 
      this.lbl_inHouse.AutoSize = true;
      this.lbl_inHouse.BackColor = System.Drawing.Color.Transparent;
      this.lbl_inHouse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_inHouse.ForeColor = System.Drawing.Color.Blue;
      this.lbl_inHouse.Location = new System.Drawing.Point(51, 39);
      this.lbl_inHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_inHouse.Name = "lbl_inHouse";
      this.lbl_inHouse.Size = new System.Drawing.Size(116, 20);
      this.lbl_inHouse.TabIndex = 0;
      this.lbl_inHouse.Text = "> In House";
      this.lbl_inHouse.Click += new System.EventHandler(this.InHouse_Enter);
      // 
      // tab_guestInfo
      // 
      this.tab_guestInfo.Controls.Add(this.tabPage1);
      this.tab_guestInfo.Controls.Add(this.tabPage2);
      this.tab_guestInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tab_guestInfo.Location = new System.Drawing.Point(5, 474);
      this.tab_guestInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tab_guestInfo.Name = "tab_guestInfo";
      this.tab_guestInfo.SelectedIndex = 0;
      this.tab_guestInfo.Size = new System.Drawing.Size(1804, 389);
      this.tab_guestInfo.TabIndex = 17;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.gb_frontDesk2);
      this.tabPage1.Location = new System.Drawing.Point(4, 26);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage1.Size = new System.Drawing.Size(1796, 359);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Guest Info";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // gb_frontDesk2
      // 
      this.gb_frontDesk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
      this.gb_frontDesk2.Controls.Add(this.label60);
      this.gb_frontDesk2.Controls.Add(this.txt_vehicleLicense);
      this.gb_frontDesk2.Controls.Add(this.txt_travelAgency);
      this.gb_frontDesk2.Controls.Add(this.lbl_vehicleLicense);
      this.gb_frontDesk2.Controls.Add(this.lbl_travelAgency);
      this.gb_frontDesk2.Controls.Add(this.txt_cardHolder);
      this.gb_frontDesk2.Controls.Add(this.txt_cardNumber);
      this.gb_frontDesk2.Controls.Add(this.txt_expiry);
      this.gb_frontDesk2.Controls.Add(this.txt_cardType);
      this.gb_frontDesk2.Controls.Add(this.txt_reservationNote);
      this.gb_frontDesk2.Controls.Add(this.txt_guestNote);
      this.gb_frontDesk2.Controls.Add(this.txt_email);
      this.gb_frontDesk2.Controls.Add(this.txt_mobile);
      this.gb_frontDesk2.Controls.Add(this.txt_telephone);
      this.gb_frontDesk2.Controls.Add(this.txt_source);
      this.gb_frontDesk2.Controls.Add(this.txt_rateCode);
      this.gb_frontDesk2.Controls.Add(this.txt_ClientType);
      this.gb_frontDesk2.Controls.Add(this.txt_postalCode);
      this.gb_frontDesk2.Controls.Add(this.txt_country);
      this.gb_frontDesk2.Controls.Add(this.txt_province);
      this.gb_frontDesk2.Controls.Add(this.txt_City);
      this.gb_frontDesk2.Controls.Add(this.txt_StreetAdress);
      this.gb_frontDesk2.Controls.Add(this.txt_lastName);
      this.gb_frontDesk2.Controls.Add(this.txt_firstName);
      this.gb_frontDesk2.Controls.Add(this.txt_title);
      this.gb_frontDesk2.Controls.Add(this.lbl_cardType);
      this.gb_frontDesk2.Controls.Add(this.lbl_expiry);
      this.gb_frontDesk2.Controls.Add(this.lbl_cardNumber);
      this.gb_frontDesk2.Controls.Add(this.lbl_cardHolder);
      this.gb_frontDesk2.Controls.Add(this.lbl_reserveationNote);
      this.gb_frontDesk2.Controls.Add(this.lbl_guestnote);
      this.gb_frontDesk2.Controls.Add(this.lbl_email);
      this.gb_frontDesk2.Controls.Add(this.lbl_mobile);
      this.gb_frontDesk2.Controls.Add(this.lbl_telephone);
      this.gb_frontDesk2.Controls.Add(this.lbl_source);
      this.gb_frontDesk2.Controls.Add(this.lbl_postalCode);
      this.gb_frontDesk2.Controls.Add(this.lbl_rateCode);
      this.gb_frontDesk2.Controls.Add(this.lbl_country);
      this.gb_frontDesk2.Controls.Add(this.lbl_clientType);
      this.gb_frontDesk2.Controls.Add(this.label2);
      this.gb_frontDesk2.Controls.Add(this.lbl_province);
      this.gb_frontDesk2.Controls.Add(this.lbl_city);
      this.gb_frontDesk2.Controls.Add(this.lbl_streetAddress);
      this.gb_frontDesk2.Controls.Add(this.lbl_lastName);
      this.gb_frontDesk2.Controls.Add(this.lbl_firstName);
      this.gb_frontDesk2.Controls.Add(this.lbl_title);
      this.gb_frontDesk2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_frontDesk2.Location = new System.Drawing.Point(-5, -14);
      this.gb_frontDesk2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_frontDesk2.Name = "gb_frontDesk2";
      this.gb_frontDesk2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_frontDesk2.Size = new System.Drawing.Size(1804, 384);
      this.gb_frontDesk2.TabIndex = 14;
      this.gb_frontDesk2.TabStop = false;
      this.gb_frontDesk2.Enter += new System.EventHandler(this.groupBox2_Enter);
      // 
      // txt_vehicleLicense
      // 
      this.txt_vehicleLicense.Location = new System.Drawing.Point(1457, 199);
      this.txt_vehicleLicense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_vehicleLicense.Name = "txt_vehicleLicense";
      this.txt_vehicleLicense.ReadOnly = true;
      this.txt_vehicleLicense.Size = new System.Drawing.Size(219, 24);
      this.txt_vehicleLicense.TabIndex = 44;
      // 
      // txt_travelAgency
      // 
      this.txt_travelAgency.Location = new System.Drawing.Point(1457, 159);
      this.txt_travelAgency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_travelAgency.Name = "txt_travelAgency";
      this.txt_travelAgency.ReadOnly = true;
      this.txt_travelAgency.Size = new System.Drawing.Size(219, 24);
      this.txt_travelAgency.TabIndex = 43;
      // 
      // lbl_vehicleLicense
      // 
      this.lbl_vehicleLicense.AutoSize = true;
      this.lbl_vehicleLicense.BackColor = System.Drawing.Color.Transparent;
      this.lbl_vehicleLicense.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_vehicleLicense.ForeColor = System.Drawing.Color.Navy;
      this.lbl_vehicleLicense.Location = new System.Drawing.Point(1297, 204);
      this.lbl_vehicleLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_vehicleLicense.Name = "lbl_vehicleLicense";
      this.lbl_vehicleLicense.Size = new System.Drawing.Size(136, 17);
      this.lbl_vehicleLicense.TabIndex = 42;
      this.lbl_vehicleLicense.Text = "Vehicle License :";
      this.lbl_vehicleLicense.Click += new System.EventHandler(this.label3_Click_1);
      // 
      // lbl_travelAgency
      // 
      this.lbl_travelAgency.AutoSize = true;
      this.lbl_travelAgency.BackColor = System.Drawing.Color.Transparent;
      this.lbl_travelAgency.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_travelAgency.ForeColor = System.Drawing.Color.Navy;
      this.lbl_travelAgency.Location = new System.Drawing.Point(1305, 164);
      this.lbl_travelAgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_travelAgency.Name = "lbl_travelAgency";
      this.lbl_travelAgency.Size = new System.Drawing.Size(129, 17);
      this.lbl_travelAgency.TabIndex = 41;
      this.lbl_travelAgency.Text = "Travel Agency :";
      this.lbl_travelAgency.Click += new System.EventHandler(this.tbl_travelAgency_Click);
      // 
      // txt_cardHolder
      // 
      this.txt_cardHolder.Location = new System.Drawing.Point(1457, 116);
      this.txt_cardHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_cardHolder.Name = "txt_cardHolder";
      this.txt_cardHolder.ReadOnly = true;
      this.txt_cardHolder.Size = new System.Drawing.Size(219, 24);
      this.txt_cardHolder.TabIndex = 40;
      // 
      // txt_cardNumber
      // 
      this.txt_cardNumber.Location = new System.Drawing.Point(1457, 75);
      this.txt_cardNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_cardNumber.Name = "txt_cardNumber";
      this.txt_cardNumber.ReadOnly = true;
      this.txt_cardNumber.Size = new System.Drawing.Size(219, 24);
      this.txt_cardNumber.TabIndex = 39;
      // 
      // txt_expiry
      // 
      this.txt_expiry.Location = new System.Drawing.Point(1061, 284);
      this.txt_expiry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_expiry.Name = "txt_expiry";
      this.txt_expiry.ReadOnly = true;
      this.txt_expiry.Size = new System.Drawing.Size(219, 24);
      this.txt_expiry.TabIndex = 38;
      // 
      // txt_cardType
      // 
      this.txt_cardType.Location = new System.Drawing.Point(1061, 241);
      this.txt_cardType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_cardType.Name = "txt_cardType";
      this.txt_cardType.ReadOnly = true;
      this.txt_cardType.Size = new System.Drawing.Size(219, 24);
      this.txt_cardType.TabIndex = 37;
      // 
      // txt_reservationNote
      // 
      this.txt_reservationNote.Location = new System.Drawing.Point(1061, 201);
      this.txt_reservationNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_reservationNote.Name = "txt_reservationNote";
      this.txt_reservationNote.ReadOnly = true;
      this.txt_reservationNote.Size = new System.Drawing.Size(219, 24);
      this.txt_reservationNote.TabIndex = 36;
      // 
      // txt_guestNote
      // 
      this.txt_guestNote.Location = new System.Drawing.Point(1061, 159);
      this.txt_guestNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_guestNote.Name = "txt_guestNote";
      this.txt_guestNote.ReadOnly = true;
      this.txt_guestNote.Size = new System.Drawing.Size(219, 24);
      this.txt_guestNote.TabIndex = 35;
      // 
      // txt_email
      // 
      this.txt_email.Location = new System.Drawing.Point(1061, 117);
      this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_email.Name = "txt_email";
      this.txt_email.ReadOnly = true;
      this.txt_email.Size = new System.Drawing.Size(219, 24);
      this.txt_email.TabIndex = 34;
      // 
      // txt_mobile
      // 
      this.txt_mobile.Location = new System.Drawing.Point(1061, 75);
      this.txt_mobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_mobile.Name = "txt_mobile";
      this.txt_mobile.ReadOnly = true;
      this.txt_mobile.Size = new System.Drawing.Size(219, 24);
      this.txt_mobile.TabIndex = 33;
      // 
      // txt_telephone
      // 
      this.txt_telephone.Location = new System.Drawing.Point(655, 284);
      this.txt_telephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_telephone.Name = "txt_telephone";
      this.txt_telephone.ReadOnly = true;
      this.txt_telephone.Size = new System.Drawing.Size(219, 24);
      this.txt_telephone.TabIndex = 32;
      // 
      // txt_source
      // 
      this.txt_source.Location = new System.Drawing.Point(655, 242);
      this.txt_source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_source.Name = "txt_source";
      this.txt_source.ReadOnly = true;
      this.txt_source.Size = new System.Drawing.Size(219, 24);
      this.txt_source.TabIndex = 31;
      // 
      // txt_rateCode
      // 
      this.txt_rateCode.Location = new System.Drawing.Point(655, 202);
      this.txt_rateCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_rateCode.Name = "txt_rateCode";
      this.txt_rateCode.ReadOnly = true;
      this.txt_rateCode.Size = new System.Drawing.Size(219, 24);
      this.txt_rateCode.TabIndex = 30;
      this.txt_rateCode.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
      // 
      // txt_ClientType
      // 
      this.txt_ClientType.Location = new System.Drawing.Point(655, 161);
      this.txt_ClientType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_ClientType.Name = "txt_ClientType";
      this.txt_ClientType.ReadOnly = true;
      this.txt_ClientType.Size = new System.Drawing.Size(219, 24);
      this.txt_ClientType.TabIndex = 29;
      // 
      // txt_postalCode
      // 
      this.txt_postalCode.Location = new System.Drawing.Point(655, 118);
      this.txt_postalCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_postalCode.Name = "txt_postalCode";
      this.txt_postalCode.ReadOnly = true;
      this.txt_postalCode.Size = new System.Drawing.Size(219, 24);
      this.txt_postalCode.TabIndex = 28;
      // 
      // txt_country
      // 
      this.txt_country.Location = new System.Drawing.Point(655, 75);
      this.txt_country.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_country.Name = "txt_country";
      this.txt_country.ReadOnly = true;
      this.txt_country.Size = new System.Drawing.Size(219, 24);
      this.txt_country.TabIndex = 27;
      // 
      // txt_province
      // 
      this.txt_province.Location = new System.Drawing.Point(281, 284);
      this.txt_province.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_province.Name = "txt_province";
      this.txt_province.ReadOnly = true;
      this.txt_province.Size = new System.Drawing.Size(219, 24);
      this.txt_province.TabIndex = 26;
      // 
      // txt_City
      // 
      this.txt_City.Location = new System.Drawing.Point(281, 242);
      this.txt_City.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_City.Name = "txt_City";
      this.txt_City.ReadOnly = true;
      this.txt_City.Size = new System.Drawing.Size(219, 24);
      this.txt_City.TabIndex = 25;
      // 
      // txt_StreetAdress
      // 
      this.txt_StreetAdress.Location = new System.Drawing.Point(281, 201);
      this.txt_StreetAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_StreetAdress.Name = "txt_StreetAdress";
      this.txt_StreetAdress.ReadOnly = true;
      this.txt_StreetAdress.Size = new System.Drawing.Size(219, 24);
      this.txt_StreetAdress.TabIndex = 24;
      // 
      // txt_lastName
      // 
      this.txt_lastName.Location = new System.Drawing.Point(281, 159);
      this.txt_lastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_lastName.Name = "txt_lastName";
      this.txt_lastName.ReadOnly = true;
      this.txt_lastName.Size = new System.Drawing.Size(219, 24);
      this.txt_lastName.TabIndex = 23;
      // 
      // txt_firstName
      // 
      this.txt_firstName.Location = new System.Drawing.Point(281, 117);
      this.txt_firstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_firstName.Name = "txt_firstName";
      this.txt_firstName.ReadOnly = true;
      this.txt_firstName.Size = new System.Drawing.Size(219, 24);
      this.txt_firstName.TabIndex = 22;
      // 
      // txt_title
      // 
      this.txt_title.Location = new System.Drawing.Point(281, 75);
      this.txt_title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txt_title.Name = "txt_title";
      this.txt_title.ReadOnly = true;
      this.txt_title.Size = new System.Drawing.Size(219, 24);
      this.txt_title.TabIndex = 21;
      this.txt_title.TextChanged += new System.EventHandler(this.tb_title_TextChanged);
      // 
      // lbl_cardType
      // 
      this.lbl_cardType.AutoSize = true;
      this.lbl_cardType.BackColor = System.Drawing.Color.Transparent;
      this.lbl_cardType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_cardType.ForeColor = System.Drawing.Color.Navy;
      this.lbl_cardType.Location = new System.Drawing.Point(947, 245);
      this.lbl_cardType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_cardType.Name = "lbl_cardType";
      this.lbl_cardType.Size = new System.Drawing.Size(99, 17);
      this.lbl_cardType.TabIndex = 20;
      this.lbl_cardType.Text = "Card Type :";
      // 
      // lbl_expiry
      // 
      this.lbl_expiry.AutoSize = true;
      this.lbl_expiry.BackColor = System.Drawing.Color.Transparent;
      this.lbl_expiry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_expiry.ForeColor = System.Drawing.Color.Navy;
      this.lbl_expiry.Location = new System.Drawing.Point(893, 289);
      this.lbl_expiry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_expiry.Name = "lbl_expiry";
      this.lbl_expiry.Size = new System.Drawing.Size(145, 17);
      this.lbl_expiry.TabIndex = 19;
      this.lbl_expiry.Text = "Expiry (mm/yy) :";
      // 
      // lbl_cardNumber
      // 
      this.lbl_cardNumber.AutoSize = true;
      this.lbl_cardNumber.BackColor = System.Drawing.Color.Transparent;
      this.lbl_cardNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_cardNumber.ForeColor = System.Drawing.Color.Navy;
      this.lbl_cardNumber.Location = new System.Drawing.Point(1317, 80);
      this.lbl_cardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_cardNumber.Name = "lbl_cardNumber";
      this.lbl_cardNumber.Size = new System.Drawing.Size(122, 17);
      this.lbl_cardNumber.TabIndex = 18;
      this.lbl_cardNumber.Text = "Card Number :";
      // 
      // lbl_cardHolder
      // 
      this.lbl_cardHolder.AutoSize = true;
      this.lbl_cardHolder.BackColor = System.Drawing.Color.Transparent;
      this.lbl_cardHolder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_cardHolder.ForeColor = System.Drawing.Color.Navy;
      this.lbl_cardHolder.Location = new System.Drawing.Point(1328, 121);
      this.lbl_cardHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_cardHolder.Name = "lbl_cardHolder";
      this.lbl_cardHolder.Size = new System.Drawing.Size(112, 17);
      this.lbl_cardHolder.TabIndex = 17;
      this.lbl_cardHolder.Text = "Card Holder :";
      // 
      // lbl_reserveationNote
      // 
      this.lbl_reserveationNote.AutoSize = true;
      this.lbl_reserveationNote.BackColor = System.Drawing.Color.Transparent;
      this.lbl_reserveationNote.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_reserveationNote.ForeColor = System.Drawing.Color.Navy;
      this.lbl_reserveationNote.Location = new System.Drawing.Point(885, 206);
      this.lbl_reserveationNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_reserveationNote.Name = "lbl_reserveationNote";
      this.lbl_reserveationNote.Size = new System.Drawing.Size(152, 17);
      this.lbl_reserveationNote.TabIndex = 16;
      this.lbl_reserveationNote.Text = "Reservation Note :";
      // 
      // lbl_guestnote
      // 
      this.lbl_guestnote.AutoSize = true;
      this.lbl_guestnote.BackColor = System.Drawing.Color.Transparent;
      this.lbl_guestnote.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_guestnote.ForeColor = System.Drawing.Color.Navy;
      this.lbl_guestnote.Location = new System.Drawing.Point(940, 164);
      this.lbl_guestnote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_guestnote.Name = "lbl_guestnote";
      this.lbl_guestnote.Size = new System.Drawing.Size(104, 17);
      this.lbl_guestnote.TabIndex = 15;
      this.lbl_guestnote.Text = "Guest Note :";
      // 
      // lbl_email
      // 
      this.lbl_email.AutoSize = true;
      this.lbl_email.BackColor = System.Drawing.Color.Transparent;
      this.lbl_email.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_email.ForeColor = System.Drawing.Color.Navy;
      this.lbl_email.Location = new System.Drawing.Point(987, 122);
      this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_email.Name = "lbl_email";
      this.lbl_email.Size = new System.Drawing.Size(60, 17);
      this.lbl_email.TabIndex = 14;
      this.lbl_email.Text = "Email :";
      // 
      // lbl_mobile
      // 
      this.lbl_mobile.AutoSize = true;
      this.lbl_mobile.BackColor = System.Drawing.Color.Transparent;
      this.lbl_mobile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_mobile.ForeColor = System.Drawing.Color.Navy;
      this.lbl_mobile.Location = new System.Drawing.Point(979, 80);
      this.lbl_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_mobile.Name = "lbl_mobile";
      this.lbl_mobile.Size = new System.Drawing.Size(69, 17);
      this.lbl_mobile.TabIndex = 13;
      this.lbl_mobile.Text = "Mobile :";
      // 
      // lbl_telephone
      // 
      this.lbl_telephone.AutoSize = true;
      this.lbl_telephone.BackColor = System.Drawing.Color.Transparent;
      this.lbl_telephone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_telephone.ForeColor = System.Drawing.Color.Navy;
      this.lbl_telephone.Location = new System.Drawing.Point(537, 288);
      this.lbl_telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_telephone.Name = "lbl_telephone";
      this.lbl_telephone.Size = new System.Drawing.Size(100, 17);
      this.lbl_telephone.TabIndex = 12;
      this.lbl_telephone.Text = "Telephone :";
      // 
      // lbl_source
      // 
      this.lbl_source.AutoSize = true;
      this.lbl_source.BackColor = System.Drawing.Color.Transparent;
      this.lbl_source.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_source.ForeColor = System.Drawing.Color.Navy;
      this.lbl_source.Location = new System.Drawing.Point(568, 247);
      this.lbl_source.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_source.Name = "lbl_source";
      this.lbl_source.Size = new System.Drawing.Size(73, 17);
      this.lbl_source.TabIndex = 11;
      this.lbl_source.Text = "Source :";
      // 
      // lbl_postalCode
      // 
      this.lbl_postalCode.AutoSize = true;
      this.lbl_postalCode.BackColor = System.Drawing.Color.Transparent;
      this.lbl_postalCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_postalCode.ForeColor = System.Drawing.Color.Navy;
      this.lbl_postalCode.Location = new System.Drawing.Point(527, 123);
      this.lbl_postalCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_postalCode.Name = "lbl_postalCode";
      this.lbl_postalCode.Size = new System.Drawing.Size(111, 17);
      this.lbl_postalCode.TabIndex = 10;
      this.lbl_postalCode.Text = "Postal Code :";
      // 
      // lbl_rateCode
      // 
      this.lbl_rateCode.AutoSize = true;
      this.lbl_rateCode.BackColor = System.Drawing.Color.Transparent;
      this.lbl_rateCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_rateCode.ForeColor = System.Drawing.Color.Navy;
      this.lbl_rateCode.Location = new System.Drawing.Point(541, 207);
      this.lbl_rateCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_rateCode.Name = "lbl_rateCode";
      this.lbl_rateCode.Size = new System.Drawing.Size(99, 17);
      this.lbl_rateCode.TabIndex = 9;
      this.lbl_rateCode.Text = "Rate Code :";
      // 
      // lbl_country
      // 
      this.lbl_country.AutoSize = true;
      this.lbl_country.BackColor = System.Drawing.Color.Transparent;
      this.lbl_country.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_country.ForeColor = System.Drawing.Color.Navy;
      this.lbl_country.Location = new System.Drawing.Point(560, 80);
      this.lbl_country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_country.Name = "lbl_country";
      this.lbl_country.Size = new System.Drawing.Size(82, 17);
      this.lbl_country.TabIndex = 8;
      this.lbl_country.Text = "Country :";
      // 
      // lbl_clientType
      // 
      this.lbl_clientType.AutoSize = true;
      this.lbl_clientType.BackColor = System.Drawing.Color.Transparent;
      this.lbl_clientType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_clientType.ForeColor = System.Drawing.Color.Navy;
      this.lbl_clientType.Location = new System.Drawing.Point(531, 166);
      this.lbl_clientType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_clientType.Name = "lbl_clientType";
      this.lbl_clientType.Size = new System.Drawing.Size(106, 17);
      this.lbl_clientType.TabIndex = 7;
      this.lbl_clientType.Text = "Client Type :";
      this.lbl_clientType.Click += new System.EventHandler(this.label3_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(28, 279);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 17);
      this.label2.TabIndex = 6;
      // 
      // lbl_province
      // 
      this.lbl_province.AutoSize = true;
      this.lbl_province.BackColor = System.Drawing.Color.Transparent;
      this.lbl_province.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_province.ForeColor = System.Drawing.Color.Navy;
      this.lbl_province.Location = new System.Drawing.Point(179, 288);
      this.lbl_province.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_province.Name = "lbl_province";
      this.lbl_province.Size = new System.Drawing.Size(86, 17);
      this.lbl_province.TabIndex = 5;
      this.lbl_province.Text = "Province :";
      this.lbl_province.Click += new System.EventHandler(this.label1_Click_3);
      // 
      // lbl_city
      // 
      this.lbl_city.AutoSize = true;
      this.lbl_city.BackColor = System.Drawing.Color.Transparent;
      this.lbl_city.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_city.ForeColor = System.Drawing.Color.Navy;
      this.lbl_city.Location = new System.Drawing.Point(221, 247);
      this.lbl_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_city.Name = "lbl_city";
      this.lbl_city.Size = new System.Drawing.Size(49, 17);
      this.lbl_city.TabIndex = 4;
      this.lbl_city.Text = "City :";
      // 
      // lbl_streetAddress
      // 
      this.lbl_streetAddress.AutoSize = true;
      this.lbl_streetAddress.BackColor = System.Drawing.Color.Transparent;
      this.lbl_streetAddress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_streetAddress.ForeColor = System.Drawing.Color.Navy;
      this.lbl_streetAddress.Location = new System.Drawing.Point(125, 206);
      this.lbl_streetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_streetAddress.Name = "lbl_streetAddress";
      this.lbl_streetAddress.Size = new System.Drawing.Size(134, 17);
      this.lbl_streetAddress.TabIndex = 3;
      this.lbl_streetAddress.Text = "Street Address :";
      this.lbl_streetAddress.Click += new System.EventHandler(this.lbl_streetAddress_Click);
      // 
      // lbl_lastName
      // 
      this.lbl_lastName.AutoSize = true;
      this.lbl_lastName.BackColor = System.Drawing.Color.Transparent;
      this.lbl_lastName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_lastName.ForeColor = System.Drawing.Color.Navy;
      this.lbl_lastName.Location = new System.Drawing.Point(164, 164);
      this.lbl_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_lastName.Name = "lbl_lastName";
      this.lbl_lastName.Size = new System.Drawing.Size(99, 17);
      this.lbl_lastName.TabIndex = 2;
      this.lbl_lastName.Text = "Last Name :";
      // 
      // lbl_firstName
      // 
      this.lbl_firstName.AutoSize = true;
      this.lbl_firstName.BackColor = System.Drawing.Color.Transparent;
      this.lbl_firstName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_firstName.ForeColor = System.Drawing.Color.Navy;
      this.lbl_firstName.Location = new System.Drawing.Point(160, 122);
      this.lbl_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_firstName.Name = "lbl_firstName";
      this.lbl_firstName.Size = new System.Drawing.Size(101, 17);
      this.lbl_firstName.TabIndex = 1;
      this.lbl_firstName.Text = "First Name :";
      // 
      // lbl_title
      // 
      this.lbl_title.AutoSize = true;
      this.lbl_title.BackColor = System.Drawing.Color.Transparent;
      this.lbl_title.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_title.ForeColor = System.Drawing.Color.Navy;
      this.lbl_title.Location = new System.Drawing.Point(216, 80);
      this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_title.Name = "lbl_title";
      this.lbl_title.Size = new System.Drawing.Size(52, 17);
      this.lbl_title.TabIndex = 0;
      this.lbl_title.Text = "Title :";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.gb_Folio);
      this.tabPage2.Location = new System.Drawing.Point(4, 26);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage2.Size = new System.Drawing.Size(1796, 359);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Folio";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
      // 
      // gb_Folio
      // 
      this.gb_Folio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
      this.gb_Folio.Controls.Add(this.groupBox2);
      this.gb_Folio.Controls.Add(this.dgv_folio);
      this.gb_Folio.Controls.Add(this.cb_folioCategry);
      this.gb_Folio.Controls.Add(this.btn_folioMove);
      this.gb_Folio.Controls.Add(this.btn_folioRefresh);
      this.gb_Folio.Controls.Add(this.btn_folioSelect);
      this.gb_Folio.Location = new System.Drawing.Point(0, 0);
      this.gb_Folio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_Folio.Name = "gb_Folio";
      this.gb_Folio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.gb_Folio.Size = new System.Drawing.Size(1793, 357);
      this.gb_Folio.TabIndex = 4;
      this.gb_Folio.TabStop = false;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rb_folioStay);
      this.groupBox2.Controls.Add(this.rb_folioNow);
      this.groupBox2.Controls.Add(this.label58);
      this.groupBox2.Controls.Add(this.label57);
      this.groupBox2.Controls.Add(this.label56);
      this.groupBox2.Controls.Add(this.label55);
      this.groupBox2.Controls.Add(this.label54);
      this.groupBox2.Controls.Add(this.label53);
      this.groupBox2.Controls.Add(this.label52);
      this.groupBox2.Controls.Add(this.label38);
      this.groupBox2.Location = new System.Drawing.Point(1528, 18);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Size = new System.Drawing.Size(255, 325);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Summary";
      // 
      // rb_folioStay
      // 
      this.rb_folioStay.AutoSize = true;
      this.rb_folioStay.Location = new System.Drawing.Point(149, 266);
      this.rb_folioStay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rb_folioStay.Name = "rb_folioStay";
      this.rb_folioStay.Size = new System.Drawing.Size(63, 21);
      this.rb_folioStay.TabIndex = 9;
      this.rb_folioStay.TabStop = true;
      this.rb_folioStay.Text = "Stay";
      this.rb_folioStay.UseVisualStyleBackColor = true;
      // 
      // rb_folioNow
      // 
      this.rb_folioNow.AutoSize = true;
      this.rb_folioNow.Location = new System.Drawing.Point(33, 266);
      this.rb_folioNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rb_folioNow.Name = "rb_folioNow";
      this.rb_folioNow.Size = new System.Drawing.Size(64, 21);
      this.rb_folioNow.TabIndex = 8;
      this.rb_folioNow.TabStop = true;
      this.rb_folioNow.Text = "Now";
      this.rb_folioNow.UseVisualStyleBackColor = true;
      // 
      // label58
      // 
      this.label58.AutoSize = true;
      this.label58.Location = new System.Drawing.Point(7, 52);
      this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label58.Name = "label58";
      this.label58.Size = new System.Drawing.Size(127, 17);
      this.label58.TabIndex = 7;
      this.label58.Text = "Other Charges:";
      // 
      // label57
      // 
      this.label57.AutoSize = true;
      this.label57.Location = new System.Drawing.Point(9, 76);
      this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label57.Name = "label57";
      this.label57.Size = new System.Drawing.Size(42, 17);
      this.label57.TabIndex = 6;
      this.label57.Text = "Tax:";
      // 
      // label56
      // 
      this.label56.AutoSize = true;
      this.label56.Location = new System.Drawing.Point(9, 100);
      this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label56.Name = "label56";
      this.label56.Size = new System.Drawing.Size(53, 17);
      this.label56.TabIndex = 5;
      this.label56.Text = "Total:";
      // 
      // label55
      // 
      this.label55.AutoSize = true;
      this.label55.Location = new System.Drawing.Point(9, 140);
      this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label55.Name = "label55";
      this.label55.Size = new System.Drawing.Size(69, 17);
      this.label55.TabIndex = 4;
      this.label55.Text = "Credits:";
      // 
      // label54
      // 
      this.label54.AutoSize = true;
      this.label54.Location = new System.Drawing.Point(12, 166);
      this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label54.Name = "label54";
      this.label54.Size = new System.Drawing.Size(74, 17);
      this.label54.TabIndex = 3;
      this.label54.Text = "Balance:";
      // 
      // label53
      // 
      this.label53.AutoSize = true;
      this.label53.Location = new System.Drawing.Point(12, 191);
      this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label53.Name = "label53";
      this.label53.Size = new System.Drawing.Size(103, 17);
      this.label53.TabIndex = 2;
      this.label53.Text = "Credit Limit:";
      // 
      // label52
      // 
      this.label52.AutoSize = true;
      this.label52.Location = new System.Drawing.Point(12, 215);
      this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label52.Name = "label52";
      this.label52.Size = new System.Drawing.Size(83, 17);
      this.label52.TabIndex = 1;
      this.label52.Text = "Available:";
      // 
      // label38
      // 
      this.label38.AutoSize = true;
      this.label38.Location = new System.Drawing.Point(8, 27);
      this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label38.Name = "label38";
      this.label38.Size = new System.Drawing.Size(120, 17);
      this.label38.TabIndex = 0;
      this.label38.Text = "Room Charge:";
      // 
      // dgv_folio
      // 
      this.dgv_folio.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
      this.dgv_folio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_folio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30});
      this.dgv_folio.Location = new System.Drawing.Point(12, 54);
      this.dgv_folio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_folio.Name = "dgv_folio";
      this.dgv_folio.RowHeadersWidth = 51;
      this.dgv_folio.Size = new System.Drawing.Size(1508, 289);
      this.dgv_folio.TabIndex = 4;
      // 
      // Column24
      // 
      this.Column24.HeaderText = "Date";
      this.Column24.MinimumWidth = 6;
      this.Column24.Name = "Column24";
      this.Column24.Width = 200;
      // 
      // Column25
      // 
      this.Column25.HeaderText = "TCode";
      this.Column25.MinimumWidth = 6;
      this.Column25.Name = "Column25";
      this.Column25.Width = 50;
      // 
      // Column26
      // 
      this.Column26.HeaderText = "Description";
      this.Column26.MinimumWidth = 6;
      this.Column26.Name = "Column26";
      this.Column26.Width = 250;
      // 
      // Column27
      // 
      this.Column27.HeaderText = "Amount";
      this.Column27.MinimumWidth = 6;
      this.Column27.Name = "Column27";
      this.Column27.Width = 150;
      // 
      // Column28
      // 
      this.Column28.HeaderText = "Tax";
      this.Column28.MinimumWidth = 6;
      this.Column28.Name = "Column28";
      this.Column28.Width = 50;
      // 
      // Column29
      // 
      this.Column29.HeaderText = "Total";
      this.Column29.MinimumWidth = 6;
      this.Column29.Name = "Column29";
      this.Column29.Width = 125;
      // 
      // Column30
      // 
      this.Column30.HeaderText = "Voucher";
      this.Column30.MinimumWidth = 6;
      this.Column30.Name = "Column30";
      this.Column30.Width = 200;
      // 
      // cb_folioCategry
      // 
      this.cb_folioCategry.ForeColor = System.Drawing.Color.Navy;
      this.cb_folioCategry.FormattingEnabled = true;
      this.cb_folioCategry.Location = new System.Drawing.Point(12, 21);
      this.cb_folioCategry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cb_folioCategry.Name = "cb_folioCategry";
      this.cb_folioCategry.Size = new System.Drawing.Size(233, 25);
      this.cb_folioCategry.TabIndex = 0;
      this.cb_folioCategry.Text = "All folios";
      // 
      // btn_folioMove
      // 
      this.btn_folioMove.ForeColor = System.Drawing.Color.Navy;
      this.btn_folioMove.Location = new System.Drawing.Point(503, 20);
      this.btn_folioMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btn_folioMove.Name = "btn_folioMove";
      this.btn_folioMove.Size = new System.Drawing.Size(100, 28);
      this.btn_folioMove.TabIndex = 3;
      this.btn_folioMove.Text = "Move";
      this.btn_folioMove.UseVisualStyleBackColor = true;
      // 
      // btn_folioRefresh
      // 
      this.btn_folioRefresh.ForeColor = System.Drawing.Color.Navy;
      this.btn_folioRefresh.Location = new System.Drawing.Point(265, 20);
      this.btn_folioRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btn_folioRefresh.Name = "btn_folioRefresh";
      this.btn_folioRefresh.Size = new System.Drawing.Size(100, 28);
      this.btn_folioRefresh.TabIndex = 1;
      this.btn_folioRefresh.Text = "Refresh";
      this.btn_folioRefresh.UseVisualStyleBackColor = true;
      // 
      // btn_folioSelect
      // 
      this.btn_folioSelect.ForeColor = System.Drawing.Color.Navy;
      this.btn_folioSelect.Location = new System.Drawing.Point(384, 20);
      this.btn_folioSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btn_folioSelect.Name = "btn_folioSelect";
      this.btn_folioSelect.Size = new System.Drawing.Size(100, 28);
      this.btn_folioSelect.TabIndex = 2;
      this.btn_folioSelect.Text = "Select";
      this.btn_folioSelect.UseVisualStyleBackColor = true;
      // 
      // panel_InHouse
      // 
      this.panel_InHouse.Controls.Add(this.label59);
      this.panel_InHouse.Controls.Add(this.pb_ImHouse_GuestFolio);
      this.panel_InHouse.Controls.Add(this.dgv_InHouse);
      this.panel_InHouse.Controls.Add(this.label8);
      this.panel_InHouse.Controls.Add(this.label7);
      this.panel_InHouse.Controls.Add(this.label6);
      this.panel_InHouse.Controls.Add(this.label5);
      this.panel_InHouse.Controls.Add(this.label4);
      this.panel_InHouse.Controls.Add(this.pb_InHouse_PostPayment);
      this.panel_InHouse.Controls.Add(this.pb_InHouse_PostCharges);
      this.panel_InHouse.Controls.Add(this.pb_InHouse_RegCard);
      this.panel_InHouse.Controls.Add(this.pb_InHouse_ChangeStay);
      this.panel_InHouse.Controls.Add(this.pb_InHouse_CheckOut);
      this.panel_InHouse.Controls.Add(this.label3);
      this.panel_InHouse.Controls.Add(this.pb_InHouse_Reservation);
      this.panel_InHouse.Controls.Add(this.label1);
      this.panel_InHouse.Controls.Add(this.pb_InHouse_NewBooking);
      this.panel_InHouse.Location = new System.Drawing.Point(0, 31);
      this.panel_InHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_InHouse.Name = "panel_InHouse";
      this.panel_InHouse.Size = new System.Drawing.Size(1533, 436);
      this.panel_InHouse.TabIndex = 60;
      // 
      // label59
      // 
      this.label59.AutoSize = true;
      this.label59.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label59.ForeColor = System.Drawing.Color.Navy;
      this.label59.Location = new System.Drawing.Point(604, 89);
      this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label59.Name = "label59";
      this.label59.Size = new System.Drawing.Size(81, 14);
      this.label59.TabIndex = 50;
      this.label59.Text = "Guest Folio";
      // 
      // pb_ImHouse_GuestFolio
      // 
      this.pb_ImHouse_GuestFolio.BackColor = System.Drawing.Color.Transparent;
      this.pb_ImHouse_GuestFolio.Location = new System.Drawing.Point(607, 10);
      this.pb_ImHouse_GuestFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_ImHouse_GuestFolio.Name = "pb_ImHouse_GuestFolio";
      this.pb_ImHouse_GuestFolio.Size = new System.Drawing.Size(85, 79);
      this.pb_ImHouse_GuestFolio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_ImHouse_GuestFolio.TabIndex = 51;
      this.pb_ImHouse_GuestFolio.TabStop = false;
      // 
      // dgv_InHouse
      // 
      this.dgv_InHouse.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_InHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_InHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21});
      this.dgv_InHouse.Location = new System.Drawing.Point(5, 121);
      this.dgv_InHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_InHouse.Name = "dgv_InHouse";
      this.dgv_InHouse.ReadOnly = true;
      this.dgv_InHouse.RowHeadersWidth = 51;
      this.dgv_InHouse.Size = new System.Drawing.Size(1527, 314);
      this.dgv_InHouse.TabIndex = 35;
      // 
      // Column11
      // 
      this.Column11.HeaderText = "Room No.";
      this.Column11.MinimumWidth = 6;
      this.Column11.Name = "Column11";
      this.Column11.ReadOnly = true;
      this.Column11.Width = 125;
      // 
      // Column12
      // 
      this.Column12.HeaderText = "Room Type";
      this.Column12.MinimumWidth = 6;
      this.Column12.Name = "Column12";
      this.Column12.ReadOnly = true;
      this.Column12.Width = 125;
      // 
      // Column13
      // 
      this.Column13.HeaderText = "Name";
      this.Column13.MinimumWidth = 6;
      this.Column13.Name = "Column13";
      this.Column13.ReadOnly = true;
      this.Column13.Width = 125;
      // 
      // Column14
      // 
      this.Column14.HeaderText = "Date In";
      this.Column14.MinimumWidth = 6;
      this.Column14.Name = "Column14";
      this.Column14.ReadOnly = true;
      this.Column14.Width = 125;
      // 
      // Column15
      // 
      this.Column15.HeaderText = "Date Out";
      this.Column15.MinimumWidth = 6;
      this.Column15.Name = "Column15";
      this.Column15.ReadOnly = true;
      this.Column15.Width = 125;
      // 
      // Column16
      // 
      this.Column16.HeaderText = "Stay";
      this.Column16.MinimumWidth = 6;
      this.Column16.Name = "Column16";
      this.Column16.ReadOnly = true;
      this.Column16.Width = 125;
      // 
      // Column17
      // 
      this.Column17.HeaderText = "ResID";
      this.Column17.MinimumWidth = 6;
      this.Column17.Name = "Column17";
      this.Column17.ReadOnly = true;
      this.Column17.Width = 125;
      // 
      // Column18
      // 
      this.Column18.HeaderText = "Rate";
      this.Column18.MinimumWidth = 6;
      this.Column18.Name = "Column18";
      this.Column18.ReadOnly = true;
      this.Column18.Width = 125;
      // 
      // Column19
      // 
      this.Column19.HeaderText = "Rate Code";
      this.Column19.MinimumWidth = 6;
      this.Column19.Name = "Column19";
      this.Column19.ReadOnly = true;
      this.Column19.Width = 125;
      // 
      // Column20
      // 
      this.Column20.HeaderText = "Adult";
      this.Column20.MinimumWidth = 6;
      this.Column20.Name = "Column20";
      this.Column20.ReadOnly = true;
      this.Column20.Width = 125;
      // 
      // Column21
      // 
      this.Column21.HeaderText = "Child";
      this.Column21.MinimumWidth = 6;
      this.Column21.Name = "Column21";
      this.Column21.ReadOnly = true;
      this.Column21.Width = 125;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.Navy;
      this.label8.Location = new System.Drawing.Point(845, 82);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(65, 28);
      this.label8.TabIndex = 34;
      this.label8.Text = "Post\r\nPayment";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.Navy;
      this.label7.Location = new System.Drawing.Point(715, 89);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(94, 14);
      this.label7.TabIndex = 33;
      this.label7.Text = "Post Charges";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Navy;
      this.label6.Location = new System.Drawing.Point(493, 89);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 14);
      this.label6.TabIndex = 32;
      this.label6.Text = "Reg Card";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Navy;
      this.label5.Location = new System.Drawing.Point(365, 90);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(90, 14);
      this.label5.TabIndex = 31;
      this.label5.Text = "Change Stay";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Navy;
      this.label4.Location = new System.Drawing.Point(260, 89);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 14);
      this.label4.TabIndex = 30;
      this.label4.Text = "Check Out";
      // 
      // pb_InHouse_PostPayment
      // 
      this.pb_InHouse_PostPayment.Location = new System.Drawing.Point(845, 15);
      this.pb_InHouse_PostPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_InHouse_PostPayment.Name = "pb_InHouse_PostPayment";
      this.pb_InHouse_PostPayment.Size = new System.Drawing.Size(75, 69);
      this.pb_InHouse_PostPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_InHouse_PostPayment.TabIndex = 29;
      this.pb_InHouse_PostPayment.TabStop = false;
      // 
      // pb_InHouse_PostCharges
      // 
      this.pb_InHouse_PostCharges.Location = new System.Drawing.Point(731, 15);
      this.pb_InHouse_PostCharges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_InHouse_PostCharges.Name = "pb_InHouse_PostCharges";
      this.pb_InHouse_PostCharges.Size = new System.Drawing.Size(75, 69);
      this.pb_InHouse_PostCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_InHouse_PostCharges.TabIndex = 28;
      this.pb_InHouse_PostCharges.TabStop = false;
      this.pb_InHouse_PostCharges.Click += new System.EventHandler(this.pictureBox6_Click);
      // 
      // pb_InHouse_RegCard
      // 
      this.pb_InHouse_RegCard.Location = new System.Drawing.Point(492, 15);
      this.pb_InHouse_RegCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_InHouse_RegCard.Name = "pb_InHouse_RegCard";
      this.pb_InHouse_RegCard.Size = new System.Drawing.Size(75, 69);
      this.pb_InHouse_RegCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_InHouse_RegCard.TabIndex = 27;
      this.pb_InHouse_RegCard.TabStop = false;
      // 
      // pb_InHouse_ChangeStay
      // 
      this.pb_InHouse_ChangeStay.Location = new System.Drawing.Point(377, 15);
      this.pb_InHouse_ChangeStay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_InHouse_ChangeStay.Name = "pb_InHouse_ChangeStay";
      this.pb_InHouse_ChangeStay.Size = new System.Drawing.Size(75, 69);
      this.pb_InHouse_ChangeStay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_InHouse_ChangeStay.TabIndex = 26;
      this.pb_InHouse_ChangeStay.TabStop = false;
      // 
      // pb_InHouse_CheckOut
      // 
      this.pb_InHouse_CheckOut.Location = new System.Drawing.Point(263, 15);
      this.pb_InHouse_CheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_InHouse_CheckOut.Name = "pb_InHouse_CheckOut";
      this.pb_InHouse_CheckOut.Size = new System.Drawing.Size(75, 69);
      this.pb_InHouse_CheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_InHouse_CheckOut.TabIndex = 25;
      this.pb_InHouse_CheckOut.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Navy;
      this.label3.Location = new System.Drawing.Point(135, 89);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 14);
      this.label3.TabIndex = 24;
      this.label3.Text = "Reservation";
      // 
      // pb_InHouse_Reservation
      // 
      this.pb_InHouse_Reservation.Location = new System.Drawing.Point(148, 15);
      this.pb_InHouse_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_InHouse_Reservation.Name = "pb_InHouse_Reservation";
      this.pb_InHouse_Reservation.Size = new System.Drawing.Size(75, 69);
      this.pb_InHouse_Reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_InHouse_Reservation.TabIndex = 23;
      this.pb_InHouse_Reservation.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Navy;
      this.label1.Location = new System.Drawing.Point(19, 89);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 14);
      this.label1.TabIndex = 22;
      this.label1.Text = "New Booking";
      // 
      // pb_InHouse_NewBooking
      // 
      this.pb_InHouse_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_InHouse_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_InHouse_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_InHouse_NewBooking.Name = "pb_InHouse_NewBooking";
      this.pb_InHouse_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_InHouse_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_InHouse_NewBooking.TabIndex = 22;
      this.pb_InHouse_NewBooking.TabStop = false;
      // 
      // panel_Arrivals
      // 
      this.panel_Arrivals.AccessibleName = "arrivals";
      this.panel_Arrivals.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.panel_Arrivals.AutoScroll = true;
      this.panel_Arrivals.Controls.Add(this.dgv_Arrival);
      this.panel_Arrivals.Controls.Add(this.label17);
      this.panel_Arrivals.Controls.Add(this.label16);
      this.panel_Arrivals.Controls.Add(this.label15);
      this.panel_Arrivals.Controls.Add(this.label14);
      this.panel_Arrivals.Controls.Add(this.label13);
      this.panel_Arrivals.Controls.Add(this.label12);
      this.panel_Arrivals.Controls.Add(this.label11);
      this.panel_Arrivals.Controls.Add(this.label10);
      this.panel_Arrivals.Controls.Add(this.label9);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_NewBooking);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_PostPayment);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_PostCharges);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_RegistrationCard);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_Confirmation);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_Cancel);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_ChangeReservation);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_CheckIn);
      this.panel_Arrivals.Controls.Add(this.pb_Arrivals_Reservation);
      this.panel_Arrivals.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.panel_Arrivals.Location = new System.Drawing.Point(0, 31);
      this.panel_Arrivals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_Arrivals.Name = "panel_Arrivals";
      this.panel_Arrivals.Size = new System.Drawing.Size(1533, 436);
      this.panel_Arrivals.TabIndex = 61;
      this.panel_Arrivals.Visible = false;
      this.panel_Arrivals.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Arrivals_Paint_1);
      // 
      // dgv_Arrival
      // 
      this.dgv_Arrival.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_Arrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Arrival.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
      this.dgv_Arrival.Location = new System.Drawing.Point(5, 121);
      this.dgv_Arrival.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_Arrival.Name = "dgv_Arrival";
      this.dgv_Arrival.ReadOnly = true;
      this.dgv_Arrival.RowHeadersWidth = 51;
      this.dgv_Arrival.Size = new System.Drawing.Size(1527, 314);
      this.dgv_Arrival.TabIndex = 54;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "Room No.";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 125;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Room Type";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 125;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "Name";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 125;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "Date In";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 125;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "Date Out";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 125;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.HeaderText = "ResID";
      this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      this.dataGridViewTextBoxColumn7.Width = 125;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.HeaderText = "Rate";
      this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Width = 125;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.HeaderText = "Rate Code";
      this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.ReadOnly = true;
      this.dataGridViewTextBoxColumn9.Width = 125;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.HeaderText = "Adult";
      this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.ReadOnly = true;
      this.dataGridViewTextBoxColumn10.Width = 125;
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.HeaderText = "Child";
      this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.ReadOnly = true;
      this.dataGridViewTextBoxColumn11.Width = 125;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.BackColor = System.Drawing.Color.Transparent;
      this.label17.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.ForeColor = System.Drawing.Color.Navy;
      this.label17.Location = new System.Drawing.Point(937, 89);
      this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(108, 16);
      this.label17.TabIndex = 43;
      this.label17.Text = "Post Payment";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.BackColor = System.Drawing.Color.Transparent;
      this.label16.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.ForeColor = System.Drawing.Color.Navy;
      this.label16.Location = new System.Drawing.Point(815, 89);
      this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(107, 16);
      this.label16.TabIndex = 42;
      this.label16.Text = "Post Charges ";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.BackColor = System.Drawing.Color.Transparent;
      this.label15.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.ForeColor = System.Drawing.Color.Navy;
      this.label15.Location = new System.Drawing.Point(693, 81);
      this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(95, 32);
      this.label15.TabIndex = 41;
      this.label15.Text = "Registration\r\nCard";
      this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.BackColor = System.Drawing.Color.Transparent;
      this.label14.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.ForeColor = System.Drawing.Color.Navy;
      this.label14.Location = new System.Drawing.Point(572, 89);
      this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(101, 16);
      this.label14.TabIndex = 40;
      this.label14.Text = "Confirmation";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.BackColor = System.Drawing.Color.Transparent;
      this.label13.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.ForeColor = System.Drawing.Color.Navy;
      this.label13.Location = new System.Drawing.Point(492, 89);
      this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(56, 16);
      this.label13.TabIndex = 39;
      this.label13.Text = "Cancel";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.BackColor = System.Drawing.Color.Transparent;
      this.label12.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.ForeColor = System.Drawing.Color.Navy;
      this.label12.Location = new System.Drawing.Point(355, 81);
      this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(94, 32);
      this.label12.TabIndex = 38;
      this.label12.Text = "Change\r\nReservation";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label12.Click += new System.EventHandler(this.label12_Click);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.BackColor = System.Drawing.Color.Transparent;
      this.label11.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.Color.Navy;
      this.label11.Location = new System.Drawing.Point(259, 89);
      this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(70, 16);
      this.label11.TabIndex = 37;
      this.label11.Text = "Check In";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.BackColor = System.Drawing.Color.Transparent;
      this.label10.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.ForeColor = System.Drawing.Color.Navy;
      this.label10.Location = new System.Drawing.Point(131, 89);
      this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(102, 16);
      this.label10.TabIndex = 36;
      this.label10.Text = "Reservations";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Transparent;
      this.label9.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ForeColor = System.Drawing.Color.Navy;
      this.label9.Location = new System.Drawing.Point(19, 89);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(100, 16);
      this.label9.TabIndex = 35;
      this.label9.Text = "New Booking";
      // 
      // pb_Arrivals_NewBooking
      // 
      this.pb_Arrivals_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_Arrivals_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_NewBooking.Name = "pb_Arrivals_NewBooking";
      this.pb_Arrivals_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_NewBooking.TabIndex = 46;
      this.pb_Arrivals_NewBooking.TabStop = false;
      // 
      // pb_Arrivals_PostPayment
      // 
      this.pb_Arrivals_PostPayment.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_PostPayment.Location = new System.Drawing.Point(957, 15);
      this.pb_Arrivals_PostPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_PostPayment.Name = "pb_Arrivals_PostPayment";
      this.pb_Arrivals_PostPayment.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_PostPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_PostPayment.TabIndex = 53;
      this.pb_Arrivals_PostPayment.TabStop = false;
      // 
      // pb_Arrivals_PostCharges
      // 
      this.pb_Arrivals_PostCharges.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_PostCharges.Location = new System.Drawing.Point(832, 15);
      this.pb_Arrivals_PostCharges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_PostCharges.Name = "pb_Arrivals_PostCharges";
      this.pb_Arrivals_PostCharges.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_PostCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_PostCharges.TabIndex = 52;
      this.pb_Arrivals_PostCharges.TabStop = false;
      // 
      // pb_Arrivals_RegistrationCard
      // 
      this.pb_Arrivals_RegistrationCard.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_RegistrationCard.Location = new System.Drawing.Point(705, 14);
      this.pb_Arrivals_RegistrationCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_RegistrationCard.Name = "pb_Arrivals_RegistrationCard";
      this.pb_Arrivals_RegistrationCard.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_RegistrationCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_RegistrationCard.TabIndex = 51;
      this.pb_Arrivals_RegistrationCard.TabStop = false;
      // 
      // pb_Arrivals_Confirmation
      // 
      this.pb_Arrivals_Confirmation.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_Confirmation.Location = new System.Drawing.Point(584, 9);
      this.pb_Arrivals_Confirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_Confirmation.Name = "pb_Arrivals_Confirmation";
      this.pb_Arrivals_Confirmation.Size = new System.Drawing.Size(85, 79);
      this.pb_Arrivals_Confirmation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_Confirmation.TabIndex = 50;
      this.pb_Arrivals_Confirmation.TabStop = false;
      // 
      // pb_Arrivals_Cancel
      // 
      this.pb_Arrivals_Cancel.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_Cancel.Location = new System.Drawing.Point(481, 15);
      this.pb_Arrivals_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_Cancel.Name = "pb_Arrivals_Cancel";
      this.pb_Arrivals_Cancel.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_Cancel.TabIndex = 49;
      this.pb_Arrivals_Cancel.TabStop = false;
      // 
      // pb_Arrivals_ChangeReservation
      // 
      this.pb_Arrivals_ChangeReservation.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_ChangeReservation.Location = new System.Drawing.Point(367, 15);
      this.pb_Arrivals_ChangeReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_ChangeReservation.Name = "pb_Arrivals_ChangeReservation";
      this.pb_Arrivals_ChangeReservation.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_ChangeReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_ChangeReservation.TabIndex = 48;
      this.pb_Arrivals_ChangeReservation.TabStop = false;
      // 
      // pb_Arrivals_CheckIn
      // 
      this.pb_Arrivals_CheckIn.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_CheckIn.Location = new System.Drawing.Point(257, 15);
      this.pb_Arrivals_CheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_CheckIn.Name = "pb_Arrivals_CheckIn";
      this.pb_Arrivals_CheckIn.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_CheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_CheckIn.TabIndex = 47;
      this.pb_Arrivals_CheckIn.TabStop = false;
      // 
      // pb_Arrivals_Reservation
      // 
      this.pb_Arrivals_Reservation.BackColor = System.Drawing.Color.Transparent;
      this.pb_Arrivals_Reservation.Location = new System.Drawing.Point(148, 15);
      this.pb_Arrivals_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Arrivals_Reservation.Name = "pb_Arrivals_Reservation";
      this.pb_Arrivals_Reservation.Size = new System.Drawing.Size(75, 69);
      this.pb_Arrivals_Reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Arrivals_Reservation.TabIndex = 45;
      this.pb_Arrivals_Reservation.TabStop = false;
      // 
      // panel_Departures
      // 
      this.panel_Departures.Controls.Add(this.label18);
      this.panel_Departures.Controls.Add(this.label19);
      this.panel_Departures.Controls.Add(this.label21);
      this.panel_Departures.Controls.Add(this.label22);
      this.panel_Departures.Controls.Add(this.label23);
      this.panel_Departures.Controls.Add(this.label24);
      this.panel_Departures.Controls.Add(this.label25);
      this.panel_Departures.Controls.Add(this.label26);
      this.panel_Departures.Controls.Add(this.pb_Departure_NewBooking);
      this.panel_Departures.Controls.Add(this.pb_Departures_PostPayment);
      this.panel_Departures.Controls.Add(this.pb_Departures_PostCharges);
      this.panel_Departures.Controls.Add(this.pb_Departures_GuestFolio);
      this.panel_Departures.Controls.Add(this.pb_Departures_RegistrationCard);
      this.panel_Departures.Controls.Add(this.pb_Departures_ChangeStay);
      this.panel_Departures.Controls.Add(this.pb_Departures_CheckOut);
      this.panel_Departures.Controls.Add(this.pb_Departures_Reservation);
      this.panel_Departures.Controls.Add(this.dgv_Departures);
      this.panel_Departures.Location = new System.Drawing.Point(0, 31);
      this.panel_Departures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_Departures.Name = "panel_Departures";
      this.panel_Departures.Size = new System.Drawing.Size(1533, 436);
      this.panel_Departures.TabIndex = 55;
      this.panel_Departures.Visible = false;
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.ForeColor = System.Drawing.Color.Navy;
      this.label18.Location = new System.Drawing.Point(832, 89);
      this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(98, 14);
      this.label18.TabIndex = 43;
      this.label18.Text = "Post Payment";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.ForeColor = System.Drawing.Color.Navy;
      this.label19.Location = new System.Drawing.Point(716, 89);
      this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(98, 14);
      this.label19.TabIndex = 42;
      this.label19.Text = "Post Charges ";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label21.ForeColor = System.Drawing.Color.Navy;
      this.label21.Location = new System.Drawing.Point(604, 89);
      this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(81, 14);
      this.label21.TabIndex = 40;
      this.label21.Text = "Guest Folio";
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label22.ForeColor = System.Drawing.Color.Navy;
      this.label22.Location = new System.Drawing.Point(479, 84);
      this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(87, 28);
      this.label22.TabIndex = 39;
      this.label22.Text = "Registration\r\nCard";
      this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label23.ForeColor = System.Drawing.Color.Navy;
      this.label23.Location = new System.Drawing.Point(363, 89);
      this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(90, 14);
      this.label23.TabIndex = 38;
      this.label23.Text = "Change Stay";
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label24.ForeColor = System.Drawing.Color.Navy;
      this.label24.Location = new System.Drawing.Point(259, 89);
      this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(75, 14);
      this.label24.TabIndex = 37;
      this.label24.Text = "Check Out";
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label25.ForeColor = System.Drawing.Color.Navy;
      this.label25.Location = new System.Drawing.Point(135, 89);
      this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(86, 14);
      this.label25.TabIndex = 36;
      this.label25.Text = "Reservation";
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label26.ForeColor = System.Drawing.Color.Navy;
      this.label26.Location = new System.Drawing.Point(17, 89);
      this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(94, 14);
      this.label26.TabIndex = 35;
      this.label26.Text = "New Booking";
      // 
      // pb_Departure_NewBooking
      // 
      this.pb_Departure_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departure_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_Departure_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departure_NewBooking.Name = "pb_Departure_NewBooking";
      this.pb_Departure_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_Departure_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departure_NewBooking.TabIndex = 46;
      this.pb_Departure_NewBooking.TabStop = false;
      // 
      // pb_Departures_PostPayment
      // 
      this.pb_Departures_PostPayment.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departures_PostPayment.Location = new System.Drawing.Point(851, 15);
      this.pb_Departures_PostPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departures_PostPayment.Name = "pb_Departures_PostPayment";
      this.pb_Departures_PostPayment.Size = new System.Drawing.Size(75, 69);
      this.pb_Departures_PostPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departures_PostPayment.TabIndex = 53;
      this.pb_Departures_PostPayment.TabStop = false;
      // 
      // pb_Departures_PostCharges
      // 
      this.pb_Departures_PostCharges.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departures_PostCharges.Location = new System.Drawing.Point(736, 15);
      this.pb_Departures_PostCharges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departures_PostCharges.Name = "pb_Departures_PostCharges";
      this.pb_Departures_PostCharges.Size = new System.Drawing.Size(75, 69);
      this.pb_Departures_PostCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departures_PostCharges.TabIndex = 52;
      this.pb_Departures_PostCharges.TabStop = false;
      // 
      // pb_Departures_GuestFolio
      // 
      this.pb_Departures_GuestFolio.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departures_GuestFolio.Location = new System.Drawing.Point(607, 10);
      this.pb_Departures_GuestFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departures_GuestFolio.Name = "pb_Departures_GuestFolio";
      this.pb_Departures_GuestFolio.Size = new System.Drawing.Size(85, 79);
      this.pb_Departures_GuestFolio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departures_GuestFolio.TabIndex = 50;
      this.pb_Departures_GuestFolio.TabStop = false;
      // 
      // pb_Departures_RegistrationCard
      // 
      this.pb_Departures_RegistrationCard.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departures_RegistrationCard.Location = new System.Drawing.Point(492, 15);
      this.pb_Departures_RegistrationCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departures_RegistrationCard.Name = "pb_Departures_RegistrationCard";
      this.pb_Departures_RegistrationCard.Size = new System.Drawing.Size(75, 69);
      this.pb_Departures_RegistrationCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departures_RegistrationCard.TabIndex = 49;
      this.pb_Departures_RegistrationCard.TabStop = false;
      // 
      // pb_Departures_ChangeStay
      // 
      this.pb_Departures_ChangeStay.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departures_ChangeStay.Location = new System.Drawing.Point(377, 15);
      this.pb_Departures_ChangeStay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departures_ChangeStay.Name = "pb_Departures_ChangeStay";
      this.pb_Departures_ChangeStay.Size = new System.Drawing.Size(75, 69);
      this.pb_Departures_ChangeStay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departures_ChangeStay.TabIndex = 48;
      this.pb_Departures_ChangeStay.TabStop = false;
      // 
      // pb_Departures_CheckOut
      // 
      this.pb_Departures_CheckOut.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departures_CheckOut.Location = new System.Drawing.Point(263, 15);
      this.pb_Departures_CheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departures_CheckOut.Name = "pb_Departures_CheckOut";
      this.pb_Departures_CheckOut.Size = new System.Drawing.Size(75, 69);
      this.pb_Departures_CheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departures_CheckOut.TabIndex = 47;
      this.pb_Departures_CheckOut.TabStop = false;
      // 
      // pb_Departures_Reservation
      // 
      this.pb_Departures_Reservation.BackColor = System.Drawing.Color.Transparent;
      this.pb_Departures_Reservation.Location = new System.Drawing.Point(148, 15);
      this.pb_Departures_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Departures_Reservation.Name = "pb_Departures_Reservation";
      this.pb_Departures_Reservation.Size = new System.Drawing.Size(75, 69);
      this.pb_Departures_Reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Departures_Reservation.TabIndex = 45;
      this.pb_Departures_Reservation.TabStop = false;
      // 
      // dgv_Departures
      // 
      this.dgv_Departures.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_Departures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Departures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.Column22,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
      this.dgv_Departures.Location = new System.Drawing.Point(5, 121);
      this.dgv_Departures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_Departures.Name = "dgv_Departures";
      this.dgv_Departures.ReadOnly = true;
      this.dgv_Departures.RowHeadersWidth = 51;
      this.dgv_Departures.Size = new System.Drawing.Size(1527, 314);
      this.dgv_Departures.TabIndex = 24;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.HeaderText = "Room No.";
      this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 125;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.HeaderText = "Room Type";
      this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.ReadOnly = true;
      this.dataGridViewTextBoxColumn12.Width = 125;
      // 
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.HeaderText = "Name";
      this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      this.dataGridViewTextBoxColumn13.ReadOnly = true;
      this.dataGridViewTextBoxColumn13.Width = 125;
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.HeaderText = "Date In";
      this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      this.dataGridViewTextBoxColumn14.ReadOnly = true;
      this.dataGridViewTextBoxColumn14.Width = 125;
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.HeaderText = "Date Out";
      this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      this.dataGridViewTextBoxColumn15.ReadOnly = true;
      this.dataGridViewTextBoxColumn15.Width = 125;
      // 
      // Column22
      // 
      this.Column22.HeaderText = "Stay";
      this.Column22.MinimumWidth = 6;
      this.Column22.Name = "Column22";
      this.Column22.ReadOnly = true;
      this.Column22.Width = 125;
      // 
      // dataGridViewTextBoxColumn16
      // 
      this.dataGridViewTextBoxColumn16.HeaderText = "ResID";
      this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
      this.dataGridViewTextBoxColumn16.ReadOnly = true;
      this.dataGridViewTextBoxColumn16.Width = 125;
      // 
      // dataGridViewTextBoxColumn17
      // 
      this.dataGridViewTextBoxColumn17.HeaderText = "Rate";
      this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
      this.dataGridViewTextBoxColumn17.ReadOnly = true;
      this.dataGridViewTextBoxColumn17.Width = 125;
      // 
      // dataGridViewTextBoxColumn18
      // 
      this.dataGridViewTextBoxColumn18.HeaderText = "Rate Code";
      this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
      this.dataGridViewTextBoxColumn18.ReadOnly = true;
      this.dataGridViewTextBoxColumn18.Width = 125;
      // 
      // dataGridViewTextBoxColumn19
      // 
      this.dataGridViewTextBoxColumn19.HeaderText = "Adult";
      this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
      this.dataGridViewTextBoxColumn19.ReadOnly = true;
      this.dataGridViewTextBoxColumn19.Width = 125;
      // 
      // dataGridViewTextBoxColumn20
      // 
      this.dataGridViewTextBoxColumn20.HeaderText = "Child";
      this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
      this.dataGridViewTextBoxColumn20.ReadOnly = true;
      this.dataGridViewTextBoxColumn20.Width = 125;
      // 
      // lbl_user
      // 
      this.lbl_user.AutoSize = true;
      this.lbl_user.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_user.Location = new System.Drawing.Point(21, 886);
      this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_user.Name = "lbl_user";
      this.lbl_user.Size = new System.Drawing.Size(100, 17);
      this.lbl_user.TabIndex = 18;
      this.lbl_user.Text = "<Username>";
      // 
      // lbl_dateTime
      // 
      this.lbl_dateTime.AutoSize = true;
      this.lbl_dateTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_dateTime.Location = new System.Drawing.Point(379, 886);
      this.lbl_dateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_dateTime.Name = "lbl_dateTime";
      this.lbl_dateTime.Size = new System.Drawing.Size(132, 17);
      this.lbl_dateTime.TabIndex = 19;
      this.lbl_dateTime.Text = "<Date and Time>";
      // 
      // panel_frontDesk
      // 
      this.panel_frontDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
      this.panel_frontDesk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel_frontDesk.Controls.Add(this.pb_HideIcon);
      this.panel_frontDesk.Controls.Add(this.pb_CloseIcon);
      this.panel_frontDesk.Controls.Add(this.pictureBox51);
      this.panel_frontDesk.Controls.Add(this.lbl_dateTime);
      this.panel_frontDesk.Controls.Add(this.lbl_user);
      this.panel_frontDesk.Controls.Add(this.tab_guestInfo);
      this.panel_frontDesk.Controls.Add(this.gb_frontDesk1);
      this.panel_frontDesk.Controls.Add(this.Ms_NoteView);
      this.panel_frontDesk.Controls.Add(this.panel_Arrivals);
      this.panel_frontDesk.Controls.Add(this.panel_InHouse);
      this.panel_frontDesk.Controls.Add(this.panel_CheckedOut);
      this.panel_frontDesk.Controls.Add(this.panel_Departures);
      this.panel_frontDesk.Controls.Add(this.panel_Cancelled);
      this.panel_frontDesk.Controls.Add(this.panel_noShows);
      this.panel_frontDesk.Controls.Add(this.panel_WaitList);
      this.panel_frontDesk.Controls.Add(this.panel_Reservation);
      this.panel_frontDesk.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_frontDesk.Location = new System.Drawing.Point(0, 0);
      this.panel_frontDesk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_frontDesk.Name = "panel_frontDesk";
      this.panel_frontDesk.Size = new System.Drawing.Size(1824, 896);
      this.panel_frontDesk.TabIndex = 0;
      this.panel_frontDesk.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // pb_HideIcon
      // 
      this.pb_HideIcon.BackColor = System.Drawing.Color.White;
      this.pb_HideIcon.Cursor = System.Windows.Forms.Cursors.Default;
      this.pb_HideIcon.Location = new System.Drawing.Point(1752, 2);
      this.pb_HideIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_HideIcon.Name = "pb_HideIcon";
      this.pb_HideIcon.Size = new System.Drawing.Size(27, 25);
      this.pb_HideIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_HideIcon.TabIndex = 65;
      this.pb_HideIcon.TabStop = false;
      this.pb_HideIcon.Click += new System.EventHandler(this.pb_HideIcon_Click);
      // 
      // pb_CloseIcon
      // 
      this.pb_CloseIcon.BackColor = System.Drawing.Color.White;
      this.pb_CloseIcon.Location = new System.Drawing.Point(1791, 2);
      this.pb_CloseIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_CloseIcon.Name = "pb_CloseIcon";
      this.pb_CloseIcon.Size = new System.Drawing.Size(27, 25);
      this.pb_CloseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_CloseIcon.TabIndex = 64;
      this.pb_CloseIcon.TabStop = false;
      this.pb_CloseIcon.Click += new System.EventHandler(this.pb_CloseIcon_Click);
      // 
      // pictureBox51
      // 
      this.pictureBox51.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox51.Image = global::NoteView.Properties.Resources.noteview_superlabel;
      this.pictureBox51.Location = new System.Drawing.Point(1476, 48);
      this.pictureBox51.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pictureBox51.Name = "pictureBox51";
      this.pictureBox51.Size = new System.Drawing.Size(333, 86);
      this.pictureBox51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox51.TabIndex = 63;
      this.pictureBox51.TabStop = false;
      // 
      // panel_CheckedOut
      // 
      this.panel_CheckedOut.Controls.Add(this.dgv_CheckedOut);
      this.panel_CheckedOut.Controls.Add(this.label28);
      this.panel_CheckedOut.Controls.Add(this.label29);
      this.panel_CheckedOut.Controls.Add(this.label30);
      this.panel_CheckedOut.Controls.Add(this.label31);
      this.panel_CheckedOut.Controls.Add(this.label32);
      this.panel_CheckedOut.Controls.Add(this.label33);
      this.panel_CheckedOut.Controls.Add(this.label34);
      this.panel_CheckedOut.Controls.Add(this.pb_CheckedOut_NewBooking);
      this.panel_CheckedOut.Controls.Add(this.pb_Checked_PostPayment);
      this.panel_CheckedOut.Controls.Add(this.pb_CheckedOut_GuestFolio);
      this.panel_CheckedOut.Controls.Add(this.pb_ChekedOut_RegisterCard);
      this.panel_CheckedOut.Controls.Add(this.pb_CheckedOut_Reinstate);
      this.panel_CheckedOut.Controls.Add(this.pb_CheckedOut_Reservation);
      this.panel_CheckedOut.Controls.Add(this.pb_CheckedOut_PostCharges);
      this.panel_CheckedOut.Location = new System.Drawing.Point(0, 31);
      this.panel_CheckedOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_CheckedOut.Name = "panel_CheckedOut";
      this.panel_CheckedOut.Size = new System.Drawing.Size(1533, 436);
      this.panel_CheckedOut.TabIndex = 62;
      this.panel_CheckedOut.Visible = false;
      // 
      // dgv_CheckedOut
      // 
      this.dgv_CheckedOut.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_CheckedOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_CheckedOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.Column23,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31});
      this.dgv_CheckedOut.Location = new System.Drawing.Point(5, 121);
      this.dgv_CheckedOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_CheckedOut.Name = "dgv_CheckedOut";
      this.dgv_CheckedOut.ReadOnly = true;
      this.dgv_CheckedOut.RowHeadersWidth = 51;
      this.dgv_CheckedOut.Size = new System.Drawing.Size(1527, 314);
      this.dgv_CheckedOut.TabIndex = 58;
      // 
      // dataGridViewTextBoxColumn21
      // 
      this.dataGridViewTextBoxColumn21.HeaderText = "Room No.";
      this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
      this.dataGridViewTextBoxColumn21.ReadOnly = true;
      this.dataGridViewTextBoxColumn21.Width = 125;
      // 
      // dataGridViewTextBoxColumn22
      // 
      this.dataGridViewTextBoxColumn22.HeaderText = "Room Type";
      this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
      this.dataGridViewTextBoxColumn22.ReadOnly = true;
      this.dataGridViewTextBoxColumn22.Width = 125;
      // 
      // dataGridViewTextBoxColumn23
      // 
      this.dataGridViewTextBoxColumn23.HeaderText = "Name";
      this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
      this.dataGridViewTextBoxColumn23.ReadOnly = true;
      this.dataGridViewTextBoxColumn23.Width = 125;
      // 
      // dataGridViewTextBoxColumn24
      // 
      this.dataGridViewTextBoxColumn24.HeaderText = "Date In";
      this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
      this.dataGridViewTextBoxColumn24.ReadOnly = true;
      this.dataGridViewTextBoxColumn24.Width = 125;
      // 
      // dataGridViewTextBoxColumn25
      // 
      this.dataGridViewTextBoxColumn25.HeaderText = "Date Out";
      this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
      this.dataGridViewTextBoxColumn25.ReadOnly = true;
      this.dataGridViewTextBoxColumn25.Width = 125;
      // 
      // Column23
      // 
      this.Column23.HeaderText = "Stay";
      this.Column23.MinimumWidth = 6;
      this.Column23.Name = "Column23";
      this.Column23.ReadOnly = true;
      this.Column23.Width = 125;
      // 
      // dataGridViewTextBoxColumn27
      // 
      this.dataGridViewTextBoxColumn27.HeaderText = "ResID";
      this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
      this.dataGridViewTextBoxColumn27.ReadOnly = true;
      this.dataGridViewTextBoxColumn27.Width = 125;
      // 
      // dataGridViewTextBoxColumn28
      // 
      this.dataGridViewTextBoxColumn28.HeaderText = "Rate";
      this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
      this.dataGridViewTextBoxColumn28.ReadOnly = true;
      this.dataGridViewTextBoxColumn28.Width = 125;
      // 
      // dataGridViewTextBoxColumn29
      // 
      this.dataGridViewTextBoxColumn29.HeaderText = "Rate Code";
      this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
      this.dataGridViewTextBoxColumn29.ReadOnly = true;
      this.dataGridViewTextBoxColumn29.Width = 125;
      // 
      // dataGridViewTextBoxColumn30
      // 
      this.dataGridViewTextBoxColumn30.HeaderText = "Adult";
      this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
      this.dataGridViewTextBoxColumn30.ReadOnly = true;
      this.dataGridViewTextBoxColumn30.Width = 125;
      // 
      // dataGridViewTextBoxColumn31
      // 
      this.dataGridViewTextBoxColumn31.HeaderText = "Child";
      this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
      this.dataGridViewTextBoxColumn31.ReadOnly = true;
      this.dataGridViewTextBoxColumn31.Width = 125;
      // 
      // label28
      // 
      this.label28.AutoSize = true;
      this.label28.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label28.ForeColor = System.Drawing.Color.Navy;
      this.label28.Location = new System.Drawing.Point(713, 89);
      this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(98, 14);
      this.label28.TabIndex = 41;
      this.label28.Text = "Post Payment";
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label29.ForeColor = System.Drawing.Color.Navy;
      this.label29.Location = new System.Drawing.Point(600, 89);
      this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(94, 14);
      this.label29.TabIndex = 40;
      this.label29.Text = "Post Charges";
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label30.ForeColor = System.Drawing.Color.Navy;
      this.label30.Location = new System.Drawing.Point(489, 89);
      this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size(81, 14);
      this.label30.TabIndex = 39;
      this.label30.Text = "Guest Folio";
      // 
      // label31
      // 
      this.label31.AutoSize = true;
      this.label31.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label31.ForeColor = System.Drawing.Color.Navy;
      this.label31.Location = new System.Drawing.Point(360, 89);
      this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label31.Name = "label31";
      this.label31.Size = new System.Drawing.Size(97, 14);
      this.label31.TabIndex = 38;
      this.label31.Text = "Register Card";
      // 
      // label32
      // 
      this.label32.AutoSize = true;
      this.label32.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label32.ForeColor = System.Drawing.Color.Navy;
      this.label32.Location = new System.Drawing.Point(260, 89);
      this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label32.Name = "label32";
      this.label32.Size = new System.Drawing.Size(69, 14);
      this.label32.TabIndex = 37;
      this.label32.Text = "Reinstate";
      // 
      // label33
      // 
      this.label33.AutoSize = true;
      this.label33.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label33.ForeColor = System.Drawing.Color.Navy;
      this.label33.Location = new System.Drawing.Point(135, 89);
      this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size(86, 14);
      this.label33.TabIndex = 36;
      this.label33.Text = "Reservation";
      // 
      // label34
      // 
      this.label34.AutoSize = true;
      this.label34.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label34.ForeColor = System.Drawing.Color.Navy;
      this.label34.Location = new System.Drawing.Point(17, 89);
      this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label34.Name = "label34";
      this.label34.Size = new System.Drawing.Size(94, 14);
      this.label34.TabIndex = 35;
      this.label34.Text = "New Booking";
      // 
      // pb_CheckedOut_NewBooking
      // 
      this.pb_CheckedOut_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_CheckedOut_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_CheckedOut_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_CheckedOut_NewBooking.Name = "pb_CheckedOut_NewBooking";
      this.pb_CheckedOut_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_CheckedOut_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_CheckedOut_NewBooking.TabIndex = 46;
      this.pb_CheckedOut_NewBooking.TabStop = false;
      // 
      // pb_Checked_PostPayment
      // 
      this.pb_Checked_PostPayment.BackColor = System.Drawing.Color.Transparent;
      this.pb_Checked_PostPayment.Location = new System.Drawing.Point(731, 15);
      this.pb_Checked_PostPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Checked_PostPayment.Name = "pb_Checked_PostPayment";
      this.pb_Checked_PostPayment.Size = new System.Drawing.Size(75, 69);
      this.pb_Checked_PostPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Checked_PostPayment.TabIndex = 51;
      this.pb_Checked_PostPayment.TabStop = false;
      // 
      // pb_CheckedOut_GuestFolio
      // 
      this.pb_CheckedOut_GuestFolio.BackColor = System.Drawing.Color.Transparent;
      this.pb_CheckedOut_GuestFolio.Location = new System.Drawing.Point(492, 10);
      this.pb_CheckedOut_GuestFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_CheckedOut_GuestFolio.Name = "pb_CheckedOut_GuestFolio";
      this.pb_CheckedOut_GuestFolio.Size = new System.Drawing.Size(85, 79);
      this.pb_CheckedOut_GuestFolio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_CheckedOut_GuestFolio.TabIndex = 49;
      this.pb_CheckedOut_GuestFolio.TabStop = false;
      this.pb_CheckedOut_GuestFolio.Click += new System.EventHandler(this.pb_CheckedOut_GuestFolio_Click);
      // 
      // pb_ChekedOut_RegisterCard
      // 
      this.pb_ChekedOut_RegisterCard.BackColor = System.Drawing.Color.Transparent;
      this.pb_ChekedOut_RegisterCard.Location = new System.Drawing.Point(377, 15);
      this.pb_ChekedOut_RegisterCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_ChekedOut_RegisterCard.Name = "pb_ChekedOut_RegisterCard";
      this.pb_ChekedOut_RegisterCard.Size = new System.Drawing.Size(75, 69);
      this.pb_ChekedOut_RegisterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_ChekedOut_RegisterCard.TabIndex = 48;
      this.pb_ChekedOut_RegisterCard.TabStop = false;
      // 
      // pb_CheckedOut_Reinstate
      // 
      this.pb_CheckedOut_Reinstate.BackColor = System.Drawing.Color.Transparent;
      this.pb_CheckedOut_Reinstate.Location = new System.Drawing.Point(263, 15);
      this.pb_CheckedOut_Reinstate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_CheckedOut_Reinstate.Name = "pb_CheckedOut_Reinstate";
      this.pb_CheckedOut_Reinstate.Size = new System.Drawing.Size(75, 69);
      this.pb_CheckedOut_Reinstate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_CheckedOut_Reinstate.TabIndex = 47;
      this.pb_CheckedOut_Reinstate.TabStop = false;
      // 
      // pb_CheckedOut_Reservation
      // 
      this.pb_CheckedOut_Reservation.BackColor = System.Drawing.Color.Transparent;
      this.pb_CheckedOut_Reservation.Location = new System.Drawing.Point(148, 15);
      this.pb_CheckedOut_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_CheckedOut_Reservation.Name = "pb_CheckedOut_Reservation";
      this.pb_CheckedOut_Reservation.Size = new System.Drawing.Size(75, 69);
      this.pb_CheckedOut_Reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_CheckedOut_Reservation.TabIndex = 45;
      this.pb_CheckedOut_Reservation.TabStop = false;
      // 
      // pb_CheckedOut_PostCharges
      // 
      this.pb_CheckedOut_PostCharges.BackColor = System.Drawing.Color.Transparent;
      this.pb_CheckedOut_PostCharges.Location = new System.Drawing.Point(616, 15);
      this.pb_CheckedOut_PostCharges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_CheckedOut_PostCharges.Name = "pb_CheckedOut_PostCharges";
      this.pb_CheckedOut_PostCharges.Size = new System.Drawing.Size(75, 69);
      this.pb_CheckedOut_PostCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_CheckedOut_PostCharges.TabIndex = 52;
      this.pb_CheckedOut_PostCharges.TabStop = false;
      // 
      // panel_Cancelled
      // 
      this.panel_Cancelled.AccessibleName = "ReservationPanel";
      this.panel_Cancelled.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.panel_Cancelled.Controls.Add(this.label51);
      this.panel_Cancelled.Controls.Add(this.pb_Cancelled_Confirmation);
      this.panel_Cancelled.Controls.Add(this.label50);
      this.panel_Cancelled.Controls.Add(this.pb_Cancelled_PostPayment);
      this.panel_Cancelled.Controls.Add(this.label49);
      this.panel_Cancelled.Controls.Add(this.pb_Cancelled_PostC);
      this.panel_Cancelled.Controls.Add(this.label37);
      this.panel_Cancelled.Controls.Add(this.label39);
      this.panel_Cancelled.Controls.Add(this.label40);
      this.panel_Cancelled.Controls.Add(this.pb_Cancelled_NewBooking);
      this.panel_Cancelled.Controls.Add(this.dgv_Cancelled);
      this.panel_Cancelled.Controls.Add(this.pb_Cancelled_Reservation);
      this.panel_Cancelled.Controls.Add(this.pb_Cancelled_GuestFolio);
      this.panel_Cancelled.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.panel_Cancelled.Location = new System.Drawing.Point(0, 31);
      this.panel_Cancelled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_Cancelled.Name = "panel_Cancelled";
      this.panel_Cancelled.Size = new System.Drawing.Size(1533, 436);
      this.panel_Cancelled.TabIndex = 58;
      this.panel_Cancelled.Visible = false;
      this.panel_Cancelled.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Cancelled_Paint);
      // 
      // label51
      // 
      this.label51.AutoSize = true;
      this.label51.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label51.ForeColor = System.Drawing.Color.Navy;
      this.label51.Location = new System.Drawing.Point(243, 89);
      this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label51.Name = "label51";
      this.label51.Size = new System.Drawing.Size(92, 14);
      this.label51.TabIndex = 39;
      this.label51.Text = "Confirmation";
      // 
      // pb_Cancelled_Confirmation
      // 
      this.pb_Cancelled_Confirmation.Location = new System.Drawing.Point(251, 12);
      this.pb_Cancelled_Confirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Cancelled_Confirmation.Name = "pb_Cancelled_Confirmation";
      this.pb_Cancelled_Confirmation.Size = new System.Drawing.Size(85, 79);
      this.pb_Cancelled_Confirmation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Cancelled_Confirmation.TabIndex = 38;
      this.pb_Cancelled_Confirmation.TabStop = false;
      // 
      // label50
      // 
      this.label50.AutoSize = true;
      this.label50.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label50.ForeColor = System.Drawing.Color.Navy;
      this.label50.Location = new System.Drawing.Point(579, 89);
      this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label50.Name = "label50";
      this.label50.Size = new System.Drawing.Size(98, 14);
      this.label50.TabIndex = 37;
      this.label50.Text = "Post Payment";
      // 
      // pb_Cancelled_PostPayment
      // 
      this.pb_Cancelled_PostPayment.Location = new System.Drawing.Point(597, 15);
      this.pb_Cancelled_PostPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Cancelled_PostPayment.Name = "pb_Cancelled_PostPayment";
      this.pb_Cancelled_PostPayment.Size = new System.Drawing.Size(75, 69);
      this.pb_Cancelled_PostPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Cancelled_PostPayment.TabIndex = 36;
      this.pb_Cancelled_PostPayment.TabStop = false;
      // 
      // label49
      // 
      this.label49.AutoSize = true;
      this.label49.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label49.ForeColor = System.Drawing.Color.Navy;
      this.label49.Location = new System.Drawing.Point(467, 89);
      this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label49.Name = "label49";
      this.label49.Size = new System.Drawing.Size(94, 14);
      this.label49.TabIndex = 35;
      this.label49.Text = "Post Charges";
      // 
      // pb_Cancelled_PostC
      // 
      this.pb_Cancelled_PostC.Location = new System.Drawing.Point(483, 15);
      this.pb_Cancelled_PostC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Cancelled_PostC.Name = "pb_Cancelled_PostC";
      this.pb_Cancelled_PostC.Size = new System.Drawing.Size(75, 69);
      this.pb_Cancelled_PostC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Cancelled_PostC.TabIndex = 34;
      this.pb_Cancelled_PostC.TabStop = false;
      // 
      // label37
      // 
      this.label37.AutoSize = true;
      this.label37.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label37.ForeColor = System.Drawing.Color.Navy;
      this.label37.Location = new System.Drawing.Point(356, 89);
      this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label37.Name = "label37";
      this.label37.Size = new System.Drawing.Size(81, 14);
      this.label37.TabIndex = 14;
      this.label37.Text = "Guest Folio";
      // 
      // label39
      // 
      this.label39.AutoSize = true;
      this.label39.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label39.ForeColor = System.Drawing.Color.Navy;
      this.label39.Location = new System.Drawing.Point(136, 89);
      this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label39.Name = "label39";
      this.label39.Size = new System.Drawing.Size(86, 14);
      this.label39.TabIndex = 12;
      this.label39.Text = "Reservation";
      // 
      // label40
      // 
      this.label40.AutoSize = true;
      this.label40.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label40.ForeColor = System.Drawing.Color.Navy;
      this.label40.Location = new System.Drawing.Point(20, 89);
      this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label40.Name = "label40";
      this.label40.Size = new System.Drawing.Size(94, 14);
      this.label40.TabIndex = 11;
      this.label40.Text = "New Booking";
      // 
      // pb_Cancelled_NewBooking
      // 
      this.pb_Cancelled_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_Cancelled_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_Cancelled_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Cancelled_NewBooking.Name = "pb_Cancelled_NewBooking";
      this.pb_Cancelled_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_Cancelled_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Cancelled_NewBooking.TabIndex = 0;
      this.pb_Cancelled_NewBooking.TabStop = false;
      // 
      // dgv_Cancelled
      // 
      this.dgv_Cancelled.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_Cancelled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Cancelled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn47});
      this.dgv_Cancelled.Location = new System.Drawing.Point(5, 121);
      this.dgv_Cancelled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_Cancelled.Name = "dgv_Cancelled";
      this.dgv_Cancelled.ReadOnly = true;
      this.dgv_Cancelled.RowHeadersWidth = 51;
      this.dgv_Cancelled.Size = new System.Drawing.Size(1527, 314);
      this.dgv_Cancelled.TabIndex = 10;
      // 
      // dataGridViewTextBoxColumn41
      // 
      this.dataGridViewTextBoxColumn41.HeaderText = "Room Type";
      this.dataGridViewTextBoxColumn41.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
      this.dataGridViewTextBoxColumn41.ReadOnly = true;
      this.dataGridViewTextBoxColumn41.Width = 150;
      // 
      // dataGridViewTextBoxColumn42
      // 
      this.dataGridViewTextBoxColumn42.HeaderText = "Name";
      this.dataGridViewTextBoxColumn42.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
      this.dataGridViewTextBoxColumn42.ReadOnly = true;
      this.dataGridViewTextBoxColumn42.Width = 150;
      // 
      // dataGridViewTextBoxColumn43
      // 
      this.dataGridViewTextBoxColumn43.HeaderText = "Date In";
      this.dataGridViewTextBoxColumn43.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
      this.dataGridViewTextBoxColumn43.ReadOnly = true;
      this.dataGridViewTextBoxColumn43.Width = 80;
      // 
      // dataGridViewTextBoxColumn44
      // 
      this.dataGridViewTextBoxColumn44.HeaderText = "Date Out";
      this.dataGridViewTextBoxColumn44.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
      this.dataGridViewTextBoxColumn44.ReadOnly = true;
      this.dataGridViewTextBoxColumn44.Width = 80;
      // 
      // dataGridViewTextBoxColumn45
      // 
      this.dataGridViewTextBoxColumn45.HeaderText = "ResId";
      this.dataGridViewTextBoxColumn45.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
      this.dataGridViewTextBoxColumn45.ReadOnly = true;
      this.dataGridViewTextBoxColumn45.Width = 150;
      // 
      // dataGridViewTextBoxColumn46
      // 
      this.dataGridViewTextBoxColumn46.HeaderText = "Rate";
      this.dataGridViewTextBoxColumn46.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
      this.dataGridViewTextBoxColumn46.ReadOnly = true;
      this.dataGridViewTextBoxColumn46.Width = 125;
      // 
      // dataGridViewTextBoxColumn48
      // 
      this.dataGridViewTextBoxColumn48.HeaderText = "Adult";
      this.dataGridViewTextBoxColumn48.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
      this.dataGridViewTextBoxColumn48.ReadOnly = true;
      this.dataGridViewTextBoxColumn48.Width = 125;
      // 
      // dataGridViewTextBoxColumn49
      // 
      this.dataGridViewTextBoxColumn49.HeaderText = "Child";
      this.dataGridViewTextBoxColumn49.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
      this.dataGridViewTextBoxColumn49.ReadOnly = true;
      this.dataGridViewTextBoxColumn49.Width = 125;
      // 
      // dataGridViewTextBoxColumn50
      // 
      this.dataGridViewTextBoxColumn50.HeaderText = "Cancel#";
      this.dataGridViewTextBoxColumn50.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
      this.dataGridViewTextBoxColumn50.ReadOnly = true;
      this.dataGridViewTextBoxColumn50.Width = 125;
      // 
      // dataGridViewTextBoxColumn47
      // 
      this.dataGridViewTextBoxColumn47.HeaderText = "Rate Code";
      this.dataGridViewTextBoxColumn47.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
      this.dataGridViewTextBoxColumn47.ReadOnly = true;
      this.dataGridViewTextBoxColumn47.Width = 150;
      // 
      // pb_Cancelled_Reservation
      // 
      this.pb_Cancelled_Reservation.Location = new System.Drawing.Point(148, 15);
      this.pb_Cancelled_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Cancelled_Reservation.Name = "pb_Cancelled_Reservation";
      this.pb_Cancelled_Reservation.Size = new System.Drawing.Size(75, 69);
      this.pb_Cancelled_Reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Cancelled_Reservation.TabIndex = 2;
      this.pb_Cancelled_Reservation.TabStop = false;
      // 
      // pb_Cancelled_GuestFolio
      // 
      this.pb_Cancelled_GuestFolio.Location = new System.Drawing.Point(359, 10);
      this.pb_Cancelled_GuestFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Cancelled_GuestFolio.Name = "pb_Cancelled_GuestFolio";
      this.pb_Cancelled_GuestFolio.Size = new System.Drawing.Size(85, 79);
      this.pb_Cancelled_GuestFolio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Cancelled_GuestFolio.TabIndex = 6;
      this.pb_Cancelled_GuestFolio.TabStop = false;
      // 
      // panel_noShows
      // 
      this.panel_noShows.AccessibleName = "ReservationPanel";
      this.panel_noShows.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.panel_noShows.Controls.Add(this.label46);
      this.panel_noShows.Controls.Add(this.label48);
      this.panel_noShows.Controls.Add(this.pb_NoShows_PostPayment);
      this.panel_noShows.Controls.Add(this.pb_NoShows_PostCharges);
      this.panel_noShows.Controls.Add(this.label20);
      this.panel_noShows.Controls.Add(this.pb_NoShows_Cancel);
      this.panel_noShows.Controls.Add(this.label45);
      this.panel_noShows.Controls.Add(this.pb_NoShows_ChangeReservation);
      this.panel_noShows.Controls.Add(this.label27);
      this.panel_noShows.Controls.Add(this.label35);
      this.panel_noShows.Controls.Add(this.label36);
      this.panel_noShows.Controls.Add(this.pb_NoShows_NewBooking);
      this.panel_noShows.Controls.Add(this.pb_NoShows_Reservation);
      this.panel_noShows.Controls.Add(this.pb_NoShows_CheckIn);
      this.panel_noShows.Controls.Add(this.dgv_NoShows);
      this.panel_noShows.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.panel_noShows.Location = new System.Drawing.Point(0, 31);
      this.panel_noShows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_noShows.Name = "panel_noShows";
      this.panel_noShows.Size = new System.Drawing.Size(1533, 436);
      this.panel_noShows.TabIndex = 57;
      this.panel_noShows.Visible = false;
      // 
      // label46
      // 
      this.label46.AutoSize = true;
      this.label46.BackColor = System.Drawing.Color.Transparent;
      this.label46.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label46.ForeColor = System.Drawing.Color.Navy;
      this.label46.Location = new System.Drawing.Point(695, 89);
      this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label46.Name = "label46";
      this.label46.Size = new System.Drawing.Size(108, 16);
      this.label46.TabIndex = 55;
      this.label46.Text = "Post Payment";
      // 
      // label48
      // 
      this.label48.AutoSize = true;
      this.label48.BackColor = System.Drawing.Color.Transparent;
      this.label48.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label48.ForeColor = System.Drawing.Color.Navy;
      this.label48.Location = new System.Drawing.Point(580, 89);
      this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label48.Name = "label48";
      this.label48.Size = new System.Drawing.Size(107, 16);
      this.label48.TabIndex = 54;
      this.label48.Text = "Post Charges ";
      // 
      // pb_NoShows_PostPayment
      // 
      this.pb_NoShows_PostPayment.BackColor = System.Drawing.Color.Transparent;
      this.pb_NoShows_PostPayment.Location = new System.Drawing.Point(712, 15);
      this.pb_NoShows_PostPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_NoShows_PostPayment.Name = "pb_NoShows_PostPayment";
      this.pb_NoShows_PostPayment.Size = new System.Drawing.Size(75, 69);
      this.pb_NoShows_PostPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_NoShows_PostPayment.TabIndex = 57;
      this.pb_NoShows_PostPayment.TabStop = false;
      // 
      // pb_NoShows_PostCharges
      // 
      this.pb_NoShows_PostCharges.BackColor = System.Drawing.Color.Transparent;
      this.pb_NoShows_PostCharges.Location = new System.Drawing.Point(597, 15);
      this.pb_NoShows_PostCharges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_NoShows_PostCharges.Name = "pb_NoShows_PostCharges";
      this.pb_NoShows_PostCharges.Size = new System.Drawing.Size(75, 69);
      this.pb_NoShows_PostCharges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_NoShows_PostCharges.TabIndex = 56;
      this.pb_NoShows_PostCharges.TabStop = false;
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label20.ForeColor = System.Drawing.Color.Navy;
      this.label20.Location = new System.Drawing.Point(493, 89);
      this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(51, 14);
      this.label20.TabIndex = 18;
      this.label20.Text = "Cancel";
      // 
      // pb_NoShows_Cancel
      // 
      this.pb_NoShows_Cancel.Location = new System.Drawing.Point(483, 15);
      this.pb_NoShows_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_NoShows_Cancel.Name = "pb_NoShows_Cancel";
      this.pb_NoShows_Cancel.Size = new System.Drawing.Size(75, 69);
      this.pb_NoShows_Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_NoShows_Cancel.TabIndex = 17;
      this.pb_NoShows_Cancel.TabStop = false;
      // 
      // label45
      // 
      this.label45.AutoSize = true;
      this.label45.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label45.ForeColor = System.Drawing.Color.Navy;
      this.label45.Location = new System.Drawing.Point(359, 80);
      this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label45.Name = "label45";
      this.label45.Size = new System.Drawing.Size(86, 28);
      this.label45.TabIndex = 16;
      this.label45.Text = "Change\r\nReservation";
      this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pb_NoShows_ChangeReservation
      // 
      this.pb_NoShows_ChangeReservation.Location = new System.Drawing.Point(372, 15);
      this.pb_NoShows_ChangeReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_NoShows_ChangeReservation.Name = "pb_NoShows_ChangeReservation";
      this.pb_NoShows_ChangeReservation.Size = new System.Drawing.Size(75, 69);
      this.pb_NoShows_ChangeReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_NoShows_ChangeReservation.TabIndex = 15;
      this.pb_NoShows_ChangeReservation.TabStop = false;
      // 
      // label27
      // 
      this.label27.AutoSize = true;
      this.label27.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label27.ForeColor = System.Drawing.Color.Navy;
      this.label27.Location = new System.Drawing.Point(261, 89);
      this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label27.Name = "label27";
      this.label27.Size = new System.Drawing.Size(67, 14);
      this.label27.TabIndex = 13;
      this.label27.Text = "Check-In";
      // 
      // label35
      // 
      this.label35.AutoSize = true;
      this.label35.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label35.ForeColor = System.Drawing.Color.Navy;
      this.label35.Location = new System.Drawing.Point(136, 89);
      this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label35.Name = "label35";
      this.label35.Size = new System.Drawing.Size(86, 14);
      this.label35.TabIndex = 12;
      this.label35.Text = "Reservation";
      // 
      // label36
      // 
      this.label36.AutoSize = true;
      this.label36.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label36.ForeColor = System.Drawing.Color.Navy;
      this.label36.Location = new System.Drawing.Point(20, 89);
      this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label36.Name = "label36";
      this.label36.Size = new System.Drawing.Size(94, 14);
      this.label36.TabIndex = 11;
      this.label36.Text = "New Booking";
      // 
      // pb_NoShows_NewBooking
      // 
      this.pb_NoShows_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_NoShows_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_NoShows_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_NoShows_NewBooking.Name = "pb_NoShows_NewBooking";
      this.pb_NoShows_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_NoShows_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_NoShows_NewBooking.TabIndex = 0;
      this.pb_NoShows_NewBooking.TabStop = false;
      this.pb_NoShows_NewBooking.Click += new System.EventHandler(this.pictureBox27_Click);
      // 
      // pb_NoShows_Reservation
      // 
      this.pb_NoShows_Reservation.Location = new System.Drawing.Point(148, 15);
      this.pb_NoShows_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_NoShows_Reservation.Name = "pb_NoShows_Reservation";
      this.pb_NoShows_Reservation.Size = new System.Drawing.Size(75, 69);
      this.pb_NoShows_Reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_NoShows_Reservation.TabIndex = 2;
      this.pb_NoShows_Reservation.TabStop = false;
      this.pb_NoShows_Reservation.Click += new System.EventHandler(this.pictureBox29_Click);
      // 
      // pb_NoShows_CheckIn
      // 
      this.pb_NoShows_CheckIn.Location = new System.Drawing.Point(263, 15);
      this.pb_NoShows_CheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_NoShows_CheckIn.Name = "pb_NoShows_CheckIn";
      this.pb_NoShows_CheckIn.Size = new System.Drawing.Size(75, 69);
      this.pb_NoShows_CheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_NoShows_CheckIn.TabIndex = 4;
      this.pb_NoShows_CheckIn.TabStop = false;
      this.pb_NoShows_CheckIn.UseWaitCursor = true;
      this.pb_NoShows_CheckIn.Click += new System.EventHandler(this.pictureBox34_Click);
      // 
      // dgv_NoShows
      // 
      this.dgv_NoShows.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_NoShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_NoShows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ico_ShareClm,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40});
      this.dgv_NoShows.Location = new System.Drawing.Point(5, 121);
      this.dgv_NoShows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_NoShows.Name = "dgv_NoShows";
      this.dgv_NoShows.RowHeadersWidth = 51;
      this.dgv_NoShows.Size = new System.Drawing.Size(1527, 314);
      this.dgv_NoShows.TabIndex = 10;
      this.dgv_NoShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
      // 
      // ico_ShareClm
      // 
      this.ico_ShareClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ico_ShareClm.Frozen = true;
      this.ico_ShareClm.HeaderText = "Share Icon";
      this.ico_ShareClm.MinimumWidth = 6;
      this.ico_ShareClm.Name = "ico_ShareClm";
      this.ico_ShareClm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ico_ShareClm.Width = 77;
      // 
      // dataGridViewTextBoxColumn26
      // 
      this.dataGridViewTextBoxColumn26.HeaderText = "Room Type";
      this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
      this.dataGridViewTextBoxColumn26.Width = 150;
      // 
      // dataGridViewTextBoxColumn32
      // 
      this.dataGridViewTextBoxColumn32.HeaderText = "Name";
      this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
      this.dataGridViewTextBoxColumn32.Width = 150;
      // 
      // dataGridViewTextBoxColumn33
      // 
      this.dataGridViewTextBoxColumn33.HeaderText = "Date In";
      this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
      this.dataGridViewTextBoxColumn33.Width = 80;
      // 
      // dataGridViewTextBoxColumn34
      // 
      this.dataGridViewTextBoxColumn34.HeaderText = "Date Out";
      this.dataGridViewTextBoxColumn34.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
      this.dataGridViewTextBoxColumn34.Width = 80;
      // 
      // dataGridViewTextBoxColumn35
      // 
      this.dataGridViewTextBoxColumn35.HeaderText = "ResId";
      this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
      this.dataGridViewTextBoxColumn35.Width = 150;
      // 
      // dataGridViewTextBoxColumn36
      // 
      this.dataGridViewTextBoxColumn36.HeaderText = "Rate";
      this.dataGridViewTextBoxColumn36.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
      this.dataGridViewTextBoxColumn36.Width = 125;
      // 
      // dataGridViewTextBoxColumn37
      // 
      this.dataGridViewTextBoxColumn37.HeaderText = "Rate Code";
      this.dataGridViewTextBoxColumn37.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
      this.dataGridViewTextBoxColumn37.Width = 150;
      // 
      // dataGridViewTextBoxColumn38
      // 
      this.dataGridViewTextBoxColumn38.HeaderText = "Adult";
      this.dataGridViewTextBoxColumn38.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
      this.dataGridViewTextBoxColumn38.Width = 125;
      // 
      // dataGridViewTextBoxColumn39
      // 
      this.dataGridViewTextBoxColumn39.HeaderText = "Child";
      this.dataGridViewTextBoxColumn39.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
      this.dataGridViewTextBoxColumn39.Width = 125;
      // 
      // dataGridViewTextBoxColumn40
      // 
      this.dataGridViewTextBoxColumn40.HeaderText = "Cancel#";
      this.dataGridViewTextBoxColumn40.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
      this.dataGridViewTextBoxColumn40.Width = 125;
      // 
      // panel_WaitList
      // 
      this.panel_WaitList.AccessibleName = "ReservationPanel";
      this.panel_WaitList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.panel_WaitList.Controls.Add(this.label47);
      this.panel_WaitList.Controls.Add(this.pb_WaitList_ConfirmRequest);
      this.panel_WaitList.Controls.Add(this.label41);
      this.panel_WaitList.Controls.Add(this.label42);
      this.panel_WaitList.Controls.Add(this.label43);
      this.panel_WaitList.Controls.Add(this.label44);
      this.panel_WaitList.Controls.Add(this.pb_WaitList_NewBooking);
      this.panel_WaitList.Controls.Add(this.dgv_WaitList);
      this.panel_WaitList.Controls.Add(this.pb_WaitList_ChangeReservation);
      this.panel_WaitList.Controls.Add(this.pb_WaitList_Confirmation);
      this.panel_WaitList.Controls.Add(this.pb_WaitList_Cancel);
      this.panel_WaitList.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.panel_WaitList.Location = new System.Drawing.Point(0, 31);
      this.panel_WaitList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_WaitList.Name = "panel_WaitList";
      this.panel_WaitList.Size = new System.Drawing.Size(1533, 436);
      this.panel_WaitList.TabIndex = 59;
      this.panel_WaitList.Visible = false;
      // 
      // label47
      // 
      this.label47.AutoSize = true;
      this.label47.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label47.ForeColor = System.Drawing.Color.Navy;
      this.label47.Location = new System.Drawing.Point(501, 82);
      this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label47.Name = "label47";
      this.label47.Size = new System.Drawing.Size(60, 28);
      this.label47.TabIndex = 16;
      this.label47.Text = "Confirm\r\nRequest";
      this.label47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pb_WaitList_ConfirmRequest
      // 
      this.pb_WaitList_ConfirmRequest.Location = new System.Drawing.Point(493, 12);
      this.pb_WaitList_ConfirmRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_WaitList_ConfirmRequest.Name = "pb_WaitList_ConfirmRequest";
      this.pb_WaitList_ConfirmRequest.Size = new System.Drawing.Size(85, 79);
      this.pb_WaitList_ConfirmRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_WaitList_ConfirmRequest.TabIndex = 15;
      this.pb_WaitList_ConfirmRequest.TabStop = false;
      // 
      // label41
      // 
      this.label41.AutoSize = true;
      this.label41.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label41.ForeColor = System.Drawing.Color.Navy;
      this.label41.Location = new System.Drawing.Point(389, 89);
      this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label41.Name = "label41";
      this.label41.Size = new System.Drawing.Size(51, 14);
      this.label41.TabIndex = 14;
      this.label41.Text = "Cancel";
      // 
      // label42
      // 
      this.label42.AutoSize = true;
      this.label42.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label42.ForeColor = System.Drawing.Color.Navy;
      this.label42.Location = new System.Drawing.Point(251, 89);
      this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label42.Name = "label42";
      this.label42.Size = new System.Drawing.Size(92, 14);
      this.label42.TabIndex = 13;
      this.label42.Text = "Confirmation";
      // 
      // label43
      // 
      this.label43.AutoSize = true;
      this.label43.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label43.ForeColor = System.Drawing.Color.Navy;
      this.label43.Location = new System.Drawing.Point(136, 81);
      this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label43.Name = "label43";
      this.label43.Size = new System.Drawing.Size(86, 28);
      this.label43.TabIndex = 12;
      this.label43.Text = "Change\r\nReservation";
      this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label44
      // 
      this.label44.AutoSize = true;
      this.label44.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label44.ForeColor = System.Drawing.Color.Navy;
      this.label44.Location = new System.Drawing.Point(20, 89);
      this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label44.Name = "label44";
      this.label44.Size = new System.Drawing.Size(94, 14);
      this.label44.TabIndex = 11;
      this.label44.Text = "New Booking";
      // 
      // pb_WaitList_NewBooking
      // 
      this.pb_WaitList_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_WaitList_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_WaitList_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_WaitList_NewBooking.Name = "pb_WaitList_NewBooking";
      this.pb_WaitList_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_WaitList_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_WaitList_NewBooking.TabIndex = 0;
      this.pb_WaitList_NewBooking.TabStop = false;
      // 
      // dgv_WaitList
      // 
      this.dgv_WaitList.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_WaitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_WaitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column31,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.Column32,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59});
      this.dgv_WaitList.Location = new System.Drawing.Point(5, 121);
      this.dgv_WaitList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_WaitList.Name = "dgv_WaitList";
      this.dgv_WaitList.ReadOnly = true;
      this.dgv_WaitList.RowHeadersWidth = 51;
      this.dgv_WaitList.Size = new System.Drawing.Size(1527, 314);
      this.dgv_WaitList.TabIndex = 10;
      // 
      // Column31
      // 
      this.Column31.HeaderText = "Room";
      this.Column31.MinimumWidth = 6;
      this.Column31.Name = "Column31";
      this.Column31.ReadOnly = true;
      this.Column31.Width = 125;
      // 
      // dataGridViewTextBoxColumn51
      // 
      this.dataGridViewTextBoxColumn51.HeaderText = "Room Type";
      this.dataGridViewTextBoxColumn51.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
      this.dataGridViewTextBoxColumn51.ReadOnly = true;
      this.dataGridViewTextBoxColumn51.Width = 150;
      // 
      // dataGridViewTextBoxColumn52
      // 
      this.dataGridViewTextBoxColumn52.HeaderText = "Name";
      this.dataGridViewTextBoxColumn52.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
      this.dataGridViewTextBoxColumn52.ReadOnly = true;
      this.dataGridViewTextBoxColumn52.Width = 150;
      // 
      // dataGridViewTextBoxColumn53
      // 
      this.dataGridViewTextBoxColumn53.HeaderText = "Date In";
      this.dataGridViewTextBoxColumn53.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
      this.dataGridViewTextBoxColumn53.ReadOnly = true;
      this.dataGridViewTextBoxColumn53.Width = 80;
      // 
      // dataGridViewTextBoxColumn54
      // 
      this.dataGridViewTextBoxColumn54.HeaderText = "Date Out";
      this.dataGridViewTextBoxColumn54.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
      this.dataGridViewTextBoxColumn54.ReadOnly = true;
      this.dataGridViewTextBoxColumn54.Width = 80;
      // 
      // Column32
      // 
      this.Column32.HeaderText = "Stay";
      this.Column32.MinimumWidth = 6;
      this.Column32.Name = "Column32";
      this.Column32.ReadOnly = true;
      this.Column32.Width = 125;
      // 
      // dataGridViewTextBoxColumn55
      // 
      this.dataGridViewTextBoxColumn55.HeaderText = "ResId";
      this.dataGridViewTextBoxColumn55.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
      this.dataGridViewTextBoxColumn55.ReadOnly = true;
      this.dataGridViewTextBoxColumn55.Width = 150;
      // 
      // dataGridViewTextBoxColumn56
      // 
      this.dataGridViewTextBoxColumn56.HeaderText = "Rate";
      this.dataGridViewTextBoxColumn56.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
      this.dataGridViewTextBoxColumn56.ReadOnly = true;
      this.dataGridViewTextBoxColumn56.Width = 125;
      // 
      // dataGridViewTextBoxColumn57
      // 
      this.dataGridViewTextBoxColumn57.HeaderText = "Rate Code";
      this.dataGridViewTextBoxColumn57.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
      this.dataGridViewTextBoxColumn57.ReadOnly = true;
      this.dataGridViewTextBoxColumn57.Width = 150;
      // 
      // dataGridViewTextBoxColumn58
      // 
      this.dataGridViewTextBoxColumn58.HeaderText = "Adult";
      this.dataGridViewTextBoxColumn58.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
      this.dataGridViewTextBoxColumn58.ReadOnly = true;
      this.dataGridViewTextBoxColumn58.Width = 125;
      // 
      // dataGridViewTextBoxColumn59
      // 
      this.dataGridViewTextBoxColumn59.HeaderText = "Child";
      this.dataGridViewTextBoxColumn59.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
      this.dataGridViewTextBoxColumn59.ReadOnly = true;
      this.dataGridViewTextBoxColumn59.Width = 125;
      // 
      // pb_WaitList_ChangeReservation
      // 
      this.pb_WaitList_ChangeReservation.Location = new System.Drawing.Point(148, 15);
      this.pb_WaitList_ChangeReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_WaitList_ChangeReservation.Name = "pb_WaitList_ChangeReservation";
      this.pb_WaitList_ChangeReservation.Size = new System.Drawing.Size(75, 69);
      this.pb_WaitList_ChangeReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_WaitList_ChangeReservation.TabIndex = 2;
      this.pb_WaitList_ChangeReservation.TabStop = false;
      // 
      // pb_WaitList_Confirmation
      // 
      this.pb_WaitList_Confirmation.Location = new System.Drawing.Point(261, 10);
      this.pb_WaitList_Confirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_WaitList_Confirmation.Name = "pb_WaitList_Confirmation";
      this.pb_WaitList_Confirmation.Size = new System.Drawing.Size(85, 79);
      this.pb_WaitList_Confirmation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_WaitList_Confirmation.TabIndex = 4;
      this.pb_WaitList_Confirmation.TabStop = false;
      // 
      // pb_WaitList_Cancel
      // 
      this.pb_WaitList_Cancel.Location = new System.Drawing.Point(380, 15);
      this.pb_WaitList_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_WaitList_Cancel.Name = "pb_WaitList_Cancel";
      this.pb_WaitList_Cancel.Size = new System.Drawing.Size(75, 69);
      this.pb_WaitList_Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_WaitList_Cancel.TabIndex = 6;
      this.pb_WaitList_Cancel.TabStop = false;
      // 
      // panel_Reservation
      // 
      this.panel_Reservation.AccessibleName = "ReservationPanel";
      this.panel_Reservation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.panel_Reservation.Controls.Add(this.lbl_GF);
      this.panel_Reservation.Controls.Add(this.lbl_Confirmation);
      this.panel_Reservation.Controls.Add(this.lbl_Reservation);
      this.panel_Reservation.Controls.Add(this.lbl_Nb);
      this.panel_Reservation.Controls.Add(this.pb_Reservation_NewBooking);
      this.panel_Reservation.Controls.Add(this.dgv_Reservation);
      this.panel_Reservation.Controls.Add(this.pb_Reservation_Reservation);
      this.panel_Reservation.Controls.Add(this.pb_Reservation_Confirmation);
      this.panel_Reservation.Controls.Add(this.pb_Reservation_GuestFolio);
      this.panel_Reservation.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.panel_Reservation.Location = new System.Drawing.Point(0, 31);
      this.panel_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel_Reservation.Name = "panel_Reservation";
      this.panel_Reservation.Size = new System.Drawing.Size(1533, 436);
      this.panel_Reservation.TabIndex = 56;
      this.panel_Reservation.Visible = false;
      this.panel_Reservation.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Reservation_Paint);
      // 
      // lbl_GF
      // 
      this.lbl_GF.AutoSize = true;
      this.lbl_GF.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_GF.ForeColor = System.Drawing.Color.Navy;
      this.lbl_GF.Location = new System.Drawing.Point(365, 89);
      this.lbl_GF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_GF.Name = "lbl_GF";
      this.lbl_GF.Size = new System.Drawing.Size(81, 14);
      this.lbl_GF.TabIndex = 14;
      this.lbl_GF.Text = "Guest Folio";
      // 
      // lbl_Confirmation
      // 
      this.lbl_Confirmation.AutoSize = true;
      this.lbl_Confirmation.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Confirmation.ForeColor = System.Drawing.Color.Navy;
      this.lbl_Confirmation.Location = new System.Drawing.Point(244, 89);
      this.lbl_Confirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Confirmation.Name = "lbl_Confirmation";
      this.lbl_Confirmation.Size = new System.Drawing.Size(92, 14);
      this.lbl_Confirmation.TabIndex = 13;
      this.lbl_Confirmation.Text = "Confirmation";
      // 
      // lbl_Reservation
      // 
      this.lbl_Reservation.AutoSize = true;
      this.lbl_Reservation.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Reservation.ForeColor = System.Drawing.Color.Navy;
      this.lbl_Reservation.Location = new System.Drawing.Point(136, 89);
      this.lbl_Reservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Reservation.Name = "lbl_Reservation";
      this.lbl_Reservation.Size = new System.Drawing.Size(86, 14);
      this.lbl_Reservation.TabIndex = 12;
      this.lbl_Reservation.Text = "Reservation";
      // 
      // lbl_Nb
      // 
      this.lbl_Nb.AutoSize = true;
      this.lbl_Nb.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Nb.ForeColor = System.Drawing.Color.Navy;
      this.lbl_Nb.Location = new System.Drawing.Point(20, 89);
      this.lbl_Nb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Nb.Name = "lbl_Nb";
      this.lbl_Nb.Size = new System.Drawing.Size(94, 14);
      this.lbl_Nb.TabIndex = 11;
      this.lbl_Nb.Text = "New Booking";
      // 
      // pb_Reservation_NewBooking
      // 
      this.pb_Reservation_NewBooking.BackColor = System.Drawing.Color.Transparent;
      this.pb_Reservation_NewBooking.Location = new System.Drawing.Point(33, 15);
      this.pb_Reservation_NewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Reservation_NewBooking.Name = "pb_Reservation_NewBooking";
      this.pb_Reservation_NewBooking.Size = new System.Drawing.Size(75, 69);
      this.pb_Reservation_NewBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Reservation_NewBooking.TabIndex = 0;
      this.pb_Reservation_NewBooking.TabStop = false;
      this.pb_Reservation_NewBooking.Click += new System.EventHandler(this.icon_Nb_Click);
      // 
      // dgv_Reservation
      // 
      this.dgv_Reservation.BackgroundColor = System.Drawing.Color.Silver;
      this.dgv_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
      this.dgv_Reservation.Location = new System.Drawing.Point(5, 121);
      this.dgv_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgv_Reservation.Name = "dgv_Reservation";
      this.dgv_Reservation.ReadOnly = true;
      this.dgv_Reservation.RowHeadersWidth = 51;
      this.dgv_Reservation.Size = new System.Drawing.Size(1527, 314);
      this.dgv_Reservation.TabIndex = 10;
      this.dgv_Reservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_2_CellContentClick);
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Room Type";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 150;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Name";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 150;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Date In";
      this.Column3.MinimumWidth = 6;
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 80;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Date Out";
      this.Column4.MinimumWidth = 6;
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 80;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "ResId";
      this.Column5.MinimumWidth = 6;
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 150;
      // 
      // Column6
      // 
      this.Column6.HeaderText = "Rate";
      this.Column6.MinimumWidth = 6;
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.Width = 125;
      // 
      // Column7
      // 
      this.Column7.HeaderText = "Rate Code";
      this.Column7.MinimumWidth = 6;
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column7.Width = 150;
      // 
      // Column8
      // 
      this.Column8.HeaderText = "Adult";
      this.Column8.MinimumWidth = 6;
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      this.Column8.Width = 125;
      // 
      // Column9
      // 
      this.Column9.HeaderText = "Child";
      this.Column9.MinimumWidth = 6;
      this.Column9.Name = "Column9";
      this.Column9.ReadOnly = true;
      this.Column9.Width = 125;
      // 
      // Column10
      // 
      this.Column10.HeaderText = "Cancel#";
      this.Column10.MinimumWidth = 6;
      this.Column10.Name = "Column10";
      this.Column10.ReadOnly = true;
      this.Column10.Width = 125;
      // 
      // pb_Reservation_Reservation
      // 
      this.pb_Reservation_Reservation.Location = new System.Drawing.Point(148, 15);
      this.pb_Reservation_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Reservation_Reservation.Name = "pb_Reservation_Reservation";
      this.pb_Reservation_Reservation.Size = new System.Drawing.Size(75, 69);
      this.pb_Reservation_Reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Reservation_Reservation.TabIndex = 2;
      this.pb_Reservation_Reservation.TabStop = false;
      // 
      // pb_Reservation_Confirmation
      // 
      this.pb_Reservation_Confirmation.Location = new System.Drawing.Point(251, 12);
      this.pb_Reservation_Confirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Reservation_Confirmation.Name = "pb_Reservation_Confirmation";
      this.pb_Reservation_Confirmation.Size = new System.Drawing.Size(85, 79);
      this.pb_Reservation_Confirmation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Reservation_Confirmation.TabIndex = 4;
      this.pb_Reservation_Confirmation.TabStop = false;
      // 
      // pb_Reservation_GuestFolio
      // 
      this.pb_Reservation_GuestFolio.Location = new System.Drawing.Point(367, 10);
      this.pb_Reservation_GuestFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pb_Reservation_GuestFolio.Name = "pb_Reservation_GuestFolio";
      this.pb_Reservation_GuestFolio.Size = new System.Drawing.Size(85, 79);
      this.pb_Reservation_GuestFolio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_Reservation_GuestFolio.TabIndex = 6;
      this.pb_Reservation_GuestFolio.TabStop = false;
      // 
      // dataGridViewImageColumn1
      // 
      this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewImageColumn1.Frozen = true;
      this.dataGridViewImageColumn1.HeaderText = "Share Icon";
      this.dataGridViewImageColumn1.MinimumWidth = 6;
      this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
      this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewImageColumn1.Width = 125;
      // 
      // pb_ExitIcon
      // 
      this.pb_ExitIcon.BackColor = System.Drawing.Color.White;
      this.pb_ExitIcon.Location = new System.Drawing.Point(1343, 2);
      this.pb_ExitIcon.Name = "pb_ExitIcon";
      this.pb_ExitIcon.Size = new System.Drawing.Size(20, 20);
      this.pb_ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_ExitIcon.TabIndex = 64;
      this.pb_ExitIcon.TabStop = false;
      // 
      // pb_MinimizeIcon
      // 
      this.pb_MinimizeIcon.BackColor = System.Drawing.Color.White;
      this.pb_MinimizeIcon.Location = new System.Drawing.Point(1314, 2);
      this.pb_MinimizeIcon.Name = "pb_MinimizeIcon";
      this.pb_MinimizeIcon.Size = new System.Drawing.Size(20, 20);
      this.pb_MinimizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_MinimizeIcon.TabIndex = 65;
      this.pb_MinimizeIcon.TabStop = false;
      // 
      // label60
      // 
      this.label60.AutoSize = true;
      this.label60.Location = new System.Drawing.Point(64, 62);
      this.label60.Name = "label60";
      this.label60.Size = new System.Drawing.Size(57, 17);
      this.label60.TabIndex = 45;
      this.label60.Text = "label60";
      // 
      // FrontDesk
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1824, 896);
      this.Controls.Add(this.panel_frontDesk);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.Ms_NoteView;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(1842, 943);
      this.MinimumSize = new System.Drawing.Size(1813, 883);
      this.Name = "FrontDesk";
      this.Text = "Front Desk";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Ms_NoteView.ResumeLayout(false);
      this.Ms_NoteView.PerformLayout();
      this.gb_frontDesk1.ResumeLayout(false);
      this.gb_frontDesk1.PerformLayout();
      this.tab_guestInfo.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.gb_frontDesk2.ResumeLayout(false);
      this.gb_frontDesk2.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.gb_Folio.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_folio)).EndInit();
      this.panel_InHouse.ResumeLayout(false);
      this.panel_InHouse.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_ImHouse_GuestFolio)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_InHouse)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_PostPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_PostCharges)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_RegCard)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_ChangeStay)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_CheckOut)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_Reservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_InHouse_NewBooking)).EndInit();
      this.panel_Arrivals.ResumeLayout(false);
      this.panel_Arrivals.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Arrival)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_NewBooking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_PostPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_PostCharges)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_RegistrationCard)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_Confirmation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_Cancel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_ChangeReservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_CheckIn)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Arrivals_Reservation)).EndInit();
      this.panel_Departures.ResumeLayout(false);
      this.panel_Departures.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departure_NewBooking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_PostPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_PostCharges)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_GuestFolio)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_RegistrationCard)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_ChangeStay)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_CheckOut)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Departures_Reservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Departures)).EndInit();
      this.panel_frontDesk.ResumeLayout(false);
      this.panel_frontDesk.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_HideIcon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CloseIcon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
      this.panel_CheckedOut.ResumeLayout(false);
      this.panel_CheckedOut.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_CheckedOut)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_NewBooking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Checked_PostPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_GuestFolio)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_ChekedOut_RegisterCard)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_Reinstate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_Reservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_CheckedOut_PostCharges)).EndInit();
      this.panel_Cancelled.ResumeLayout(false);
      this.panel_Cancelled.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_Confirmation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_PostPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_PostC)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_NewBooking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Cancelled)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_Reservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Cancelled_GuestFolio)).EndInit();
      this.panel_noShows.ResumeLayout(false);
      this.panel_noShows.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_PostPayment)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_PostCharges)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_Cancel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_ChangeReservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_NewBooking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_Reservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_NoShows_CheckIn)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_NoShows)).EndInit();
      this.panel_WaitList.ResumeLayout(false);
      this.panel_WaitList.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_ConfirmRequest)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_NewBooking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_WaitList)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_ChangeReservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_Confirmation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_WaitList_Cancel)).EndInit();
      this.panel_Reservation.ResumeLayout(false);
      this.panel_Reservation.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_NewBooking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_Reservation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_Confirmation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Reservation_GuestFolio)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_ExitIcon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb_MinimizeIcon)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.MenuStrip Ms_NoteView;
    private System.Windows.Forms.ToolStripMenuItem toolstrip_NoteView;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_Transactions;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_Reservations;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_Sc;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_Operations;
    private System.Windows.Forms.ToolStripMenuItem exportImportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStrip_Reports;
    private System.Windows.Forms.ToolStripMenuItem advSearchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.PictureBox pb_Reservation_Reservation;
    private System.Windows.Forms.PictureBox pb_Reservation_Confirmation;
    private System.Windows.Forms.PictureBox pb_Reservation_GuestFolio;
    private System.Windows.Forms.PictureBox pb_Reservation_NewBooking;
    private System.Windows.Forms.GroupBox gb_frontDesk1;
    private System.Windows.Forms.Label lbl_Arrival;
    private System.Windows.Forms.Label lbl_Departures;
    private System.Windows.Forms.Label lbl_Waitlist;
    private System.Windows.Forms.Label lbl_cancelled;
    private System.Windows.Forms.Label lbl_Reservations;
    private System.Windows.Forms.Label lbl_checkedOut;
    private System.Windows.Forms.Label lbl_noShows;
    private System.Windows.Forms.Label lbl_space;
    private System.Windows.Forms.Label lbl_inHouse;
    private System.Windows.Forms.TabControl tab_guestInfo;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.GroupBox gb_frontDesk2;
    private System.Windows.Forms.TextBox txt_vehicleLicense;
    private System.Windows.Forms.TextBox txt_travelAgency;
    private System.Windows.Forms.Label lbl_vehicleLicense;
    private System.Windows.Forms.Label lbl_travelAgency;
    private System.Windows.Forms.TextBox txt_cardHolder;
    private System.Windows.Forms.TextBox txt_cardNumber;
    private System.Windows.Forms.TextBox txt_expiry;
    private System.Windows.Forms.TextBox txt_cardType;
    private System.Windows.Forms.TextBox txt_reservationNote;
    private System.Windows.Forms.TextBox txt_guestNote;
    private System.Windows.Forms.TextBox txt_email;
    private System.Windows.Forms.TextBox txt_mobile;
    private System.Windows.Forms.TextBox txt_telephone;
    private System.Windows.Forms.TextBox txt_source;
    private System.Windows.Forms.TextBox txt_rateCode;
    private System.Windows.Forms.TextBox txt_ClientType;
    private System.Windows.Forms.TextBox txt_postalCode;
    private System.Windows.Forms.TextBox txt_country;
    private System.Windows.Forms.TextBox txt_province;
    private System.Windows.Forms.TextBox txt_City;
    private System.Windows.Forms.TextBox txt_StreetAdress;
    private System.Windows.Forms.TextBox txt_lastName;
    private System.Windows.Forms.TextBox txt_firstName;
    private System.Windows.Forms.TextBox txt_title;
    private System.Windows.Forms.Label lbl_cardType;
    private System.Windows.Forms.Label lbl_expiry;
    private System.Windows.Forms.Label lbl_cardNumber;
    private System.Windows.Forms.Label lbl_cardHolder;
    private System.Windows.Forms.Label lbl_reserveationNote;
    private System.Windows.Forms.Label lbl_guestnote;
    private System.Windows.Forms.Label lbl_email;
    private System.Windows.Forms.Label lbl_mobile;
    private System.Windows.Forms.Label lbl_telephone;
    private System.Windows.Forms.Label lbl_source;
    private System.Windows.Forms.Label lbl_postalCode;
    private System.Windows.Forms.Label lbl_rateCode;
    private System.Windows.Forms.Label lbl_country;
    private System.Windows.Forms.Label lbl_clientType;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_province;
    private System.Windows.Forms.Label lbl_city;
    private System.Windows.Forms.Label lbl_streetAddress;
    private System.Windows.Forms.Label lbl_lastName;
    private System.Windows.Forms.Label lbl_firstName;
    private System.Windows.Forms.Label lbl_title;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label lbl_user;
    private System.Windows.Forms.Label lbl_dateTime;
    private System.Windows.Forms.Panel panel_frontDesk;
    private System.Windows.Forms.DataGridView dgv_Departures;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    private System.Windows.Forms.Panel panel_Departures;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.PictureBox pb_Departure_NewBooking;
    private System.Windows.Forms.PictureBox pb_Departures_PostPayment;
    private System.Windows.Forms.PictureBox pb_Departures_PostCharges;
    private System.Windows.Forms.PictureBox pb_Departures_GuestFolio;
    private System.Windows.Forms.PictureBox pb_Departures_RegistrationCard;
    private System.Windows.Forms.PictureBox pb_Departures_ChangeStay;
    private System.Windows.Forms.PictureBox pb_Departures_CheckOut;
    private System.Windows.Forms.PictureBox pb_Departures_Reservation;
    private System.Windows.Forms.ToolStripMenuItem postPaymentToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem postChargesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem guestFolioToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem unprocessedCreditCardTransactionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem authorizedTransactionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem folioAppearanceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelAllNoShowsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem processLateFeesToolStripMenuItem;
    private System.Windows.Forms.Panel panel_Arrivals;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.PictureBox pb_Arrivals_NewBooking;
    private System.Windows.Forms.PictureBox pb_Arrivals_PostCharges;
    private System.Windows.Forms.PictureBox pb_Arrivals_RegistrationCard;
    private System.Windows.Forms.PictureBox pb_Arrivals_Confirmation;
    private System.Windows.Forms.PictureBox pb_Arrivals_Cancel;
    private System.Windows.Forms.PictureBox pb_Arrivals_ChangeReservation;
    private System.Windows.Forms.PictureBox pb_Arrivals_CheckIn;
    private System.Windows.Forms.PictureBox pb_Arrivals_Reservation;
    private System.Windows.Forms.Panel panel_CheckedOut;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.Label label32;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.Label label34;
    private System.Windows.Forms.PictureBox pb_CheckedOut_NewBooking;
    private System.Windows.Forms.PictureBox pb_Checked_PostPayment;
    private System.Windows.Forms.PictureBox pb_CheckedOut_GuestFolio;
    private System.Windows.Forms.PictureBox pb_ChekedOut_RegisterCard;
    private System.Windows.Forms.PictureBox pb_CheckedOut_Reinstate;
    private System.Windows.Forms.PictureBox pb_CheckedOut_Reservation;
    private System.Windows.Forms.PictureBox pb_CheckedOut_PostCharges;
    private System.Windows.Forms.Panel panel_InHouse;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pb_InHouse_PostPayment;
    private System.Windows.Forms.PictureBox pb_InHouse_PostCharges;
    private System.Windows.Forms.PictureBox pb_InHouse_RegCard;
    private System.Windows.Forms.PictureBox pb_InHouse_ChangeStay;
    private System.Windows.Forms.PictureBox pb_InHouse_CheckOut;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pb_InHouse_Reservation;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pb_InHouse_NewBooking;
    private System.Windows.Forms.DataGridView dgv_InHouse;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
    private System.Windows.Forms.DataGridView dgv_Arrival;
    private System.Windows.Forms.DataGridView dgv_CheckedOut;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
    private System.Windows.Forms.DataGridView dgv_Reservation;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    private System.Windows.Forms.Panel panel_Reservation;
    private System.Windows.Forms.Label lbl_GF;
    private System.Windows.Forms.Label lbl_Confirmation;
    private System.Windows.Forms.Label lbl_Reservation;
    private System.Windows.Forms.Label lbl_Nb;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.Panel panel_noShows;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label label35;
    private System.Windows.Forms.Label label36;
    private System.Windows.Forms.PictureBox pb_NoShows_NewBooking;
    private System.Windows.Forms.DataGridView dgv_NoShows;
    private System.Windows.Forms.PictureBox pb_NoShows_Reservation;
    private System.Windows.Forms.PictureBox pb_NoShows_CheckIn;
    private System.Windows.Forms.Panel panel_Cancelled;
    private System.Windows.Forms.Label label37;
    private System.Windows.Forms.Label label39;
    private System.Windows.Forms.Label label40;
    private System.Windows.Forms.PictureBox pb_Cancelled_NewBooking;
    private System.Windows.Forms.DataGridView dgv_Cancelled;
    private System.Windows.Forms.PictureBox pb_Cancelled_Reservation;
    private System.Windows.Forms.PictureBox pb_Cancelled_GuestFolio;
    private System.Windows.Forms.Panel panel_WaitList;
    private System.Windows.Forms.Label label41;
    private System.Windows.Forms.Label label42;
    private System.Windows.Forms.Label label43;
    private System.Windows.Forms.Label label44;
    private System.Windows.Forms.PictureBox pb_WaitList_NewBooking;
    private System.Windows.Forms.DataGridView dgv_WaitList;
    private System.Windows.Forms.PictureBox pb_WaitList_ChangeReservation;
    private System.Windows.Forms.PictureBox pb_WaitList_Confirmation;
    private System.Windows.Forms.PictureBox pb_WaitList_Cancel;
    private System.Windows.Forms.Label label50;
    private System.Windows.Forms.PictureBox pb_Cancelled_PostPayment;
    private System.Windows.Forms.Label label49;
    private System.Windows.Forms.PictureBox pb_Cancelled_PostC;
    private System.Windows.Forms.GroupBox gb_Folio;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rb_folioStay;
    private System.Windows.Forms.RadioButton rb_folioNow;
    private System.Windows.Forms.Label label58;
    private System.Windows.Forms.Label label57;
    private System.Windows.Forms.Label label56;
    private System.Windows.Forms.Label label55;
    private System.Windows.Forms.Label label54;
    private System.Windows.Forms.Label label53;
    private System.Windows.Forms.Label label52;
    private System.Windows.Forms.Label label38;
    private System.Windows.Forms.DataGridView dgv_folio;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
    private System.Windows.Forms.ComboBox cb_folioCategry;
    private System.Windows.Forms.Button btn_folioMove;
    private System.Windows.Forms.Button btn_folioRefresh;
    private System.Windows.Forms.Button btn_folioSelect;
    private System.Windows.Forms.Label label59;
    private System.Windows.Forms.PictureBox pb_ImHouse_GuestFolio;
    private System.Windows.Forms.Label label51;
    private System.Windows.Forms.PictureBox pb_Cancelled_Confirmation;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
    private System.Windows.Forms.Label label47;
    private System.Windows.Forms.PictureBox pb_WaitList_ConfirmRequest;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.PictureBox pb_Arrivals_PostPayment;
    private System.Windows.Forms.PictureBox pictureBox51;
    private System.Windows.Forms.Label label46;
    private System.Windows.Forms.Label label48;
    private System.Windows.Forms.PictureBox pb_NoShows_PostPayment;
    private System.Windows.Forms.PictureBox pb_NoShows_PostCharges;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.PictureBox pb_NoShows_Cancel;
    private System.Windows.Forms.Label label45;
    private System.Windows.Forms.PictureBox pb_NoShows_ChangeReservation;
    private System.Windows.Forms.DataGridViewImageColumn ico_ShareClm;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
    private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    private PictureBox pb_HideIcon;
    private PictureBox pb_CloseIcon;
    private PictureBox pb_ExitIcon;
    private PictureBox pb_MinimizeIcon;
    private Label label60;
  }
}

