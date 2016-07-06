
namespace Model
{
    /// <summary>
    /// 产品实体类
    /// </summary>
    public class Product
    {
        private string id;
        /// <summary>
        /// 产品ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string typeid;
        /// <summary>
        /// 产品类别ID
        /// </summary>
        public string Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }

        private string content;
        /// <summary>
        /// 产品内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string picture1;
        /// <summary>
        /// 产品图片1
        /// </summary>
        public string Picture1
        {
            get { return picture1; }
            set { picture1 = value; }
        }

        private string picture2;
        /// <summary>
        /// 产品图片2
        /// </summary>
        public string Picture2
        {
            get { return picture2; }
            set { picture2 = value; }
        }

        private string picture3;
        /// <summary>
        /// 产品图片3
        /// </summary>
        public string Picture3
        {
            get { return picture3; }
            set { picture3 = value; }
        }

        private string picture4;
        /// <summary>
        /// 产品图片4
        /// </summary>
        public string Picture4
        {
            get { return picture4; }
            set { picture4 = value; }
        }

        private string picture5;
        /// <summary>
        /// 产品图片5
        /// </summary>
        public string Picture5
        {
            get { return picture5; }
            set { picture5 = value; }
        }

        private string price;
        /// <summary>
        /// 产品价格
        /// </summary>
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product() { }
        public Product(string id,string name,string content,string picture1,string price)
        {
            this.id = id;
            this.name = name;
            this.content = content;
            this.picture1 = picture1;
            this.price = price;            
        }

    }
}
