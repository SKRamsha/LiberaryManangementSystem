namespace LiberaryManangementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            userControl11.Hide();
            uc_std.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            uc_std.Show();
            uc_std.BringToFront();
        }
     
    }
}