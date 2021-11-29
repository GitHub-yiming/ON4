using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modles;

namespace DAL
{

    /// <summary>
    /// 楼层数据访问类
    /// </summary>
    public class NumberofLayerService
    {
        /// <summary>
        /// 查询楼层信息
        /// </summary>
        /// <returns></returns>
        public List<NumberofLayers> GetAllClass()
        {
            string sql = "select NumberofLayer,NumberofLayersId from NumberofLayers";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<NumberofLayers> list = new List<NumberofLayers>();
            while (objReader.Read())
            {
                list.Add(new NumberofLayers()
                {
                    NumberofLayersId = Convert.ToInt32(objReader["NumberofLayersId"]),
                    NumberofLayer = objReader["NumberofLayer"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        //获取楼层数量
        public int GetAllnum()
        {
            string sql = "select count(*) from NumberofLayers";
             int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            return result;
        }

    }
}
