/* 
 *  作者：牛腩
 *  创建时间：
 *  类说明：新闻实体类
 */
namespace Model
{
    /// <summary>
    /// 新闻实体类
    /// </summary>
    public class News
    {
        private string id;
        /// <summary>
        /// 主键,自增
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string publisher;
        /// <summary>
        /// 新闻发布者
        /// </summary>
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private int clicks;
        /// <summary>
        /// 新闻点击量
        /// </summary>
        public int Clicks
        {
            get { return clicks; }
            set { clicks = value; }
        }

        private string time;
        /// <summary>
        /// 新闻发布时间
        /// </summary>
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string content;
        /// <summary>
        /// 新闻内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string typeid;
        /// <summary>
        /// 新闻所属类别
        /// </summary>
        public string Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }

        private int istop;
        /// <summary>
        /// 是否置顶
        /// </summary>
        public int Istop
        {
            get { return istop; }
            set { istop = value; }
        }

        private int sortid;
        /// <summary>
        /// 排序序号
        /// </summary>
        public int Sortid
        {
            get { return sortid; }
            set { sortid = value; }
        }

        private string pic1;
        /// <summary>
        /// 新闻图片1
        /// </summary>
        public string Pic1
        {
            get { return pic1; }
            set { pic1 = value; }
        }

        private string pic2;
        /// <summary>
        /// 新闻图片2
        /// </summary>
        public string Pic2
        {
            get { return pic2; }
            set { pic2 = value; }
        }

        private string pic3;
        /// <summary>
        /// 新闻图片3
        /// </summary>
        public string Pic3
        {
            get { return pic3; }
            set { pic3 = value; }
        }

        private string pic4;
        /// <summary>
        /// 新闻图片4
        /// </summary>
        public string Pic4
        {
            get { return pic4; }
            set { pic4 = value; }
        }

        private string pic5;
        /// <summary>
        /// 新闻图片5
        /// </summary>
        public string Pic5
        {
            get { return pic5; }
            set { pic5 = value; }
        }

        private int ischecked;
        /// <summary>
        /// 是否审核
        /// </summary>
        public int Checked
        {
            get { return ischecked; }
            set { ischecked = value; }
        }

        private string lastedittime;
        /// <summary>
        /// 最后编辑时间
        /// </summary>
        public string Lastedittime
        {
            get { return lastedittime; }
            set { lastedittime = value; }
        }

        private string checkuserid;
        /// <summary>
        /// 审核人ID
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
