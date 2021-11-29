using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modles
{
    [Obsolete]//弃用
    /// <summary>
    /// 表号实体类
    /// </summary>
    public class Table_Numbers
    {
        public string Table_Number1 { get; set; }
        public int NumberofLayersId { get; set; }
        public string ControlAddress { get; set; }
        public string Port_diection { get; set; }
    }
}
