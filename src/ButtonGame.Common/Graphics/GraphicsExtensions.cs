using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonGame
{
  public static class GraphicsExtensions
  {
    public static void DrawRectangle(this IGraphics graphics, ARGB color, RectF rect)
    {
      graphics.DrawRectangle(color, rect.X, rect.Y, rect.Width, rect.Height);
    }

    public static void FillRectangle(this IGraphics graphics, ARGB color, RectF rect)
    {
      graphics.FillRectangle(color, rect.X, rect.Y, rect.Width, rect.Height);
    }

    public static void DrawButton(this IGraphics graphics, RectF rect, string text, bool focused, bool pressed)
    {
      ARGB fill = pressed ? ARGB.Gray : ARGB.LightGray;
      ARGB tlBorder = pressed ? ARGB.DarkGray : new ARGB(212, 212, 212);
      ARGB brBorder = pressed ? new ARGB(212, 212, 212) : ARGB.DarkGray;

      // draw a line at the top
      graphics.FillRectangle(fill, rect);

      for (int l = 0; l <= 1; ++l)
      {
        graphics.DrawLine(tlBorder, rect.X + l, rect.Y + l, rect.Right - l, rect.Y + l);
        graphics.DrawLine(tlBorder, rect.X + l, rect.Y + l, rect.X + l, rect.Bottom - l);

        graphics.DrawLine(brBorder, rect.X + l, rect.Bottom - l, rect.Right - l, rect.Bottom - l);
        graphics.DrawLine(brBorder, rect.Right - l, rect.Y + l, rect.Right - l, rect.Bottom - l);
      }
    }

    public static void DrawBottomPointingThumb(this IGraphics graphics, RectF rect)
    {
    }
  }
}
