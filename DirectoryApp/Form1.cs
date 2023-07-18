namespace DirectoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button has been clicked");
            string givenMsg = textBox1.Text;
            WelcomingForm welcomingForm = new WelcomingForm(givenMsg);

            welcomingForm.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.Text = string.Empty;
        }
    }
}