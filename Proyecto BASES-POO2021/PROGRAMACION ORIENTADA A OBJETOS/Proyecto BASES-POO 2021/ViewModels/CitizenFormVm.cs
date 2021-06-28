using System;

namespace Proyecto_BASES_POO_2021.viewModels
{
    public class CitizenFormVm
    {
        public string DuiC { get; set; }
        
        public DateTime FirstVaccineDate { get; set; }
        
        public string CitizenAddress { get; set; }
        
        public string CitizenName { get; set; }
        
        public string Telephone { get; set; }
        
        public string CitizenEmail { get; set; }
        
        public int IdInstitution { get; set; }
        
        public bool PriorityGroup { get; set; }
    }
}