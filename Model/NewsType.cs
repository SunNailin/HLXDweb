/* 
 *  ���ߣ�������
 *  ����ʱ�䣺2016/5/14
 *  ��˵�����������ʵ����
 */ 
namespace Model
{
    /// <summary>
    /// �������ʵ����
    /// </summary>
    public class NewsType
    {
        private string id;
        /// <summary>
        /// ����,����
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string newsTypeName;
        /// <summary>
        /// �������
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
