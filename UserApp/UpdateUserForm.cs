using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApp
{
    public partial class UpdateUserForm : Form
    {
        private readonly User _user;
        public UpdateUserForm(User user)
        {
            InitializeComponent();
            _user = user;
            txt_Email.Text = _user.Email;
            txt_Name.Text = _user.Name;
            txt_Username.Text = _user.Username;
            txt_Password.Text = _user.Password;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            VirtualDB db = new VirtualDB();
            User? userToUpdate = db.users.FirstOrDefault(u => u.Username == txt_Username.Text);


            this.Close();
        }
    }
}
