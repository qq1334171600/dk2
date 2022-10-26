using dk2.page;
using dk2.page.weekly;

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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiContextMenuStripAvatorAlreadyLogin = new Sunny.UI.UIContextMenuStrip();
            this.toolStripMenuItemReg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.uiContextMenuStripUnLogin = new Sunny.UI.UIContextMenuStrip();
            this.ToolStripMenuItemRegUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRegStu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRegTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoginUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoginStu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoginTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.uiSmoothLabelHeader = new Sunny.UI.UISmoothLabel();
            this.Header.SuspendLayout();
            this.uiContextMenuStripAvatorAlreadyLogin.SuspendLayout();
            this.uiContextMenuStripUnLogin.SuspendLayout();
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
            this.Header.Controls.Add(this.uiSmoothLabelHeader);
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
            this.Aside.Click += new System.EventHandler(this.Aside_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(550, 302);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "查询日报";
            this.tabPage3.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(550, 302);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "发布日志";
            this.tabPage4.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(550, 302);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "修改日报";
            this.tabPage5.Visible = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(0, 0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(550, 302);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "请假申请";
            this.tabPage6.Visible = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(0, 0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(550, 302);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "费用报销申请";
            this.tabPage7.Visible = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(0, 0);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(550, 302);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "组内公告";
            this.tabPage8.Visible = false;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(0, 0);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(550, 302);
            this.tabPage9.TabIndex = 6;
            this.tabPage9.Text = "其他事由提交";
            this.tabPage9.Visible = false;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(0, 0);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(550, 302);
            this.tabPage10.TabIndex = 7;
            this.tabPage10.Text = "查询周报";
            this.tabPage10.Visible = false;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(0, 0);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(550, 302);
            this.tabPage11.TabIndex = 8;
            this.tabPage11.Text = "修改周报";
            this.tabPage11.Visible = false;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(0, 0);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(550, 302);
            this.tabPage12.TabIndex = 9;
            this.tabPage12.Text = "发布周报";
            this.tabPage12.Visible = false;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(0, 0);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(550, 302);
            this.tabPage13.TabIndex = 10;
            this.tabPage13.Text = "Idea记录";
            this.tabPage13.Visible = false;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(0, 0);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(1026, 544);
            this.tabPage14.TabIndex = 11;
            this.tabPage14.Text = "导师沟通记录";
            this.tabPage14.Visible = false;
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
            // uiContextMenuStripAvatorAlreadyLogin
            // 
            this.uiContextMenuStripAvatorAlreadyLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStripAvatorAlreadyLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStripAvatorAlreadyLogin.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uiContextMenuStripAvatorAlreadyLogin.IsScaled = true;
            this.uiContextMenuStripAvatorAlreadyLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReg,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemLogOut,
            this.toolStripMenuItemLogin});
            this.uiContextMenuStripAvatorAlreadyLogin.Name = "uiContextMenuStripAvator";
            this.uiContextMenuStripAvatorAlreadyLogin.Size = new System.Drawing.Size(113, 108);
            this.uiContextMenuStripAvatorAlreadyLogin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // toolStripMenuItemReg
            // 
            this.toolStripMenuItemReg.Name = "toolStripMenuItemReg";
            this.toolStripMenuItemReg.Size = new System.Drawing.Size(112, 26);
            this.toolStripMenuItemReg.Text = "注册";
            this.toolStripMenuItemReg.Visible = false;
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(112, 26);
            this.ToolStripMenuItemSetting.Text = "设置";
            // 
            // ToolStripMenuItemLogOut
            // 
            this.ToolStripMenuItemLogOut.Name = "ToolStripMenuItemLogOut";
            this.ToolStripMenuItemLogOut.Size = new System.Drawing.Size(112, 26);
            this.ToolStripMenuItemLogOut.Text = "退出";
            this.ToolStripMenuItemLogOut.Click += new System.EventHandler(this.ToolStripMenuItemLogOut_Click);
            // 
            // toolStripMenuItemLogin
            // 
            this.toolStripMenuItemLogin.Name = "toolStripMenuItemLogin";
            this.toolStripMenuItemLogin.Size = new System.Drawing.Size(112, 26);
            this.toolStripMenuItemLogin.Text = "登录";
            this.toolStripMenuItemLogin.Visible = false;
            // 
            // uiContextMenuStripUnLogin
            // 
            this.uiContextMenuStripUnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStripUnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStripUnLogin.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uiContextMenuStripUnLogin.IsScaled = true;
            this.uiContextMenuStripUnLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRegUser,
            this.ToolStripMenuItemLoginUser});
            this.uiContextMenuStripUnLogin.Name = "uiContextMenuStripUnLogin";
            this.uiContextMenuStripUnLogin.Size = new System.Drawing.Size(113, 56);
            this.uiContextMenuStripUnLogin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ToolStripMenuItemRegUser
            // 
            this.ToolStripMenuItemRegUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRegStu,
            this.ToolStripMenuItemRegTeacher});
            this.ToolStripMenuItemRegUser.Name = "ToolStripMenuItemRegUser";
            this.ToolStripMenuItemRegUser.Size = new System.Drawing.Size(112, 26);
            this.ToolStripMenuItemRegUser.Text = "注册";
            // 
            // ToolStripMenuItemRegStu
            // 
            this.ToolStripMenuItemRegStu.Name = "ToolStripMenuItemRegStu";
            this.ToolStripMenuItemRegStu.Size = new System.Drawing.Size(112, 26);
            this.ToolStripMenuItemRegStu.Text = "学生";
            this.ToolStripMenuItemRegStu.Click += new System.EventHandler(this.ToolStripMenuItemRegStu_Click);
            // 
            // ToolStripMenuItemRegTeacher
            // 
            this.ToolStripMenuItemRegTeacher.Name = "ToolStripMenuItemRegTeacher";
            this.ToolStripMenuItemRegTeacher.Size = new System.Drawing.Size(112, 26);
            this.ToolStripMenuItemRegTeacher.Text = "导师";
            this.ToolStripMenuItemRegTeacher.Click += new System.EventHandler(this.ToolStripMenuItemRegTeacher_Click);
            // 
            // ToolStripMenuItemLoginUser
            // 
            this.ToolStripMenuItemLoginUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoginStu,
            this.toolStripMenuItemLoginTeacher});
            this.ToolStripMenuItemLoginUser.Name = "ToolStripMenuItemLoginUser";
            this.ToolStripMenuItemLoginUser.Size = new System.Drawing.Size(112, 26);
            this.ToolStripMenuItemLoginUser.Text = "登录";
            // 
            // toolStripMenuItemLoginStu
            // 
            this.toolStripMenuItemLoginStu.Name = "toolStripMenuItemLoginStu";
            this.toolStripMenuItemLoginStu.Size = new System.Drawing.Size(112, 26);
            this.toolStripMenuItemLoginStu.Text = "学生";
            this.toolStripMenuItemLoginStu.Click += new System.EventHandler(this.toolStripMenuItemLoginStu_Click);
            // 
            // toolStripMenuItemLoginTeacher
            // 
            this.toolStripMenuItemLoginTeacher.Name = "toolStripMenuItemLoginTeacher";
            this.toolStripMenuItemLoginTeacher.Size = new System.Drawing.Size(112, 26);
            this.toolStripMenuItemLoginTeacher.Text = "导师";
            this.toolStripMenuItemLoginTeacher.Click += new System.EventHandler(this.toolStripMenuItemLoginTeacher_Click);
            // 
            // uiSmoothLabelHeader
            // 
            this.uiSmoothLabelHeader.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabelHeader.Location = new System.Drawing.Point(219, 0);
            this.uiSmoothLabelHeader.Name = "uiSmoothLabelHeader";
            this.uiSmoothLabelHeader.Size = new System.Drawing.Size(520, 74);
            this.uiSmoothLabelHeader.Style = Sunny.UI.UIStyle.DarkBlue;
            this.uiSmoothLabelHeader.TabIndex = 1;
            this.uiSmoothLabelHeader.Text = "研究生学习打卡系统";
            this.uiSmoothLabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiSmoothLabelHeader.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.uiContextMenuStripAvatorAlreadyLogin.ResumeLayout(false);
            this.uiContextMenuStripUnLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIStyleManager uiStyleManager1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStripAvatorAlreadyLogin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogin;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStripUnLogin;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRegUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRegStu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRegTeacher;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoginUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoginStu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoginTeacher;
        private Sunny.UI.UISmoothLabel uiSmoothLabelHeader;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
    }
}