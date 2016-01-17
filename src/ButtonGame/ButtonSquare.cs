using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ButtonGame
{
  public class ButtonSquare
  {
    public int Index;
    public bool Selected;
    public int Value;
    public bool Cleared;
    public RectangleF Bounds;
    public PushButtonState State;
    public bool MouseDown;

    internal void ReleaseMouse()
    {
      MouseDown = false;
      State = PushButtonState.Normal;
    }

    internal void CaptureMouse()
    {
      MouseDown = true;
      State = PushButtonState.Pressed;
    }
  }
}
