using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            CabinxCitizens = new HashSet<CabinxCitizen>();
        }

        public string Dui { get; set; }
        public string FullName { get; set; }
        public string CitizenAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int? IdCharge { get; set; }
        public int? IdSecEffect { get; set; }
        public int? IdRecord { get; set; }
        public int? IdDisease { get; set; }
        public DateTime? DateVaccine { get; set; }
        public DateTime? DateArrival { get; set; }

        public virtual Charge IdChargeNavigation { get; set; }
        public virtual Disease IdDiseaseNavigation { get; set; }
        public virtual SecondaryEffect IdSecEffectNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<CabinxCitizen> CabinxCitizens { get; set; }
    }
}
