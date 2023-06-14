using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
  internal class PictureButton : PictureBox
  {
    public PictureButton() : base()
    {
      MouseHover += OnHover;
      MouseDown += OnMouseDown;
      MouseLeave += OnIdle;
    }

    private void OnHover(object sender, EventArgs e)
    {
      BorderStyle = BorderStyle.FixedSingle;
    }

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
      BorderStyle = BorderStyle.Fixed3D;
    }

    private void OnIdle(object sender, EventArgs e)
    {
      BorderStyle = BorderStyle.None;
    }
  }
}
