namespace tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            this.germanPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.countryLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.Image = global::tutorial2_4.Properties.Resources.Finland;
            this.finlandPictureBox.Location = new System.Drawing.Point(331, 170);
            this.finlandPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(219, 109);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandPictureBox.TabIndex = 0;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.finlandPictureBox_Click);
            // 
            // germanPictureBox
            // 
            this.germanPictureBox.Image = global::tutorial2_4.Properties.Resources.Germany;
            this.germanPictureBox.Location = new System.Drawing.Point(593, 170);
            this.germanPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.germanPictureBox.Name = "germanPictureBox";
            this.germanPictureBox.Size = new System.Drawing.Size(229, 109);
            this.germanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanPictureBox.TabIndex = 1;
            this.germanPictureBox.TabStop = false;
            this.germanPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = global::tutorial2_4.Properties.Resources.France;
            this.francePictureBox.Location = new System.Drawing.Point(31, 170);
            this.francePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(242, 109);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 2;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // countryLable
            // 
            this.countryLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLable.Location = new System.Drawing.Point(308, 325);
            this.countryLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countryLable.Name = "countryLable";
            this.countryLable.Size = new System.Drawing.Size(242, 85);
            this.countryLable.TabIndex = 3;
            this.countryLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "指給我看一面旗幟，我就能告訴你那是哪個國家。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryLable);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.germanPictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox germanPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.Label countryLable;
        private System.Windows.Forms.Label label1;
    }
}

