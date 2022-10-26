using dk2.page;

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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("发布日志");
            Sunny.UI.NavMenuItem navMenuItem1 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("修改日报");
            Sunny.UI.NavMenuItem navMenuItem2 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNodeDaily = Aside.CreateNode("日报管理", 3000);
            Aside.CreateChildNode(treeNodeDaily, AddPage(new PageAddDaily(),3001));
            Aside.CreateChildNode(treeNodeDaily, AddPage(new PageAlterDaily(), 3002));

            Sunny.UI.NavMenuItem navMenuItem3 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("请假申请");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("物品报销申请");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("其他事由留言");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("组内公告");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("课题组事务", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("发布周报");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("修改周报");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("查询周报");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("周报管理", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Idea记录");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("导师沟通记录");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            treeNode1.Name = "";
            navMenuItem1.AlwaysOpen = false;
            navMenuItem1.Enabled = true;
            navMenuItem1.ImageIndex = -1;
            navMenuItem1.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem1.PageIndex = 3001;
            navMenuItem1.SelectedImageIndex = -1;
            navMenuItem1.Symbol = 0;
            navMenuItem1.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem1.SymbolSize = 24;
            navMenuItem1.Tag = null;
            navMenuItem1.Text = "发布日志";
            navMenuItem1.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem1.TipsCustom = false;
            navMenuItem1.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem1.TipsText = null;
            treeNode1.Tag = navMenuItem1;
            treeNode1.Text = "发布日志";
            treeNode2.Name = "";
            navMenuItem2.AlwaysOpen = false;
            navMenuItem2.Enabled = true;
            navMenuItem2.ImageIndex = -1;
            navMenuItem2.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem2.PageIndex = 3002;
            navMenuItem2.SelectedImageIndex = -1;
            navMenuItem2.Symbol = 0;
            navMenuItem2.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem2.SymbolSize = 24;
            navMenuItem2.Tag = null;
            navMenuItem2.Text = "修改日报";
            navMenuItem2.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem2.TipsCustom = false;
            navMenuItem2.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem2.TipsText = null;
            treeNode2.Tag = navMenuItem2;
            treeNode2.Text = "修改日报";
            navMenuItem3.AlwaysOpen = false;
            navMenuItem3.Enabled = true;
            navMenuItem3.ImageIndex = -1;
            navMenuItem3.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem3.PageIndex = 2001;
            navMenuItem3.SelectedImageIndex = -1;
            navMenuItem3.Symbol = 0;
            navMenuItem3.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem3.SymbolSize = 24;
            navMenuItem3.Tag = null;
            navMenuItem3.Text = "日报管理";
            navMenuItem3.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem3.TipsCustom = false;
            navMenuItem3.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem3.TipsText = null;
            
            treeNode4.Name = "nodeGroupLeave";
            treeNode4.Text = "请假申请";
            treeNode5.Name = "nodeRroupExpense ";
            treeNode5.Text = "物品报销申请";
            treeNode6.Name = "nodeGroupOther";
            treeNode6.Text = "其他事由留言";
            treeNode7.Name = "nodeGroupNotice";
            treeNode7.Text = "组内公告";
            treeNode8.Name = "nodeResearchGroup";
            treeNode8.Text = "课题组事务";
            treeNode9.Name = "nodeWeeklyAdd";
            treeNode9.Text = "发布周报";
            treeNode10.Name = "nodeWeeklyAlter";
            treeNode10.Text = "修改周报";
            treeNode11.Name = "nodeWeeklySelect";
            treeNode11.Text = "查询周报";
            treeNode12.Name = "nodeWeekly";
            treeNode12.Text = "周报管理";
            treeNode13.Name = "nodeIdeaRecord";
            treeNode13.Text = "Idea记录";
            treeNode14.Name = "nodeTeacherTalk";
            treeNode14.Text = "导师沟通记录";
            this.Aside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12,
            treeNode13,
            treeNode14});
            this.Aside.Size = new System.Drawing.Size(250, 682);
            this.Aside.Style = Sunny.UI.UIStyle.DarkBlue;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(550, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发布日志";
            this.tabPage1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1026, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改日报";
            this.tabPage2.Visible = false;
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
    }
}