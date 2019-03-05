using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDCommerce.Domain.Account.ValueObjects;

namespace DDDCommerce.Domain.Account.Entities
{
    public class Student
    {

        public Name Name { get; private set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }


    }
}
