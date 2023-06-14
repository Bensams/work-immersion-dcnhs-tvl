using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteView
{
  public partial class FrontDesk : Form
    {
        private static readonly Point LockedInPoint = new Point(0, 0);
        private readonly Panel[] contentPanels;
        public FrontDesk()
        {
            InitializeComponent();
            contentPanels = new Panel[]
            {
              panel_InHouse, panel_Arrivals, panel_Departures,
              panel_CheckedOut, panel_noShows, panel_Cancelled,
              panel_WaitList
            };
        }

        /*Default Text, ForeColor, and Font*/
        public void FrontDeskTable()
        {
            this.lbl_inHouse.Text = "In House";
            this.lbl_inHouse.ForeColor = Color.Black;
            this.lbl_inHouse.Font = new Font("Verdana", 8);

            this.lbl_Arrival.Text = "Arrivals";
            this.lbl_Arrival.ForeColor = Color.Black;
            this.lbl_Arrival.Font = new Font("Verdana", 8);

            this.lbl_Departures.Text = "Departures";
            this.lbl_Departures.ForeColor = Color.Black;
            this.lbl_Departures.Font = new Font("Verdana", 8);

            this.lbl_Reservations.Text = "Reservations";
            this.lbl_Reservations.ForeColor = Color.Black;
            this.lbl_Reservations.Font = new Font("Verdana", 8);

            this.lbl_checkedOut.Text = "Checked Out";
            this.lbl_checkedOut.ForeColor = Color.Black;
            this.lbl_checkedOut.Font = new Font("Verdana", 8);

            this.lbl_noShows.Text = "No Shows";
            this.lbl_noShows.ForeColor = Color.Black;
            this.lbl_noShows.Font = new Font("Verdana", 8);

            this.lbl_cancelled.Text = "Cancelled";
            this.lbl_cancelled.ForeColor = Color.Black;
            this.lbl_cancelled.Font = new Font("Verdana", 8);

            this.lbl_Waitlist.Text = "Wait List";
            this.lbl_Waitlist.ForeColor = Color.Black;
            this.lbl_Waitlist.Font = new Font("Verdana", 8);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void icon_Nb_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbl_Profile_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Confirmation_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonFrontdesk1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gb_1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void inHouseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void tb_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_CloseIcon_Click(object sender, EventArgs e)
        {
            // TODO: Invoke common onExit method
            this.Close();
        }

        private void pb_HideIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_Reservations.Text = "> Reservations";
            this.lbl_Reservations.ForeColor = Color.Blue;
            this.lbl_Reservations.Font = new Font("Verdana", 10, FontStyle.Bold);
            this.panel_Reservation.Visible = true;
            this.panel_InHouse.Visible = false;
            this.panel_Arrivals.Visible = false;
            this.panel_Departures.Visible = false;
            this.panel_CheckedOut.Visible = false;
            this.panel_noShows.Visible = false;
            this.panel_Cancelled.Visible = false;
            this.panel_WaitList.Visible = false;

        }
        private void Departures_Click(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_Departures.Text = "> Departures";
            this.lbl_Departures.ForeColor = Color.Blue;
            this.lbl_Departures.Font = new Font("Verdana", 10, FontStyle.Bold);
            this.panel_Reservation.Visible = false;
            this.panel_InHouse.Visible = false;
            this.panel_Arrivals.Visible = false;
            this.panel_Departures.Visible = true;
            this.panel_CheckedOut.Visible = false;
            this.panel_noShows.Visible = false;
            this.panel_Cancelled.Visible = false;
            this.panel_WaitList.Visible = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tbl_travelAgency_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void lbl_streetAddress_Click(object sender, EventArgs e)
        {

        }

        private void bfdbfgbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PrioritizePanel(Panel pnl)
        {
            foreach (Panel thePanel in contentPanels)
            {
                if (thePanel != pnl)
                {
                    thePanel.Visible = false;
                }
                else thePanel.Visible = true;
            }
        }

        private void InHouse_Enter(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_inHouse.Text = "> In House";
            this.lbl_inHouse.ForeColor = Color.Blue;
            this.lbl_inHouse.Font = new Font("Verdana", 10, FontStyle.Bold);
            PrioritizePanel(panel_InHouse);
        }

        private void lbl_Arrival_Click(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_Arrival.Text = "> Arrivals";
            this.lbl_Arrival.ForeColor = Color.Blue;
            this.lbl_Arrival.Font = new Font("Verdana", 10, FontStyle.Bold);
            PrioritizePanel(panel_Arrivals);

        }

        private void lbl_checkedOut_Click(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_checkedOut.Text = " > Checked Out";
            this.lbl_checkedOut.ForeColor = Color.Blue;
            this.lbl_checkedOut.Font = new Font("Verdana", 10, FontStyle.Bold);
            PrioritizePanel(panel_CheckedOut);

        }

        private void lbl_noShows_Click(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_noShows.Text = " > No Shows";
            this.lbl_noShows.ForeColor = Color.Blue;
            this.lbl_noShows.Font = new Font("Verdana", 10, FontStyle.Bold);
            PrioritizePanel(panel_noShows);
        }

        private void lbl_cancelled_Click(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_cancelled.Text = " > Cancelled";
            this.lbl_cancelled.ForeColor = Color.Blue;
            this.lbl_cancelled.Font = new Font("Verdana", 10, FontStyle.Bold);
            PrioritizePanel(panel_Cancelled);
        }

        private void lbl_Waitlist_Click(object sender, EventArgs e)
        {
            FrontDeskTable();
            this.lbl_Waitlist.Text = " > Wait List";
            this.lbl_Waitlist.ForeColor = Color.Blue;
            this.lbl_Waitlist.Font = new Font("Verdana", 10, FontStyle.Bold);
            PrioritizePanel(panel_WaitList);

        }

        private void dgv_InHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gb_frontDesk1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_Arrivals_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel_Departures_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void guestFolioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel_Arrivals_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel_Reservation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_tapeChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pb_CheckedOut_GuestFolio_Click(object sender, EventArgs e)
        {

        }

        private void panel_Cancelled_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
