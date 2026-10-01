namespace Tutoral_2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(208, 62);
            label1.Name = "label1";
            label1.Size = new Size(359, 50);
            label1.TabIndex = 0;
            label1.Text = "選擇一個語言OwO";
            // 
            // button1
            // 
            button1.Location = new Point(109, 279);
            button1.Name = "button1";
            button1.Size = new Size(158, 74);
            button1.TabIndex = 1;
            button1.Text = "意大利";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(320, 279);
            button2.Name = "button2";
            button2.Size = new Size(158, 74);
            button2.TabIndex = 2;
            button2.Text = "西班牙";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(533, 279);
            button3.Name = "button3";
            button3.Size = new Size(158, 74);
            button3.TabIndex = 3;
            button3.Text = "德國";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(172, 156);
            label2.Name = "label2";
            label2.Size = new Size(430, 61);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}
