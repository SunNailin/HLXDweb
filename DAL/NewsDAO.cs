/*
 * 创建人：孙乃麟
 * 创建时间：2016年5月
 * 说明：新闻内容操作类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    class NewsDAO
    {
        private SQLHelper sqlhelper;
        public NewsDAO()
        {
            sqlhelper = new SQLHelper();
        }

        // 取出最新的10条新闻（所属分类，新闻标题，发布时间，发布者）

        //取出最热的10条新闻（先不做）

        //根据类别ID取出该类别下的新闻

        //根据新闻ID取出该条新闻的主题内容

        //根据标题搜索新闻（先不做）

        //根据内容搜索新闻（先不做）

        //增加新闻

        //修改新闻

        //删除新闻

    }
}
