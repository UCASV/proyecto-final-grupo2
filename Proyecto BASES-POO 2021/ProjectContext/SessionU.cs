using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class SessionU
    {
        public int IdSession { get; set; }
        public int IdManager { get; set; }
        public int IdCabin { get; set; }
        public DateTime SessionDate { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
    }
}
