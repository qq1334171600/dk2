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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("查询日报");
            Sunny.UI.NavMenuItem navMenuItem1 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("发布日志");
            Sunny.UI.NavMenuItem navMenuItem2 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("修改日报");
            Sunny.UI.NavMenuItem navMenuItem3 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("日报管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            Sunny.UI.NavMenuItem navMenuItem4 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("请假申请");
            Sunny.UI.NavMenuItem navMenuItem5 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("费用报销申请");
            Sunny.UI.NavMenuItem navMenuItem6 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("组内公告");
            Sunny.UI.NavMenuItem navMenuItem7 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("其他事由提交");
            Sunny.UI.NavMenuItem navMenuItem8 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("课题组事务", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            Sunny.UI.NavMenuItem navMenuItem9 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("查询周报");
            Sunny.UI.NavMenuItem navMenuItem10 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("修改周报");
            Sunny.UI.NavMenuItem navMenuItem11 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("发布周报");
            Sunny.UI.NavMenuItem navMenuItem12 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("周报管理", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            Sunny.UI.NavMenuItem navMenuItem13 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Idea记录");
            Sunny.UI.NavMenuItem navMenuItem14 = new Sunny.UI.NavMenuItem();
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("导师沟通记录");
            Sunny.UI.NavMenuItem navMenuItem15 = new Sunny.UI.NavMenuItem();
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
            treeNode1.Name = "";
            navMenuItem1.AlwaysOpen = false;
            navMenuItem1.Enabled = true;
            navMenuItem1.ImageIndex = -1;
            navMenuItem1.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem1.PageIndex = 3003;
            navMenuItem1.SelectedImageIndex = -1;
            navMenuItem1.Symbol = 0;
            navMenuItem1.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem1.SymbolSize = 24;
            navMenuItem1.Tag = null;
            navMenuItem1.Text = "查询日报";
            navMenuItem1.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem1.TipsCustom = false;
            navMenuItem1.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem1.TipsText = null;
            treeNode1.Tag = navMenuItem1;
            treeNode1.Text = "查询日报";
            treeNode2.Name = "";
            navMenuItem2.AlwaysOpen = false;
            navMenuItem2.Enabled = true;
            navMenuItem2.ImageIndex = -1;
            navMenuItem2.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem2.PageIndex = 3001;
            navMenuItem2.SelectedImageIndex = -1;
            navMenuItem2.Symbol = 0;
            navMenuItem2.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem2.SymbolSize = 24;
            navMenuItem2.Tag = null;
            navMenuItem2.Text = "发布日志";
            navMenuItem2.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem2.TipsCustom = false;
            navMenuItem2.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem2.TipsText = null;
            treeNode2.Tag = navMenuItem2;
            treeNode2.Text = "发布日志";
            treeNode3.Name = "";
            navMenuItem3.AlwaysOpen = false;
            navMenuItem3.Enabled = true;
            navMenuItem3.ImageIndex = -1;
            navMenuItem3.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem3.PageIndex = 3002;
            navMenuItem3.SelectedImageIndex = -1;
            navMenuItem3.Symbol = 0;
            navMenuItem3.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem3.SymbolSize = 24;
            navMenuItem3.Tag = null;
            navMenuItem3.Text = "修改日报";
            navMenuItem3.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem3.TipsCustom = false;
            navMenuItem3.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem3.TipsText = null;
            treeNode3.Tag = navMenuItem3;
            treeNode3.Text = "修改日报";
            treeNode4.Name = "";
            navMenuItem4.AlwaysOpen = false;
            navMenuItem4.Enabled = true;
            navMenuItem4.ImageIndex = -1;
            navMenuItem4.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem4.PageIndex = 3000;
            navMenuItem4.SelectedImageIndex = -1;
            navMenuItem4.Symbol = 0;
            navMenuItem4.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem4.SymbolSize = 24;
            navMenuItem4.Tag = null;
            navMenuItem4.Text = "日报管理";
            navMenuItem4.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem4.TipsCustom = false;
            navMenuItem4.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem4.TipsText = null;
            treeNode4.Tag = navMenuItem4;
            treeNode4.Text = "日报管理";
            treeNode5.Name = "";
            navMenuItem5.AlwaysOpen = false;
            navMenuItem5.Enabled = true;
            navMenuItem5.ImageIndex = -1;
            navMenuItem5.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem5.PageIndex = 4001;
            navMenuItem5.SelectedImageIndex = -1;
            navMenuItem5.Symbol = 0;
            navMenuItem5.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem5.SymbolSize = 24;
            navMenuItem5.Tag = null;
            navMenuItem5.Text = "请假申请";
            navMenuItem5.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem5.TipsCustom = false;
            navMenuItem5.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem5.TipsText = null;
            treeNode5.Tag = navMenuItem5;
            treeNode5.Text = "请假申请";
            treeNode6.Name = "";
            navMenuItem6.AlwaysOpen = false;
            navMenuItem6.Enabled = true;
            navMenuItem6.ImageIndex = -1;
            navMenuItem6.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem6.PageIndex = 4002;
            navMenuItem6.SelectedImageIndex = -1;
            navMenuItem6.Symbol = 0;
            navMenuItem6.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem6.SymbolSize = 24;
            navMenuItem6.Tag = null;
            navMenuItem6.Text = "费用报销申请";
            navMenuItem6.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem6.TipsCustom = false;
            navMenuItem6.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem6.TipsText = null;
            treeNode6.Tag = navMenuItem6;
            treeNode6.Text = "费用报销申请";
            treeNode7.Name = "";
            navMenuItem7.AlwaysOpen = false;
            navMenuItem7.Enabled = true;
            navMenuItem7.ImageIndex = -1;
            navMenuItem7.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem7.PageIndex = 4003;
            navMenuItem7.SelectedImageIndex = -1;
            navMenuItem7.Symbol = 0;
            navMenuItem7.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem7.SymbolSize = 24;
            navMenuItem7.Tag = null;
            navMenuItem7.Text = "组内公告";
            navMenuItem7.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem7.TipsCustom = false;
            navMenuItem7.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem7.TipsText = null;
            treeNode7.Tag = navMenuItem7;
            treeNode7.Text = "组内公告";
            treeNode8.Name = "";
            navMenuItem8.AlwaysOpen = false;
            navMenuItem8.Enabled = true;
            navMenuItem8.ImageIndex = -1;
            navMenuItem8.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem8.PageIndex = 4004;
            navMenuItem8.SelectedImageIndex = -1;
            navMenuItem8.Symbol = 0;
            navMenuItem8.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem8.SymbolSize = 24;
            navMenuItem8.Tag = null;
            navMenuItem8.Text = "其他事由提交";
            navMenuItem8.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem8.TipsCustom = false;
            navMenuItem8.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem8.TipsText = null;
            treeNode8.Tag = navMenuItem8;
            treeNode8.Text = "其他事由提交";
            treeNode9.Name = "";
            navMenuItem9.AlwaysOpen = false;
            navMenuItem9.Enabled = true;
            navMenuItem9.ImageIndex = -1;
            navMenuItem9.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem9.PageIndex = 4000;
            navMenuItem9.SelectedImageIndex = -1;
            navMenuItem9.Symbol = 0;
            navMenuItem9.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem9.SymbolSize = 24;
            navMenuItem9.Tag = null;
            navMenuItem9.Text = "课题组事务";
            navMenuItem9.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem9.TipsCustom = false;
            navMenuItem9.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem9.TipsText = null;
            treeNode9.Tag = navMenuItem9;
            treeNode9.Text = "课题组事务";
            treeNode10.Name = "";
            navMenuItem10.AlwaysOpen = false;
            navMenuItem10.Enabled = true;
            navMenuItem10.ImageIndex = -1;
            navMenuItem10.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem10.PageIndex = 5003;
            navMenuItem10.SelectedImageIndex = -1;
            navMenuItem10.Symbol = 0;
            navMenuItem10.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem10.SymbolSize = 24;
            navMenuItem10.Tag = null;
            navMenuItem10.Text = "查询周报";
            navMenuItem10.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem10.TipsCustom = false;
            navMenuItem10.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem10.TipsText = null;
            treeNode10.Tag = navMenuItem10;
            treeNode10.Text = "查询周报";
            treeNode11.Name = "";
            navMenuItem11.AlwaysOpen = false;
            navMenuItem11.Enabled = true;
            navMenuItem11.ImageIndex = -1;
            navMenuItem11.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem11.PageIndex = 5002;
            navMenuItem11.SelectedImageIndex = -1;
            navMenuItem11.Symbol = 0;
            navMenuItem11.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem11.SymbolSize = 24;
            navMenuItem11.Tag = null;
            navMenuItem11.Text = "修改周报";
            navMenuItem11.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem11.TipsCustom = false;
            navMenuItem11.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem11.TipsText = null;
            treeNode11.Tag = navMenuItem11;
            treeNode11.Text = "修改周报";
            treeNode12.Name = "";
            navMenuItem12.AlwaysOpen = false;
            navMenuItem12.Enabled = true;
            navMenuItem12.ImageIndex = -1;
            navMenuItem12.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem12.PageIndex = 5001;
            navMenuItem12.SelectedImageIndex = -1;
            navMenuItem12.Symbol = 0;
            navMenuItem12.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem12.SymbolSize = 24;
            navMenuItem12.Tag = null;
            navMenuItem12.Text = "发布周报";
            navMenuItem12.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem12.TipsCustom = false;
            navMenuItem12.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem12.TipsText = null;
            treeNode12.Tag = navMenuItem12;
            treeNode12.Text = "发布周报";
            treeNode13.Name = "";
            navMenuItem13.AlwaysOpen = false;
            navMenuItem13.Enabled = true;
            navMenuItem13.ImageIndex = -1;
            navMenuItem13.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem13.PageIndex = 5000;
            navMenuItem13.SelectedImageIndex = -1;
            navMenuItem13.Symbol = 0;
            navMenuItem13.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem13.SymbolSize = 24;
            navMenuItem13.Tag = null;
            navMenuItem13.Text = "周报管理";
            navMenuItem13.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem13.TipsCustom = false;
            navMenuItem13.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem13.TipsText = null;
            treeNode13.Tag = navMenuItem13;
            treeNode13.Text = "周报管理";
            treeNode14.Name = "";
            navMenuItem14.AlwaysOpen = false;
            navMenuItem14.Enabled = true;
            navMenuItem14.ImageIndex = -1;
            navMenuItem14.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem14.PageIndex = 7001;
            navMenuItem14.SelectedImageIndex = -1;
            navMenuItem14.Symbol = 0;
            navMenuItem14.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem14.SymbolSize = 24;
            navMenuItem14.Tag = null;
            navMenuItem14.Text = "Idea记录";
            navMenuItem14.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem14.TipsCustom = false;
            navMenuItem14.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem14.TipsText = null;
            treeNode14.Tag = navMenuItem14;
            treeNode14.Text = "Idea记录";
            treeNode15.Name = "";
            navMenuItem15.AlwaysOpen = false;
            navMenuItem15.Enabled = true;
            navMenuItem15.ImageIndex = -1;
            navMenuItem15.PageGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            navMenuItem15.PageIndex = 6001;
            navMenuItem15.SelectedImageIndex = -1;
            navMenuItem15.Symbol = 0;
            navMenuItem15.SymbolOffset = new System.Drawing.Point(0, 0);
            navMenuItem15.SymbolSize = 24;
            navMenuItem15.Tag = null;
            navMenuItem15.Text = "导师沟通记录";
            navMenuItem15.TipsBackColor = System.Drawing.Color.Empty;
            navMenuItem15.TipsCustom = false;
            navMenuItem15.TipsForeColor = System.Drawing.Color.Empty;
            navMenuItem15.TipsText = null;
            treeNode15.Tag = navMenuItem15;
            treeNode15.Text = "导师沟通记录";
            this.Aside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9,
            treeNode13,
            treeNode14,
            treeNode15});
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