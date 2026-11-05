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
            if (!TryGetScore(test1TextBox, "第一次測驗成績", out double test1))
            {
                return;
            }

            if (!TryGetScore(test2TextBox, "第二次測驗成績", out double test2))
            {
                return;
            }

            if (!TryGetScore(test3TextBox, "第三次測驗成績", out double test3))
            {
                return;
            }

            double average = (test1 + test2 + test3) / 3;
            averageLabel.Text = average.ToString("F1");

            string grade = GetGrade(average);

            MessageBox.Show(
                "成績等級：" + grade,
                "計算結果",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private string GetGrade(double average)
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
            out double score)
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

            if (!double.TryParse(scoreTextBox.Text.Trim(), out score))
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
