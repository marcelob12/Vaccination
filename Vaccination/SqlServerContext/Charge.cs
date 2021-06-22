using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Charge
    {
        public Charge()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string NameCharge { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
