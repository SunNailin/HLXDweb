using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using DAL;

namespace BLL
{
    public class LoginManager
    {
       private  LoginDAO lgdao = null;
       public LoginManager()
        {
            lgdao = new LoginDAO();
        }
        #region 判断用户登录是否成功
        /// <summary>
        /// 判断用户登录是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public  bool CheckLogin(string name, string pwd)
        {
            return lgdao.checkLogin(name,  pwd);
        }
        #endregion

        public bool isLogined(string name)
        {
            return lgdao.isLogined(name);
        }
    }


}
