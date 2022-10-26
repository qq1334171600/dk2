using dk2.util;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dk2.page
{
    public partial class PageRegTeacher : UIPage
    {
        AutoSize auto;
        DBUtil dB;

        public PageRegTeacher()
        {
            InitializeComponent();
            dB = new DBUtil();
            auto = new AutoSize(this.Width, this.Height);
            auto.setTag(this);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (CheckUtil.CheckInputEmpty(uiTextBoxRegTName, this, "请输入姓名！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegTPhone, this, "请输入手机号！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegTId, this, "请输入教师工号！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegTDirection, this, "请输入研究方向！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegOrg, this, "请输入所属单位！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegTPassword, this, "请输入密码！")

                )
            {
                string name = uiTextBoxRegTName.Text;
                string sex = "男";
                if (uiRadioButtonTFemale.Checked)
                {
                    sex = "女";
                }
                string phone = uiTextBoxRegTPhone.Text;
                string tId = uiTextBoxRegTId.Text;
                string researchDirection = uiTextBoxRegTDirection.Text;
                string org = uiTextBoxRegOrg.Text;
                string password = uiTextBoxRegTPassword.Text;
                //ShowInfoTip("注册:" + name + sex + phone + tId + researchDirection + org);
                string selectTeacherSql = string.Format(
                       "SELECT teacher_name " +
                       "FROM table_teacher " +
                       "WHERE teacher_name = \"{0}\"", name);
                DataTable dt = dB.selectReturnDataTable(selectTeacherSql, "t_teacher");
                if (dt.Rows.Count > 0)
                {
                    ShowWarningTip("该导师已存在，请确认姓名输入是否有误或重名，有疑问请联系管理员！");
                    return;
                }
                string insertSql = string.Format(
                    "INSERT INTO table_teacher(teacher_name,teacher_sex,teacher_phone,teacher_id,teacher_direction,teacher_org,teacher_password)" +
                    "VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\")",
                    name,sex,phone,tId,researchDirection,org,password);
                if (dB.sqlExcute(insertSql) > 0)
                {
                    ShowSuccessTip("注册成功");
                }

            }
        }
        private void PageRegTeacher_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / auto.MainFormOldWidth;
            float newy = (this.Height) / auto.MainFormOldHeight;
            auto.setControls(newx, newy, this);
        }
    }
}
