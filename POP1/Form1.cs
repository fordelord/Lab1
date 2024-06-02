using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POP1
{
    public partial class Form1 : Form
    {
        static public Form1 form1;

        public Form1()
        {
            InitializeComponent();

            form1 = this;
            
            y = new double[n];
            F = new MyDel[n];
            AnalyticalData = new List<double>();
            NumericalData = new List<double>();

            BuildChart();

        }
        private static double a = 60.0;
        private static double Rad = Math.PI / 180;
        private static double m = 0.02;
        private static double w = 2.0 / 3.0;
        private static double x0 = 0.1;
        private static double v0 = 0.3;
        private static double c = 0.45;
        private static double l0 = 0.5;
        private static double r = 0.15;
        private static double g = 9.81;
        private static double k2, B;
        private static double x, C1, C2;

        public double tMax { get; set; }

        public double dt;
        double dtInput = 0.01;

        double[] y;
        MyDel[] F;
        int n = 2;

        static double f;

        public delegate double MyDel(double t, double[] y);

        public List<double> AnalyticalData;
        public List<double> NumericalData;

        double f1(double t, double[] y)
        {
            return y[1];
        }
        double f2(double t, double[] y)
        {
            // ispav
            return -(c / m - w * w) * y[0] + c * l0 / m;
        }
        private double calculateBValue()
        {
            return c * l0 / m;
        }

        private double calculateK2Value()
        {
            return c / m - w * w;
        }
        private double[] getKYValue(double[] yValue, double[] y, int n)
        {
            double[] kYValue = new double[n];
            for (int i = 0; i < n; i++)
            {
                kYValue[i] = y[i] + 0.5 * yValue[i];
            }

            return kYValue;
        }

        public double[] RK(double t, double[] y, MyDel[] F, double h)
        {
            int n = y.Length;
            double[] k1 = new double[n];

            for (int i = 0; i < n; i++)
            {
                k1[i] = h * F[i](t, y);
            }

            // k2 calculation
            double[] k2 = new double[n];
            double[] k2YValue = getKYValue(k1, y, n);
            double tFunctionValue = t + h / 2;
            for (int i = 0; i < n; i++)
            {
                k2[i] = h * F[i](tFunctionValue, k2YValue);
            }

            double[] k3 = new double[n];
            double[] k3YValue = getKYValue(k2, y, n);
            for (int i = 0; i < n; i++)
            {
                k3[i] = h * F[i](tFunctionValue, k3YValue);
            }

            double[] k4 = new double[n];
            double[] k4YValue = new double[n];
            for (int i = 0; i < n; i++)
            {
                k4YValue[i] = y[i] + k3[i];
            }
            for (int i = 0; i < n; i++)
            {
                k4[i] = h * F[i](t + h, k4YValue);
            }

            double[] result = new double[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = y[i] + (k1[i] + 2 * k2[i] + 2 * k3[i] + k4[i]) / 6;
            }

            return result;
        }

        private void resetInputFields()
        {
            aInput.Value = Convert.ToDecimal(a);
            aInput.Increment = Convert.ToDecimal(1);

            mInput.Value = Convert.ToDecimal(m);
            mInput.Increment = Convert.ToDecimal(0.01);

            wInput.Value = Convert.ToDecimal(w);
            wInput.Increment = Convert.ToDecimal(0.01);

            xInput.Value = Convert.ToDecimal(x0);
            xInput.Increment = Convert.ToDecimal(0.01);

            vInput.Value = Convert.ToDecimal(v0);
            vInput.Increment = Convert.ToDecimal(0.01);

            cInput.Value = Convert.ToDecimal(c);
            cInput.Increment = Convert.ToDecimal(0.01);

            lInput.Value = Convert.ToDecimal(l0);
            lInput.Increment = Convert.ToDecimal(0.01);

            rInput.Value = Convert.ToDecimal(r);
            rInput.Increment = Convert.ToDecimal(0.01);

            comboBox1.Text = "0.01";
        }


        private void handleDefaultButtonClick(object sender, EventArgs e)
        {
            a = 60.0;
            m = 0.02;
            w = 2.0 / 3.0;
            x0 = 0.1;
            v0 = 0.3;
            c = 0.45;
            l0 = 0.5;
            r = 0.15;

            resetInputFields();
        }

        private void BuildChart()
        {
            //alla
            y[0] = x0;
            y[1] = v0;
            F[0] = f1;
            F[1] = f2;

            tMax = 12.0;
            dt = 0.01;
            int pointsLength = Convert.ToInt16(tMax / dt);


            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea("Default"));

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series);


            for (int i = 0; i < pointsLength; i++)
            {
                double t = i * dt;
                k2 = calculateK2Value();
                B = calculateBValue();


                if (k2 >= 0)
                {
                    C1 = x0 - B / k2;
                    C2 = v0 / Math.Sqrt(k2);
                    x = C1 * Math.Cos(Math.Sqrt(k2) * t) + C2 * Math.Sin(Math.Sqrt(k2) * t) + B / k2;
                }
                else if (k2 < 0)
                {
                    C1 = x0 / 2 + v0 / (2 * Math.Sqrt(Math.Abs(k2))) - B / (2 * k2);
                    C2 = x0 / 2 - v0 / (2 * Math.Sqrt(Math.Abs(k2))) - B / (2 * k2);
                    x = C1 * Math.Pow(Math.E, Math.Sqrt(Math.Abs(k2)) * t) + C2 * Math.Pow(Math.E, -Math.Sqrt(Math.Abs(k2)) * t)
                        + B / k2;
                }

                series.Points.AddXY(t, x);
                AnalyticalData.Add(x);

                //alla
                // y = RK(t, y, F, 0.01);
                //series.Points.AddXY(t, y[0]);
            }

            dt = 0.01;
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series2);
            for (double i = 0; i < tMax; i += dt)
            {
                y = RK(i, y, F, dt);
                series2.Points.AddXY(i, y[0]);
                NumericalData.Add(y[0]);
            }

            setOscillationsFrequency();
        }

        private void setOscillationsFrequency()
        {
            f = w / 2 / Math.PI;
            textBox1.Text = "Частота коливань: " + Convert.ToString(f);
        }

        private void onLoadForm(object sender, EventArgs e)
        {
            resetInputFields();

            k2 = calculateK2Value();
            B = calculateBValue();
        }

        private void handleAInputChange(object sender, EventArgs e)
        {
            a = Convert.ToDouble(aInput.Value);
            BuildChart();
        }

        private void handleMInputChange(object sender, EventArgs e)
        {
            m = Convert.ToDouble(mInput.Value);
            BuildChart();
        }

        private void handleWInputChange(object sender, EventArgs e)
        {
            w = Convert.ToDouble(wInput.Value);
            BuildChart();
        }

        private void handleXInputChange(object sender, EventArgs e)
        {
            x0 = Convert.ToDouble(xInput.Value);
            BuildChart();
        }

        private void handleVInputChange(object sender, EventArgs e)
        {
            v0 = Convert.ToDouble(vInput.Value);
            BuildChart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void handleCInputChange(object sender, EventArgs e)
        {
            c = Convert.ToDouble(cInput.Value);
            BuildChart();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = dtInput.ToString();

            BuildChart();
        }

        private void handleLInputChange(object sender, EventArgs e)
        {
            l0 = Convert.ToDouble(lInput.Value);
            BuildChart();
        }

        private void handleRInputChange(object sender, EventArgs e)
        {
            r = Convert.ToDouble(rInput.Value);
            BuildChart();
        }
    }
}