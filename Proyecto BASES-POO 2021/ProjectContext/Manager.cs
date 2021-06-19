using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class Manager
    {
        public Manager()
        {
            Cabins = new HashSet<Cabin>();
            SessionUs = new HashSet<SessionU>();
        }

        public int IdManager { get; set; }
        public int IdTypeEmployee { get; set; }
        public string ManagerName { get; set; }
        public string ManagerAddress { get; set; }
        public string InstitutionalEmail { get; set; }
        public string UserM { get; set; }
        public string Psw { get; set; }

        public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
        public virtual ICollection<Cabin> Cabins { get; set; }
        public virtual ICollection<SessionU> SessionUs { get; set; }
    }
}
