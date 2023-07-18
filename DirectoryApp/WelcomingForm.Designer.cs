namespace DirectoryApp
{
    partial class WelcomingForm
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
            txt_msg = new TextBox();
            SuspendLayout();
            // 
            // txt_msg
            // 
            txt_msg.Location = new Point(12, 12);
            txt_msg.Multiline = true;
            txt_msg.Name = "txt_msg";
            txt_msg.Size = new Size(388, 187);
            txt_msg.TabIndex = 1;
            // 
            // WelcomingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 211);
            Controls.Add(txt_msg);
            Name = "WelcomingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcoming Form";
            Load += WelcomingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_msg;
    }
}