using dk2.entity;
using dk2.page;
using Org.BouncyCastle.Utilities.Encoders;
using Qiniu.Http;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using User = dk2.entity.User;

namespace dk2.util
{
     public class RtfUtil
    {
        public static RtfUtil _Instance = null;
        public async Task<bool> SaveAndUploadWithRtf(string stuId,string type,UIRichTextBox uirich)
        {
            //数据库语句
            string sql = "";
            //本地文件路径和远程文件路径
            string rootPath = Application.StartupPath + "\\rtf\\"+type+"\\";
            string localFilename = string.Format("{0}-{1}.rtf", DateTime.Now.ToString("yyyy@MM@dd-HH@mm@ss"), stuId);
            string remoteFileName = string.Format("dk-{2}/{0}/{1}.rtf", DateTime.Now.ToString("yyyy@MM@dd-HH@mm@ss"), stuId,type);
           //创建缓存文件夹
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }
            //操作rtf
            uirich.Focus();
            uirich.Select(0,
            uirich.Rtf.Length);
            Clipboard.SetData(DataFormats.Rtf,
            uirich.SelectedRtf);
            FileStream fs = new FileStream(rootPath + localFilename, FileMode.Create, FileAccess.Write);
            //将富文本内容保存为文件
            uirich.SaveFile(fs, RichTextBoxStreamType.RichText);
            fs.Close();
            //uiRichTextBoxTaskCompletionContent.SelectedRtf = "";
            uirich.Select(0, 0);
            //上传文件到Oss
            HttpResult result = await HttpUtil.UploadPicture(rootPath + localFilename, remoteFileName);
            if (result.Code == 200)//200代表上传成功
            {
                DBUtil dB = new DBUtil();
                switch (type)//根据不同模块存入相应数据库
                    //todo:如果插入失败应该删除刚才上传成功的文件，并回滚前几个插入记录
                {
                    case "TaskCompletionContent"://日任务完成内容
                         sql = string.Format(
                    "UPDATE table_tasks SET task_completion_content = \"{0}\" WHERE task_id = {1}", HttpUtil.OssRootUrl + remoteFileName, User.currentUser.CurrentTaskId);
                        if (dB.sqlExcute(sql) > 0)
                        {
                            User.currentUser.FileUrl = HttpUtil.OssRootUrl + remoteFileName;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "Problem"://日问题
                        sql = string.Format(
                   "UPDATE table_tasks SET task_completion_content = \"{0}\" WHERE task_id = {1}", HttpUtil.OssRootUrl + remoteFileName, User.currentUser.CurrentTaskId);
                        if (dB.sqlExcute(sql) > 0)
                        {
                            User.currentUser.FileUrl = HttpUtil.OssRootUrl + remoteFileName;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case "WeekTaskCompletionContent"://周任务完成内容
                        sql = string.Format(
                   "UPDATE table_dk_week set week_task_completion_content=\"{1}\" WHERE weekNo={0} AND stu_id=\"{2}\"",User.currentUser.CurrentWeekNo, HttpUtil.OssRootUrl + remoteFileName, User.currentUser.StuId);
                        if (dB.sqlExcute(sql) > 0)
                        {
                            User.currentUser.FileUrl = HttpUtil.OssRootUrl + remoteFileName;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "WeekProblem"://周问题
                        sql = string.Format(
                   "UPDATE table_dk_week set week_problem" +
                   "=\"{1}\" WHERE weekNo={0} AND stu_id=\"{2}\"", User.currentUser.CurrentWeekNo, HttpUtil.OssRootUrl + remoteFileName, User.currentUser.StuId);
                        if (dB.sqlExcute(sql) > 0)
                        {
                            User.currentUser.FileUrl = HttpUtil.OssRootUrl + remoteFileName;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "WeekProblemCompletion"://周问题解决
                        sql = string.Format(
                   "UPDATE table_dk_week set week_problem_completion_content" +
                   "=\"{1}\" WHERE weekNo={0} AND stu_id=\"{2}\"", User.currentUser.CurrentWeekNo, HttpUtil.OssRootUrl + remoteFileName, User.currentUser.StuId);
                        if (dB.sqlExcute(sql) > 0)
                        {
                            User.currentUser.FileUrl = HttpUtil.OssRootUrl + remoteFileName;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "WeekGains"://周专业收获
                        sql = string.Format(
                   "UPDATE table_dk_week set week_gains" +
                   "=\"{1}\" WHERE weekNo={0} AND stu_id=\"{2}\"", User.currentUser.CurrentWeekNo, HttpUtil.OssRootUrl + remoteFileName, User.currentUser.StuId);
                        if (dB.sqlExcute(sql) > 0)
                        {
                            User.currentUser.FileUrl = HttpUtil.OssRootUrl + remoteFileName;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "WeekNotes"://周备注
                        sql = string.Format(
                   "UPDATE table_dk_week set week_notes" +
                   "=\"{1}\" WHERE weekNo={0} AND stu_id=\"{2}\"", User.currentUser.CurrentWeekNo, HttpUtil.OssRootUrl + remoteFileName, User.currentUser.StuId);
                        if (dB.sqlExcute(sql) > 0)
                        {
                            User.currentUser.FileUrl = HttpUtil.OssRootUrl + remoteFileName;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    default:
                        break;
                }
                return false;
                //由于tasks是由上周日报生成的，所以这里使用update，并记录最后updateTime
                

            }
            else
            {
                return false;
            }
            
        }

        //应用单件模式 这样无需到处new对象，全局只有一个
        public static RtfUtil currentInstance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new RtfUtil();
                return _Instance;
            }
        }

    }
}
