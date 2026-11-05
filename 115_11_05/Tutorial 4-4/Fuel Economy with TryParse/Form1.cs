using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;
            double liters;
            double kmpl;

            if (!double.TryParse(milesTextBox.Text, out km) || km < 0)
            {
                MessageBox.Show("請輸入有效的公里數");
                return;
            }

            if (!double.TryParse(gallonsTextBox.Text, out liters) || liters <= 0)
            {
                MessageBox.Show("請輸入有效且大於 0 的公升數");
                return;
            }

            kmpl = km / liters;
            mpgLabel.Text = kmpl.ToString("F2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
