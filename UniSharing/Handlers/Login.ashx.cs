using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniSharing.Handlers
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string phone = context.Request.Form["userPhone"];
            string passeword = context.Request.Form["userPWD"];

            Model_User user = new Model_User();
            user.PhoneNum = phone;
            user.UserPassword = passeword;

            string res = BLL_UserManagement.LogIn(user);
            context.Response.Write(res);

            //context.Response.Write(name + passeword);

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