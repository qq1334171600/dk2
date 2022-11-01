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

namespace dk2.page
{
    public partial class PageSelectDaily : UIPage
    {
        DBUtil dB;
        DataTable data;
        public PageSelectDaily()
        {
            InitializeComponent();
            dB = new DBUtil();
        }

        private void uiButtonSelectWeekNo_Click(object sender, EventArgs e)
        {
            //不选内容
            uiRichTextBoxDailyDetail.SelectionLength = 0;
            string weekNo = uiComboBoxWeekNo.Text;
            string dayOfWeek = uiComboBoxDayOfWeek.Text;
            string fileUrl = "";
            ShowWarningTip("这是第" + weekNo + "周第" + dayOfWeek + "天");
            string taskSql = string.Format("SELECT *  FROM  table_dk_main, table_tasks  " +
                "WHERE table_dk_main.dk_id = table_tasks.dk_id  " +
                "AND table_dk_main.stu_id = \"{0}\" " +
                "AND dk_week_no = {1} " +
                "AND dk_week_of_day ={2}", User.currentUser.StuId, weekNo, dayOfWeek);
            data = dB.selectReturnDataTable(taskSql, "t_task");
            int length = data.Rows.Count;
            if (length > 0)
            {
                //如果数据库查出来只有一个文件，那么直接显示
                if (length == 1)
                {
                    MessageBox.Show("1");
                    fileUrl = data.Rows[0]["task_completion_content"].ToString();
                    if (fileUrl.Contains("7.zhangjian.link"))
                    {
                        uiRichTextBoxDailyDetail.LoadFile(HttpUtil.HttpDownload(fileUrl), RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        uiRichTextBoxDailyDetail.Text="获取数据有误:"+fileUrl;
                    }
                }
                //否则每个文件遍历合并
                else
                {
                    MessageBox.Show("2");
                    for (int i = 0; i < length; i++)
                    {
                        fileUrl = data.Rows[i]["task_completion_content"].ToString();
                        if (fileUrl.Contains("7.zhangjian.link"))
                        {
                            uiRichTextBoxDailyDetail.AppendText("\n-------------------------------------------\n");
                            RichTextBox rtfSecond = new RichTextBox();
                            rtfSecond.LoadFile(HttpUtil.HttpDownload(fileUrl),RichTextBoxStreamType.RichText);
                            rtfSecond.Select(rtfSecond.Rtf.Length, 0);
                            uiRichTextBoxDailyDetail.SelectedRtf = rtfSecond.Rtf;
                        }
                        else
                        {
                            uiRichTextBoxDailyDetail.Text = "获取数据有误:" + fileUrl;
                        }
                    }
                }
            }
            ShowWarningDialog(taskSql);
        }
    }
}
