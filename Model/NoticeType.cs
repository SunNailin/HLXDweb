/* 
 *  作者：
 *  创建时间：
 *  类说明：公告类别实体类
 */ 
namespace Model
{
    /// <summary>
    /// 公告类别实体类
    /// </summary>
    public class NoticeType
    {
        private string id;
        /// <summary>
        /// 类别ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// 类别名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public NoticeType(string name,string intro)
        {
            this.name = name;
            this.intro = intro;
        }

    }
}
