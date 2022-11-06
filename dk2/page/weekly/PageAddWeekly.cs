using dk2.entity;
using dk2.form;
using dk2.util;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dk2.page.weekly
{
    public partial class PageAddWeekly : UIPage
    {
        string rtfDirPath = Application.StartupPath + "\\rtf\\";
        DBUtil dB;
        DataTable data;
        public PageAddWeekly()
        {
            InitializeComponent();
            countText();
            if (Directory.Exists(rtfDirPath))
            {
                MessageBox.Show(rtfDirPath);
                FileSizeUtil.DeleteFolder(rtfDirPath);
            }
            uiProcessBar1.Value = 0;
            dB = new DBUtil();
           /* if (User.currentUser.LoginStatus == false)
            {
                FormLogin form = new FormLogin();
                form.ShowDialog();
                this.SetDisabled();
            }
            else
            {
                this.SetEnabled();
            }*/
        }
        private void countText()
        {
            int count = uiRichTextBoxTaskCompletionContent.TextLength
                + uiRichTextBoxProblem.TextLength
                + uiRichTextBoxProblemCompletion.TextLength
                + uiRichTextBoxLiteratrueUnderstand.TextLength
                + uiRichTextBoxGains.TextLength
                + uiRichTextBoxNotes.TextLength;
            uiLabelInputTextLength.Text = count.ToString() + "/3000";
        }


        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiTitlePanel8_Click(object sender, EventArgs e)
        {

        }

        private void uiButtonNextWeekAddTask_Click(object sender, EventArgs e)
        {
            string dkId = "";
            //在插入dk_main记录之前先查询下周的那天有没有dk_id没有再插入
            string selectDkId = string.Format("SELECT dk_id " +
                "FROM table_dk_main " +
                "WHERE stu_id=\"{0}\" " +
                "AND dk_week_no={1} " +
                "AND dk_week_of_day={2} " +
                "GROUP BY dk_id desc ", User.currentUser.StuId,
                uiComboBoxWeekNo.Text,
                uiComboBoxNextWeekSelectDay.Text);
            data = dB.selectReturnDataTable(selectDkId,"dk_id");
            if (data.Rows.Count > 0)
            {
                dkId = data.Rows[0]["dk_id"].ToString();
                MessageBox.Show("数据库已有:"+dkId);
            }
            else
            {
                //添加下周每日计划时，先插入对应每天的dk_main记录以获得dk_id
                string insertDkMain = string.Format("INSERT INTO table_dk_main(stu_id,dk_week_no,dk_week_of_day) " +
                    "VALUES (\"{0}\",{1},{2})", User.currentUser.StuId, uiComboBoxWeekNo.Text, uiComboBoxNextWeekSelectDay.Text);
                if (dB.sqlExcute(insertDkMain) > 0)
                {
                    ShowSuccessTip("插入打卡记录成功");
                    data = dB.selectReturnDataTable(selectDkId, "dk_id");
                    if (data.Rows.Count > 0)
                    {
                        dkId = data.Rows[0]["dk_id"].ToString();
                        MessageBox.Show("数据库有:" + dkId);
                    }
                }

            }
            string insertTaskOfDaySql = string.Format("INSERT INTO table_tasks(task_week_no,task_week_of_day,task_content,dk_id) " +
                "VALUES ({0},{1},\"{2}\",{3})", uiComboBoxWeekNo.Text, uiComboBoxNextWeekSelectDay.Text, uiTextBoxNextWeekTaskDetail.Text, dkId);
            if (dB.sqlExcute(insertTaskOfDaySql) > 0)
            {
                ShowSuccessTip("添加成功");
                uiListBoxNextTasksList.Items.Clear();
                string weekNo = uiComboBoxWeekNo.Text;
                string taskSql = string.Format("SELECT *  FROM  table_dk_main, table_tasks  " +
                    "WHERE table_dk_main.dk_id = table_tasks.dk_id  " +
                    "AND table_dk_main.stu_id = \"{0}\" " +
                    "AND dk_week_no = {1} " , User.currentUser.StuId, weekNo);
                data = dB.selectReturnDataTable(taskSql, "t_task");
                int length = data.Rows.Count;
                if (length > 0)
                {
                    for (int i = 0; i < length; i++)
                    {
                        uiListBoxNextTasksList.Items.Add(data.Rows[i]["task_content"]);
                    }
                }
            }

        }

        private void PageAddWeekly_Initialize(object sender, EventArgs e)
        {

        }
    }
}
