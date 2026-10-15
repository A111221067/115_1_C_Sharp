namespace Tutorial2_5
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
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            this.showBackButton111 = new System.Windows.Forms.Button();
            this.showFaceButton222 = new System.Windows.Forms.Button();
            this.cardbackPictureBox222 = new System.Windows.Forms.PictureBox();
            this.cardfacePictureBox111 = new System.Windows.Forms.PictureBox();
            this.cardfacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardbackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox222)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showBackButton
            // 
            this.showBackButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBackButton.Location = new System.Drawing.Point(85, 653);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(256, 169);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "顯示背面";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFaceButton.Location = new System.Drawing.Point(85, 848);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(256, 169);
            this.showFaceButton.TabIndex = 3;
            this.showFaceButton.Text = "顯示正面";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // showBackButton111
            // 
            this.showBackButton111.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBackButton111.Location = new System.Drawing.Point(720, 653);
            this.showBackButton111.Name = "showBackButton111";
            this.showBackButton111.Size = new System.Drawing.Size(256, 169);
            this.showBackButton111.TabIndex = 6;
            this.showBackButton111.Text = "顯示背面";
            this.showBackButton111.UseVisualStyleBackColor = true;
            this.showBackButton111.Click += new System.EventHandler(this.showBackButton111_Click);
            // 
            // showFaceButton222
            // 
            this.showFaceButton222.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFaceButton222.Location = new System.Drawing.Point(720, 858);
            this.showFaceButton222.Name = "showFaceButton222";
            this.showFaceButton222.Size = new System.Drawing.Size(256, 169);
            this.showFaceButton222.TabIndex = 7;
            this.showFaceButton222.Text = "顯示正面";
            this.showFaceButton222.UseVisualStyleBackColor = true;
            this.showFaceButton222.Click += new System.EventHandler(this.showFaceButton222_Click);
            // 
            // cardbackPictureBox222
            // 
            this.cardbackPictureBox222.Image = global::Tutorial2_5.Properties.Resources.Backface_Red;
            this.cardbackPictureBox222.Location = new System.Drawing.Point(702, 129);
            this.cardbackPictureBox222.Name = "cardbackPictureBox222";
            this.cardbackPictureBox222.Size = new System.Drawing.Size(327, 481);
            this.cardbackPictureBox222.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbackPictureBox222.TabIndex = 5;
            this.cardbackPictureBox222.TabStop = false;
            // 
            // cardfacePictureBox111
            // 
            this.cardfacePictureBox111.Image = global::Tutorial2_5.Properties.Resources.Joker_Red;
            this.cardfacePictureBox111.Location = new System.Drawing.Point(702, 129);
            this.cardfacePictureBox111.Name = "cardfacePictureBox111";
            this.cardfacePictureBox111.Size = new System.Drawing.Size(325, 481);
            this.cardfacePictureBox111.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfacePictureBox111.TabIndex = 4;
            this.cardfacePictureBox111.TabStop = false;
            this.cardfacePictureBox111.Visible = false;
            // 
            // cardfacePictureBox
            // 
            this.cardfacePictureBox.Image = global::Tutorial2_5.Properties.Resources.Joker_Black;
            this.cardfacePictureBox.Location = new System.Drawing.Point(62, 139);
            this.cardfacePictureBox.Name = "cardfacePictureBox";
            this.cardfacePictureBox.Size = new System.Drawing.Size(325, 481);
            this.cardfacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfacePictureBox.TabIndex = 1;
            this.cardfacePictureBox.TabStop = false;
            this.cardfacePictureBox.Visible = false;
            // 
            // cardbackPictureBox
            // 
            this.cardbackPictureBox.Image = global::Tutorial2_5.Properties.Resources.Backface_Blue;
            this.cardbackPictureBox.Location = new System.Drawing.Point(62, 139);
            this.cardbackPictureBox.Name = "cardbackPictureBox";
            this.cardbackPictureBox.Size = new System.Drawing.Size(327, 481);
            this.cardbackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbackPictureBox.TabIndex = 0;
            this.cardbackPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 1118);
            this.Controls.Add(this.showFaceButton222);
            this.Controls.Add(this.showBackButton111);
            this.Controls.Add(this.cardbackPictureBox222);
            this.Controls.Add(this.cardfacePictureBox111);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cardfacePictureBox);
            this.Controls.Add(this.cardbackPictureBox);
            this.Name = "Form1";
            this.Text = "撲克牌";
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox222)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardbackPictureBox;
        private System.Windows.Forms.PictureBox cardfacePictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
        private System.Windows.Forms.PictureBox cardfacePictureBox111;
        private System.Windows.Forms.PictureBox cardbackPictureBox222;
        private System.Windows.Forms.Button showBackButton111;
        private System.Windows.Forms.Button showFaceButton222;
    }
}

