using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_secondVaccine : Form
    {
        
        public frm_secondVaccine(string dui)
        {
            InitializeComponent();
            txt_citizenDUI.Text = dui;
            txt_citizenDUI.Enabled = false;
            txt_Place.Enabled = false;
            txt_cabin.Enabled = false;
            chb_Priority.Enabled = false;
            txt_secondAppointment.Enabled = false;
        }

        private void frm_secondVaccine_Load(object sender, EventArgs e)
        {
            var db = new PROJECT_BD_POOContext();

            var validationPriority = (from a in db.CitizenForms
                where a.DuiC == txt_citizenDUI.Text  
                select a.PriorityGroup).FirstOrDefault();
            chb_Priority.Checked = validationPriority;
            
            //Ordena todas las cabinas existentes en la base
            var listacabinas = db.Cabins
                .OrderBy(c => c.IdCabin)
                .ToList();
            
            Random rnd = new Random();
            //genera un numero aleatorio dentro del rango de numero de cabinas que hay en la base
            var randomCavin = rnd.Next(1, listacabinas.Count + 1) ;
            //selecciona una dirección en base al numero aleatorio obtenido anteriormente
            var query2 = (from a in db.Cabins
                where a.IdCabin == randomCavin  
                select a.CabinAddress).FirstOrDefault();
            
            //muestra la informacion al gestor
            txt_Place.Text = query2;
            txt_cabin.Text = randomCavin.ToString();
            
            System.Globalization.DateTimeFormatInfo dInfo = new System.Globalization.DateTimeFormatInfo();
            
            dInfo.ShortDatePattern = "dd/MM/yyyy  hh:mm:ss";
            //días para personas de prioridad
            var firtvaccine = (from a in db.CitizenForms
                where a.DuiC ==  txt_citizenDUI.Text
                select a.FirstVaccineDate).FirstOrDefault();
            
            var datemin = firtvaccine.AddDays(42);
            //dias para personas que no son de prioridad
            var newdatemax = firtvaccine.AddDays(47);
            var newdatemax2 = firtvaccine.AddDays(56);
            
            if (chb_Priority.Checked == true)
            {
                DateTime dtMin = Convert.ToDateTime(datemin, dInfo);
                DateTime dtMax = Convert.ToDateTime(newdatemax, dInfo);
                
                TimeSpan tsMax = dtMax - dtMin;
                //para crear el random

                Random rn = new Random();
                //dias aleatorios que generarán la proxima fecha

                int rnDays = rn.Next(1, tsMax.Days);
                //fecha aleatoria resultante de los dias sumados a la fecha minima

                DateTime dtRan = dtMin.AddDays(rnDays);
                //representacion en un textbox
            
                txt_secondAppointment.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss tt");
                
                //Realiza la insercion de datos en la base
               /* var newAppointment = new Appointment()
                {   
                    DuiC = txtDuiShow.Text,
                    IdCabin = randomCavin,
                    AppointmentAddress =  query2,
                    AppointmentDate = dtRan,
                    WaitingTime = ,
                };*/

            }
            else
            {
                //para calcular la diferencia de días entre fechas para personas sin prioridad
                DateTime dtMin = Convert.ToDateTime(newdatemax, dInfo);
                DateTime dtMax = Convert.ToDateTime(newdatemax2, dInfo);
                
                TimeSpan tsMax = dtMax - dtMin;
                //para crear el random

                Random rn = new Random();
                //dias aleatorios que generarán la proxima fecha

                int rnDays = rn.Next(1, tsMax.Days);
                //fecha aleatoria resultante de los dias sumados a la fecha minima

                DateTime dtRan = dtMin.AddDays(rnDays);
                //representacion en un textbox
            
                txt_secondAppointment.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss tt");

                //Realiza la insercion de datos en la base
                //Quitar comentarios al realizar el waiting time
                /*var newAppointment = new Appointment()
                {   
                    DuiC = txtDuiShow.Text,
                    IdCabin = randomCavin,
                    AppointmentAddress =  query2,
                    AppointmentDate = dtRan,
                    WaitingTime = ,
                };*/

            }
            
            /*//para segundo formulario
            //Se crea un nuevo random entre 6 y 8 semanas 
            Random rnd2 = new Random();
            var newweeks = rnd2.Next(42,56);
            
            DateTime nuevaFecha = Convert.ToDateTime(txt_fecha.Text);
            //El resultado es una nueva fecha con la suma de ese resultado a la fecha de la primera sita
            nuevaFecha = nuevaFecha.AddDays(newweeks);*/
            
        }
    }
}