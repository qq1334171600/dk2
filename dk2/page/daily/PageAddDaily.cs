using dk2.entity;
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
        public PageAddDaily()
        {
            InitializeComponent();
        }

        private void uiListBox1_DoubleClick(object sender, EventArgs e)
        {
            uiTextBoxTaskDetail.Text=uiListBox1.SelectedItem.ToString()+ "服务器系统重置，选择centos7，稳定占用内存低\r\n安装宝塔面板便于管理服务器\r\n安装MySQL服务，本地可连接上\r\n安装nginx服务，可以放置一些简单的网页供访问，链接:www.zhangjian.link\r\n学习SunnyUI,使用sunnyUI做出协调的界面服务器系统重置，选择centos7，稳定占用内存低\r\n安装宝塔面板便于管理服务器\r\n安装MySQL服务，本地可连接上\r\n安装nginx服务，可以放置一些简单的网页供访问，链接:www.zhangjian.link\r\n学习SunnyUI,使用sunnyUI做出协调的界面服务器系统重置，选择centos7，稳定占用内存低\r\n安装宝塔面板便于管理服务器\r\n安装MySQL服务，本地可连接上\r\n安装nginx服务，可以放置一些简单的网页供访问，链接:www.zhangjian.link\r\n学习SunnyUI,使用sunnyUI做出协调的界面服务器系统重置，选择centos7，稳定占用内存低\r\n安装宝塔面板便于管理服务器\r\n安装MySQL服务，本地可连接上\r\n安装nginx服务，可以放置一些简单的网页供访问，链接:www.zhangjian.link\r\n学习SunnyUI,使用sunnyUI做出协调的界面服务器系统重置，选择centos7，稳定占用内存低\r\n安装宝塔面板便于管理服务器\r\n安装MySQL服务，本地可连接上\r\n安装nginx服务，可以放置一些简单的网页供访问，链接:www.zhangjian.link\r\n学习SunnyUI,使用sunnyUI做出协调的界面服务器系统重置，选择centos7，稳定占用内存低\r\n安装宝塔面板便于管理服务器\r\n安装MySQL服务，本地可连接上\r\n安装nginx服务，可以放置一些简单的网页供访问，链接:www.zhangjian.link\r\n学习SunnyUI,使用sunnyUI做出协调的界面";
        }

        private async void uiButtonPublish_Click(object sender, EventArgs e)
        {
            string stuId=User.currentUser.StuId;
            if (stuId.IsNullOrEmpty())
            {
                stuId = "default_empty_stuid";
            }
            string rootPath =Application.StartupPath+"\\rtf\\";
            string localFilename = string.Format("{0}-{1}.rtf", DateTime.Now.ToString("yyyy@MM@dd-HH@mm@ss"), stuId);
            string remoteFileName = string.Format("dk/{0}/{1}.rtf", DateTime.Now.ToString("yyyy@MM@dd-HH@mm@ss"),stuId);
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }
            uiRichTextBoxTaskCompletionContent.Focus();
            uiRichTextBoxTaskCompletionContent.Select(0,
            uiRichTextBoxTaskCompletionContent.Rtf.Length);
            Clipboard.SetData(DataFormats.Rtf, 
            uiRichTextBoxTaskCompletionContent.SelectedRtf);
            FileStream fs = new FileStream(rootPath+localFilename, FileMode.Create, FileAccess.Write);
            uiRichTextBoxTaskCompletionContent.SaveFile(fs, RichTextBoxStreamType.RichText);
            fs.Close();
            //uiRichTextBoxTaskCompletionContent.SelectedRtf = "";
            HttpResult result = await HttpUtil.UploadPicture(rootPath + localFilename, remoteFileName);
            if (result.Code == 200)
            {
                ShowSuccessTip("上传文件成功");
            }
                
            uiRichTextBoxTaskCompletionContent.Select(0,0);
        }
    }
}
