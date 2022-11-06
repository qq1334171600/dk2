using dk2.entity;
using dk2.form;
using dk2.util;
using Qiniu.Http;
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
using System.Windows.Forms.Design;

namespace dk2.page
{
    public partial class PageAddDaily : UIPage
    {
        string rtfDirPath = Application.StartupPath + "\\rtf\\";
        DBUtil dB;
        DataTable data;
        public PageAddDaily()
        {
            InitializeComponent();
            countText();
            if (Directory.Exists(rtfDirPath))
            {
                MessageBox.Show(rtfDirPath);
                FileSizeUtil.DeleteFolder(rtfDirPath);
            }
            uiProcessBar1.Value = 0;
            dB=new DBUtil();
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

        private void uiListBox1_DoubleClick(object sender, EventArgs e)
        {
            ShowWarningDialog("选择的任务的taskId为：" + data.Rows[uiListBox1.SelectedIndex]["task_id"]);
            User.currentUser.CurrentTaskId = data.Rows[uiListBox1.SelectedIndex]["task_id"].ToString();
            uiTextBoxTaskDetail.Text = uiListBox1.SelectedItem.ToString();
        }

        private async void uiButtonPublish_Click(object sender, EventArgs e)
        {
            //判空
            string stuId=User.currentUser.StuId;
            if (CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxTaskCompletionContent, this, "请输入完成情况！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxProblem, this, "请输入遇到的问题！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxLiteratrueUnderstand, this, "请输入文献理解情况！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxTaskCompletionContent, this, "请输入姓名！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxGains, this, "请输入专业收获！")
                && CheckUtil.CheckInputEmptyWithRichBox(uiRichTextBoxNotes, this, "请输入备注！")
                )
            {
                if (stuId.IsNullOrEmpty())
                {
                    stuId = "default_empty_stuid";
                }
                //保存各模块内容为RTF格式存在本地后上传到七牛云OSS
                bool taskCompletionContent = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "TaskCompletionContent", uiRichTextBoxTaskCompletionContent);
                if (taskCompletionContent)
                {
                    uiProcessBar1.Value += 20;
                    ShowInfoDialog("文档上传成功，链接地址为:"+User.currentUser.FileUrl);
                }
                bool problem = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "Problem", uiRichTextBoxProblem);
                if (problem)
                {
                    uiProcessBar1.Value += 20;
                }
                bool problemCompletion = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "ProblemCompletion", uiRichTextBoxProblemCompletion);
                if (problemCompletion)
                {
                    uiProcessBar1.Value += 20;
                }
                bool literatrueUnderstand = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "LiteratrueUnderstand", uiRichTextBoxLiteratrueUnderstand);
                if (literatrueUnderstand)
                {
                    uiProcessBar1.Value += 20;
                }
                bool gains = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "Gains", uiRichTextBoxGains);

                if (gains)
                {
                    uiProcessBar1.Value += 20;
                }
                bool notes = await RtfUtil.currentInstance.SaveAndUploadWithRtf(stuId, "Notes", uiRichTextBoxNotes);
                if (notes)
                {
                    uiProcessBar1.Value += 20;
                }


                long dirSpace=FileSizeUtil.GetDirectorySpace(rtfDirPath);
                long dirSpaceMB =dirSpace/1024;
                if (dirSpaceMB > 5*1024)
                {
                    ShowWarningTip("文档过大，请减少图片插入量，或改用更小分辨率的图片!");
                    uiLabelRtfFileSize.ForeColor = Color.Red;
                }
                else
                {
                    uiLabelRtfFileSize.ForeColor = Color.Green;

                }
                uiLabelRtfFileSize.Text = dirSpaceMB + "KB";

                if (taskCompletionContent && problem && problemCompletion && literatrueUnderstand && gains && notes)
                {
                    ShowSuccessTip("发布成功");
                }
                else
                {
                    ShowErrorTip("发布失败，请检查内容!");
                }
                //ShowInfoDialog("文档缓存文件占用空间:" + (dirSpace/1024/1024)+"MB");
            }

        }

        private void uiRichTextBoxTaskCompletionContent_TextChanged(object sender, EventArgs e)
        {
            countText();
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

        private void uiRichTextBoxProblem_TextChanged(object sender, EventArgs e)
        {
            countText();
        }

        private void uiRichTextBoxProblemCompletion_TextChanged(object sender, EventArgs e)
        {
            countText();
        }

        private void uiRichTextBoxLiteratrueUnderstand_TextChanged(object sender, EventArgs e)
        {
            countText();
        }

        private void uiRichTextBoxGains_TextChanged(object sender, EventArgs e)
        {
            countText();
        }

        private void uiRichTextBoxNotes_TextChanged(object sender, EventArgs e)
        {
            countText();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            uiListBox1.Items.Clear();
            string weekNo=uiComboBoxWeekNo.Text;
            string dayOfWeek=uiComboBoxDayOfWeek.Text;
            ShowWarningTip("这是第" + weekNo + "周第" + dayOfWeek + "天");
            string taskSql = string.Format("SELECT *  FROM  table_dk_main, table_tasks  " +
                "WHERE table_dk_main.dk_id = table_tasks.dk_id  " +
                "AND table_dk_main.stu_id = \"{0}\" " +
                "AND dk_week_no = {1} " +
                "AND dk_week_of_day ={2}", User.currentUser.StuId,weekNo, dayOfWeek);
            data=dB.selectReturnDataTable(taskSql, "t_task");
            int length=data.Rows.Count;
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    uiListBox1.Items.Add(data.Rows[i]["task_content"]);
                }
            }
            ShowWarningDialog(taskSql);
            
        }

        private void PageAddDaily_Initialize(object sender, EventArgs e)
        {
            if (User.currentUser.LoginStatus == false)
            {
                FormLogin form = new FormLogin();
                form.ShowDialog();
                this.SetDisabled();
            }
            else
            {
                this.SetEnabled();
            }
        }
    }
}
