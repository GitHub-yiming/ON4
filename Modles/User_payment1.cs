using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modles
{
    //用户缴费实体类
    public class User_payment1
    {
        public string Table_number { get; set; }
        public  string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime Billabletime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
