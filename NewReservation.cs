using System;
using System.Windows.Forms;

namespace NoteView
{
  public partial class NewReservation : Form
  {
    public NewReservation()
    {
      InitializeComponent();
    }

    private void tb_Info_Selected(object sender, TabControlEventArgs e)
    {
      if (e.TabPage == tp_Calendar)
        btn_Refresh.Visible = true;
      else
        btn_Refresh.Visible = false;
    }
    private void btn_Clear_Click(object sender, EventArgs e)
    {
      // Guest Info
      tb_FirstName.Text = ""; tb_LastName.Text = ""; tb_Address.Text = ""; tb_ZipCode.Text = ""; cb_Country.Text = "";
      cb_Nationality.Text = ""; tb_City.Text = ""; tb_State_Province.Text = "";
      tb_GuestNote.Text = ""; tb_MobileNum.Text = ""; tb_TelephoneNum.Text = ""; tb_Email.Text = "";
      cb_PostDepo.Checked = false; tb_Amount.Text = string.Empty;
      // Payment Method
      cb_PostDepo.Checked = false; cb_CardType.Text = ""; tb_CardNumber.Text = "";
      tb_ExpiryDate.Text = ""; tb_CardNumber.Text = "";
      // Vehicle Method
      tb_Brand.Text = "";
      tb_Color.Text = "";
      tb_Model.Text = "";
      tb_License.Text = "";
    }
    private void cb_PostDepo_CheckedChanged(object sender, EventArgs e)
    {
      if (cb_PostDepo.Checked == true) tb_Amount.Enabled = true;
      else tb_Amount.Enabled = false; tb_Amount.Text = "";
    }

        private void GuestInfoPage_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            btn_Clear_Click(sender, e);
            cb_ClientType.Text = "";
            cb_RoomCharge.Text = "";

        }

        private void NewReservation_Load(object sender, EventArgs e)
        {
            dtp_Arrival.Value = DateTime.Today;
            dtp_Departure.Value = DateTime.Today;
        }

        private void dtp_Departure_ValueChanged(object sender, EventArgs e)
        {
            int Arrival = dtp_Arrival.Value.Day;
            int departure = dtp_Departure.Value.Day;

            if (departure > Arrival)
            {
                nud_Nights.Value = 0;
                for (int today = Arrival; today < departure; ++today)
                {
                    nud_Nights.Value += 1;
                }
            }
            if (departure <= Arrival)
                nud_Nights.Value = 0;   
        }
        private void nud_Nights_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}