using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            const double increment = 0.01 * 10;
            const double upperLimit = 12.0;
            int i0 = 0;

            StringBuilder output = new StringBuilder();

            for (double i = 0; i < upperLimit; i += increment)
            {
                i0 += 1;
                double analytical = Form1.form1.AnalyticalData[i0];
                double numerical = Form1.form1.NumericalData[i0];
                double absolute = Math.Abs(analytical - numerical);
                double relative = Math.Abs(analytical - numerical) / Math.Abs(analytical);
                double relative100 = relative * 100.0;

                output.AppendFormat("\t{0:F4}\t\t{1:F4}\t\t{2:F4}\t\t{3:F4}\t\t{4:F4}{5}",
                                    analytical, numerical, absolute, relative, relative100, Environment.NewLine);
            }

            textBox1.Text = output.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
