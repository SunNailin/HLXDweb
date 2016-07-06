/*
 *创建人：孙乃麟
 *创建时间：
 *说明：
 *版权所有：
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
    public class ProductDAO
    {
        private SQLHelper sqlhelper;
        public ProductDAO()
        {
            sqlhelper = new SQLHelper();
        }


        #region 插入产品
        /// <summary>
        /// 增加产品
        /// </summary>
        /// <param name="pdt">产品对象</param>
        /// <returns></returns>
        public bool InsertProduct(Product pdt)
        {
            bool flag = false;
            string cmdText = "procProductInsert";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@name",pdt.Name),
            new SqlParameter("@content",pdt.Content),
            new SqlParameter("@picture1",pdt.Picture1),
            new SqlParameter("@typeid",pdt.Typeid),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 修改产品
        /// <summary>
        /// 修改产品
        /// </summary>
        /// <param name="nt">产品实体对象</param>
        /// <returns></returns>
        public bool UpdateProduct(Product pdt)
        {
            bool flag = false;
            string cmdText = "procProductUpdate";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",pdt.Id),
                new SqlParameter("@name",pdt.Name),
            new SqlParameter("@content",pdt.Content),
            new SqlParameter("@picture1",pdt.Picture1),
            new SqlParameter("@typeid",pdt.Typeid),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 删除产品
        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="id">产品ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "procProductDelete";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@id",id),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 选择全部产品
        /// <summary>
        /// 选择全部产品
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllProduct()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("procProductSelectAllProduct", CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 根据产品类别ID选择产品
        /// <summary>
        /// 根据产品类别ID选择产品
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>

        public DataTable SelectProductByTypeID(string typeID)
        {
            DataTable dt = new DataTable();
            string cmdText = "procProductSelectByTypeID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@product_type_id",typeID),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 根据产品ID选择产品
        /// <summary>
        /// 根据产品ID选择产品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product SelectByID(string id)
        {
            DataTable dt = new DataTable();
            Product pdt = new Product();
            string cmdText = "procProductSelectProductByID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@product_id",id),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            pdt.Id = id;
            pdt.Name= dt.Rows[0]["product_name"].ToString();
            pdt.Content = dt.Rows[0]["product_content"].ToString();
            //n.Publisher = dt.Rows[0]["news_publisher"].ToString();            
            pdt.Typeid = dt.Rows[0]["product_typeid"].ToString();
            pdt.Picture1 = dt.Rows[0]["product_picture1"].ToString();
            return pdt;
        }
        #endregion

    }
}
