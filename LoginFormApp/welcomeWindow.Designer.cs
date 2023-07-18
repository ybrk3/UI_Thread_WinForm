namespace LoginFormApp
{
    partial class welcomeWindow
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
            lbl_welcome = new Label();
            btn_cooking = new Button();
            logList = new ListBox();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Location = new Point(33, 37);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(0, 20);
            lbl_welcome.TabIndex = 0;
            // 
            // btn_cooking
            // 
            btn_cooking.BackColor = Color.DarkSeaGreen;
            btn_cooking.Location = new Point(12, 309);
            btn_cooking.Name = "btn_cooking";
            btn_cooking.Size = new Size(755, 61);
            btn_cooking.TabIndex = 2;
            btn_cooking.Text = "Commence Cooking";
            btn_cooking.UseVisualStyleBackColor = false;
            btn_cooking.Click += btn_cooking_Click;
            // 
            // logList
            // 
            logList.FormattingEnabled = true;
            logList.ItemHeight = 20;
            logList.Location = new Point(12, 22);
            logList.Name = "logList";
            logList.Size = new Size(755, 244);
            logList.TabIndex = 3;
            // 
            // welcomeWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 385);
            Controls.Add(logList);
            Controls.Add(btn_cooking);
            Controls.Add(lbl_welcome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "welcomeWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome !";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private Button btn_cooking;
        private ListBox logList;
    }
}