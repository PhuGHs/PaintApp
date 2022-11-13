using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public class RectangleCollection
    {
        private List<CustomRectangle> _rects;
        private List<CustomRectangle> _ellipses;

        public List<CustomRectangle> Rects { get { return _rects; } }
        public List<CustomRectangle> ellipses { get { return _ellipses; } }
        public RectangleCollection()
        {
            _rects = new List<CustomRectangle>();
            _ellipses = new List<CustomRectangle>();
        }
        public void generateCircle(Control panel, int x, int y)
        {
            Random rd = new Random();
            int Width = rd.Next(400);
            Rectangle r = new Rectangle(x, y, Width, Width);
            CustomRectangle cr = new CustomRectangle(r, Pens.Red);
            panel.Invalidate();
            ellipses.Add(cr);
        }

        public void generateRectangle(Control panel, int x, int y)
        {
            Random rd = new Random();
            int Width = rd.Next(400);
            int Height = rd.Next(400);
            Rectangle rec = new Rectangle(x, y, Width, Height);
            CustomRectangle cr = new CustomRectangle(rec, Pens.Blue);

            panel.Invalidate();
            _rects.Add(cr);
        }
    }
}
