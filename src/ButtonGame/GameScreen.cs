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

    private int numButtons = 41;
    private ButtonSquare[] board;
    private Random random;

    private ButtonSquare highlightRight;
    private ButtonSquare highlightLeft;
    private Font buttonFont;

    public GameScreen()
    {
      buttonFont = new Font("Consolas", 12, FontStyle.Bold);

      timerInvalidate = new Timer();
      timerInvalidate.Enabled = false;
      timerInvalidate.Tick += timerInvalidate_Tick;

      random = new Random();
      DoubleBuffered = true; 
      Application.AddMessageFilter(this);

      DoYield(Rebuild);

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

    private int NextValue()
    {
      return random.Next(1, numButtons);
    }

    private void Rebuild()
    {
      var path = new Stack<ButtonSquare>();
      board = new ButtonSquare[numButtons];

      // pick a random position within the board
      int i = random.Next(numButtons);

      // assign a value to the button
      board[i] = new ButtonSquare
      {
        Index = i,
        Value = NextValue(),
        Selected = false,
      };

      path.Push(board[i]);

      int j, d, v;
      while (board.Any(b => b == null))
      {
        do
        {
          j = random.Next(numButtons);
        } 
        while (board[j] != null);

        var square = new ButtonSquare
        {
          Index = j,
          Selected = false,
        };
        board[j] = square;

        path.Push(square);

        v = 0;
        d = (random.Next() % 2 == 0) ? -1 : 1;
        while (j != i)
        {
          j = mod(j + d, numButtons);
          ++v;
        }

        square.Value = v;
        i = square.Index;
      }

      path.Peek().Selected = true;
      CalculateBounds();
    }

    private void CalculateBounds()
    {
      if (board == null)
      {
        return;
      }

      float padding = 10;
      float width = ClientSize.Width - (padding * 2);
      float x = padding;
      float squareSize = width / numButtons;

      float middle = ((float)ClientSize.Height) / 2;
      float y = (middle - squareSize / 2);

      for (int i = 0; i < numButtons; ++i, x += squareSize)
      {
        board[i].Bounds = new RectangleF(x, y, squareSize, squareSize);
      }
    }

    private void ReleaseMouseAll()
    {
      Array.ForEach(board, b => b.ReleaseMouse());
    }

    private int mod(int x, int m)
    {
      return (x % m + m) % m;
    }

    private int GetRight(ButtonSquare square)
    {
      return mod(square.Index + square.Value, board.Length);
    }

    private int GetLeft(ButtonSquare square)
    {
      return mod(square.Index - square.Value, board.Length);
    }

    private void SelectSquare(int i)
    {
      if (!board[i].Cleared)
      {
        board[i].Selected = true;
      }
    }

    private void UnselectAll()
    {
      foreach (var square in board)
      {
        square.Selected = false;
      }
    }

    private ButtonSquare HitTestSquare(Point pt)
    {
      return board.Where(b => b.Selected && !b.Cleared && b.Bounds.Contains(pt)).SingleOrDefault();
    }

    private void ClickSquare(ButtonSquare square)
    {
      UnselectAll();
      square.Cleared = true;

      SelectSquare(GetLeft(square));
      SelectSquare(GetRight(square));

      if (!board.Any(b => b.Selected))
      {
        if (board.All(b => b.Cleared))
        {
          MessageBox.Show(this, "You win! Press [Space] to start over");
        }
        else
        {
          MessageBox.Show(this, "You LOSE! Press [Space] to start over");
        }
      }
    }

    private void RenderScene(Graphics graphics)
    {
      graphics.Clear(Color.CornflowerBlue);

      if (board == null)
      {
        return;
      }

      Rectangle rect, highlight;
      int width, height, cx;

      foreach (var square in board)
      {
        if (square.Cleared)
        {
          continue;
        }

        rect = Rectangle.Truncate(square.Bounds);
        if (highlightLeft == square || highlightRight == square)
        {
          highlight = rect;
          highlight.Inflate(3, 3);
          graphics.FillRectangle(Brushes.Goldenrod, highlight);
        }

        string text = square.Value.ToString();
        ButtonRenderer.DrawButton(graphics, rect, text, buttonFont, square.Selected, square.State);

        if (square.Selected)
        {
          width = rect.Width / 2;
          height = rect.Height / 2;
          cx = rect.X + (rect.Width / 2);

          rect.X = cx - (width / 2);
          rect.Y -= height;
          rect.Width = width;
          rect.Height = height;

          TrackBarRenderer.DrawBottomPointingThumb(graphics, rect, TrackBarThumbState.Hot);
        }
      }
    }

    bool IMessageFilter.PreFilterMessage(ref Message m)
    {
      if (m.Msg == 0x0200)
      {
        highlightRight = null;
        highlightLeft = null;

        var pt = PointToClient(Cursor.Position);
        if (!Bounds.Contains(pt))
        {
          ReleaseMouseAll();
        }
        else
        {
          var square = HitTestSquare(pt);
          if (square != null)
          {
            highlightRight = board[GetRight(square)];
            highlightLeft = board[GetLeft(square)];
          }
        }
      }
      else if (m.Msg == 0x101)
      {
        Rebuild();
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
      CalculateBounds();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);
      if (board == null)
      {
        return;
      }

      ReleaseMouseAll();

      var square = HitTestSquare(e.Location);
      if (square != null)
      {
        square.CaptureMouse();
      }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);
      if (board == null)
      {
        return;
      }

      var square = board.SingleOrDefault(b => b.MouseDown);
      if (square != null)
      {
        ClickSquare(square);
      }

      ReleaseMouseAll();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      RenderScene(e.Graphics);
    }

    private void timerInvalidate_Tick(object sender, EventArgs e)
    {
      Invalidate();
    }
  }
}
