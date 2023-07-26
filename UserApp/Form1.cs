namespace UserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_Username.Select();
            btn_Login.Enabled = false;
        }

        private void txt_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
            textBox.BackColor = Color.LightYellow;
        }
        private void txt_TextLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = default;
            if (textBox.Text == string.Empty) { textBox.Text = "You should enter input"; textBox.BackColor = Color.Red; }
            else btn_Login.Enabled = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            VirtualDB virtualDB = new VirtualDB();
            User? user = virtualDB.users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user is null){ MessageBox.Show("Please check your username or password", "User Not Found", MessageBoxButtons.OK); return; }
            
                
            



            //Başarılı ise
            ActivitySelectionForm activitySelectionForm = new ActivitySelectionForm(user);
            activitySelectionForm.ShowDialog();
        }
    }
}