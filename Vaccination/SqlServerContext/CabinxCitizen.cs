using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class CabinxCitizen
    {
        public string Dui { get; set; }
        public int IdCabin { get; set; }

        public virtual Citizen DuiNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
    }
}
