using dk2.entity;
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

namespace dk2.form
{
    public partial class FormLogin : UILoginForm
    {
        DBUtil dB;
        public FormLogin()
        {
            InitializeComponent();
            dB=new DBUtil();

        }
        public void FLogin_SetUiLine(string content)
        {
            uiLine2.Text = content;
        }
        private void FLogin_ButtonLoginClick(object sender, System.EventArgs e)
        {
            string loginSql;
            //UserName就是封装了界面里用户名输入框的值
            //Password就是封装了界面里密码输入框的值
            if (uiLine2.Text.Contains("学生"))
            {
                loginSql = string.Format(
                    "SELECT stu_password  FROM table_stu  WHERE stu_id = \"{0}\"", UserName);
                DataTable dt = dB.selectReturnDataTable(loginSql, "t_login");
                if (!(dt.Rows.Count > 0))
                {
                    ShowWarningTip("该学生账号不存在!请联系管理员");
                    return;
                }
                else if (dt.Rows[0][0].ToString().Trim()==Password)
                {
                    User.currentUser.LoginStatus = true;
                    IsLogin = true;
                    Close();
                }
                else
                {
                    User.currentUser.LoginStatus = false;
                    IsLogin = false;
                    ShowWarningTip("密码错误!");
                }   
            }
            else if (uiLine2.Text.Contains("导师"))
            {
                loginSql = string.Format(
                    "SELECT teacher_password  FROM table_teacher  WHERE teacher_name = \"{0}\"", UserName);
                DataTable dt = dB.selectReturnDataTable(loginSql, "t_login");
                if (!(dt.Rows.Count > 0))
                {
                    ShowWarningTip("该导师账号不存在!请联系管理员");
                    return;
                }
                else if (dt.Rows[0][0].ToString().Trim() == Password)
                {
                    User.currentUser.LoginStatus = true;
                    IsLogin = true;
                    Close();
                }
                else
                {
                    User.currentUser.LoginStatus = false;
                    IsLogin = false;
                    ShowWarningTip("密码错误!");
                }
            }
            else
            {
                ShowErrorTip("程序错误，请联系管理员");
            }
        }
    }
}
