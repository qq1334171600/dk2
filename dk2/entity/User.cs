using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dk2.entity
{
    public class User
    {
        private string stuId;
        private string teacherName;
        private bool loginStatus = false;//登陆状态
        private int userRoleId;
        private string fileUrl;
        private string currentTaskId;
        private string currentWeekNo;

        public string StuId { get => stuId; set => stuId = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public bool LoginStatus { get => loginStatus; set => loginStatus = value; }
        public int UserRoleId { get => userRoleId; set => userRoleId = value; }
        public string FileUrl { get => fileUrl; set => fileUrl = value; }
        public string CurrentTaskId { get => currentTaskId; set => currentTaskId = value; }
        public string CurrentWeekNo { get => currentWeekNo; set => currentWeekNo = value; }


        public static User _CurrentUser = null;

        //应用单件模式，保存用户登录状态
        public static User currentUser
        {
            get
            {
                if (_CurrentUser == null)
                    _CurrentUser = new User();
                return _CurrentUser;
            }
        }


    }
}
