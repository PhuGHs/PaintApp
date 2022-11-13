using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public class CustomRectangle
    {
        private Rectangle _rec;
        private SolidBrush _fillColor;
        private Point[] _points;
        string _shape;

        public Rectangle Rec { get { return _rec; } }
        public Point[] Points { get { return _points; } }
        public SolidBrush FillColor { get { return _fillColor; } }
        public string Shape { get { return _shape; } }
        public CustomRectangle(string shape, Rectangle r, SolidBrush fillColor)
        {
            this._shape = shape;
            this._rec = r;
            this._fillColor = fillColor;
        }

        public CustomRectangle(string shape, Point[] points, SolidBrush fillColor)
        {
            this._shape = shape;
            this._points = points;
            this._fillColor = fillColor;
        }
        
        public void DrawCustomRectangle(Graphics g, CustomRectangle rec)
        {
            if (rec._shape == "rectangle")
            {
                g.FillRectangle(FillColor, Rec);
            }
            else if (rec._shape == "circle")
            {
                g.FillEllipse(FillColor, Rec);
            }
            else //triangle
            {
                g.FillPolygon(FillColor, Points);
            }
        }
    }
}
