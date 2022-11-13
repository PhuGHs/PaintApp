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
            SolidBrush fillColor = new SolidBrush(Program.myColor.Color);
            CustomRectangle cr = new CustomRectangle("circle", r, fillColor);
            panel.Invalidate();
            _rects.Add(cr);
        }

        public void generateRectangle(Control panel, int x, int y)
        {
            Random rd = new Random();
            int Width = rd.Next(400);
            int Height = rd.Next(400);
            Rectangle rec = new Rectangle(x, y, Width, Height);
            SolidBrush fillColor = new SolidBrush(Program.myColor.Color);
            CustomRectangle cr = new CustomRectangle("rectangle", rec, fillColor);

            panel.Invalidate();
            _rects.Add(cr);
        }

        public void generateTriangle(Control panel, int x, int y)
        {
            Random rd = new Random();
            int x1 = rd.Next(400);
            int y1 = rd.Next(400);
            int x2 = rd.Next(400);
            int y2 = rd.Next(400);
            Point point1 = new Point(x, y);
            Point point2 = new Point(x1, y1);
            Point point3 = new Point(x2, y2);
            Point[] points = { point1, point2, point3 };
            
            SolidBrush fillColor = new SolidBrush(Program.myColor.Color);

            panel.Invalidate();
            CustomRectangle cr = new CustomRectangle("triangle", points, fillColor);
            _rects.Add(cr);
        }
    }
}
