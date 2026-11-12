using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 建立表單上的所有控制項。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RAIT = 0.005m;
            decimal balance;
            int months;


            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    int count = 1;
                    while (count <= months)
                    {
                        balance += months;
                        detailListBox.Items.Add($"第{count}個月的本利和: {balance:C2}");
                        count++;
                    }

                    // 顯示所有月份計算完成後的結餘。
                    endingBalanceLabel.Text = balance.ToString("C2");
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數字");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除輸入欄位、結餘標籤及明細清單。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 將游標移回起始餘額輸入欄位。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
