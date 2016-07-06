/*
 *创建人：孙乃麟
 *创建时间：
 *说明：
 *版权所有：
*/
using System;
using System.Collections.Generic;
using BLL;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class ProductManager
    {
        private ProductDAO pdtdao = null;
        public ProductManager()
        {
            pdtdao = new ProductDAO();
        }

        #region 插入产品
        /// <summary>
        /// 增加产品
        /// </summary>
        /// <param name="pdt">产品对象</param>
        /// <returns></returns>
        public bool InsertProduct(Product pdt)
        {
            return pdtdao.InsertProduct(pdt);
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
            return pdtdao.UpdateProduct(pdt);
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
            return pdtdao.Delete(id);
        }
        #endregion

        #region 选择全部产品
        /// <summary>
        /// 选择全部产品
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllProduct()
        {
            return pdtdao.SelectAllProduct();
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
            return pdtdao.SelectProductByTypeID(typeID);
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
            return pdtdao.SelectByID(id);
        }
        #endregion
    }
}
