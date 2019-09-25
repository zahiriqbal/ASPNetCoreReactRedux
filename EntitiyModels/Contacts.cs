using System;
using System.Collections.Generic;

namespace AspNetCoreReactRedux.EntitiyModels
{
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
