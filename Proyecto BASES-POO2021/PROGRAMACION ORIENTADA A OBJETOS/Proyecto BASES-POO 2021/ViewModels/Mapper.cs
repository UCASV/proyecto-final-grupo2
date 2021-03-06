using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021.viewModels
{
    public static class ProjectMapper
    {
        public static ManagerVm mapManagerVm(Manager m)
        {
            return new ManagerVm()
            {
                IdManager = m.IdManager,
                IdTypeEmployee = m.IdTypeEmployee,
                InstitutionalEmail = m.InstitutionalEmail,
                ManagerName = m.ManagerName,
                ManagerAddress = m.ManagerAddress
            };
        }
        
        public static CitizenFormVm MapCitizenFormVm(CitizenForm c)
        {
            return new CitizenFormVm()
            {
                DuiC = c.DuiC,
                CitizenName = c.CitizenName,
                CitizenAddress = c.CitizenAddress,
                Telephone = c.Telephone,
                CitizenEmail = c.CitizenEmail,
                IdInstitution = c.IdInstitution,
                PriorityGroup =c.PriorityGroup
            };
        }
        
        public static AppointmentVm MapAppointmentVm(Appointment a)
        {
            return new AppointmentVm()
            {
               IdAppontiment = a.IdAppontiment,
               DuiC = a.DuiC,
               IdCabin =  a.IdCabin,
               AppointmentDate = a.AppointmentDate,
               AppointmentAddress = a.AppointmentAddress
            };
        }
        
        
        
         
    }
    
}