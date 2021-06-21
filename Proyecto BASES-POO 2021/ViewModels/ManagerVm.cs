using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021.viewModels
{
    public class ManagerVm
    {
        public int IdManager { get; set; }
        public int IdTypeEmployee { get; set; }
        public string ManagerName { get; set; }
        public string ManagerAddress { get; set; }
        public string InstitutionalEmail { get; set; }
        
        
        //public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
    }
}