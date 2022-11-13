using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myRectangles = new RectangleCollection();
            myColor = new ColorDialog();
            myColor.Color = Color.Black;
            Application.Run(new Form1());
        }
        public static ColorDialog myColor { get; set; }
        public static RectangleCollection myRectangles { get; set; }
    }
}
