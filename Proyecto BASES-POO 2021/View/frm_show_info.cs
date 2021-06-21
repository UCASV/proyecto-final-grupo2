using System;
using System.Collections.Generic;
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

            txt_lugar.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss");
            
            
            
            
        }

        
    }
}