using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Manager
    {
        public Manager()
        {
            Registers = new HashSet<Register>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordManager { get; set; }
        public int IdCabin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual ICollection<Register> Registers { get; set; }
    }
}
