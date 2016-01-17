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
    private ButtonSquareGame game;

    public GameScreen()
    {
      buttonFont = new Font("Consolas", 12, FontStyle.Bold);
      game = new ButtonSquareGame();

      timerInvalidate = new Timer();
      timerInvalidate.Enabled = false;
      timerInvalidate.Tick += timerInvalidate_Tick;

      DoubleBuffered = true; 
      Application.AddMessageFilter(this);

      if (!DesignMode)
      {
        DoYield(timerInvalidate.Start);
      }

      DoYield(() => game.Rebuild(Width, Height));
    }

    private async void DoYield(Action action)
    {
      await Task.Yield();
      action();
    }

    bool IMessageFilter.PreFilterMessage(ref Message m)
    {
      if (m.Msg == 0x0200)
      {
        var pt = PointToClient(Cursor.Position);
        game.UpdateHighlight(pt.X, pt.Y);
      }
      else if (m.Msg == 0x101)
      {
        game.Rebuild(ClientRectangle.Width, ClientRectangle.Height);
      }
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
      game.CalculateBounds(ClientRectangle.Width, ClientRectangle.Height);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);
      game.OnMouseDown(e.X, e.Y);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);
      var result = game.OnMouseUp(e.X, e.Y);
      switch (result)
      {
        case ButtonSquareGameResult.Lose:
          MessageBox.Show(this, "You lose! Press space to reset", "Result");
          break;
        case ButtonSquareGameResult.Win:
          MessageBox.Show(this, "You win! Press space to reset", "Result");
          break;
      }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      game.RenderScene(new GdiGraphics(e.Graphics));
    }

    private void timerInvalidate_Tick(object sender, EventArgs e)
    {
      Invalidate();
    }
  }
}
