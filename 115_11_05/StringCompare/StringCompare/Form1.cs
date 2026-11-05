using System;
using System.Windows.Forms;

namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            bool isEqual = string.Equals(
                InputString1TextBox.Text,
                InputString2TextBox.Text,
                StringComparison.Ordinal);

            MessageBox.Show(
                isEqual ? "兩個字串相同。" : "兩個字串不同。",
                "比較結果",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
