using dk2.util;
using MySql.Data.MySqlClient;
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

namespace dk2.page
{
    public partial class PageRegStu : UIPage
    {
        AutoSize auto;
        DBUtil dB;
        public PageRegStu()
        {
            InitializeComponent();
            dB = new DBUtil();
            auto = new AutoSize(this.Width,this.Height);
            auto.setTag(this);
        }

        private void PageRegStu_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / auto.MainFormOldWidth;
            float newy = (this.Height) / auto.MainFormOldHeight;
            auto.setControls(newx, newy, this);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (CheckUtil.CheckInputEmpty(uiTextBoxRegName, this, "请输入姓名！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegPhone, this, "请输入手机号！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegStuId, this, "请输入学号！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegDirection, this, "请输入研究方向！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegTeacher, this, "请输入导师名称！")
                && CheckUtil.CheckInputEmpty(uiTextBoxRegPassword, this, "请输入密码！")

                )

            {
                string name = uiTextBoxRegName.Text;
                string sex = "男";
                if (uiRadioButtonFemale.Checked)
                {
                    sex = "女";
                }
                string phone = uiTextBoxRegPhone.Text;
                string stuId = uiTextBoxRegStuId.Text;
                string researchDirection = uiTextBoxRegDirection.Text;
                string teacher = uiTextBoxRegTeacher.Text;
                string password=uiTextBoxRegPassword.Text;
                //ShowInfoTip("注册:" + name + sex + phone + stuId + researchDirection + teacher);
                string selectTeacherSql = string.Format(
                    "SELECT teacher_name " +
                    "FROM table_teacher " +
                    "WHERE teacher_name = \"{0}\"",teacher);
                //MySqlDataReader sqlReadTeacher = dB.selectReturnDataReader(selectTeacherSql);
                DataTable dt=dB.selectReturnDataTable(selectTeacherSql,"t_teacher");
                if (!(dt.Rows.Count > 0))
                {
                    ShowWarningTip("该导师不存在，请确认姓名输入是否有误，有疑问请联系管理员！");
                    return;
                }
                string selectStuSql = string.Format(
                    "SELECT stu_id " +
                    "FROM table_stu " +
                    "WHERE stu_id=\"{0}\"",stuId);
                DataTable dt2 = dB.selectReturnDataTable(selectStuSql, "t_stu");
                if ((dt2.Rows.Count > 0))
                {
                    ShowWarningTip("该学生已存在，请确认学号输入是否有误，有疑问请联系管理员！");
                    return;
                }
                string insertSql = string.Format(
                    "INSERT INTO table_stu (stu_name,stu_sex,stu_phone,stu_id,stu_direction,teacher_name,stu_password)" +
                                     "VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\")",
                    name,sex,phone,stuId,researchDirection,teacher,password);
                if (dB.sqlExcute(insertSql) > 0)
                {
                    ShowSuccessTip("注册成功");
                }
            }
        }
    }
}
