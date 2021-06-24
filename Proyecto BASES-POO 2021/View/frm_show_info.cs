using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_BASES_POO_2021.ProjectContext;
using System.Linq;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_show_info : Form
    {
        
        public frm_show_info(string ucitizen)
        {
            InitializeComponent();
             txtDuiShow.Text = ucitizen;
             
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        

        private void frm_show_info_Load(object sender, EventArgs e)
        {
            
            var db = new PROJECT_BD_POOContext();

            var validationPriority = (from a in db.CitizenForms
                where a.DuiC == txtDuiShow.Text  
                select a.PriorityGroup).FirstOrDefault();
            chkPriority.Checked = validationPriority;
            
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
            text_Lugar.Text = query2;
            txtidcabin.Text = randomCavin.ToString();
            
            System.Globalization.DateTimeFormatInfo dInfo = new System.Globalization.DateTimeFormatInfo();
            dInfo.ShortDatePattern = "dd/MM/yyyy  hh:mm:ss";
            //días para personas de prioridad
            var newdatemax = DateTime.Now.AddDays(30);
            //dias para personas que no son de prioridad
            var newdatemax2 = DateTime.Now.AddDays(60);
            
            if (chkPriority.Checked == true)
            {
                DateTime dtMin = Convert.ToDateTime(DateTime.Now, dInfo);
                DateTime dtMax = Convert.ToDateTime(newdatemax, dInfo);
                
                TimeSpan tsMax = dtMax - dtMin;
                //para crear el random

                Random rn = new Random();
                //dias aleatorios que generarán la proxima fecha

                int rnDays = rn.Next(1, tsMax.Days);
                //fecha aleatoria resultante de los dias sumados a la fecha minima

                DateTime dtRan = dtMin.AddDays(rnDays);
                //representacion en un textbox
            
                txt_fecha.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss tt");
                
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
            
                txt_fecha.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss tt");

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
