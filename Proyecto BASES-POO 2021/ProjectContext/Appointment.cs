using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class Appointment
    {
        public int IdAppontiment { get; set; }
        public int IdCabin { get; set; }
        public string DuiC { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentAddress { get; set; }
        public DateTime? WaitingTime { get; set; }

        public virtual CitizenForm DuiCNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
    }
}
