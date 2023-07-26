namespace NotfyMessageBoxApp
{
    public partial class Form1 : Form
    {
        public VirtualDataBase virtualDataBase;
        public Form1()
        {
            InitializeComponent();
            virtualDataBase = new VirtualDataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addUSer_Click(object sender, EventArgs e)
        {
            DialogResult userSelection = MessageBox.Show($"Are you sure to add user {txt_name.Text}?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (userSelection == DialogResult.Yes)
            {
                bool result = AddUser(new User
                {
                    Id = Guid.NewGuid(),
                    Name = txt_name.Text,
                    Surname = txt_surname.Text,
                    Email = txt_email.Text,
                });
                if (result)
                {
                    userAddedIcon = new NotifyIcon();
                    userAddedIcon.BalloonTipText = "User has been successfully added!";
                    userAddedIcon.BalloonTipTitle = "Successful!";
                    userAddedIcon.Visible = true;
                    userAddedIcon.Icon = SystemIcons.Information;
                    userAddedIcon.ShowBalloonTip(2500);
                }
                else MessageBox.Show("Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lb_users.DataSource = virtualDataBase.users;

            }
            else if (userSelection == DialogResult.No)
            {

                userAddedIcon = new NotifyIcon();
                userAddedIcon.BalloonTipText = "User not added. Total User :" + virtualDataBase.users.Count.ToString();
                userAddedIcon.BalloonTipTitle = "Information!";
                userAddedIcon.Visible = true;
                userAddedIcon.Icon = SystemIcons.Information;
                userAddedIcon.ShowBalloonTip(2500);
            }
            ClearTexts();

            lb_users.DataSource = virtualDataBase.users.ToArray();
        }
        private void ClearTexts()
        {
            txt_name.Text = string.Empty;
            txt_surname.Text = string.Empty;
            txt_email.Text = string.Empty;
        }
        private bool AddUser(User user)
        {
            try
            {
                virtualDataBase.users.Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}