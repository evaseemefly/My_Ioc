using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SMTestFixture smt = new SMTestFixture();
            smt.Setup();
            SMTestFixture.TestMethod();
        }
    }
}
