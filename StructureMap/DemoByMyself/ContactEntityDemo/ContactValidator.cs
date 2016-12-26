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
    public class ContactValidator : IContactValidator
    {
        public bool Validate(ContactEntity contact)
        {
            Console.WriteLine(string.Format("Contact \"{0}\" has been validated.", contact.Name));
            return true;

        }
    }
}
