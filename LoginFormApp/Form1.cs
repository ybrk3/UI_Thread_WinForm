namespace LoginFormApp
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            if (username == "Admin" && password == "123")
            {
                welcomeWindow welcomeWindow = new welcomeWindow(username);
                welcomeWindow.Show();
            }
            else { MessageBox.Show("Please check your user information", "Wrong User Info"); }
        }
    }
}