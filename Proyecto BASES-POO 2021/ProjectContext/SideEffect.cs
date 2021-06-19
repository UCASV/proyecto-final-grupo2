using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class SideEffect
    {
        public int IdSideEffects { get; set; }
        public string DuiC { get; set; }
        public string SideEffectsName { get; set; }

        public virtual CitizenForm DuiCNavigation { get; set; }
    }
}
