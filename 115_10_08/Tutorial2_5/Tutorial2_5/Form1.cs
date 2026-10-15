using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = true;
            cardfacePictureBox.Visible = false;
        }

        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardfacePictureBox.Visible = true;
            cardbackPictureBox.Visible = false;
        }

        private void showBackButton111_Click(object sender, EventArgs e)
        {
            cardbackPictureBox222.Visible = true;
            cardfacePictureBox111.Visible = false;
        }

        private void showFaceButton222_Click(object sender, EventArgs e)
        {
            cardfacePictureBox111.Visible = true;
            cardbackPictureBox222.Visible = false;
        }
    }
}
