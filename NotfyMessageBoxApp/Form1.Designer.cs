namespace NotfyMessageBoxApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btn_addUSer = new Button();
            txt_email = new TextBox();
            txt_surname = new TextBox();
            txt_name = new TextBox();
            lbl_email = new Label();
            lbl_surname = new Label();
            lbl_name = new Label();
            groupBox2 = new GroupBox();
            userAddedIcon = new NotifyIcon(components);
            lb_users = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_addUSer);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_surname);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(lbl_email);
            groupBox1.Controls.Add(lbl_surname);
            groupBox1.Controls.Add(lbl_name);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New User Information Form";
            // 
            // btn_addUSer
            // 
            btn_addUSer.Location = new Point(222, 162);
            btn_addUSer.Name = "btn_addUSer";
            btn_addUSer.Size = new Size(107, 29);
            btn_addUSer.TabIndex = 2;
            btn_addUSer.Text = "Add User";
            btn_addUSer.UseVisualStyleBackColor = true;
            btn_addUSer.Click += btn_addUSer_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(139, 122);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(190, 27);
            txt_email.TabIndex = 1;
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(139, 85);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(190, 27);
            txt_surname.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(139, 44);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(190, 27);
            txt_name.TabIndex = 1;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(16, 122);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 20);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "Email";
            // 
            // lbl_surname
            // 
            lbl_surname.AutoSize = true;
            lbl_surname.Location = new Point(16, 85);
            lbl_surname.Name = "lbl_surname";
            lbl_surname.Size = new Size(67, 20);
            lbl_surname.TabIndex = 0;
            lbl_surname.Text = "Surname";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(16, 44);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(49, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lb_users);
            groupBox2.Location = new Point(384, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 214);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Users";
            // 
            // userAddedIcon
            // 
            userAddedIcon.Text = "userAddedIcon";
            userAddedIcon.Visible = true;
            // 
            // lb_users
            // 
            lb_users.FormattingEnabled = true;
            lb_users.ItemHeight = 20;
            lb_users.Location = new Point(6, 25);
            lb_users.Name = "lb_users";
            lb_users.Size = new Size(249, 184);
            lb_users.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 244);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users App";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_addUSer;
        private TextBox txt_email;
        private TextBox txt_surname;
        private TextBox txt_name;
        private Label lbl_email;
        private Label lbl_surname;
        private Label lbl_name;
        private GroupBox groupBox2;
        private NotifyIcon userAddedIcon;
        private ListBox lb_users;
    }
}