/* 
 *  ���ߣ�ţ��
 *  ����ʱ�䣺2016/7/7 ������ 21:56:14
 *  ��˵��������Աʵ����
 */ 
namespace Model
{
    /// <summary>
    /// ����Աʵ����
    /// </summary>
    public class Admin
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

        private string typeid;
        /// <summary>
        /// ����Ա���ID
        /// </summary>
        public string Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }

        private string loginname;
        /// <summary>
        /// ��¼��
        /// </summary>
        public string Loginname
        {
            get { return loginname; }
            set { loginname = value; }
        }

        private string realname;
        /// <summary>
        /// ����
        /// </summary>
        public string Realname
        {
            get { return realname; }
            set { realname = value; }
        }

        private string password;
        /// <summary>
        /// ����
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string lastip;
        /// <summary>
        /// ����¼IP
        /// </summary>
        public string Lastip
        {
            get { return lastip; }
            set { lastip = value; }
        }

        private string lasttime;
        /// <summary>
        /// ����¼ʱ��
        /// </summary>
        public string Lasttime
        {
            get { return lasttime; }
            set { lasttime = value; }
        }

        private string email;
        /// <summary>
        /// ����
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string addtime;
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public string Addtime
        {
            get { return addtime; }
            set { addtime = value; }
        }

        private string status;
        /// <summary>
        /// ״̬,Ĭ��Ϊ1,����
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string bywhom;
        /// <summary>
        /// ˭��ӵ�
        /// </summary>
        public string Bywhom
        {
            get { return bywhom; }
            set { bywhom = value; }
        }

    }
}
