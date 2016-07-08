/* 
 *  作者：牛腩
 *  创建时间：2016/7/7 星期四 21:56:14
 *  类说明：管理员实体类
 */ 
namespace Model
{
    /// <summary>
    /// 管理员实体类
    /// </summary>
    public class Admin
    {
        private string id;
        /// <summary>
        /// 管理员ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string typeid;
        /// <summary>
        /// 管理员类别ID
        /// </summary>
        public string Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }

        private string loginname;
        /// <summary>
        /// 登录名
        /// </summary>
        public string Loginname
        {
            get { return loginname; }
            set { loginname = value; }
        }

        private string realname;
        /// <summary>
        /// 真名
        /// </summary>
        public string Realname
        {
            get { return realname; }
            set { realname = value; }
        }

        private string password;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string lastip;
        /// <summary>
        /// 最后登录IP
        /// </summary>
        public string Lastip
        {
            get { return lastip; }
            set { lastip = value; }
        }

        private string lasttime;
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public string Lasttime
        {
            get { return lasttime; }
            set { lasttime = value; }
        }

        private string email;
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string addtime;
        /// <summary>
        /// 添加时间
        /// </summary>
        public string Addtime
        {
            get { return addtime; }
            set { addtime = value; }
        }

        private string status;
        /// <summary>
        /// 状态,默认为1,启用
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string bywhom;
        /// <summary>
        /// 谁添加的
        /// </summary>
        public string Bywhom
        {
            get { return bywhom; }
            set { bywhom = value; }
        }

    }
}
