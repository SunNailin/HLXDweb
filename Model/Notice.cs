/* 
 *  ���ߣ�ţ��
 *  ����ʱ�䣺
 *  ��˵���������ʵ����
 */ 
namespace Model
{
    /// <summary>
    /// �����ʵ����
    /// </summary>
    public class Notice
    {
        private string id;
        /// <summary>
        /// �����ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        /// <summary>
        /// �������
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string publisherid;
        /// <summary>
        /// ���淢����
        /// </summary>
        public string Publisherid
        {
            get { return publisherid; }
            set { publisherid = value; }
        }

        private int clicks;
        /// <summary>
        /// ��������
        /// </summary>
        public int Clicks
        {
            get { return clicks; }
            set { clicks = value; }
        }

        private string time;
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string content;
        /// <summary>
        /// ����
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string typeid;
        /// <summary>
        /// ���ID
        /// </summary>
        public string Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }

        private int istop;
        /// <summary>
        /// �Ƿ��ö�
        /// </summary>
        public int Istop
        {
            get { return istop; }
            set { istop = value; }
        }

        private int sortid;
        /// <summary>
        /// �����
        /// </summary>
        public int Sortid
        {
            get { return sortid; }
            set { sortid = value; }
        }

        private string picture1;
        /// <summary>
        /// ͼƬ1
        /// </summary>
        public string Picture1
        {
            get { return picture1; }
            set { picture1 = value; }
        }

        private string picture2;
        /// <summary>
        /// ͼƬ2
        /// </summary>
        public string Picture2
        {
            get { return picture2; }
            set { picture2 = value; }
        }

        public Notice() { }
        public Notice(string title, string content, string time,string typeid,string publisherid)
        {
            this.title = title;
            this.content = content;
            this.typeid = typeid;
            this.time = time;
            this.publisherid = publisherid;
        }

    }
}
