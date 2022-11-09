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
            User.currentUser.CurrentWeekNo = uiComboBoxWeekNo.Text;
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
            data = dB.selectReturnDataTable(selectDkId, "dk_id");
            if (data.Rows.Count > 0)
            {
                dkId = data.Rows[0]["dk_id"].ToString();
                //MessageBox.Show("数据库已有:"+dkId);
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
                        //MessageBox.Show("数据库有:" + dkId);
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
                    "AND dk_week_no = {1} ", User.currentUser.StuId, weekNo);
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
            uiListBoxNextTasksList.Items.Clear();
            string weekNo = uiComboBoxWeekNo.Text;
            string taskSql = string.Format("SELECT *  FROM  table_dk_main, table_tasks  " +
                "WHERE table_dk_main.dk_id = table_tasks.dk_id  " +
                "AND table_dk_main.stu_id = \"{0}\" " +
                "AND dk_week_no = {1} ", User.currentUser.StuId, weekNo);
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

        private async void uiButtonPublish_Click(object sender, EventArgs e)
        {
            //判空
            string stuId = User.currentUser.StuId;
            if (CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxTaskCompletionContent, this, "请输入完成情况！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxProblem, this, "请输入遇到的问题！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxProblemCompletion, this, "请输入问题解决情况！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxGains, this, "请输入专业收获！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxNotes, this, "请输入备注！")
                )
            {
                if (stuId.IsNullOrEmpty())
                {
                    stuId = "default_empty_stuid";
                }
                if (User.currentUser.CurrentWeekNo == null)
                {
                    ShowErrorDialog("请选择周次!");
                    return;
                }
                //保存各模块内容为RTF格式存在本地后上传到七牛云OSS
                bool taskCompletionContent = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "WeekTaskCompletionContent", uiRichTextBoxTaskCompletionContent);
                if (taskCompletionContent)
                {
                    uiProcessBar1.Value += 20;
                    //ShowInfoDialog("文档上传成功，链接地址为:" + User.currentUser.FileUrl);
                }
                bool problem = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "WeekProblem", uiRichTextBoxProblem);
                if (problem)
                {
                    uiProcessBar1.Value += 20;
                }
                bool problemCompletion = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "WeekProblemCompletion", uiRichTextBoxProblemCompletion);
                if (problemCompletion)
                {
                    uiProcessBar1.Value += 20;
                }
               /* bool literatrueUnderstand = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "LiteratrueUnderstand", uiRichTextBoxLiteratrueUnderstand);
                if (literatrueUnderstand)
                {
                    uiProcessBar1.Value += 20;
                }*/
                bool gains = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "WeekGains", uiRichTextBoxGains);

                if (gains)
                {
                    uiProcessBar1.Value += 20;
                }
                bool notes = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "WeekNotes", uiRichTextBoxNotes);
                if (notes)
                {
                    uiProcessBar1.Value += 20;
                }


                long dirSpace = FileSizeUtil.GetDirectorySpace(rtfDirPath);
                long dirSpaceMB = dirSpace / 1024;
                if (dirSpaceMB > 5 * 1024)
                {
                    ShowWarningTip("文档过大，请减少图片插入量，或改用更小分辨率的图片!");
                    uiLabelRtfFileSize.ForeColor = Color.Red;
                }
                else
                {
                    uiLabelRtfFileSize.ForeColor = Color.Green;

                }
                uiLabelRtfFileSize.Text = dirSpaceMB + "KB";

                if (taskCompletionContent && problem && problemCompletion  && gains && notes)
                {
                    ShowSuccessTip("发布成功");
                }
                else
                {
                    ShowErrorTip("发布失败，请检查内容!");
                }
            }
        }
    }
}
