using System;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!TryGetScore(test1TextBox, "第一次測驗", out double test1Score))
            {
                return;
            }

            if (!TryGetScore(test2TextBox, "第二次測驗", out double test2Score))
            {
                return;
            }

            if (!TryGetScore(test3TextBox, "第三次測驗", out double test3Score))
            {
                return;
            }

            double averageScore = (test1Score + test2Score + test3Score) / 3;

            averageLabel.Text = averageScore.ToString("F2");
        }

        private bool TryGetScore(
            TextBox scoreTextBox,
            string testName,
            out double score)
        {
            if (!double.TryParse(scoreTextBox.Text, out score))
            {
                MessageBox.Show(
                    testName + "必須輸入數字。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                scoreTextBox.Focus();
                scoreTextBox.SelectAll();

                return false;
            }

            if (score < 0 || score > 100)
            {
                MessageBox.Show(
                    testName + "必須介於 0 到 100 之間。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                scoreTextBox.Focus();
                scoreTextBox.SelectAll();

                return false;
            }

            return true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();
            averageLabel.Text = string.Empty;

            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "確定要離開程式嗎？",
                "離開確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
