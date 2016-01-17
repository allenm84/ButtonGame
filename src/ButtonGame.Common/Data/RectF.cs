using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonGame
{
  public struct RectF
  {
    public float X, Y, Width, Height;

    public float Left { get { return X; } }
    public float Right { get { return X + Width; } }
    public float Top { get { return Y; } }
    public float Bottom { get { return Y + Height; } }

    public RectF(float x, float y, float width, float height)
    {
      X = x;
      Y = y;
      Width = width;
      Height = height;
    }

    public bool Contains(float x, float y)
    {
      return X <= x &&
            x < Right &&
            Y <= y &&
            y < Bottom;
    }

    public void Inflate(float x, float y)
    {
      X -= x;
      Y -= y;
      Width += 2 * x;
      Height += 2 * y;
    }
  }
}
