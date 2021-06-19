using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class CitizenForm
    {
        public CitizenForm()
        {
            Appointments = new HashSet<Appointment>();
            ChronicDiseases = new HashSet<ChronicDisease>();
            SideEffectsNavigation = new HashSet<SideEffect>();
        }

        public string DuiC { get; set; }
        public DateTime FirstVaccineDate { get; set; }
        public string SideEffects { get; set; }
        public string CitizenAddress { get; set; }
        public string CitizenName { get; set; }
        public string Telephone { get; set; }
        public string CitizenEmail { get; set; }
        public int IdInstitution { get; set; }
        public bool PriorityGroup { get; set; }

        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ChronicDisease> ChronicDiseases { get; set; }
        public virtual ICollection<SideEffect> SideEffectsNavigation { get; set; }
    }
}
