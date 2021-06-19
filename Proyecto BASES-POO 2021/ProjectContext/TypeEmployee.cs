using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class TypeEmployee
    {
        public TypeEmployee()
        {
            Managers = new HashSet<Manager>();
        }

        public int IdTypeEmployee { get; set; }
        public string TypeEmployee1 { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}
