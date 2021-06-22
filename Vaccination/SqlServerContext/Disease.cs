using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Disease
    {
        public Disease()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string DiseaseName { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
