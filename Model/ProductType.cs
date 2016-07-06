/* 
 *  作者：牛腩
 *  创建时间：
 *  类说明：产品类别实体类
 */
namespace Model
{
    /// <summary>
    /// 产品类别实体类
    /// </summary>
    public class ProductType
    {
        private string id;
        /// <summary>
        /// 产品类别ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// 产品类别名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string intro;
        /// <summary>
        /// 产品类别简介
        /// </summary>
        public string Intro
        {
            get { return intro; }
            set { intro = value; }
        }

        public ProductType() { }
        public ProductType(string id, string name, string intro)
        {
            this.id = id;
            this.name = name;
            this.intro = intro;
        }

    }
}
