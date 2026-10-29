using System;
using System.Globalization;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        private const decimal RegularWorkHours = 8m;
        private const decimal OvertimeRate = 1.5m;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal hoursWorked;
            decimal hourlyPayRate;

            if (!decimal.TryParse(
                hoursWorkedTextBox.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out hoursWorked))
            {
                MessageBox.Show(
                    "請輸入有效的工作時數。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                hoursWorkedTextBox.Focus();
                hoursWorkedTextBox.SelectAll();
                return;
            }

            if (!decimal.TryParse(
                hourlyPayRateTextBox.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out hourlyPayRate))
            {
                MessageBox.Show(
                    "請輸入有效的每小時薪資。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                hourlyPayRateTextBox.Focus();
                hourlyPayRateTextBox.SelectAll();
                return;
            }

            if (hoursWorked < 0)
            {
                MessageBox.Show(
                    "工作時數不可為負數。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                hoursWorkedTextBox.Focus();
                hoursWorkedTextBox.SelectAll();
                return;
            }

            if (hourlyPayRate < 0)
            {
                MessageBox.Show(
                    "每小時薪資不可為負數。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                hourlyPayRateTextBox.Focus();
                hourlyPayRateTextBox.SelectAll();
                return;
            }

            decimal regularHours = Math.Min(hoursWorked, RegularWorkHours);
            decimal overtimeHours = Math.Max(hoursWorked - RegularWorkHours, 0m);

            decimal regularPay = regularHours * hourlyPayRate;
            decimal overtimePay = overtimeHours * hourlyPayRate * OvertimeRate;
            decimal grossPay = regularPay + overtimePay;

            grossPayLabel.Text = grossPay.ToString("N2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = string.Empty;

            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
