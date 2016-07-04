/* 
 *  ���ߣ�ţ��
 *  ����ʱ�䣺
 *  ��˵��������ʵ����
 */
namespace Model
{
    /// <summary>
    /// ����ʵ����
    /// </summary>
    public class News
    {
        private string id;
        /// <summary>
        /// ����,����
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        /// <summary>
        /// ���ű���
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string publisher;
        /// <summary>
        /// ���ŷ�����
        /// </summary>
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private int clicks;
        /// <summary>
        /// ���ŵ����
        /// </summary>
        public int Clicks
        {
            get { return clicks; }
            set { clicks = value; }
        }

        private string time;
        /// <summary>
        /// ���ŷ���ʱ��
        /// </summary>
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string content;
        /// <summary>
        /// ��������
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string typeid;
        /// <summary>
        /// �����������
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
        /// �������
        /// </summary>
        public int Sortid
        {
            get { return sortid; }
            set { sortid = value; }
        }

        private string pic1;
        /// <summary>
        /// ����ͼƬ1
        /// </summary>
        public string Pic1
        {
            get { return pic1; }
            set { pic1 = value; }
        }

        private string pic2;
        /// <summary>
        /// ����ͼƬ2
        /// </summary>
        public string Pic2
        {
            get { return pic2; }
            set { pic2 = value; }
        }

        private string pic3;
        /// <summary>
        /// ����ͼƬ3
        /// </summary>
        public string Pic3
        {
            get { return pic3; }
            set { pic3 = value; }
        }

        private string pic4;
        /// <summary>
        /// ����ͼƬ4
        /// </summary>
        public string Pic4
        {
            get { return pic4; }
            set { pic4 = value; }
        }

        private string pic5;
        /// <summary>
        /// ����ͼƬ5
        /// </summary>
        public string Pic5
        {
            get { return pic5; }
            set { pic5 = value; }
        }

        private int ischecked;
        /// <summary>
        /// �Ƿ����
        /// </summary>
        public int Checked
        {
            get { return ischecked; }
            set { ischecked = value; }
        }

        private string lastedittime;
        /// <summary>
        /// ���༭ʱ��
        /// </summary>
        public string Lastedittime
        {
            get { return lastedittime; }
            set { lastedittime = value; }
        }

        private string checkuserid;
        /// <summary>
        /// �����ID
        /// </summary>
        public string Checkuserid
        {
            get { return checkuserid; }
            set { checkuserid = value; }
        }

        public News() { }
        public News(string title, string content, string typeid, string publisher,string time)
        {
            this.title = title;
            this.content = content;
            this.typeid = typeid;
            this.publisher = publisher;
            this.time = time;
        }

    }
}
