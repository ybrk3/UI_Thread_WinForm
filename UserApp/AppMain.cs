﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserApp
{
    public partial class AppMain : Form
    {
        public AppMain(User user)
        {
            InitializeComponent();

            label1.Text = $"{user.Name}, Welcome !!";

        }


    }
}
