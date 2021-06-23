using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_BASES_POO_2021.ProjectContext;


namespace Proyecto_BASES_POO_2021
{
    public partial class frm_show_info : Form
    {
        public frm_show_info()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void txt_lugar_TextChanged(object sender, EventArgs e)
        {
    
            
            var db = new PROJECT_BD_POOContext();
            
            System.Globalization.DateTimeFormatInfo dInfo = new System.Globalization.DateTimeFormatInfo();
            dInfo.ShortDatePattern = "dd/MM/yyyy  hh:mm:ss";
 //para pasar la info de un par de textbox string a datetime
            
            DateTime dtMin = Convert.ToDateTime(DateTime.Now, dInfo);
            DateTime dtMax = Convert.ToDateTime("08/08/2021", dInfo);
//para calcular la diferencia de días entre fechas

            TimeSpan tsMax = dtMax - dtMin;
// para crear el random

            Random rn = new Random();
//dias aleatorios que generarán la proxima fecha

            int rnDays = rn.Next(1, tsMax.Days);
//fecha aleatoria resultante de los dias sumados a la fecha minima

            DateTime dtRan = dtMin.AddDays(rnDays);
//representacion en un textbox

            //txt_lugar.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss");
            
            
            
            
        }


        private void frm_show_info_Load(object sender, EventArgs e)
        {
            var db = new PROJECT_BD_POOContext();
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
            textLugar.Text = query2;
            textBox1.Text = randomCavin.ToString();
            
            //Realiza la insercion de datos en la base
            /*var newAppointment = new Appointment()
            {   
                //DuiC = "juan",
                IdCabin = randomCavin,
                AppointmentAddress =  query2,
                //AppointmentDate = ,
                //WaitingTime = ,
            };*/
            
        }
    }
}