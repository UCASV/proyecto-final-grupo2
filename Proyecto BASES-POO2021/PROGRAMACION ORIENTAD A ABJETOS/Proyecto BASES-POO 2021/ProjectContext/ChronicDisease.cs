using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class ChronicDisease
    {
        public int IdCronicDisease { get; set; }
        public string DuiC { get; set; }
        public string DiseaseName { get; set; }

        public virtual CitizenForm DuiCNavigation { get; set; }
    }
}
