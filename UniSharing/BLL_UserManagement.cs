using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace UniSharing
{
    public class BLL_UserManagement
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns>代表成功与否的布尔值</returns>
        public static bool SignUp(Model_User user)
        {
            //string temp = "INSERT INTO [dbo].[user]([Id],[userName],[userPWD],[userMail],[school],[schoolNum])VALUES(< Id, int,>,< userName, nchar(10),> ,< userPWD, nchar(10),>,< userMail, nchar(10),>,< school, nchar(10),>,< schoolNum, nchar(10),>)"
            string sql = "insert into [dbo].[user](userName,userPWD,userMail,school,schoolNum)values(@userName,@userPWD,@userMail,@school,@schoolNum)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userName", user.UserName),
                new SqlParameter("@userPWD",user.UserPassword),
                new SqlParameter("@userMail",user.UserMail),
                new SqlParameter("@school",user.School),
                new SqlParameter("@schoolNum",user.SchoolNum),

            };
            int ret = DAO_databaseControl.ExecuteSql(sql, parameters);
            if(ret>0)
            { return true; }
            else
            { return false; }
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="user"></param>
        /// <returns>用户ID</returns>
        public string LogIn(Model_User user)
        {
            string sql = "select Id from user where userName=@userName and userPWD=@userPWD";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userName", user.UserName),
                new SqlParameter("@userPWD",user.UserPassword),
            };
            DataTable dt_temp = DAO_databaseControl.GetDataSet(sql, parameters);
            if(dt_temp.Rows.Count>0)
            {
                string ret_ID = dt_temp.Rows[0][0].ToString();
                return ret_ID;
            }
            else
            {
                string ret = "false";
                return ret;
            }
        }
    }
}