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

        public List<CustomRectangle> Rects { get { return _rects; } }
        public RectangleCollection()
        {
            _rects = new List<CustomRectangle>();
        }
        public void generateCircle(Control panel, int x, int y)
        {
            Random rd = new Random();
            int Width = rd.Next(400);
            Rectangle r = new Rectangle(x, y, Width, Width);
            Pen pen = new Pen(Program.myColor.Color);
            CustomRectangle cr = new CustomRectangle("circle", r, pen);
            panel.Invalidate();
            _rects.Add(cr);
        }

        public void generateRectangle(Control panel, int x, int y)
        {
            Random rd = new Random();
            int Width = rd.Next(400);
            int Height = rd.Next(400);
            Rectangle rec = new Rectangle(x, y, Width, Height);
            Pen pen = new Pen(Program.myColor.Color);
            CustomRectangle cr = new CustomRectangle("rectangle", rec, pen);

            panel.Invalidate();
            _rects.Add(cr);
        }
    }
}
