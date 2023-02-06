using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Linq.Expressions;

namespace GeometryCalc
{
    public partial class FormDraw : Form
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public FormDraw(double a, double b, double c)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;

            drawTriangle(a, b, c);
        }

        private void drawTriangle(double a, double b, double c)
        {
            Point[] points = new Point[3];

            points[0].X = 0; points[0].Y = 0;

            points[1].X = (int)a; points[1].Y = 0;

            points[2].X = (int)b; points[2].Y = (int)c;

            Bitmap bmp = new Bitmap(pcbDraw.Width, pcbDraw.Height);

            using (Graphics grfx = Graphics.FromImage(bmp))
            {
                // Рисуем.
                grfx.Clear(Color.White);
                grfx.DrawPolygon(Pens.Black, points);
            }
            
            // Устанавливаем изображение.
            pcbDraw.Image = bmp;
        }

        private void pcbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    pcbDraw.Scale(2);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    pcbDraw.Scale(-2);
                }

            }
            catch
            {

            }
        }
    }
}
