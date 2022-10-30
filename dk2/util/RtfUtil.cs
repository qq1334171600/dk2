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
            //路径
            string rootPath = Application.StartupPath + "\\rtf\\"+type+"\\";
            string localFilename = string.Format("{0}-{1}.rtf", DateTime.Now.ToString("yyyy@MM@dd-HH@mm@ss"), stuId);
            string remoteFileName = string.Format("dk-{2}/{0}/{1}.rtf", DateTime.Now.ToString("yyyy@MM@dd-HH@mm@ss"), stuId,type);
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
            uirich.SaveFile(fs, RichTextBoxStreamType.RichText);
            fs.Close();
            //uiRichTextBoxTaskCompletionContent.SelectedRtf = "";
            uirich.Select(0, 0);
            //上传文件
            HttpResult result = await HttpUtil.UploadPicture(rootPath + localFilename, remoteFileName);
            if (result.Code == 200)
            {
                DBUtil dB = new DBUtil();
                switch (type)
                {
                    case "TaskCompletionContent":
                        string sql = string.Format(
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
                    default:
                        break;
                }
                return true;
                //由于tasks是由上周日报生成的，所以这里使用update，并记录最后updateTime
                
            }
            else
            {
                return false;
            }
            
        }

        //应用单件模式，保存用户登录状态
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
