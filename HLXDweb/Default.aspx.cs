using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;

namespace HLXDweb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = new NewsTypeDAO().SelectAll();
            GridView1.DataBind();
            //Response.Write(new SQLHelper().ExecuteNonQuery("SELECT webinfo_address FROM webinfo where webinfo_id = 1"));
        }
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from news_type";
            string tpName = TextBox1.Text;
            string id = TextBox2.Text;
            NewsType newsTp = new NewsType (id ,tpName);
            //链接数据库
            Getdata(sql);
            bool b = new NewsTypeDAO().Delete(id);
            Response.Write(b);
            //new SQLHelper().ExecuteNonQuery();
            GridView1.DataSource = new NewsTypeDAO().SelectAll();
            GridView1.DataBind();
        }
    }
}
