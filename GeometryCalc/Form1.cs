using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryCalc
{
    public partial class Form1 : Form
    {

        Triangle triangle;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            lblRes1.Text = "Результат";

            lblRes2.Text = "Результат";

            double a;
            double b;
            double al;
            bool p = false;
            try
            {
                StringBuilder err = new StringBuilder();
                a = Convert.ToDouble(txbA1.Text);
                b = Convert.ToDouble(txbB1.Text);
                al = Convert.ToDouble(txbAl1.Text);

                if (a<0)
                {
                    p = true;
                    txbA1.Text = "";
                    err.Append("Сторона а имела неверный формат ");
                }
                 if (b<0)
                {
                    p = true;
                    txbB1.Text = "";
                    err.Append("Сторона b имела неверный формат. ");
                }
                if (al<0)
                {
                    p = true;
                    txbAl1.Text = "";
                    err.Append("Угол а имел неверный формат. ");
                }
                if (al>= 180)
                {
                    p = true;
                    txbAl1.Text = "";
                    err.Append("Угол а недопустим. ");
                }

                if (p)
                {
                    throw new Exception(err.ToString());
                }
                    triangle = new Triangle();

                triangle.a = a;

                triangle.b = b;

                triangle.al = al;

                lblRes1.Text = lblRes1.Text + " " + triangle.resultSquareAB().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                StringBuilder err = new StringBuilder();
                a = Convert.ToDouble(txbA2.Text);
                b = Convert.ToDouble(txbB2.Text);
                al = Convert.ToDouble(txbAl2.Text);
                if (a < 0)
                {
                    p = true;
                    txbA2.Text = "";
                    err.Append("Сторона а имела неверный формат ");
                }
                if (b < 0)
                {
                    p = true;
                    txbB2.Text = "";
                    err.Append("Сторона b имела неверный формат. ");
                }
                if (al < 0)
                {
                    p = true;
                    txbAl2.Text = "";
                    err.Append("Угол а имел неверный формат. ");
                }
                if (al >= 180)
                {
                    p = true;
                    txbAl2.Text = "";
                    err.Append("Угол а недопустим. ");
                }

                if (p)
                {
                    throw new Exception(err.ToString());
                }
                triangle = new Triangle();

                triangle.a = a;

                triangle.b = b;

                triangle.al = al;

                lblRes2.Text = lblRes2.Text + " " + Math.Round(triangle.resultSquareAB(),3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
