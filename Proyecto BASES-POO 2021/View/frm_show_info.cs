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
        public frm_show_info()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void frm_show_info_Load(object sender, EventArgs e)
        {
            System.Globalization.DateTimeFormatInfo dInfo = new System.Globalization.DateTimeFormatInfo();
            dInfo.ShortDatePattern = "dd/MM/yyyy  hh:mm:ss";
            //para pasar la info de un par de textbox string a datetime

            var newdatemax = DateTime.Now.AddDays(30);
            DateTime dtMin = Convert.ToDateTime(DateTime.Now, dInfo);
            DateTime dtMax = Convert.ToDateTime(newdatemax, dInfo);
            //para calcular la diferencia de días entre fechas
            /*
             var newdatemax2 = DateTime.Now.AddDays(60);
             DateTime dtMin = Convert.ToDateTime(newdatemax, dInfo);
            DateTime dtMax = Convert.ToDateTime(newdatemax2, dInfo);
             */
            TimeSpan tsMax = dtMax - dtMin;
            // para crear el random

            Random rn = new Random();
            //dias aleatorios que generarán la proxima fecha

            int rnDays = rn.Next(1, tsMax.Days);
            //fecha aleatoria resultante de los dias sumados a la fecha minima

            DateTime dtRan = dtMin.AddDays(rnDays);
            //representacion en un textbox

            txt_fecha.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss tt");

           
            
            //para segundo formulario
            //Se crea un nuevo random entre 6 y 8 semanas 
            Random rnd2 = new Random();
            var newweeks = rnd2.Next(42,56);
            
            DateTime nuevaFecha = Convert.ToDateTime(txt_fecha.Text);
            //El resultado es una nueva fecha con la suma de ese resultado a la fecha de la primera sita
            nuevaFecha = nuevaFecha.AddDays(newweeks);

            








        }
        
    }
}