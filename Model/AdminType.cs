/* 
 *  ���ߣ�ţ��
 *  ����ʱ�䣺2016/7/7 ������ 21:52:48
 *  ��˵��������Ա���ʵ����
 */ 
namespace Model
{
    /// <summary>
    /// ����Ա���ʵ����
    /// </summary>
    public class AdminType
    {
        private string id;
        /// <summary>
        /// ����ԱID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// ����Ա�������
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string auth;
        /// <summary>
        /// Ȩ��
        /// </summary>
        public string Auth
        {
            get { return auth; }
            set { auth = value; }
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

        private string num;
        /// <summary>
        /// ��������Ա��Ŀ
        /// </summary>
        public string Num
        {
            get { return num; }
            set { num = value; }
        }

    }
}
