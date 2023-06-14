using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoteView
{
  internal class Staller : BackgroundWorker
  {
    public delegate void Done();
    public Staller() : base()
    {
      WorkerReportsProgress = false;
      DoWork += new DoWorkEventHandler(DoWorkMethod);
      RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompletedMethod);
    }

    public void DoWorkMethod(object sender, DoWorkEventArgs e)
    {
      Thread.Sleep(500);
      e.Result = e.Argument;
    }

    public void RunWorkerCompletedMethod(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null && e.Result != null)
      {
        ((Done) e.Result)();
      }
    }
  }
}
