using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 讀取並解析輸入的公里數與公升數，計算 km/L
            double kilometers;
            double liters;

            // 使用 InvariantCulture 以避免不同地區小數點問題
            if (!double.TryParse(milesTextBox.Text, out kilometers))
            {
                MessageBox.Show("請在 " + milesPromptLabel.Text + " 輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                milesTextBox.Focus();
                return;
            }

            if (!double.TryParse(gallonsTextBox.Text, out liters))
            {
                MessageBox.Show("請在 " + gallonsPromptLabel.Text + " 輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gallonsTextBox.Focus();
                return;
            }

            if (liters <= 0)
            {
                MessageBox.Show("公升數必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gallonsTextBox.Focus();
                return;
            }

            double kmPerLiter = kilometers / liters;

            // 顯示結果，保留兩位小數
            mpgLabel.Text = kmPerLiter.ToString("F2") + "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
