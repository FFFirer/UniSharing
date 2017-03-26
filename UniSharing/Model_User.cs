using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniSharing
{
    public class Model_User
    {
        private string username;
        private string userpassword;
        private string userMail;
        private string school;
        private string schoolNum;
        private string phoneNum;
        private int userid;
        
        public string UserName
        {
            set { username = value; }
            get { return username; }
        }
        public string UserPassword
        {
            set { userpassword = value; }
            get { return userpassword; }
        }
        public int UserID
        {
            set { userid = value; }
            get { return UserID; }
        }
        public string UserMail
        {
            set { userMail = value; }
            get { return userMail; }
        }
        public string School
        {
            set { school = value; }
            get { return school; }
        }
        public string SchoolNum
        {
            set { schoolNum = value; }
            get { return schoolNum; }
        }
        public string PhoneNum
        {
            set { phoneNum = value; }
            get { return phoneNum; }
        }
    }
}