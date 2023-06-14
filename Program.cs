using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NoteView
{
  internal class UnexpectedException : Exception
  {
    public UnexpectedException(string msg) : base(msg) { }
  }

  internal static class Program
  {
    public static Session session;
    public static bool dbConnOk = false;

    public static void Assert(bool condition, string msg)
    {
      if (!condition) throw new UnexpectedException(msg);
    }

    public static void AssertUnreachable(string msg = "Code unreachable")
    {
      throw new UnexpectedException(msg);
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      try
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        // TODO: Implement correct form flow
       /* Application.Run(new NewReservation());
        return;*/
        Application.Run(new SetupDB());
        if (!dbConnOk) return;
          Application.Run(new UserLogin());
        if (session == null || session.username == null) return;
        Application.Run(new HomeForm());
      }
      finally
      {
        Session.conn?.Close();
      }
    }
  }
}
