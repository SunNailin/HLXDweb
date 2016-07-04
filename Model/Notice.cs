/* 
 *  作者：牛腩
 *  创建时间：
 *  类说明：活动公告实体类
 */ 
namespace Model
{
    /// <summary>
    /// 活动公告实体类
    /// </summary>
    public class Notice
    {
        private string id;
        /// <summary>
        /// 活动公告ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        /// <summary>
        /// 公告标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string publisherid;
        /// <summary>
        /// 公告发布者
        /// </summary>
        public string Publisherid
        {
            get { return publisherid; }
            set { publisherid = value; }
        }

        private int clicks;
        /// <summary>
        /// 公告点击量
        /// </summary>
        public int Clicks
        {
            get { return clicks; }
            set { clicks = value; }
        }

        private string time;
        /// <summary>
        /// 发布时间
        /// </summary>
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string content;
        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string typeid;
        /// <summary>
        /// 类别ID
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
        /// 排序号
        /// </summary>
        public int Sortid
        {
            get { return sortid; }
            set { sortid = value; }
        }

        private string picture1;
        /// <summary>
        /// 图片1
        /// </summary>
        public string Picture1
        {
            get { return picture1; }
            set { picture1 = value; }
        }

        private string picture2;
        /// <summary>
        /// 图片2
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
