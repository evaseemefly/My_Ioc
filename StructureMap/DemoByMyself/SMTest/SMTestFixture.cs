using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;


namespace SMTest
{
    class SMTestFixture
    {
        public void Setup()
        {
            ObjectFactory.Initialize(x =>
            {
                x.IgnoreStructureMapConfig = true;
                x.For<IAppEngine>().Singleton().Use<AppEngine>();
                x.For<IGreeter>().Use<ChineseGreeter>();
                x.For<IOutput>().Use<ConsoleOutput>();
            });
        }

        public static void TestMethod()
        {
            IAppEngine appEngine = ObjectFactory.GetInstance<IAppEngine>();
            appEngine.Run();
        }
    }
}
