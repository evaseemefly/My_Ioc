using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace ContactEntityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //依赖注入方式1：
            //ObjectFactory.Initialize(x =>
            //{
            //    x.For<IContactValidator>().Use<ContactValidator>();
            //    x.For<IContactRepository>()
            //    .Use<ContactRepository>()
            //    .Ctor<ContactRepository>("connectionString")    //内联的定义构造函数依赖。根据类型选择构造函数参数和构造函数的名字。使用这种方法,如果有多个相同类型的构造函数参数
            //    .EqualToAppSetting("Connection-String");
            //});

            //方式2：xml的方式
            ObjectFactory.Initialize(x =>
            {
                x.PullConfigurationFromAppConfig = true;
            });

            //在容器初始化后 用于添加额外的配置
            ObjectFactory.Configure(x =>
            {
                x.Scan(a =>
                {
                    
                    a.AssembliesFromApplicationBaseDirectory();//扫描当前应用程序域的应用程序基础目录并添加任何组装发现扫描操作。
                    a.LookForRegistries();//将扫描操作自动检测,包括任何注册表类中发现组装的扫描
                });
            });

            ContactEntity contact = new ContactEntity()
            {
                Name = "liu",
                Birthday = new DateTime(1988, 1, 1),
                IDCard = "12312313123"
            };

            ContactController controller = ObjectFactory.GetInstance<ContactController>();
            controller.Save(contact);
            Console.ReadKey();
        }
    }
}
