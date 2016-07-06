/* 
 *  ���ߣ�ţ��
 *  ����ʱ�䣺
 *  ��˵������Ʒ���ʵ����
 */
namespace Model
{
    /// <summary>
    /// ��Ʒ���ʵ����
    /// </summary>
    public class ProductType
    {
        private string id;
        /// <summary>
        /// ��Ʒ���ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// ��Ʒ�������
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string intro;
        /// <summary>
        /// ��Ʒ�����
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
