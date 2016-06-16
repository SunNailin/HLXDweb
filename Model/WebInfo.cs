/* 
 *  作者：牛腩
 *  创建时间：2016/6/16 星期四 15:12:12
 *  类说明：网页信息 实体类
 */
namespace Model
{
    /// <summary>
    /// 网页信息 实体类
    /// </summary>
    public class WebInfo
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string keywords;
        public string Keywords
        {
            get { return keywords; }
            set { keywords = value; }
        }

        private double clicks;
        public double Clicks
        {
            get { return clicks; }
            set { clicks = value; }
        }

        private string pic1;
        public string Pic1
        {
            get { return pic1; }
            set { pic1 = value; }
        }

        private string pic2;
        public string Pic2
        {
            get { return pic2; }
            set { pic2 = value; }
        }

        private string pic3;
        public string Pic3
        {
            get { return pic3; }
            set { pic3 = value; }
        }

        private string pic4;
        public string Pic4
        {
            get { return pic4; }
            set { pic4 = value; }
        }

        private string pic5;
        public string Pic5
        {
            get { return pic5; }
            set { pic5 = value; }
        }

        private string logo;
        public string Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string postcode;
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string fax;
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string contactor;
        public string Contactor
        {
            get { return contactor; }
            set { contactor = value; }
        }

        public WebInfo(string id, string keywords,
            double clicks, string pic1, string pic2, string pic3,
            string pic4, string pic5, string logo, string address,
            string postcode, string phone, string fax, string email,
            string contactor)
        {
            this.id = id;
            this.keywords = keywords;
            this.clicks = clicks;
            this.pic1 = pic1;
            this.pic2 = pic2;
            this.pic3 = pic3;
            this.pic4 = pic4;
            this.pic5 = pic5;
            this.logo = logo;
            this.address = address;
            this.phone = phone;
            this.fax = fax;
            this.email = email;
            this.contactor = contactor;
            this.postcode = postcode;
        }

    }
}
