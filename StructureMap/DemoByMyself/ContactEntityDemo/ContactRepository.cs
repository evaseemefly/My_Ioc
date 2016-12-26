using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactEntityDemo
{
    public class ContactRepository : IContactRepository
    {
        private string _connectionString;
        public ContactRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public bool Save(ContactEntity contact)
        {
            Console.WriteLine(string.Format("Contact \"{0}\" has been saved to:", contact.Name));
            Console.WriteLine(this._connectionString);
            return true;

        }
    }
}
