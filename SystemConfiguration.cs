using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Text.RegularExpressions;

namespace NoteView
{
  public partial class SystemConfiguration : Form
  {
    private const string RoomSearchInactiveStringHeader = "Existing Rooms";
    private const string RoomSearchActiveStringHeader = "Searching for rooms..";
    private const string ServiceSearchInactiveStringHeader = "Existing Services";
    private const string ServiceSearchActiveStringHeader = "Searching for services..";

    private readonly Label[] selectionLabels;
    private readonly Panel[] controlPanels;
    private readonly string[] inactiveSelectionTexts;
    private readonly string[] activeSelectionTexts;
    private readonly Font inactiveSelectionFont = new Font("Verdana", 9, FontStyle.Regular);
    private readonly Font activeSelectionFont = new Font("Verdana", 10, FontStyle.Bold);


    public SystemConfiguration()
    {
      InitializeComponent();

      selectionLabels = new Label[]
      {
        lbl_Room,
        lbl_Service
      };

      controlPanels = new Panel[]
      {
        pnl_Room,
        pnl_Service
      };

      inactiveSelectionTexts = new string[]
      {
        "Rooms",
        "Services"
      };

      activeSelectionTexts = new string[inactiveSelectionTexts.Length];

      for (int i = 0; i < inactiveSelectionTexts.Length; ++i)
      {
        activeSelectionTexts[i] = $"▶ {inactiveSelectionTexts[i]}";
      }
    }

    private void SelectControlPanel(Label selected)
    {
      int found = -1;
      // Disabler loop
      for (int i = 0; i < selectionLabels.Length; ++i)
      {
        Label lbl = selectionLabels[i];
        if (lbl == selected) found = i;
        lbl.Text = inactiveSelectionTexts[i];
        controlPanels[i].Visible = false;
        controlPanels[i].Dock = DockStyle.None;
        lbl.Font = inactiveSelectionFont;
        lbl.ForeColor = Color.Black;
      }

      Program.Assert(found != -1, "Label [selected] is not in selection labels");
      selected.Text = activeSelectionTexts[found];
      controlPanels[found].Visible = true;
      controlPanels[found].Dock = DockStyle.Fill;
      selected.Font = activeSelectionFont;
      selected.ForeColor = Color.Navy;
    }

    private void SetRoomConfigControls(bool state)
    {
      dgv_Rooms.Enabled = state;
      pcmd_RoomSearch.Enabled = state;
      txt_RoomSearch.Enabled = state;
    }

    private void FetchRooms(string keyword = null)
    {
      SetRoomConfigControls(false);
      UseWaitCursor = true;
      dgv_Rooms.Rows.Clear();
      gb_RoomTable.Text = RoomSearchActiveStringHeader;
      bwork_RoomFetcher.RunWorkerAsync(keyword);
    }

    private struct RoomFetchRow
    {
      public string id, roomNo, roomType, rate, capacity;

      public RoomFetchRow(string id, string no, string type, string rate, string capacity)
      {
        this.id = id;
        roomNo = no;
        roomType = type;
        this.rate = rate;
        this.capacity = capacity;
      }
    }

    private void bwork_RoomFetcher_DoWork(object sender, DoWorkEventArgs e)
    {
      string query;

      if (e.Argument == null)
      {
        query = $"SELECT * FROM Room;";
      }
      else
      {
        string sought = (string) e.Argument;
        query = $"SELECT * FROM Room WHERE roomNumber LIKE '%{sought}%' OR roomType LIKE '%{sought}%';";
      }

      Session.AssertConnection();

      RoomFetchRow row = new RoomFetchRow();

      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        cmd.CommandText = query;
        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            row.id = $"{reader.GetInt32("id")}";
            row.roomNo = reader.GetString("roomNumber");
            row.roomType = reader.GetString("roomType");
            row.rate = $"{reader.GetFloat("rate")}";
            row.capacity = $"{reader.GetInt32("capacity")}";

            bwork_RoomFetcher.ReportProgress(0, row);
          }
        }
      }
    }

    private void bwork_RoomFetcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      SetRoomConfigControls(true);
      UseWaitCursor = false;
      if (e.Error == null)
      {
        gb_RoomTable.Text = RoomSearchInactiveStringHeader;
      } 
      else
      {
        MessageBox.Show("Cannot fetch rooms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      cmd_RoomRemove.Enabled = dgv_Rooms.CurrentRow != null;
    }

    private void SystemConfiguration_Load(object sender, EventArgs e)
    {
      SelectControlPanel(lbl_Room);
      FetchRooms();
    }

    private void pcmd_RoomSearch_Click(object sender, EventArgs e)
    {
      FetchRooms(string.IsNullOrWhiteSpace(txt_RoomSearch.Text) ? null : txt_RoomSearch.Text);
    }

    private void bwork_RoomFetcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      RoomFetchRow row = (RoomFetchRow) e.UserState;

      dgv_Rooms.Rows.Add(row.id, row.roomNo, row.roomType, row.rate, row.capacity);
    }

    private void cmd_RoomRemove_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure?", "Confirm Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        bwork_RoomDeleter.RunWorkerAsync(dgv_Rooms.SelectedRows);
      }
    }

    private void bwork_RoomDeleter_DoWork(object sender, DoWorkEventArgs e)
    {
      DataGridViewSelectedRowCollection rows = (DataGridViewSelectedRowCollection) e.Argument;
      Session.AssertConnection();

      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        foreach (DataGridViewRow row in rows)
        {
          cmd.CommandText = $"DELETE FROM Room WHERE id = {row.Cells[0].Value};";
          cmd.ExecuteNonQuery();
        }
      }
    }

    private void bwork_RoomDeleter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null)
      {
        FetchRooms(txt_RoomSearch.Text);
      }
      else
      {
        MessageBox.Show("Cannot delete room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private static void SetControls(bool state, params Control[] ctrls)
    {
      foreach (Control ctrl in ctrls)
      {
        ctrl.Enabled = state;
      }
    }

    private bool AllFilled(params TextBox[] txts)
    {
      foreach (TextBox txt in txts)
      {
        if (string.IsNullOrEmpty(txt.Text)) return false;
      }
      return true;
    }

    private static readonly Regex RealNumRegex = new Regex("^[0-9]*(\\.[0-9]+)?$");
    private static readonly Regex IntNumRegex = new Regex("^[0-9]*$");

    private void cmd_RoomAdd_Click(object sender, EventArgs e)
    {
      if (!AllFilled(txt_RoomNo, txt_RoomType, txt_RoomRate, txt_RoomCapacity))
      {
        MessageBox.Show("Missing room information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!RealNumRegex.IsMatch(txt_RoomRate.Text))
      {
        MessageBox.Show("Rate must be a real number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (!IntNumRegex.IsMatch(txt_RoomCapacity.Text))
      {
        MessageBox.Show("Capacity must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      bool abort = MessageBox.Show("Are you sure? You cannot change room info later", "Confirm Room Addition", MessageBoxButtons.YesNo) == DialogResult.No;
      if (abort) return;

      SetControls(false, txt_RoomNo, txt_RoomType, txt_RoomRate, txt_RoomCapacity, cmd_RoomAdd);
      bwork_RoomAdder.RunWorkerAsync();
    }

    private void bwork_RoomAdder_DoWork(object sender, DoWorkEventArgs e)
    {
      UseWaitCursor = true;

      string roomNo = txt_RoomNo.Text;
      string roomType = txt_RoomType.Text;
      string rate = txt_RoomRate.Text;
      string capacity = txt_RoomCapacity.Text;

      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        // Verify if data is original
        cmd.CommandText = $"SELECT * FROM Room WHERE roomNumber = '{roomNo}';";
        using (MySqlDataReader dr = cmd.ExecuteReader())
        {
          if (dr.HasRows)
          {
            throw new ArgumentException("Duplicate room found, cannot add this room.");
          }
        }

        cmd.CommandText = $"INSERT INTO Room (roomNumber, roomType, rate, capacity) VALUES ('{roomNo}', '{roomType}', {rate}, {capacity});";
        cmd.ExecuteNonQuery();
      }
    }

    private void bwork_RoomAdder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        switch (e.Error)
        {
          case ArgumentException exc:
            MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            break;
          case MySqlException exc:
            MessageBox.Show("Cannot add room to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            break;
          default:
            MessageBox.Show($"An error occured. {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            break;
        }
      }
      else
      {
        MessageBox.Show("Room added successfully");
        txt_RoomNo.Text = string.Empty;
        txt_RoomType.Text = string.Empty;
        txt_RoomRate.Text = string.Empty;
        txt_RoomCapacity.Text = string.Empty;
      }

      SetControls(true, txt_RoomNo, txt_RoomType, txt_RoomRate, txt_RoomCapacity, cmd_RoomAdd);
      UseWaitCursor = false;
      FetchRooms();
    }

    private void pcmd_RoomClear_Click(object sender, EventArgs e)
    {
      txt_RoomNo.Text = string.Empty;
      txt_RoomType.Text = string.Empty;
      txt_RoomRate.Text = string.Empty;
      txt_RoomCapacity.Text = string.Empty;
    }
    
    private void lbl_Room_Click(object sender, EventArgs e)
    {
      SelectControlPanel(lbl_Room);
    }

    private void lbl_Service_Click(object sender, EventArgs e)
    {
      SelectControlPanel(lbl_Service);
    }
  }
}
