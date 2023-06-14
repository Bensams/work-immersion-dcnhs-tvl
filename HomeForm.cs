using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
  public partial class HomeForm : Form
  {
    // Table Indicator
    private readonly Label[] tableSelectIndicators;
    private readonly string[] dormantIndicatorTexts;
    private readonly string[] activeIndicatorTexts;
    private readonly Font dormantIndicatorFont = new Font("Verdana", 9, FontStyle.Regular);
    private readonly Font activeIndicatorFont = new Font("Verdana", 9, FontStyle.Bold);
    private readonly Color dormantIndicatorColor = Color.Black;
    private readonly Color activeIndicatorColor = Color.Blue;

    private void SetTableIndicatorEmphasizedState(int ii, bool state)
    {
      Label theIndicator = tableSelectIndicators[ii];
      if (state)
      {
        theIndicator.Font = activeIndicatorFont;
        theIndicator.Text = activeIndicatorTexts[ii];
        theIndicator.ForeColor = activeIndicatorColor;
        SetDGVColumns(tableLayouts[ii]);
      }
      else
      {
        theIndicator.Font = dormantIndicatorFont;
        theIndicator.Text = dormantIndicatorTexts[ii];
        theIndicator.ForeColor = dormantIndicatorColor;
      }
    }

    private void EmphasizeTableIndicator(Label theIndicator)
    {
      for (int i = 0; i < tableSelectIndicators.Length; i++)
      {
        SetTableIndicatorEmphasizedState(i, theIndicator == tableSelectIndicators[i]);
      }
    }
    // End of Table Indicators

    // DGV Modifiers
    private readonly DataGridViewColumn[] inHouseColumns = new DataGridViewColumn[]
      {
        MakeColumn<DataGridViewTextBoxColumn>("Room No."),
        MakeColumn<DataGridViewTextBoxColumn>("Room Type"),
        MakeColumn<DataGridViewTextBoxColumn>("Name"),
        MakeColumn<DataGridViewTextBoxColumn>("Date In"),
        MakeColumn<DataGridViewTextBoxColumn>("Date Out"),
        MakeColumn<DataGridViewTextBoxColumn>("Stay"),
        MakeColumn<DataGridViewTextBoxColumn>("Res ID"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate Code"),
        MakeColumn<DataGridViewTextBoxColumn>("Adult"),
        MakeColumn<DataGridViewTextBoxColumn>("Child")
      };
    private readonly DataGridViewColumn[] noShowColumns = new DataGridViewColumn[]
      {
        MakeColumn<DataGridViewTextBoxColumn>("Room No."),
        MakeColumn<DataGridViewTextBoxColumn>("Room Type"),
        MakeColumn<DataGridViewTextBoxColumn>("Name"),
        MakeColumn<DataGridViewTextBoxColumn>("Date In"),
        MakeColumn<DataGridViewTextBoxColumn>("Date Out"),
        MakeColumn<DataGridViewTextBoxColumn>("Res ID"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate Code"),
        MakeColumn<DataGridViewTextBoxColumn>("Adult"),
        MakeColumn<DataGridViewTextBoxColumn>("Child"),
        MakeColumn<DataGridViewTextBoxColumn>("Cancel No.")
      };

    private readonly DataGridViewColumn[][] tableLayouts;

    private static DataGridViewColumn MakeColumn<T>(string name, bool readOnly = true) where T : DataGridViewColumn, new()
    {
      DataGridViewColumn obj = new T
      {
        HeaderText = name,
        ReadOnly = readOnly
      };
      return obj;
    }

    private void SetDGVColumns(DataGridViewColumn[] cols)
    {
      dgv_DataTable.Columns.Clear();
      dgv_DataTable.Columns.AddRange(cols);
      //dgv_DataTable.Rows.Add();
    }
    // End of DGV Modifiers

    // WinForm methods
    public HomeForm()
    {
      InitializeComponent();

      tableSelectIndicators = new Label[]
      {
        lbl_InHouse, lbl_Arrivals, lbl_Departures,
        lbl_Reservations, lbl_CheckedOut, lbl_NoShows,
        lbl_Cancelled, lbl_WaitList
      };

      dormantIndicatorTexts = new string[]
      {
        "In House", "Arrivals", "Departures",
        "Reservations", "Checked Out", "No Shows",
        "Cancelled", "Wait List"
      };

      activeIndicatorTexts = new string[dormantIndicatorTexts.Length];

      for (int i = 0; i < activeIndicatorTexts.Length; i++)
      {
        activeIndicatorTexts[i] = $"▶ {dormantIndicatorTexts[i]}";
      }

      // TODO: OPTIMIZE!
      tableLayouts = new DataGridViewColumn[][] {
      // For In House
      inHouseColumns,

      // For Arrivals
      new DataGridViewColumn []
      {
        MakeColumn<DataGridViewTextBoxColumn>("Room No."),
        MakeColumn<DataGridViewTextBoxColumn>("Room Type"),
        MakeColumn<DataGridViewTextBoxColumn>("Name"),
        MakeColumn<DataGridViewTextBoxColumn>("Date In"),
        MakeColumn<DataGridViewTextBoxColumn>("Date Out"),
        MakeColumn<DataGridViewTextBoxColumn>("Res ID"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate Code"),
        MakeColumn<DataGridViewTextBoxColumn>("Adult"),
        MakeColumn<DataGridViewTextBoxColumn>("Child")
      },

      // For Departures
      inHouseColumns,

      // For Reservations
      inHouseColumns,

      // For Checked Out
      inHouseColumns,

      // For No Shows
      noShowColumns,

      // For Cancelled
      noShowColumns,

      // For Wait List
      inHouseColumns
    };
    }

    private void HomeForm_Load(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_InHouse);
      Session.AssertConnection();
      Session sesh = Program.session;
      lbl_UserFullName.Text = $"{sesh.lastName}, {sesh.firstName}";
      lbl_Username.Text = $"({sesh.username})";
    }

    private bool AskExitConfirmation()
    {
      var res = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
      return res == DialogResult.Yes;
    }

    private void lbl_InHouse_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_InHouse);
    }

    private void lbl_Arrivals_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Arrivals);
    }

    private void lbl_Departures_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Departures);
    }

    private void lbl_Reservations_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Reservations);
    }

    private void lbl_CheckedOut_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_CheckedOut);
    }

    private void lbl_NoShows_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_NoShows);
    }

    private void lbl_Cancelled_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Cancelled);
    }

    private void lbl_WaitList_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_WaitList);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = !AskExitConfirmation();
    }

    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new ChangePassword().ShowDialog();
    }

    private void pcmd_NewBooking_Click(object sender, EventArgs e)
    {
     new NewReservation().ShowDialog();
    }

    private void systemConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new SystemConfiguration().ShowDialog();
    }
  }
}
