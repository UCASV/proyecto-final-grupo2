using System;

namespace Proyecto_BASES_POO_2021.viewModels
{
    public class AppointmentVm
    {
        public int IdAppontiment { get; set; }
        
        public int IdCabin { get; set; }
        
        public string DuiC { get; set; }
        
        public DateTime AppointmentDate { get; set; }
        
        public string AppointmentAddress { get; set; }
    }
}