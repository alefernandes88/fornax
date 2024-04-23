using fornax.Core.Base;
using System;

namespace fornax.Core.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public DateTime InitialDate { get; set; }

    }
}
