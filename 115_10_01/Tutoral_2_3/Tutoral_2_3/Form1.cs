namespace Tutoral_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           label2.Text = "Buongiorno!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Buen día!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Guten Morgen!";
        }
    }
}
