
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;
using DAL;

namespace BLL
{
   public  class ProductTypeManager
    {
       private ProductTypeDAO pdtdao = null;
       public ProductTypeManager()
        {
            pdtdao = new ProductTypeDAO();
        }
       #region 增加产品类别
       /// <summary>
       ///增加产品类别
       /// </summary>
       /// <param name="tpName">产品类别名称</param>
       /// <returns></returns>
       public bool Insert(string tpName)
       {
           return pdtdao.Insert(tpName);
       }
       #endregion

       #region 修改类别
       /// <summary>
       /// 修改类别
       /// </summary>
       /// <param name="id">类别ID</param>
       /// <param name="tpName">类别名称</param>
       /// <returns></returns>
       public bool Update(ProductType tp)
       {
           return pdtdao.Update(tp);
       }
       #endregion

       #region 判断类别名称是否已经存在
       /// <summary>
       /// 判断类别名称是否已经存在
       /// </summary>
       /// <param name="tpName">产品类别名称</param>
       /// <returns></returns>
       public bool IsExists(string tpName)
       {
           return pdtdao.IsExists(tpName);
       }
       #endregion

       #region 取出所有产品类别
       /// <summary>
       /// 取出所有产品类别
       /// </summary>
       /// <returns>返回查询到的数据</returns>
       public DataTable SelectAll()
       {
           return pdtdao.SelectAll();
       }
       #endregion

       #region 删除产品类别（连同其下的公告一同删除）
       /// <summary>
       /// 删除产品类别（连同其下的公告一同删除）
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public bool Delete(string id)
       {
           return pdtdao.Delete(id);
       }
       #endregion
    }
}
