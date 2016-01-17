using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonGame
{
  public class ButtonGame
  {
    private int numButtons = 41;
    private ButtonSquare[] board;
    private Random random;

    private ButtonSquare highlightRight;
    private ButtonSquare highlightLeft;

    public ButtonGame()
    {
      random = new Random();
    }

    private int NextValue()
    {
      return random.Next(1, numButtons);
    }

    public void Rebuild(float screenWidth, float screenHeight)
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
      CalculateBounds(screenWidth, screenHeight);
    }

    public void CalculateBounds(float screenWidth, float screenHeight)
    {
      if (board == null)
      {
        return;
      }

      float padding = 10;
      float width = screenWidth - (padding * 2);
      float x = padding;
      float squareSize = width / numButtons;

      float middle = screenHeight / 2;
      float y = (middle - squareSize / 2);

      for (int i = 0; i < numButtons; ++i, x += squareSize)
      {
        board[i].Bounds = new RectF(x, y, squareSize, squareSize);
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

    private ButtonSquare HitTestSquare(PtF pt)
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
          //MessageBox.Show(this, "You win! Press [Space] to start over");
        }
        else
        {
          //MessageBox.Show(this, "You LOSE! Press [Space] to start over");
        }
      }
    }

    private void RenderScene(IGraphics graphics)
    {
      graphics.Clear(ARGB.CornflowerBlue);

      if (board == null)
      {
        return;
      }

      RectF rect, highlight;
      float width, height, cx;

      foreach (var square in board)
      {
        if (square.Cleared)
        {
          continue;
        }

        rect = square.Bounds;
        if (highlightLeft == square || highlightRight == square)
        {
          highlight = rect;
          highlight.Inflate(3, 3);
          graphics.FillRectangle(ARGB.Goldenrod, highlight);
        }

        string text = square.Value.ToString();
        graphics.DrawButton(rect, text, square.Selected, square.State);

        if (square.Selected)
        {
          width = rect.Width / 2;
          height = rect.Height / 2;
          cx = rect.X + (rect.Width / 2);

          rect.X = cx - (width / 2);
          rect.Y -= height;
          rect.Width = width;
          rect.Height = height;

          graphics.DrawBottomPointingThumb(rect);
        }
      }
    }
  }
}
