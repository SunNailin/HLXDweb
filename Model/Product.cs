
namespace Model
{
    /// <summary>
    /// ��Ʒʵ����
    /// </summary>
    public class Product
    {
        private string id;
        /// <summary>
        /// ��ƷID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string typeid;
        /// <summary>
        /// ��Ʒ���ID
        /// </summary>
        public string Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }

        private string content;
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string picture1;
        /// <summary>
        /// ��ƷͼƬ1
        /// </summary>
        public string Picture1
        {
            get { return picture1; }
            set { picture1 = value; }
        }

        private string picture2;
        /// <summary>
        /// ��ƷͼƬ2
        /// </summary>
        public string Picture2
        {
            get { return picture2; }
            set { picture2 = value; }
        }

        private string picture3;
        /// <summary>
        /// ��ƷͼƬ3
        /// </summary>
        public string Picture3
        {
            get { return picture3; }
            set { picture3 = value; }
        }

        private string picture4;
        /// <summary>
        /// ��ƷͼƬ4
        /// </summary>
        public string Picture4
        {
            get { return picture4; }
            set { picture4 = value; }
        }

        private string picture5;
        /// <summary>
        /// ��ƷͼƬ5
        /// </summary>
        public string Picture5
        {
            get { return picture5; }
            set { picture5 = value; }
        }

        private string price;
        /// <summary>
        /// ��Ʒ�۸�
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
