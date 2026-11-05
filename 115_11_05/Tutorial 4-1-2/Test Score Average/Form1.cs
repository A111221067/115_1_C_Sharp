using System;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!TryGetScore(test1TextBox, "第一次測驗成績", out decimal test1Score))
            {
                return;
            }

            if (!TryGetScore(test2TextBox, "第二次測驗成績", out decimal test2Score))
            {
                return;
            }

            if (!TryGetScore(test3TextBox, "第三次測驗成績", out decimal test3Score))
            {
                return;
            }

            decimal average = (test1Score + test2Score + test3Score) / 3;
            string grade = GetGrade(average);

            averageLabel.Text = string.Format(
                "平均：{0:F1}\r\n等級：{1}",
                average,
                grade);
        }

        private string GetGrade(decimal average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        private bool TryGetScore(
            TextBox scoreTextBox,
            string scoreName,
            out decimal score)
        {
            if (string.IsNullOrWhiteSpace(scoreTextBox.Text))
            {
                MessageBox.Show(
                    "請輸入" + scoreName + "。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                score = 0;
                scoreTextBox.Focus();

                return false;
            }

            if (!decimal.TryParse(scoreTextBox.Text.Trim(), out score))
            {
                MessageBox.Show(
                    scoreName + "必須是有效的數字。",
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
                    scoreName + "必須介於 0 到 100 之間。",
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
