/* 
 *  作者：孙乃麟
 *  创建时间：2016/5/14
 *  类说明：新闻类别实体类
 */ 
namespace Model
{
    /// <summary>
    /// 新闻类别实体类
    /// </summary>
    public class NewsType
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

        private string newsTypeName;
        /// <summary>
        /// 类别名称
        /// </summary>
        public string NewsTypeName
        {
            get { return newsTypeName; }
            set { newsTypeName = value; }
        }

        public NewsType(string newsTypeName)
        {
            this.newsTypeName = newsTypeName;
        }

    }
}
