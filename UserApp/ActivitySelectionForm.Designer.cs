namespace UserApp
{
    partial class ActivitySelectionForm
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
            btn_GoToApp = new Button();
            btn_UpdateInfo = new Button();
            SuspendLayout();
            // 
            // btn_GoToApp
            // 
            btn_GoToApp.BackColor = Color.Green;
            btn_GoToApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GoToApp.Location = new Point(14, 31);
            btn_GoToApp.Name = "btn_GoToApp";
            btn_GoToApp.Size = new Size(200, 29);
            btn_GoToApp.TabIndex = 0;
            btn_GoToApp.Text = "Go To App";
            btn_GoToApp.UseVisualStyleBackColor = false;
            btn_GoToApp.Click += btn_GoToApp_Click;
            // 
            // btn_UpdateInfo
            // 
            btn_UpdateInfo.BackColor = Color.Teal;
            btn_UpdateInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UpdateInfo.Location = new Point(220, 31);
            btn_UpdateInfo.Name = "btn_UpdateInfo";
            btn_UpdateInfo.Size = new Size(206, 29);
            btn_UpdateInfo.TabIndex = 0;
            btn_UpdateInfo.Text = "Update Your User Info";
            btn_UpdateInfo.UseVisualStyleBackColor = false;
            btn_UpdateInfo.Click += btn_UpdateInfo_Click;
            // 
            // ActivitySelectionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 92);
            Controls.Add(btn_UpdateInfo);
            Controls.Add(btn_GoToApp);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ActivitySelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wellcome !!";
            Load += ActivitySelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_GoToApp;
        private Button btn_UpdateInfo;
    }
}