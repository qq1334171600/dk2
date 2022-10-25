namespace dk2.form
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiContextMenuStripAvator = new Sunny.UI.UIContextMenuStrip();
            this.toolStripMenuItemReg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.Header.SuspendLayout();
            this.uiContextMenuStripAvator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Footer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Footer.ForeColor = System.Drawing.Color.White;
            this.Footer.Location = new System.Drawing.Point(252, 670);
            this.Footer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.Footer.Size = new System.Drawing.Size(1026, 48);
            this.Footer.Style = Sunny.UI.UIStyle.DarkBlue;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.uiAvatar1);
            this.Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Header.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(252, 36);
            this.Header.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.Header.Size = new System.Drawing.Size(1026, 90);
            this.Header.Style = Sunny.UI.UIStyle.DarkBlue;
            // 
            // Aside
            // 
            this.Aside.Location = new System.Drawing.Point(2, 36);
            this.Aside.Size = new System.Drawing.Size(250, 682);
            this.Aside.Style = Sunny.UI.UIStyle.DarkBlue;
            // 
            // uiStyleManager1
            // 
            this.uiStyleManager1.DPIScale = true;
            this.uiStyleManager1.Style = Sunny.UI.UIStyle.DarkBlue;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.uiAvatar1.Location = new System.Drawing.Point(942, 14);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.DarkBlue;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiAvatar1.Click += new System.EventHandler(this.uiAvatar1_Click);
            // 
            // uiContextMenuStripAvator
            // 
            this.uiContextMenuStripAvator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStripAvator.Font = new System.Drawing.Font("微软雅黑", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStripAvator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uiContextMenuStripAvator.IsScaled = true;
            this.uiContextMenuStripAvator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReg,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemLogOut,
            this.toolStripMenuItemLogin});
            this.uiContextMenuStripAvator.Name = "uiContextMenuStripAvator";
            this.uiContextMenuStripAvator.Size = new System.Drawing.Size(113, 116);
            this.uiContextMenuStripAvator.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // toolStripMenuItemReg
            // 
            this.toolStripMenuItemReg.Name = "toolStripMenuItemReg";
            this.toolStripMenuItemReg.Size = new System.Drawing.Size(112, 28);
            this.toolStripMenuItemReg.Text = "注册";
            this.toolStripMenuItemReg.Visible = false;
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(112, 28);
            this.ToolStripMenuItemSetting.Text = "设置";
            // 
            // ToolStripMenuItemLogOut
            // 
            this.ToolStripMenuItemLogOut.Name = "ToolStripMenuItemLogOut";
            this.ToolStripMenuItemLogOut.Size = new System.Drawing.Size(112, 28);
            this.ToolStripMenuItemLogOut.Text = "退出";
            // 
            // toolStripMenuItemLogin
            // 
            this.toolStripMenuItemLogin.Name = "toolStripMenuItemLogin";
            this.toolStripMenuItemLogin.Size = new System.Drawing.Size(112, 28);
            this.toolStripMenuItemLogin.Text = "登录";
            this.toolStripMenuItemLogin.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.Style = Sunny.UI.UIStyle.DarkBlue;
            this.Text = "学习打卡程序";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 1254, 649);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Footer, 0);
            this.Header.ResumeLayout(false);
            this.uiContextMenuStripAvator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIStyleManager uiStyleManager1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStripAvator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogin;
    }
}