using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dk2.util
{
    class AutoSize
    {
        public  AutoSize(float OldW,float OldH)
        {
            MainFormOldHeight = OldH;
            MainFormOldWidth = OldW;
        }
        public float MainFormOldWidth;
        public float MainFormOldHeight;
        public void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }
        /// <summary>
        /// 设置对应控件的大小
        /// </summary>
        /// <param name="newx">窗体长</param>
        /// <param name="newy">窗体宽</param>
        /// <param name="cons">控件</param>
        public void setControls(float newx, float newy, Control cons)
        {
                foreach (Control con in cons.Controls)
            {
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                    float a = Convert.ToSingle(mytag[0]) * newx;
                    con.Width = (int)a;
                    a = Convert.ToSingle(mytag[1]) * newy;
                    con.Height = (int)(a);
                    a = Convert.ToSingle(mytag[2]) * newx;
                    con.Left = (int)(a);
                    a = Convert.ToSingle(mytag[3]) * newy;
                    con.Top = (int)(a);
                    Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                    if (currentSize <= 0)
                    {
                        currentSize = 1;
                    }else if (currentSize > Single.MaxValue)
                    {
                        currentSize = Single.MaxValue - 1;
                    }
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
                
            }
        }
        public void clearPages(UIAsideMainFrame frame)
        {
            foreach(UIPage p in frame.GetPages<UIPage>())
            {
                if (p.PageIndex < 2000)
                {
                    frame.RemovePage(p.PageIndex);
                }
            }
        }
    }
}
