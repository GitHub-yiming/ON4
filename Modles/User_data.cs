using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modles
{

    /// <summary>
    /// 用户实体类
    /// </summary>
    public class User_data
    {
        //Table_number, Names, Room_No, Building, Phone, NumberofLayersId, CreateTime
        public string Table_number { get; set; }
        public string Names { get; set; }
        public string Gender { get; set; }
        public string Room_No { get; set; }
        public string Building { get; set; }
        public string Phone { get; set; }
        public int NumberofLayersId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime Billabletime { get; set; }

        //拓展属性
        public string NumberofLayer { get; set; }

    }
}
