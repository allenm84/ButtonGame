using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonGame
{
  public class GdiGraphics : IGraphics
  {
    private Graphics graphics;

    public GdiGraphics(Graphics graphics)
    {
      this.graphics = graphics;
    }

    private static Color GetColor(ARGB color)
    {
      return Color.FromArgb(color.A, color.R, color.G, color.B);
    }

    void IGraphics.Clear(ARGB color)
    {
      graphics.Clear(GetColor(color));
    }

    void IGraphics.DrawLine(ARGB color, float x1, float y1, float x2, float y2)
    {
      using (var pen = new Pen(GetColor(color)))
      {
        graphics.DrawLine(pen, x1, y1, x2, y2);
      }
    }

    void IGraphics.DrawRectangle(ARGB color, float x, float y, float width, float height)
    {
      using (var pen = new Pen(GetColor(color)))
      {
        graphics.DrawRectangle(pen, x, y, width, height);
      }
    }

    void IGraphics.FillRectangle(ARGB color, float x, float y, float width, float height)
    {
      using (var brush = new SolidBrush(GetColor(color)))
      {
        graphics.FillRectangle(brush, x, y, width, height);
      }
    }
  }
}
