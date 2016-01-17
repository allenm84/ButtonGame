using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ButtonGame
{
  public class GameScreen : Panel, IMessageFilter
  {
    private Timer timerInvalidate;
    private Font buttonFont;

    public GameScreen()
    {
      buttonFont = new Font("Consolas", 12, FontStyle.Bold);

      timerInvalidate = new Timer();
      timerInvalidate.Enabled = false;
      timerInvalidate.Tick += timerInvalidate_Tick;

      DoubleBuffered = true; 
      Application.AddMessageFilter(this);

      if (!DesignMode)
      {
        DoYield(timerInvalidate.Start);
      }
    }

    private async void DoYield(Action action)
    {
      await Task.Yield();
      action();
    }

    bool IMessageFilter.PreFilterMessage(ref Message m)
    {
      //if (m.Msg == 0x0200)
      //{
      //  highlightRight = null;
      //  highlightLeft = null;

      //  var pt = PointToClient(Cursor.Position);
      //  if (!Bounds.Contains(pt))
      //  {
      //    ReleaseMouseAll();
      //  }
      //  else
      //  {
      //    var square = HitTestSquare(pt);
      //    if (square != null)
      //    {
      //      highlightRight = board[GetRight(square)];
      //      highlightLeft = board[GetLeft(square)];
      //    }
      //  }
      //}
      //else if (m.Msg == 0x101)
      //{
      //  Rebuild();
      //}
      return false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        Application.RemoveMessageFilter(this);

        if (timerInvalidate != null)
        {
          timerInvalidate.Stop();
          timerInvalidate.Tick -= timerInvalidate_Tick;
          timerInvalidate.Dispose();
          timerInvalidate = null;
        }
      }
      base.Dispose(disposing);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      base.OnSizeChanged(e);
      //CalculateBounds();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);
      //if (board == null)
      //{
      //  return;
      //}

      //ReleaseMouseAll();

      //var square = HitTestSquare(e.Location);
      //if (square != null)
      //{
      //  square.CaptureMouse();
      //}
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);
      //if (board == null)
      //{
      //  return;
      //}

      //var square = board.SingleOrDefault(b => b.MouseDown);
      //if (square != null)
      //{
      //  ClickSquare(square);
      //}

      //ReleaseMouseAll();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      //RenderScene(e.Graphics);
    }

    private void timerInvalidate_Tick(object sender, EventArgs e)
    {
      Invalidate();
    }
  }
}
