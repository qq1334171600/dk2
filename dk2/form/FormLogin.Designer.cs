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
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "研究生打卡程序\r\n";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLine2);
            this.uiPanel1.Controls.SetChildIndex(this.uiLine2, 0);
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(376, 421);
            this.lblSubText.Text = "dev by zj V2.0";
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.White;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.Location = new System.Drawing.Point(-82, 85);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(360, 29);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 6;
            this.uiLine2.Text = "学生登录";
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Name = "FormLogin";
            this.SubText = "dev by zj V2.0";
            this.Text = "登录窗口";
            this.Title = "研究生打卡程序\r\n";
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.ButtonLoginClick += FLogin_ButtonLoginClick;

        }

       
        #endregion

        private Sunny.UI.UILine uiLine2;
    }
}