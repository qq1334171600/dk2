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
            autoSizeTool = new AutoSize();
            autoSizeTool.MainFormOldWidth= this.Width;
            autoSizeTool.MainFormOldHeight = this.Height;
            autoSizeTool.setTag(this);//存储控件的信息

        }

        private void uiAvatar1_Click(object sender, EventArgs e)
        {
            if (formLogin.IsLogin)
            {
                uiContextMenuStripAvator.Show(uiAvatar1, 0, uiAvatar1.Height);
            }
            else
            {
                ShowErrorDialog("请先登录!");
                formLogin.ShowDialog();
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
    }
}
