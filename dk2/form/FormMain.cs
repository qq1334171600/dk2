using dk2.page;
using dk2.util;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dk2.form
{
    public partial class FormMain : UIAsideHeaderMainFooterFrame
    {
        FormLogin formLogin;
        AutoSize autoSizeTool;

        public FormMain()
        {
            InitializeComponent();
            //设置关联
            Aside.TabControl = MainTabControl;
            Aside.SelectFirst();
            formLogin = new FormLogin();
            autoSizeTool = new AutoSize(this.Width,this.Height);
            /*autoSizeTool.MainFormOldWidth= this.Width;
            autoSizeTool.MainFormOldHeight = this.Height;*/
            autoSizeTool.setTag(this);//存储控件的信息

        }

        private void uiAvatar1_Click(object sender, EventArgs e)
        {
            if (formLogin == null)
            {
                formLogin = new FormLogin();
            }
            if (formLogin.IsLogin)
            {
                uiContextMenuStripAvatorAlreadyLogin.Show(uiAvatar1, 0, uiAvatar1.Height);
            }
            else
            {
                uiContextMenuStripUnLogin.Show(uiAvatar1, 0, uiAvatar1.Height);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / autoSizeTool.MainFormOldWidth;
            float newy = (this.Height) / autoSizeTool.MainFormOldHeight;
            
            autoSizeTool.setControls(newx, newy, this);
        }

        private void toolStripMenuItemLoginStu_Click(object sender, EventArgs e)
        {
            autoSizeTool.clearPages(this);
            uiSmoothLabelHeader.Text = "学生登录";
            if (formLogin == null||formLogin.IsDisposed)
            {
                formLogin = null;
                formLogin = new FormLogin();
            }
            formLogin.FLogin_SetUiLine("学生登录");
            if (formLogin.IsLogin)
            {
                ShowInfoTip("已登录!");
            }
            else
            {
                formLogin.ShowDialog();
                if (formLogin.IsLogin)
                {
                    UIMessageTip.ShowOk("登录成功");
                }

                formLogin.Dispose();
            }
        }

        private void ToolStripMenuItemLogOut_Click(object sender, EventArgs e)
        {
            autoSizeTool.clearPages(this);
            formLogin = null;
        }

        private void ToolStripMenuItemRegStu_Click(object sender, EventArgs e)
        {
            autoSizeTool.clearPages(this);
            if (!ExistPage(1001))
            {
                AddPage(new PageRegStu());
            }
            SelectPage(1001);
            uiSmoothLabelHeader.Text = "学生注册";
        }
        private void ToolStripMenuItemRegTeacher_Click(object sender, EventArgs e)
        {
            autoSizeTool.clearPages(this);
            if (!ExistPage(1002))
            {
                AddPage(new PageRegTeacher());
            }
            SelectPage(1002);
            uiSmoothLabelHeader.Text = "导师注册";
        }

        private void toolStripMenuItemLoginTeacher_Click(object sender, EventArgs e)
        {
            autoSizeTool.clearPages(this);
            uiSmoothLabelHeader.Text = "导师登录";
            if (formLogin == null || formLogin.IsDisposed)
            {
                formLogin = null;
                formLogin = new FormLogin();
            }
            formLogin.FLogin_SetUiLine("导师登录");
            if (formLogin.IsLogin)
            {
                ShowInfoTip("已登录!");
            }
            else
            {
                formLogin.ShowDialog();
                if (formLogin.IsLogin)
                {
                    UIMessageTip.ShowOk("登录成功");
                }

                formLogin.Dispose();
            }

        }

        private void Aside_Click(object sender, EventArgs e)
        {
            uiSmoothLabelHeader.Text=Aside.SelectedNode.Text;
        }
    }
}
