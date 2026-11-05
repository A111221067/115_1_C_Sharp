namespace StringCompare
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label String1Label;
        private Label String2Label;
        private TextBox InputString1TextBox;
        private TextBox InputString2TextBox;
        private Button CompareButton;
        private Button ExitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            String1Label = new Label();
            String2Label = new Label();
            InputString1TextBox = new TextBox();
            InputString2TextBox = new TextBox();
            CompareButton = new Button();
            ExitButton = new Button();
            SuspendLayout();

            // String1Label
            String1Label.AutoSize = true;
            String1Label.Location = new Point(50, 45);
            String1Label.Name = "String1Label";
            String1Label.Size = new Size(55, 19);
            String1Label.TabIndex = 0;
            String1Label.Text = "字串1：";

            // String2Label
            String2Label.AutoSize = true;
            String2Label.Location = new Point(50, 95);
            String2Label.Name = "String2Label";
            String2Label.Size = new Size(55, 19);
            String2Label.TabIndex = 1;
            String2Label.Text = "字串2：";

            // InputString1TextBox
            InputString1TextBox.Location = new Point(130, 40);
            InputString1TextBox.Name = "InputString1TextBox";
            InputString1TextBox.Size = new Size(300, 27);
            InputString1TextBox.TabIndex = 2;

            // InputString2TextBox
            InputString2TextBox.Location = new Point(130, 90);
            InputString2TextBox.Name = "InputString2TextBox";
            InputString2TextBox.Size = new Size(300, 27);
            InputString2TextBox.TabIndex = 3;

            // CompareButton
            CompareButton.Location = new Point(130, 145);
            CompareButton.Name = "CompareButton";
            CompareButton.Size = new Size(100, 35);
            CompareButton.TabIndex = 4;
            CompareButton.Text = "比較";
            CompareButton.UseVisualStyleBackColor = true;
            CompareButton.Click += CompareButton_Click;

            // ExitButton
            ExitButton.Location = new Point(250, 145);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 35);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "離開";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 230);
            Controls.Add(String1Label);
            Controls.Add(String2Label);
            Controls.Add(InputString1TextBox);
            Controls.Add(InputString2TextBox);
            Controls.Add(CompareButton);
            Controls.Add(ExitButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "字串比較";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
