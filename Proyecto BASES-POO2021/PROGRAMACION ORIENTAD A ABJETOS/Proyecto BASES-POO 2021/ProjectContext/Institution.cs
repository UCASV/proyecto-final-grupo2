using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class Institution
    {
        public Institution()
        {
            CitizenForms = new HashSet<CitizenForm>();
        }

        public int IdInstitution { get; set; }
        public string InstitutionName { get; set; }

        public virtual ICollection<CitizenForm> CitizenForms { get; set; }
    }
}
