namespace dk2.form
{
    partial class FormLogin
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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "郭老师组研究生打卡程序\r\n";
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(376, 421);
            this.lblSubText.Text = "dev by zj V2.0";
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Name = "FormLogin";
            this.Text = "登录窗口";
            this.ButtonLoginClick += FLogin_ButtonLoginClick;
            this.ResumeLayout(false);

        }

        private void FormLogin_ButtonLoginClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}