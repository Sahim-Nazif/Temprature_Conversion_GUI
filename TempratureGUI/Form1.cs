using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempratureGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            

            double farenheit = double.Parse(numberEnter.Text);
            double celcius;

            if (radioButton1.Checked)
            {
                celcius = (farenheit - 32) * 5 / 9;

                Result.Text = Math.Round(celcius).ToString();
            }
            else if (radioButton2.Checked)
            {
                celcius = double.Parse(numberEnter.Text);
                farenheit = (celcius * 9 / 5) + 32;
                Result.Text = Math.Round(farenheit).ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberEnter.Clear();
            Result.Text = null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Have a nice day !" , "Exit Temprature Calculator");
            Application.Exit();
        }
    }
}
