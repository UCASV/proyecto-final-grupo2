using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            Appointments = new HashSet<Appointment>();
            SessionUs = new HashSet<SessionU>();
        }

        public int IdCabin { get; set; }
        public int IdManager { get; set; }
        public string CabinAddress { get; set; }
        public string CabinEmail { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Manager IdManagerNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<SessionU> SessionUs { get; set; }
    }
}
