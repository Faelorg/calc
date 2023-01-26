﻿using System;
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
    public partial class Form2 : Form
    {
        Triangle triangle = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            lblRes1.Text = "Результат";

            lblRes2.Text = "Результат";

            double a;
            double b;
            double c;
            bool p = false;
            try
            {
                StringBuilder err = new StringBuilder();
                a = Convert.ToDouble(txbA1.Text);
                b = Convert.ToDouble(txbB1.Text);
                c = Convert.ToDouble(txbC1.Text);

                if (a < 0)
                {
                    p = true;
                    txbA1.Text = "";
                    err.Append("Сторона а имела неверный формат ");
                }
                if (b < 0)
                {
                    p = true;
                    txbB1.Text = "";
                    err.Append("Сторона b имела неверный формат. ");
                }
                if (c < 0)
                {
                    p = true;
                    txbC1.Text = "";
                    err.Append("Угол а имел неверный формат. ");
                }
                if (p)
                {
                    throw new Exception(err.ToString());
                }
                triangle = new Triangle(a, b, c, null);

                lblRes1.Text = lblRes1.Text + " " + triangle.resultSquareAB().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
