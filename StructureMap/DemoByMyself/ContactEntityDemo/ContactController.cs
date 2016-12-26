using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactEntityDemo
{
    public class ContactController
    {
        private IContactRepository _repository;
        private IContactValidator _validator;

        public ContactController(IContactValidator validator,IContactRepository repository)
        {
            this._repository = repository;
            this._validator = validator;
        }

        public bool Save(ContactEntity contact)
        {
            if (this._validator.Validate(contact))
                return this._repository.Save(contact);
            else
                return false;
        }
    }
}
