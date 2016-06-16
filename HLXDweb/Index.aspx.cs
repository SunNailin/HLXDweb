using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DAL;
using Model;

namespace HLXDweb
{
    public partial class Index1 : System.Web.UI.Page
    {
        // Response.Write(new SQLHelper().test());
        public static DataTable Getdata(string sql)
        {
            string strsql = @"data source=.;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\DB_HLXD.mdf;User Instance=false";
            SqlConnection conn = new SqlConnection(strsql);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //string sql = "select address from webinfo where id =1";
            string sqlstr1 = "SELECT webinfo_address FROM webinfo where webinfo_id = 1";
            WebInfo webInfo = new WebInfo("2","tttt", 1324, "saf", "adsg", "ag", "asdg", "ag", "agd", "饭卡据了解", "adg", "asg", "adg", "adsg", "adg");
            new WebInfoDAO().Update(webInfo);
            DataTable dt = Getdata(sqlstr1);
            //webInfo = dt;
            //webInfo.Address = dt.

            //index_address = sqlstr1;
            Label1.Text = "asfa";
        }

    }
}