using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modles;

namespace DAL
{
    /// <summary>
    /// 用户数据访问类
    /// </summary>
    public class User_dataService
    {
        /// <summary>
        /// 根据楼层查询用户信息
        /// </summary>
        /// <param name="numberofLayer"></param>
        /// <returns></returns>
        public List<User_data> GetInfoByFloor(string numberofLayer)
        {
            string sql = "select Table_number,Names,Gender,Room_No,Building,Phone,Billabletime from User_data1";
            sql += " inner join NumberofLayers on User_data1.NumberofLayersId=NumberofLayers.NumberofLayersId";
            sql += " where NumberofLayer='{0}'";
            sql = string.Format(sql, numberofLayer);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<User_data> stuList = new List<User_data>();
            while (objReader.Read())
            {
                stuList.Add(new User_data()
                {
                    Table_number = objReader["Table_number"].ToString(),
                    Names = objReader["Names"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    Room_No = objReader["Room_No"].ToString(),
                    Building = objReader["Building"].ToString(),
                    Phone = objReader["Phone"].ToString(),
                    Billabletime = Convert.ToDateTime(objReader["Billabletime"])
                });
            }

            objReader.Close();
            return stuList;
        }

        /// <summary>
        /// 判断表号是否存在
        /// </summary>
        /// <param name="table_Number"></param>
        /// <returns></returns>
        public bool IsIdNoExisted(string table_Number)
        {
            string sql = string.Format("select count(*) from User_data1 where Table_number={0}", table_Number);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            else return false;
        }

        /// <summary>
        /// 验证手机号是否存在
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        public bool IsPhoneNoExisted(string phone)
        {
            string sql = string.Format("select count(*) from User_data1 where Phone={0}", phone);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            else return false;
        }

        /// <summary>
        /// 判断表号是否存在
        /// </summary>
        /// <param name="tablenumber"></param>
        /// <returns></returns>
        public bool IsTableNumber(string tablenumber)
        {
            string sql = string.Format("select count(*) from Table_Numbers1 where Table_Number1='{0}' ", tablenumber);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return false;
            else return true;
        }

        /// <summary>
        /// 判断用户是否重复
        /// </summary>
        /// <param name="tablenumber"></param>
        /// <returns></returns>
        public bool NotUserRepeat(string tablenumber,string names)
        {
            string sql = string.Format("select count(*) from User_data1 where Table_number='{0}' and Names='{1}' ", tablenumber,names);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            else return false ;
        }

        /// <summary>
        /// 将用户信息保存到数据库
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int AddUser(User_data objUser_data)
        {
            //【1】编写sql语句
            StringBuilder sqlBuilder = new StringBuilder("insert into User_data1 ");
            sqlBuilder.Append("(Table_number,Names,Gender,Room_No,Building,Phone,NumberofLayersId)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}',{6});select @@identity");
            //【2】解析对象
            string sql = string.Format(sqlBuilder.ToString(), objUser_data.Table_number, objUser_data.Names,
                objUser_data.Gender, objUser_data.Room_No, objUser_data.Building,
                objUser_data.Phone, objUser_data.NumberofLayersId);

            //【3】提交SQL语句
            try
            {
                return Convert.ToInt32(SQLHelper.Update(sql));//执行sql语句，返回学号
            }
            catch (Exception ex)
            {

                throw new Exception("添加学员时数据访问异常：" + ex.Message);
            }
        }



        /// <summary>
        /// 用户缴费
        /// </summary>
        /// <param name="objCost"></param>
        /// <returns></returns>
        public int UserCost(User_balances objCost)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(" update User_balance  set Balance=Balance+{0} where Table_number='{1}' ");
            string sql = string.Format(sqlBuilder.ToString(), objCost.Balance,objCost.Table_number);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("修改单价信息数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 修改用户余额
        /// </summary>
        /// <param name="objBalance"></param>
        /// <returns></returns>
        public int ModifyUserBalance(User_balances objBalance)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(" if(select  Cost from User_payment1)<{0} ");
            sqlBuilder.Append(" update User_balance  set Balance=Balance+({0}-(select  Cost from User_payment1 where Table_number='{1}')) where Table_number='{1}' ");
            sqlBuilder.Append(" else ");
            sqlBuilder.Append(" update User_balance  set Balance=Balance-((select  Cost from User_payment1 where Table_number='{1}')-{0}) where Table_number='{1}' ");
            string sql = string.Format(sqlBuilder.ToString(), objBalance.Balance, objBalance.Table_number);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("修改用户余额数据访问发生异常：" + ex.Message);
            }
        }


        StreamReader sr;
        /// <summary>
        /// 更新用户余额
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<User_balances> QueryScoreList1(string num)
        {

            sr = new StreamReader("Cost_Schedule.txt", Encoding.UTF8);
            string str1 = sr.ReadToEnd();
            sr.Dispose();
            StringBuilder sql = new StringBuilder();
            #region SQL语句--已弃用
            //string sql1 = string.Format(sql.ToString(), num);
            //SqlDataReader objReader = SQLHelper.GetReader(sql1.ToString());
            sql.Append(" if object_id(N'tempdb..#Table6',N'U') is not null drop table #Table6 ");
            sql.Append(" select  distinct Cooling_capacity,Calories into   #Table6  from CalorimeterTable1 where Table_number='{0}' ");
            sql.Append(" alter table #Table6 add id int identity(1,1) ");

            sql.Append(" if object_id(N'tempdb..#Table10',N'U') is not null drop table #Table10 ");
            sql.Append(" select top 2*   into   #Table10  from #Table6 order by id desc ");

            sql.Append(" if object_id(N'tempdb..#Table11',N'U') is not null drop table #Table11 ");
            sql.Append(" select distinct Cooling_capacity,Calories into #Table11 from #Table10 ");
            sql.Append(" alter table #Table11 add id int identity(1,1) ");

            sql.Append(" if object_id(N'tempdb..#Table7',N'U') is not null drop table #Table7 ");
            sql.Append(" select top 2*   into   #Table7  from #Table11 order by id desc ");

            sql.Append(" if object_id(N'tempdb..#Table8',N'U') is not null drop table #Table8 ");
            sql.Append(" create table #Table8(Cost2 money) alter table #Table8 add id int identity(0,1) ");

            sql.Append(" if (select COUNT(*) from #Table7)=1 and (select count(*) from CalorimeterTable1 where Table_number='{0}')=1 begin  ");
            sql.Append(" insert into #Table8(Cost2) values (((select CONVERT( numeric(8,2),Cooling_capacity)*(select Cooling_capacity from Unit_pricess where id=1) from #Table7)+ ");
            sql.Append(" (select CONVERT( numeric(8,2),Calories)*(select Calories from Unit_pricess where id=1) from #Table7))) ");
            sql.Append(" update User_balance  set Balance= Balance-(ISNULL( (select Cost2 from #Table8 where id=0),0)) where Table_number='{0}'  select *from User_balance end");
            sql.Append(" else if (select COUNT(*) from #Table7)=2 begin ");
            sql.Append(" insert into #Table8(Cost2) (((select((((CONVERT(numeric(8, 2),b.Cooling_capacity)  -  ");
            sql.Append(" CONVERT(numeric(8, 2),a.Cooling_capacity))*(select Calories from Unit_pricess where id=1))) ");
            sql.Append(" +(((CONVERT(numeric(8, 2),b.Calories)  - CONVERT(numeric(8, 2),a.Calories))*(select Cooling_capacity from Unit_pricess where id=1)))) ");
            sql.Append(" from #Table7 a left join #Table7 b on a.id + 1 = b.id))) delete from #Table8 where Cost2 IS NULL;  ");
            sql.Append(" update User_balance  set Balance=Balance-(select Cost2 from #Table8 where id=1) where Table_number='{0}' ");
            sql.Append(" select *from User_balance end ");
            #endregion


            string sql1 = string.Format(str1.ToString(), num);
            SqlDataReader objReader = SQLHelper.GetReader(sql1.ToString());
            List<User_balances> stuList = new List<User_balances>();
            try
            {
            while (objReader.Read())
            {
                stuList.Add(new User_balances()
                {
                    Table_number = objReader["Table_number"].ToString(),
                    Names=objReader["Names"].ToString(),
                    Balance = Convert.ToDecimal(objReader["Balance"]),
                    NumberofLayersId = objReader["NumberofLayersId"].ToString(),
                    Room_No=objReader["Room_No"].ToString()
                });
            }
            objReader.Close();
            return stuList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 统一修改额度
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int UnifyModifyQuota(int Quota)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("  update User_balance set Quota={0} ");
            string sql = string.Format(sqlBuilder.ToString(), Quota);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("统一修改额度数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 余额超额查询
        /// </summary>
        /// <param name="tablenumber"></param>
        /// <returns></returns>
        public string Quota_calculation(string tablenumber)
        {
            string sql1 = " if object_id(N'tempdb..#Table9',N'U') is not null drop table #Table9 ";
            sql1 += " create table #Table9( strings nvarchar(30) )  ";
            sql1 += " if (select Balance+Quota from User_balance where Table_number='{0}')<=0 ";
            sql1 += " insert into #Table9(strings)values('信用超额'); else insert into #Table9(strings)values('信用正常');  select *from #Table9 ";
            string sql2 = string.Format(sql1, tablenumber);
            try
            {
                return Convert.ToString(SQLHelper.GetSingleResult(sql2));
            }
            catch (Exception ex)
            {
                throw new Exception("余额超额数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 阀门地址查询
        /// </summary>
        /// <param name="tablenumber"></param>
        /// <returns></returns>
        public string ValveClosed(string tablenumber)
        {
            string sql1 = " SELECT CONTROLADDRESS FROM Table_Numbers1 WHERE TABLE_NUMBER1='{0}' ";
            string sql2 = string.Format(sql1, tablenumber);
            try
            {
               return Convert.ToString(SQLHelper.GetSingleResult(sql2));
            }
            catch (Exception ex)
            {

                throw new Exception("阀门地址查询数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 阀门端口查询
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public string SelectPort(string port)
        {
            string sql1 = " select Port_diection from Table_Numbers1 where Table_Number1='{0}' ";
            string sql2 = string.Format(sql1, port);
            try
            {
                return Convert.ToString(SQLHelper.GetSingleResult(sql2));
            }
            catch (Exception ex)
            {
                throw new Exception("阀门地址查询数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 根据表号查询楼层
        /// </summary>
        /// <param name="tablenumber"></param>
        /// <returns></returns>
        public string QueryFloor (string tablenumber)
        {
            string sql1 = " select NumberofLayersId from Table_Numbers1 where Table_Number1='{0}' ";
            string sql2 = string.Format(sql1, tablenumber);
            try
            {
                return Convert.ToString(SQLHelper.GetSingleResult(sql2));
            }
            catch (Exception ex)
            {

                throw new Exception("根据表号查询楼层数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 查找对应表号的冷量最大值
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double QueryMax(string num)
        {
            string sql1 = " if object_id(N'tempdb..#Table6',N'U') is not null drop table #Table10 ";
            sql1 += " select  Cooling_capacity,CreateTime into   #Table10  from CalorimeterTable1  where Table_number='{0}' ";
            sql1 += " select Cooling_capacity from #Table10 where CreateTime= (select max(CreateTime) from #Table10) ";

            string sql2 = string.Format(sql1, num);
            try
            {
                return Convert.ToDouble(SQLHelper.GetSingleResult(sql2));
            }
            catch (Exception ex)
            {

                throw new Exception("检测热量表返回数据与数据库中的数据对比时发生异常！" + ex.Message);
            }
        }


    }
}
