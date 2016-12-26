using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactEntityDemo
{
    /// <summary>
    /// 联系人仓储
    /// </summary>
    public interface IContactRepository
    {
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        bool Save(ContactEntity contact);
    }
}
