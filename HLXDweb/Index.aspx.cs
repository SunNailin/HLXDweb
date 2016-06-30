using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BLL;
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
            string id = "1";
            WebInfo webinfo = new WebInfo();
            WebInfoManager wim = new WebInfoManager();
            //index_address = sqlstr1;
            webinfo = wim.SelectByID(id);
            Label1.Text = webinfo.Address;
            Label2.Text = webinfo.Postcode;
            Label3.Text = webinfo.Phone;
            Label4.Text = webinfo.Contactor;
            Label5.Text = webinfo.Email;
            Label6.Text = webinfo.Phone;
            Label7.Text = webinfo.Contactor;
        }

    }
}