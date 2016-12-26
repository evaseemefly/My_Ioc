using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTest
{
    public class ChineseGreeter : IGreeter
    {
        public string GetGreeting()
        {
            return "你好";
        }
    }
}
