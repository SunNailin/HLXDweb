/* 
 *  ���ߣ�������
 *  ����ʱ�䣺2016/5/14
 *  ��˵������������ʵ����
 */
namespace Model
{
    /// <summary>
    /// ��������ʵ����
    /// </summary>
    public class FriendLink
    {
        private string flID;
        public string FLID
        {
            get { return flID; }
            set { flID = value; }
        }

        private string flTitle;
        public string FLTitle
        {
            get { return flTitle; }
            set { flTitle = value; }
        }

        private string flURL;
        public string FLURL
        {
            get { return flURL; }
            set { flURL = value; }
        }

        private int flSortID;
        public int FLSortID
        {
            get { return flSortID; }
            set { flSortID = value; }
        }

        private string flPic;
        public string FLPic
        {
            get { return flPic; }
            set { flPic = value; }
        }

        private int flClicks;
        public int FLClicks
        {
            get { return flClicks; }
            set { flClicks = value; }
        }

    }
}
