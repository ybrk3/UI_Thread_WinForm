namespace UserApp
{
    partial class UpdateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_Name = new TextBox();
            label2 = new Label();
            txt_Email = new TextBox();
            label3 = new Label();
            txt_Username = new TextBox();
            label4 = new Label();
            txt_Password = new TextBox();
            btn_Update = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(93, 36);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(234, 27);
            txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(93, 69);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(234, 27);
            txt_Email.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 42);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(449, 39);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(169, 27);
            txt_Username.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 75);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(449, 72);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(169, 27);
            txt_Password.TabIndex = 1;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(373, 112);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(245, 29);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(93, 112);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(234, 29);
            btn_Cancel.TabIndex = 2;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += button3_Click;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 168);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Update);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txt_Username);
            Controls.Add(label3);
            Controls.Add(txt_Name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UpdateUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Name;
        private Label label2;
        private TextBox txt_Email;
        private Label label3;
        private TextBox txt_Username;
        private Label label4;
        private TextBox txt_Password;
        private Button btn_Update;
        private Button btn_Cancel;
    }
}