namespace UserApp
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
            txt_Username = new TextBox();
            lbl_Username = new Label();
            txt_Password = new TextBox();
            lbl_Password = new Label();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(136, 25);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(195, 27);
            txt_Username.TabIndex = 0;
            txt_Username.Text = "Enter your username";
            txt_Username.Enter += txt_Click;
            txt_Username.Leave += txt_TextLeave;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(35, 32);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(75, 20);
            lbl_Username.TabIndex = 1;
            lbl_Username.Text = "Username";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(136, 58);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(195, 27);
            txt_Password.TabIndex = 0;
            txt_Password.Text = "Enter your password";
            txt_Password.Enter += txt_Click;
            txt_Password.Leave += txt_TextLeave;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(35, 65);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(70, 20);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.ActiveCaption;
            btn_Login.ForeColor = SystemColors.ActiveCaptionText;
            btn_Login.Location = new Point(136, 103);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(195, 29);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 156);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to our App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Username;
        private Label lbl_Username;
        private TextBox txt_Password;
        private Label lbl_Password;
        private Button btn_Login;
    }
}