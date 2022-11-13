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
        private Pen _pen;
        string _shape;

        public Rectangle Rec { get { return _rec; } }
        public Pen Pen { get { return _pen; } }
        public string Shape { get { return _shape; } }
        public CustomRectangle(string shape, Rectangle r, Pen pen)
        {
            this._shape = shape;
            this._rec = r;
            this._pen = pen;
        }
        
        public void DrawCustomRectangle(Graphics g, CustomRectangle rec)
        {
            if (rec._shape == "rectangle")
            {
                g.DrawRectangle(rec._pen, rec._rec);
            }
            else if (rec._shape == "circle")
            {
                g.DrawEllipse(rec._pen, rec._rec);
            }
        }
    }
}
