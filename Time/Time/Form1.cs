using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        private DateTime t1;
        private DateTime t2;

        public Form1()
        {
            InitializeComponent();

            minUP.Maximum = 59;
            minUP.Minimum = 0;

            minUP.TabStop = false;

            secUP.Maximum = 59;
            secUP.Minimum = 0;

            secUP.TabStop = false;

            button1.Enabled = false;
        }
        private void minUP_ValueChanged(object sender, EventArgs e)
        {
            if ((minUP.Value == 0) &&
                    (secUP.Value == 0))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                t1 = new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.Day);
                t2 = t1.AddMinutes((double)minUP.Value);
                t2 = t2.AddSeconds((double)secUP.Value);

                groupBox1.Enabled = false;
                button1.Text = "Стоп";

                if (t2.Minute < 9)
                    Time.Text = "0" + t2.Minute.ToString() + ":";
                else
                    Time.Text = t2.Minute.ToString() + ":";

                if (t2.Second < 9)
                    Time.Text += "0" + t2.Second.ToString();
                else
                    Time.Text += t2.Second.ToString();

                timer1.Interval = 1000;

                timer1.Enabled = true;

                groupBox1.Visible = false;
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";
                groupBox1.Enabled = true;
                minUP.Value = t2.Minute;
                secUP.Value = t2.Second;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t2 = t2.AddSeconds(-1);
            
            if (t2.Minute < 9)
                Time.Text = "0" + t2.Minute.ToString() + ":";
            else
                Time.Text = t2.Minute.ToString() + ':';

            if (t2.Second < 9)
                Time.Text += "0" + t2.Second.ToString();
            else
                Time.Text += t2.Second.ToString();

            if (Equals(t1, t2))
            {
                timer1.Enabled = false;
                DialogResult result = MessageBox.Show(Owner, "Заданный интервал времени истёк", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button1.Text = "Пуск";
                groupBox1.Enabled = true;
                minUP.Value = 0;
                secUP.Value = 0;
                Application.Restart();
            }
        }

        private void Time_Click(object sender, EventArgs e)
        {
            
        }

        private void Sec_Click(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {

        }
    }
}
