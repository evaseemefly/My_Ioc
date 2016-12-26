using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTest
{
    public class ConsoleOutput:IOutput
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
