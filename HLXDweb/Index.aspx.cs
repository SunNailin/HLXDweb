using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace HLXDweb
{
    public partial class Index1 : System.Web.UI.Page
    {
      // Response.Write(new SQLHelper().test());

      /*  protected void Page_Load(object sender, EventArgs e)
        {
            string setting = "ApplicationServices";
            var connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[setting];
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            conn.Open();
            string index_address = "";
            string sqlstr1 = "SELECT webinfo_address FROM webinfo where webinfo_id = 1";
            index_address = sqlstr1;
            Label1.Text = "连接" + conn.Database + "数据库成功！";
        }*/
        
    }
}