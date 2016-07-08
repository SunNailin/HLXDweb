/* 
 *  作者：牛腩
 *  创建时间：2016/7/7 星期四 21:52:48
 *  类说明：管理员类别实体类
 */ 
namespace Model
{
    /// <summary>
    /// 管理员类别实体类
    /// </summary>
    public class AdminType
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

        private string name;
        /// <summary>
        /// 管理员类别名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string auth;
        /// <summary>
        /// 权限
        /// </summary>
        public string Auth
        {
            get { return auth; }
            set { auth = value; }
        }

        private string intro;
        /// <summary>
        /// 类别介绍
        /// </summary>
        public string Intro
        {
            get { return intro; }
            set { intro = value; }
        }

        private string num;
        /// <summary>
        /// 该类别管理员数目
        /// </summary>
        public string Num
        {
            get { return num; }
            set { num = value; }
        }

    }
}
