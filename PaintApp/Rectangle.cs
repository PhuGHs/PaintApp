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

        public Rectangle Rec { get { return _rec; } }
        public Pen Pen { get { return _pen; } }
        public CustomRectangle(Rectangle r, Pen pen)
        {
            this._rec = r;
            this._pen = pen;
        }
        
        public void DrawCustomRectangle(Graphics g, CustomRectangle rec)
        {
            g.DrawRectangle(rec._pen, rec._rec);
        }
    }
}
