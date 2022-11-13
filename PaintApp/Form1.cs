using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            curColor.ReadOnly = true;
            splitContainer1.Panel2.MouseUp += MouseUpHandler;
            curColor.BackColor = Color.Black;
        }
        private void color_Click(object sender, EventArgs e)
        {
            Program.myColor = new ColorDialog();
            Program.myColor.AllowFullOpen = false;
            Program.myColor.ShowHelp = true;
            Program.myColor.Color = curColor.BackColor;
            if(Program.myColor.ShowDialog() == DialogResult.OK)
            {
                curColor.BackColor = Program.myColor.Color;
            }
        }

        private void MouseUpHandler(object sender, MouseEventArgs e)
        {
            if (rec.Checked)
            {
                Program.myRectangles.generateRectangle(splitContainer1.Panel2,e.X, e.Y);
            }
            else if (tri.Checked)
            {

            }
            else
            {
                Program.myRectangles.generateCircle(splitContainer1.Panel2,e.X, e.Y);
            }
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            //Graphics g2 = e.Graphics;
            if (rec.Checked)
            {
                foreach(var rec in Program.myRectangles.Rects)
                {
                    rec.DrawCustomRectangle(g1, rec);
                }
            }
            else if (tri.Checked)
            {
                
            }
            else
            {
                foreach(var el in Program.myRectangles.ellipses)
                {
                    el.DrawCustomRectangle(g1, el);
                }
            }
        }
    }
}
