using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dk2.util
{
    static class CheckUtil
    {
        public static  bool CheckInputEmpty(UITextBox edit,UIPage page, string desc)
        {
            bool flag = edit.Text.IsValid();
            if (!flag)
            {
                page.ShowWarningDialog(desc);
                edit.Focus();
            }

            return flag;
        }
        public static bool CheckInputEmptyWithRichBox(UIRichTextBox edit, UIPage page, string desc)
        {
            bool flag = edit.Text.IsValid();
            if (!flag)
            {
                page.ShowWarningDialog(desc);
                edit.Focus();
            }

            return flag;
        }
        public static bool CheckInputRange(UITextBox edit,UIPage page,int min, int max, string desc)
        {
            bool flag = edit.IntValue >= min && edit.IntValue <= max;
            if (!flag)
            {
                page.ShowWarningDialog(desc);
                edit.Focus();
            }

            return flag;
        }
    }
}
