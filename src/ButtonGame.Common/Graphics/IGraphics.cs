using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonGame
{
  public interface IGraphics
  {
    void Clear(ARGB color);
    void DrawLine(ARGB color, float x1, float y1, float x2, float y2);
    void DrawRectangle(ARGB color, float x, float y, float width, float height);
    void FillRectangle(ARGB color, float x, float y, float width, float height);
  }
}
