using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        Stats ST = new Stats();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((prob1.Value + prob2.Value + prob3.Value + prob4.Value) > 1) state.Text = "Неудачная выборка";
            else
            {
                state.Text = "Успешно!";
				ST.SetData((int)number.Value, prob1.Value, prob2.Value, prob3.Value, prob4.Value);
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series[0].Points.Clear();
                decimal[] pointsXY = ST.GetData();
                for (int i = 0; i < pointsXY.Length; i++)
                {

                    chart1.Series[0].Points.AddXY(i + 1, pointsXY[i]);
                }
                prob5.Text = Convert.ToString(1 - (prob1.Value + prob2.Value + prob3.Value + prob4.Value));
                
                decimal av = 0;
                decimal var = 0;
                decimal E = 0;
                decimal D = 0;
                decimal error_av;
                decimal error_var;
                decimal chi_square = 0;

                for (int i = 0; i < ST.size; i++)
                {
                    av += pointsXY[i] * (i + 1);
                    var += pointsXY[i] * (i + 1) * (i + 1);
                    E += ST.prob[i] * (i + 1);
                    D += ST.prob[i] * (i + 1) * (i + 1);
                    chi_square += (ST.stat[i] * ST.stat[i]) / (ST.N * ST.prob[i]);
                }
                D -= E * E;
                var -= av * av;
                error_var = Decimal.Round(Math.Abs((var - D) / E) * 100);
                error_av = Decimal.Round(Math.Abs((av - E) / D) * 100);
                chi_square -= ST.N;
                lable7.Text = "Average: " + av.ToString();
				label8.Text = "Variance: " + var.ToString();
                label7.Text = "error = " + Convert.ToString(error_av) + "%";
				label10.Text = "error = " + Convert.ToString(error_var) + "%";
				
                if (chi_square > 11.07M)
                {
                    chi.Text = Convert.ToString(Decimal.Round(chi_square, 2)) + " < 11,07";
                    state.Text = "is false";
                }
                else
                {
                    chi.Text = Convert.ToString(Decimal.Round(chi_square, 2)) + " < 11,07";
                    state.Text = "is true";
                }
            }
        }
    }
    public class Stats
	{
        Random r = new Random();
        public int N;
        public int[] stat;
        public decimal[] prob;
        public int size;
        public void SetData(int N, params decimal[] m)
        {
            size = m.Length + 1;
            prob = new decimal[m.Length + 1];
            this.N = N;
            stat = new int[m.Length + 1];
            stat[m.Length] = 0;
            for (int i = 0; i < m.Length; i++)
            {
                prob[i] = m[i];
                stat[i] = 0;
            }
            prob[m.Length] = 1 - prob[0] - prob[1] - prob[2] - prob[3];
        }
        public decimal[] GetData()
        {
            decimal A;
            int k = -1;
            decimal[] freq = new decimal[stat.Length];
            for (int i = 0; i < N; i++)
            {
                A = (decimal)r.NextDouble();
                for (k = -1; A > 0; k++)
                {
                    A -= prob[k + 1];
                }
                stat[k]++;
            }
            for (int i = 0; i < stat.Length; i++)
            {
                freq[i] = (decimal)stat[i] / N;
            }
            return freq;
        }
    }
}
