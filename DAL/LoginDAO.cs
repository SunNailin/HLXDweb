using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;


namespace DAL
{
    public class LoginDAO
    {
        private SQLHelper sqlhelper = null;
        public LoginDAO()
        {
            sqlhelper = new SQLHelper();
        }

        public bool checkLogin(string name, string pwd)
        {


            bool flag = false;
            string sql_check = "select admin_loginname from admin where admin_loginname= '" + name + "' and admin_password='" + pwd + "'";
            flag = sqlhelper.checkReturn(sql_check, CommandType.Text);
            return flag;
        }


    }
}
