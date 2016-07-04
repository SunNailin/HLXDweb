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

        #region 将指定字符串按指定长度进行剪切
        /// <summary>
        /// 将指定字符串按指定长度进行剪切
        /// </summary>
        /// <param name="oldStr">需要截取的长度</param>
        /// <param name="maxLength">字符串的最大长度</param>
        /// <param name="endWith">超过长度的后缀</param>
        /// <returns>如果超过最大长度，返回截断后得新字符串加上后缀，否则，返回原字符串</returns>
        public static string StringTruncate(string oldStr, int maxLength, string endWith)
        {
            if (string.IsNullOrEmpty(oldStr))
                //throw new NullReferenceException("原字符串不能为空");
                return oldStr + endWith;
            if (maxLength < 1)
                throw new Exception("返回的字符串长度必须大于[0]");
            if (oldStr.Length > maxLength)
            {
                string strTmp = oldStr.Substring(0, maxLength);
                if (string.IsNullOrEmpty(endWith))
                    return strTmp;
                else
                    return strTmp + endWith;
            }

            return oldStr;
        }
        #endregion

        protected void gvMain_RowCreated(object sender, GridViewRowEventArgs e)
        {
            //这是稳妥的设定gridview字体的方法
            gvNewNews.Font.Size = 10;
            //这个是控制每行的列宽.
            gvNewNews.RowStyle.Height = 20;
            //这个是控制每列的宽度，可以根据需要设置更多的列
            gvNewNews.Columns[0].ItemStyle.Width =280;
            gvNewNews.Columns[1].ItemStyle.Width = 100;
            
        }
        protected string introcont;
        protected void Page_Load(object sender, EventArgs e)
        {

            //string sql = "select address from webinfo where id =1";
            string webinfo_id = "1";
            WebInfo webinfo = new WebInfo();
            WebInfoManager wim = new WebInfoManager();
            webinfo = wim.SelectByID(webinfo_id);

            Intro intro = new Intro();
            IntroManager introm = new IntroManager();
            string intro_id = "3";
            intro = introm.SelectByID(intro_id);
            introcont = StringTruncate(intro.Content, 80, "…… &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp详细内容>>>");
            Label1.Text = webinfo.Address;
            Label2.Text = webinfo.Postcode;
            Label3.Text = webinfo.Phone;
            Label4.Text = webinfo.Contactor;
            Label5.Text = webinfo.Email;
           // Label6.Text = StringTruncate(intro.Content,100, "...");
            //lbl_jieshaozhaiyao.Text = StringTruncate(intro.Content,100,"……");
            //lbl_xiangxineirong.Text = "详细内容>>>";
            //lbl_xiangxineirong.DataBind();
            if (!Page.IsPostBack)
            {
                gvNewNews.DataSource = new NewsManager().SelectNewestNews();
                gvNewNews.DataBind();
            }


        }

    }
}