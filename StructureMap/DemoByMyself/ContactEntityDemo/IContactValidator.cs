using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactEntityDemo
{
    /// <summary>
    /// 联系人验证
    /// </summary>
    public interface IContactValidator
    {
        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        bool Validate(ContactEntity contact);
    }
}
