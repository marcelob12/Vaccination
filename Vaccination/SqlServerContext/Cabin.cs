using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            Appointments = new HashSet<Appointment>();
            CabinxCitizens = new HashSet<CabinxCitizen>();
            Employees = new HashSet<Employee>();
            Managers = new HashSet<Manager>();
            Registers = new HashSet<Register>();
        }

        public int Id { get; set; }
        public string AddressCabin { get; set; }
        public string CabinPhone { get; set; }
        public string Manager { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<CabinxCitizen> CabinxCitizens { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Register> Registers { get; set; }
    }
}
