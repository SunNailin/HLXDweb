/* 
 *  ���ߣ�
 *  ����ʱ�䣺
 *  ��˵�����������ʵ����
 */ 
namespace Model
{
    /// <summary>
    /// �������ʵ����
    /// </summary>
    public class NoticeType
    {
        private string id;
        /// <summary>
        /// ���ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// �������
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string intro;
        /// <summary>
        /// ������
        /// </summary>
        public string Intro
        {
            get { return intro; }
            set { intro = value; }
        }

        public NoticeType(string name,string intro)
        {
            this.name = name;
            this.intro = intro;
        }

    }
}
