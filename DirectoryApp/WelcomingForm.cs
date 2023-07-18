using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class WelcomingForm : Form
    {
        public WelcomingForm(string givenText)
        {
            InitializeComponent();
            txt_msg.Text = givenText;
        }

        private void WelcomingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
