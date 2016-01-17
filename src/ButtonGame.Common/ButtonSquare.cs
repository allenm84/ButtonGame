using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonGame
{
  public class ButtonSquare
  {
    public int Index;
    public bool Selected;
    public int Value;
    public bool Cleared;
    public RectF Bounds;
    public ButtonState State;
    public bool MouseDown;

    internal void ReleaseMouse()
    {
      MouseDown = false;
      State = ButtonState.Normal;
    }

    internal void CaptureMouse()
    {
      MouseDown = true;
      State = ButtonState.Pressed;
    }
  }
}
