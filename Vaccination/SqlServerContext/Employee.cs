using System;
using System.Collections.Generic;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string InstitutionalMail { get; set; }
        public string EmployeeAddress { get; set; }
        public int IdType { get; set; }
        public int IdCabin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Type IdTypeNavigation { get; set; }
    }
}
