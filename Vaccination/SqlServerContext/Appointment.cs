using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public DateTime? FirstDate { get; set; }
        public DateTime? SecondDate { get; set; }
        public string VaccinationPlace { get; set; }
        public int? IdCabin { get; set; }
        public string Dui { get; set; }

        public virtual Citizen DuiNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
    }
}
