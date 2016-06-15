/* 
 *  作者：孙乃麟
 *  创建时间：2016/5/14
 *  类说明：友情链接实体类
 */
namespace Model
{
    /// <summary>
    /// 友情链接实体类
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
