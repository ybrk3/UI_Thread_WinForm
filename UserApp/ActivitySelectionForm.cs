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
    public partial class ActivitySelectionForm : Form
    {
        private readonly User _user;
        public ActivitySelectionForm(User user)
        {
            InitializeComponent();
            _user = user;

        }

        private void ActivitySelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_GoToApp_Click(object sender, EventArgs e)
        {
            AppMain mainApp = new AppMain(_user);
            mainApp.Show();
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm(_user);
            updateUserForm.Show();
        }
    }
}
