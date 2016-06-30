/* 
 *  ���ߣ�������
 *  ����ʱ�䣺
 *  ��˵������˾���ʵ����
 */ 
namespace Model
{
    /// <summary>
    /// ��˾���ʵ����
    /// </summary>
    public class Intro
    {
        private int id;
        /// <summary>
        /// ���ID
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        /// <summary>
        /// ������
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string content;
        /// <summary>
        /// �������
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string picture1;
        /// <summary>
        /// ���ͼƬ1
        /// </summary>
        public string Picture1
        {
            get { return picture1; }
            set { picture1 = value; }
        }

        private string picture2;
        /// <summary>
        /// ���ͼƬ2
        /// </summary>
        public string Picture2
        {
            get { return picture2; }
            set { picture2 = value; }
        }

        private string picture3;
        /// <summary>
        /// ���ͼƬ3
        /// </summary>
        public string Picture3
        {
            get { return picture3; }
            set { picture3 = value; }
        }

        private string time;
        /// <summary>
        /// ��鷢��ʱ��
        /// </summary>
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private int sortid;
        /// <summary>
        /// ��������
        /// </summary>
        public int Sortid
        {
            get { return sortid; }
            set { sortid = value; }
        }

        public Intro() {  }
        public Intro(string title,string content,string picture1,string picture2,int sortid) 
        {
            this.title = title;
            this.content = content;
            this.picture1 = picture1;
            this.picture2 = picture2;
            this.sortid = sortid;
        }

    }
}
