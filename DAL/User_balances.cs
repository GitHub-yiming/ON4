﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modles;

namespace DAL
{
    public class User__balances
    {
        //public List<Unit_prices> GetAllClass()
        //{
        //    string sql = " select Unit_price from Unit_prices ";
        //    SqlDataReader objReader = SQLHelper.GetReader(sql);
        //    List<Unit_prices> list = new List<Unit_prices>();
        //    while (objReader.Read())
        //    {
        //        list.Add(new Unit_prices()
        //        {
        //            Unit_price = Convert.ToInt32(objReader["Unit_price"])
        //        });
        //    }
        //    objReader.Close();
        //    return list;
        //}

        public int ModifyStudent(Unit_prices objStudent)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(" update Unit_pricess  set Calories={0},Cooling_capacity={1} where id=1  ");
            string sql = string.Format(sqlBuilder.ToString(), objStudent.Calories, objStudent.Cooling_capacity);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("修改学员信息是数据访问发生异常：" + ex.Message);
            }
        }
    }
}
