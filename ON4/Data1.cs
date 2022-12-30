using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON4
{
    class Data1
    {

        #region 监控
        #region 普通读取报文拼接
        public byte[] Common_meter_reading(string vs1)
        {
            List<byte> vs = new List<byte>();
            for (int i = 0; i < 6; i++)
            {
                vs.Add(0xFE);
            }
            vs.Add(0x68);
            vs.Add(0x20);
            //表号
            for (int i = 0; i < vs1.Length / 2; i++)
            {
                vs.Add(Get_table_number_1(vs1)[i]);
            }
            vs.Add(0X00);
            vs.Add(0X11);
            vs.Add(0X11);
            vs.Add(0X01);
            vs.Add(0X03);
            vs.Add(0X1F);
            vs.Add(0X90);
            vs.Add(0X12);
            //累加和校验
            vs.Add(XSummation_check_1(vs.ToArray()));
            vs.Add(0x16);
            return vs.ToArray();
        }
        #endregion

        #region 普通报文解析
        /// <summary>
        /// 普通报文解析-1(未使用)
        /// </summary>
        /// <param name="vs"></param>
        /// <returns></returns>
        public string[] Ordinary_message_analysis_1(byte[] vs)
        {
            string[] vs1 = new string[11];
            string vs2 = "", vs3 = "", vs4 = "", vs5 = "", vs6 = "", vs7 = "", vs8 = "", vs9 = "", vs10 = "", vs11 = "", vs12 = "";
            #region 获取表号
            for (int i = 5; i > 1; i--)
            {
                vs2 += vs[i].ToString("X2");
            }
            vs1[0] = vs2;
            #endregion
            #region 获取当前冷量
            for (int i = 17; i > 13; i--)
            {
                vs3 += vs[i].ToString("X2");
            }
            vs1[1] = vs3;
            #endregion
            #region 获取当前热量
            for (int i = 22; i > 18; i--)
            {
                vs4 += vs[i].ToString("X2");
            }
            vs1[2] = vs4;
            #endregion
            #region 获取热功率
            for (int i = 27; i > 23; i--)
            {
                vs5 += vs[i].ToString("X2");
            }
            vs1[3] = vs5;
            #endregion
            #region 获取瞬时流量
            for (int i = 32; i > 28; i--)
            {
                vs6 += vs[i].ToString("X2");
            }
            vs1[4] = vs6;
            #endregion
            #region 获取累计流量
            for (int i = 37; i > 33; i--)
            {
                vs7 += vs[i].ToString("X2");
            }
            vs1[5] = vs7;
            #endregion
            #region 获取供水温度
            for (int i = 41; i > 38; i--)
            {
                vs8 += vs[i].ToString("X2");
            }
            vs1[6] = vs8;
            #endregion
            #region 获取回水温度
            for (int i = 44; i > 41; i--)
            {
                vs9 += vs[i].ToString("X2");
            }
            vs1[7] = vs9;
            #endregion
            #region 获取累计工作时间
            for (int i = 47; i > 44; i--)
            {
                vs10 += vs[i].ToString("X2");
            }
            vs1[8] = vs10;
            #endregion
            #region 获取仪表当前时间
            for (int i = 54; i > 47; i--)
            {
                vs11 += vs[i].ToString("X2");
            }
            vs1[9] = vs11;
            #endregion
            #region 获取仪表状态
            for (int i = 56; i > 54; i--)
            {
                vs12 += vs[i].ToString("X2");
            }
            vs1[10] = vs12;
            #endregion

            return vs1;
        }

        /// <summary>
        /// 普通报文解析-2(使用中)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string[] Ordinary_message_analysis_2(byte[] data)
        {
            try
            {
                string[] vs1 = new string[11];
                //string vs2 = "";
                //for (int i = 5; i > 1; i--)
                //{
                //    vs2 += data[i].ToString("X2");
                //}

                vs1[0] = data[5].ToString("X2") + data[4].ToString("X2") + data[3].ToString("X2") + data[2].ToString("X2");
                vs1[1] = data[17].ToString("X2") + data[16].ToString("X2") + data[15].ToString("X2") + "." + data[14].ToString("X2");
                vs1[2] = data[22].ToString("X2") + data[21].ToString("X2") + data[20].ToString("X2") + "." + data[19].ToString("X2");
                vs1[3] = data[27].ToString("X2") + data[26].ToString("X2") + data[25].ToString("X2") + "." + data[24].ToString("X2");
                vs1[4] = data[32].ToString("X2") + data[31].ToString("X2") + "." + data[30].ToString("X2") + data[29].ToString("X2");
                vs1[5] = data[37].ToString("X2") + data[36].ToString("X2") + data[35].ToString("X2") + "." + data[34].ToString("X2");
                vs1[6] = data[41].ToString("X2") + data[40].ToString("X2") + "." + data[39].ToString("X2");
                vs1[7] = data[44].ToString("X2") + data[43].ToString("X2") + "." + data[42].ToString("X2");
                vs1[8] = data[47].ToString("X2") + data[46].ToString("X2") + data[45].ToString("X2");
                vs1[9] = data[54].ToString("X2") + data[53].ToString("X2") + "/" + data[52].ToString("X2") + "/" + data[51].ToString("X2") + "/" + data[50].ToString("X2") + "/" + data[55].ToString("X2") + "/" + data[54].ToString("X2");
                vs1[10] = data[55].ToString("X2") + data[56].ToString("X2");
                return vs1;
            }
            catch (Exception)
            {

                return null;
            }

        }


        /// <summary>
        /// 普通报文解析-3(使用中)
        /// 热量合并到冷量显示，热量为0
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string[] Ordinary_message_analysis_3(byte[] data)
        {
            string[] vs1 = new string[11];

            vs1[0] = data[5].ToString("X2") + data[4].ToString("X2") + data[3].ToString("X2") + data[2].ToString("X2");

            //冷量
            //vs1[1] = data[17].ToString("X2") + data[16].ToString("X2") + data[15].ToString("X2") + "." + data[14].ToString("X2");

            string cool = data[17].ToString("X2") + data[16].ToString("X2") + data[15].ToString("X2") + "." + data[14].ToString("X2");
            double cooldouble = Convert.ToDouble(cool);

            //热量
            //vs1[2] = data[22].ToString("X2") + data[21].ToString("X2") + data[20].ToString("X2") + "." + data[19].ToString("X2"); 
            string hot = data[22].ToString("X2") + data[21].ToString("X2") + data[20].ToString("X2") + "." + data[19].ToString("X2");
            double hotduble = Convert.ToDouble(hot);

            double hotaddcol = cooldouble + hotduble;

            vs1[1] = String.Format("{0:F}", hotaddcol);//冷量
            vs1[2] = "000000.00";//热量
            vs1[3] = data[27].ToString("X2") + data[26].ToString("X2") + data[25].ToString("X2") + "." + data[24].ToString("X2");
            vs1[4] = data[32].ToString("X2") + data[31].ToString("X2") + "." + data[30].ToString("X2") + data[29].ToString("X2");
            vs1[5] = data[37].ToString("X2") + data[36].ToString("X2") + data[35].ToString("X2") + "." + data[34].ToString("X2");
            vs1[6] = data[41].ToString("X2") + data[40].ToString("X2") + "." + data[39].ToString("X2");
            vs1[7] = data[44].ToString("X2") + data[43].ToString("X2") + "." + data[42].ToString("X2");
            vs1[8] = data[47].ToString("X2") + data[46].ToString("X2") + data[45].ToString("X2");
            vs1[9] = data[54].ToString("X2") + data[53].ToString("X2") + "/" + data[52].ToString("X2") + "/" + data[51].ToString("X2") + "/" + data[50].ToString("X2") + "/" + data[55].ToString("X2") + "/" + data[54].ToString("X2");
            vs1[10] = data[55].ToString("X2") + data[56].ToString("X2");
            return vs1;
        }


        #endregion

        #region 解析表号
        /// <summary>
        /// 解析表号
        /// 20 20 42 94=>94 42 20 20
        /// </summary>
        /// <param name="vs33"></param>
        /// <returns></returns>
        public byte[] Get_table_number_1(string vs33)
        {
            byte[] vs1 = new byte[vs33.Length / 2];
            byte[] vs2 = new byte[vs33.Length / 2];
            for (int i = 0; i < vs33.Length / 2; i++)
            {
                //字符串转字节数组
                vs1[i] = Convert.ToByte(vs33.Substring(i * 2, 2), 16);
            }
            if (vs1.Length == 4)
            {
                vs2[0] = vs1[3]; vs2[1] = vs1[2]; vs2[2] = vs1[1]; vs2[3] = vs1[0];
            }
            else
            {
                vs2[0] = vs1[5]; vs2[1] = vs1[4]; vs2[2] = vs1[3]; vs2[3] = vs1[2]; vs2[4] = vs1[1]; vs2[5] = vs1[0];
            }

            return vs2;
        }
        #endregion

        #region 写表号及时间

        /// <summary>
        /// 写表号及时间
        /// </summary>
        /// <param name="vs1">当前表号</param>
        /// <param name="vs2">写入表号</param>
        /// <param name="vs3">写入时间</param>
        /// <returns></returns>
        public byte[] Write_table_number_and_time(string vs1, string vs2, string vs3)
        {
            List<byte> vs = new List<byte>();

            for (int i = 0; i < 6; i++)
            {
                vs.Add(0xFE);
            }
            vs.Add(0x68);
            vs.Add(0x20);
            for (int i = 0; i < vs1.Length / 2; i++)
            {
                vs.Add(Get_table_number_1(vs1)[i]);
            }
            vs.Add(0x00);
            vs.Add(0x11);
            vs.Add(0x11);
            vs.Add(0x39);
            vs.Add(0x11);
            vs.Add(0x18);
            vs.Add(0xA0);
            vs.Add(0xAA);
            for (int i = 0; i < vs2.Length / 2; i++)
            {
                //字符串转字节数组
                //vs.Add(Convert.ToByte(vs2.Substring(i * 2, 2), 16));
                vs.Add(Get_table_number_1(vs2)[i]);
            }
            vs.Add(0x00);
            vs.Add(0x11);
            vs.Add(0x11);
            string[] tt1 = new string[5];
            string tt = "";
            tt1[0] = vs3.Substring(0, 4);
            tt1[1] = vs3.Substring(5, 2);
            tt1[2] = vs3.Substring(8, 2);
            tt1[3] = vs3.Substring(11, 2);
            tt1[4] = vs3.Substring(14, 2);
            for (int i = 0; i < tt1.Length; i++)
            {
                tt += tt1[i];
            }

            for (int i = 0; i < tt.Length / 2; i++)
            {
                vs.Add(Get_table_number_1(tt)[i]);
            }
            vs.Add(XSummation_check_1(vs.ToArray()));
            vs.Add(0x16);
            return vs.ToArray();

        }

        #endregion

        #region  累积量清零

        public byte[] Cumulative_reset(string vs1)
        {
            List<byte> vs = new List<byte>();
            for (int i = 0; i < 6; i++)
            {
                vs.Add(0xFE);
            }
            vs.Add(0x68);
            vs.Add(0x20);
            for (int i = 0; i < vs1.Length / 2; i++)
            {
                vs.Add(Get_table_number_1(vs1)[i]);
            }
            vs.Add(0X04);
            vs.Add(0X03);
            vs.Add(0X04);
            vs.Add(0X90);
            vs.Add(0X00);
            vs.Add(XSummation_check_1(vs.ToArray()));
            vs.Add(0x16);
            return vs.ToArray();
        }

        #endregion

        #region 进入检定
        public byte[] Enter_verification(string vs1)
        {
            List<byte> vs = new List<byte>();
            for (int i = 0; i < 6; i++)
            {
                vs.Add(0xFE);
            }
            vs.Add(0x68);
            vs.Add(0x20);
            for (int i = 0; i < vs1.Length / 2; i++)
            {
                vs.Add(Get_table_number_1(vs1)[i]);
            }
            vs.Add(0X33);
            vs.Add(0X00);
            vs.Add(XSummation_check_1(vs.ToArray()));
            vs.Add(0x16);
            return vs.ToArray();
        }
        #endregion

        #region 累加和校验
        /// <summary>
        /// 写入校验和计算
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public byte XSummation_check_1(byte[] data)
        {
            #region 获取数组相同元素的个数
            int n = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ToString("X2") == "FE")
                {
                    n++;
                }
            }
            #endregion
            byte[] vs3 = new byte[data.Length - n];
            Array.Copy(data, n, vs3, 0, data.Length - n);//截取需要校验的位
            byte[] vs = new byte[1];//累加后
            byte vs1;//返回校验码
            for (int i = 0; i < vs3.Length; i++)
            {
                vs[0] += vs3[i];
            }
            return vs1 = Convert.ToByte(vs[0]);
        }


        //去除包头(FE)、校验码和包尾(16)
        public byte XSummation_check_2(byte[] data)
        {
            #region 获取数组相同元素的个数
            int n = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ToString("X2") == "FE")
                {
                    n++;
                }
            }

            #endregion
            byte[] vs3 = new byte[data.Length - (n + 2)];
            byte[] vs4 = new byte[data.Length - n];
            Array.Copy(data, n, vs4, 0, data.Length - n);//截取需要校验的位
            Array.Copy(vs4, 0, vs3, 0, vs4.Length - 2);
            byte[] vs = new byte[1];//累加后
            byte vs1;//返回校验码
            for (int i = 0; i < vs3.Length; i++)
            {
                vs[0] += vs3[i];
            }
            return vs1 = Convert.ToByte(vs[0]);
        }

        #endregion
        #endregion

        #region 热量表数据记录设置

        /// <summary>
        /// 向数据库读取表号
        /// </summary>
        /// <returns></returns>
        public string[] SQL_table_number_read()
        {

            List<string> vs = new List<string>();
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

            sqlConn.Open();

            String sqlStr = @" select Table_number from User_data1 ";

            SqlCommand sqlComm = new SqlCommand(sqlStr, sqlConn);

            SqlDataReader reader = sqlComm.ExecuteReader();

            while (reader.Read())
            {
                vs.Add(reader["Table_Number"].ToString().Replace(" ", ""));
            }
            reader.Close();
            sqlConn.Close();
            return vs.ToArray();
        }

        /// <summary>
        /// 向数据库读取表号
        /// </summary>
        /// <param name="num">楼号ID</param>
        /// <returns></returns>
        public string[] SQL_table_number_read(int num)
        {

            List<string> vs = new List<string>();
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

            sqlConn.Open();

            String sqlStr = @"select Table_number from User_data1 where NumberofLayersId=" + num.ToString();

            SqlCommand sqlComm = new SqlCommand(sqlStr, sqlConn);

            SqlDataReader reader = sqlComm.ExecuteReader();

            while (reader.Read())
            {
                vs.Add(reader["Table_number"].ToString().Replace(" ", ""));
            }
            reader.Close();
            sqlConn.Close();
            return vs.ToArray();
        }

        /// <summary>
        /// 读取表号的类型(对应楼层数)
        /// </summary>
        /// <returns></returns>
        public string[] SQL_table_number_read1()
        {

            List<string> vs = new List<string>();
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

            sqlConn.Open();

            String sqlStr = @"  select distinct NumberofLayersId from User_data1";

            SqlCommand sqlComm = new SqlCommand(sqlStr, sqlConn);

            SqlDataReader reader = sqlComm.ExecuteReader();

            while (reader.Read())
            {
                vs.Add(reader["NumberofLayersId"].ToString().Replace(" ", ""));
            }
            reader.Close();
            sqlConn.Close();
            return vs.ToArray();
        }



        /// <summary>
        /// 向数据库写入表数据
        /// </summary>
        public void Fddd(string[] vs)

        {
            //Console.WriteLine("使用Bulk插入的实现方式");
            Stopwatch sw = new Stopwatch();
            DataTable dt = GetTableSchema();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString))
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);
                bulkCopy.DestinationTableName = "CalorimeterTable1";
                bulkCopy.BatchSize = dt.Rows.Count;
                conn.Open();
                sw.Start();

                DataRow dr = dt.NewRow();
                dr[0] = Guid.NewGuid();
                //dr[1] = DateTime.Now.ToString();
                for (int i = 0; i < vs.Length; i++)
                {
                    dr[i + 1] = vs[i];
                }
                dt.Rows.Add(dr);
                if (dt != null && dt.Rows.Count != 0)
                {
                    bulkCopy.WriteToServer(dt);
                    sw.Stop();
                }



            }
        }

        static DataTable GetTableSchema()
        {
            /*
        [Table_number]
      ,[Cooling_capacity]
      ,[Calories]
      ,[Thermal_power]
      ,[Instantaneous_flow]
            Cumulative_flow
      ,[Water_supply_temperature]
      ,[Return_watertemperature]
      ,[Cumulative_working_time]
      ,[Instrument_current_time]
      ,[Instrument_status]
      ,[CreateTime]
             */
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
        new DataColumn("Id",typeof(Guid)),
        new DataColumn("Table_number",typeof(string)),
        new DataColumn("Cooling_capacity",typeof(string)),
        new DataColumn("Calories",typeof(string)),
        new DataColumn("Thermal_power",typeof(string)),
        new DataColumn("Instantaneous_flow",typeof(string)),
        new DataColumn("Cumulative_flow",typeof(string)),
        new DataColumn("Water_supply_temperature",typeof(string)),
        new DataColumn("Return_water_temperature",typeof(string)),
        new DataColumn("Cumulative_working_time",typeof(string)),
        new DataColumn("Instrument_current_time",typeof(string)),
        new DataColumn("Instrument_status",typeof(string)),
        new DataColumn("Time",typeof(DateTime))
            });
            return dt;
        }

        #endregion

        #region 阀门控制

        #region CRC校验


        #region 查表法
        //这里采用查表法
        //高位
        private static readonly byte[] aucCRCHi = new byte[256]
{
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64,
            1,
            192,
            128,
            65,
            1,
            192,
            128,
            65,
            0,
            193,
            129,
            64
};
        //低位
        private static readonly byte[] aucCRCLo = new byte[256]
        {
            0,192,193,1,195,3,2,
            194,
            198,
            6,
            7,
            199,
            5,
            197,
            196,
            4,
            204,
            12,
            13,
            205,
            15,
            207,
            206,
            14,
            10,
            202,
            203,
            11,
            201,
            9,
            8,
            200,
            216,
            24,
            25,
            217,
            27,
            219,
            218,
            26,
            30,
            222,
            223,
            31,
            221,
            29,
            28,
            220,
            20,
            212,
            213,
            21,
            215,
            23,
            22,
            214,
            210,
            18,
            19,
            211,
            17,
            209,
            208,
            16,
            240,
            48,
            49,
            241,
            51,
            243,
            242,
            50,
            54,
            246,
            247,
            55,
            245,
            53,
            52,
            244,
            60,
            252,
            253,
            61,
            255,
            63,
            62,
            254,
            250,
            58,
            59,
            251,
            57,
            249,
            248,
            56,
            40,
            232,
            233,
            41,
            235,
            43,
            42,
            234,
            238,
            46,
            47,
            239,
            45,
            237,
            236,
            44,
            228,
            36,
            37,
            229,
            39,
            231,
            230,
            38,
            34,
            226,
            227,
            35,
            225,
            33,
            32,
            224,
            160,
            96,
            97,
            161,
            99,
            163,
            162,
            98,
            102,
            166,
            167,
            103,
            165,
            101,
            100,
            164,
            108,
            172,
            173,
            109,
            175,
            111,
            110,
            174,
            170,
            106,
            107,
            171,
            105,
            169,
            168,
            104,
            120,
            184,
            185,
            121,
            187,
            123,
            122,
            186,
            190,
            126,
            127,
            191,
            125,
            189,
            188,
            124,
            180,
            116,
            117,
            181,
            119,
            183,
            182,
            118,
            114,
            178,
            179,
            115,
            177,
            113,
            112,
            176,
            80,
            144,
            145,
            81,
            147,
            83,
            82,
            146,
            150,
            86,
            87,
            151,
            85,
            149,
            148,
            84,
            156,
            92,
            93,
            157,
            95,
            159,
            158,
            94,
            90,
            154,
            155,
            91,
            153,
            89,
            88,
            152,
            136,
            72,
            73,
            137,
            75,
            139,
            138,
            74,
            78,
            142,
            143,
            79,
            141,
            77,
            76,
            140,
            68,
            132,
            133,
            69,
            135,
            71,
            70,
            134,
            130,
            66,
            67,
            131,
            65,
            129,
            128,
            64
        };

        #endregion

        /// <summary>
        /// 生成CRC
        /// </summary>
        /// <param name="pucFrame"></param>
        /// <param name="usLen"></param>
        /// <returns></returns>
        public byte[] Crc16(byte[] pucFrame, int usLen)
        {
            int i = 0;
            byte[] res = new byte[2]
            {
                255,
                255
            };
            ushort iIndex = 0;
            while (usLen-- > 0)
            {
                iIndex = (ushort)(res[0] ^ pucFrame[i++]);
                res[0] = (byte)(res[1] ^ aucCRCHi[iIndex]);
                res[1] = aucCRCLo[iIndex];
            }
            return res;
        }

        /// <summary>
        /// CRC验证
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private bool CheckCRC(byte[] response)
        {
            byte[] crc = Crc16(response, response.Length - 2);
            if (crc[0] == response[response.Length - 2] && crc[1] == response[response.Length - 1])
            {
                return true;
            }
            return false;
        }


        //暂未用到
        /// <summary>
        /// CRC算法
        /// </summary>
        /// <param name="pByte"></param>
        /// <param name="nNumberOfBytes"></param>
        /// <param name="pChecksum"></param>
        private void CalculateCRC(byte[] pByte, int nNumberOfBytes, out ushort pChecksum)
        {
            pChecksum = ushort.MaxValue;
            for (int nByte = 0; nByte < nNumberOfBytes; nByte++)
            {
                pChecksum ^= pByte[nByte];
                for (int nBit = 0; nBit < 8; nBit++)
                {
                    ushort nShiftedBit = (ushort)(((pChecksum & 1) == 1) ? 1 : 0);
                    pChecksum >>= 1;
                    if (nShiftedBit != 0)
                    {
                        pChecksum ^= 40961;
                    }
                }
            }
        }

        #endregion

        #region 阀门串口
        public SerialPort ValveClosed;

        /// <summary>
        /// 打开阀门控制串口
        /// </summary>
        /// <param name="iPortName">Com口-String</param>
        /// <param name="iBaudRate">波特率-int</param>
        /// <param name="iParity">校验位-Parity</param>
        /// <param name="iDataBits">数据位-int</param>
        /// <param name="iStopBits">停止位-StopBits</param>
        public void ConnectValveClosed(string iPortName, int iBaudRate, Parity iParity, int iDataBits, StopBits iStopBits)
        {
            ValveClosed = new SerialPort(iPortName, iBaudRate, iParity, iDataBits, iStopBits);
            if (ValveClosed.IsOpen)
            {
                ValveClosed.Close();
            }
            ValveClosed.Open();
        }

        /// <summary>
        /// 关闭串口1
        /// </summary>
        public void DisConnect1()
        {

            if (ValveClosed.IsOpen)
            {
                ValveClosed.Close();
            }


        }

        #endregion

        /// <summary>
        /// 读线圈状态
        /// </summary>
        /// <param name="SlaveAddress">从站地址</param>
        /// <param name="InitialAddress">起始地址</param>
        /// <param name="Quantity">数量</param>
        /// <returns></returns>
        public byte[] Read_coil(ushort SlaveAddress, ushort InitialAddress, ushort Quantity)
        {
            List<byte> Read_coils = new List<byte>();
            //从站地址
            Read_coils.Add((byte)SlaveAddress);
            //功能码
            Read_coils.Add(0x01);
            //起始地址
            Read_coils.Add((byte)(InitialAddress / 256)); //高位
            Read_coils.Add((byte)(InitialAddress % 256)); //低位
                                                          //数量
            Read_coils.Add((byte)(Quantity / 256)); //高位
            Read_coils.Add((byte)(Quantity % 256)); //低位
                                                    //校验码
            Read_coils.AddRange(Crc16(Read_coils.ToArray(), Read_coils.Count));
            return Read_coils.ToArray();

        }

        /// <summary>
        /// 写线圈
        /// </summary>
        /// <param name="SlaveAddress">从站地址</param>
        /// <param name="InitialAddress">起始地址</param>
        /// <param name="Instruction">控制指令</param>
        /// <returns></returns>
        public byte[] Write_coil(ushort SlaveAddress, int InitialAddress, int Instruction)
        {
            List<byte> Write_coils = new List<byte>();
            //从站地址
            Write_coils.Add((byte)SlaveAddress);
            //功能码
            Write_coils.Add(0x05);
            //起始地址
            if (InitialAddress == 0)
            {
                //第一路继电器
                Write_coils.Add(0x00); //高位
                Write_coils.Add(0x00); //低位
            }
            else
            {
                //第二路继电器
                Write_coils.Add(0x00); //高位
                Write_coils.Add(0x01); //低位
            }

            //控制指令
            if (Instruction == 0)
            {
                Write_coils.Add(0X00); //高位
                Write_coils.Add(0X00); //低位
            }
            else
            {
                Write_coils.Add(0XFF); //高位
                Write_coils.Add(0X00); //低位
            }

            //校验码
            Write_coils.AddRange(Crc16(Write_coils.ToArray(), Write_coils.Count));
            return Write_coils.ToArray();
        }

        /// <summary>
        /// 读-解析
        /// </summary>
        /// <param name="Data">接收的数据</param>
        /// <returns></returns>
        public byte[] Read_Parsing(byte[] Data)
        {
            if (CheckCRC(Data))
            {
                byte[] Read_Parsings = new byte[Data.Length - 4];
                for (int i = 0; i == Data.Length - 4; i++)
                {
                    Read_Parsings[i] = Data[i + 2];
                }
                return Read_Parsings;
            }
            return null;
        }

        /// <summary>
        /// 写-解析
        /// </summary>
        /// <param name="Data">接收的数据</param>
        /// <returns></returns>
        public byte[] Write_Parsing(byte[] Data)
        {
            if (CheckCRC(Data))
            {
                byte[] Write_Parsings = new byte[Data.Length - 4];
                for (int i = 0; i == Data.Length - 4; i++)
                {
                    Write_Parsings[i] = Data[i + 2];
                }
                return Write_Parsings;
            }
            return null;
        }

        #endregion

        #region 导出excel
        /// <summary>
        /// 导出excel
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="isShowExcle"></param>
        /// <returns></returns>
        public bool DataGridviewShowToExcel(DataGridView dgv, bool isShowExcle, int vs)
        {
            if (dgv.Rows.Count == 0)
                return false;
            //建立Excel对象 
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcle;
            //生成字段名称 
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }
            if (vs == 1)
            {
                //填充数据 
                for (int i = 0; i < dgv.RowCount - 1; i++)
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (dgv[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dgv[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                        }
                    }
                }
            }
            else
            {
                //填充数据 
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (dgv[j, i].ValueType == typeof(string))
                        {
                            if (dgv[j, i].Value == null)
                                continue;
                            else
                                excel.Cells[i + 2, j + 1] = "'" + dgv[j, i].Value.ToString();
                        }
                        else
                        {
                            if (dgv[j, i].Value == null)
                                continue;
                            else
                                excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                        }
                    }
                }
            }


            return true;
        }
        #endregion


    }
}
