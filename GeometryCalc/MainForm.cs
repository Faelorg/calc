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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var f = new Form1();

            f.Show();
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var f = new Form2();

            f.Show();
            this.Close();
        }
    }
}
