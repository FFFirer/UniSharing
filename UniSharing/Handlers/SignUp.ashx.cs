using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniSharing.Handlers
{
    /// <summary>
    /// SignUp 的摘要说明
    /// </summary>
    public class SignUp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string name = context.Request.Form["name"];
            string mail = context.Request.Form["mail"];
            string password = context.Request.Form["password"];
            string school = context.Request.Form["school"];
            string schoolId = context.Request.Form["schoolId"];
            //封装用户对象
            Model_User user = new Model_User();
            user.UserName = name;
            user.UserMail = mail;
            user.UserPassword = password;
            user.School = school;
            user.SchoolNum = schoolId;

            //context.Response.Write(name + mail + password + school + schoolId);

            bool res = BLL_UserManagement.SignUp(user);
            if (res == true)
            {
                context.Response.Write("success");
            }
            else
            {
                context.Response.Write("fail");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}