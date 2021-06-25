using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_BASES_POO_2021.ProjectContext;
using System.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
 
            //***********
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
               var newAppointment = new Appointment()
                {   
                    DuiC = txtDuiShow.Text,
                    IdCabin = randomCavin,
                    AppointmentAddress =  query2,
                    AppointmentDate = dtRan
                };
               db.Add(newAppointment);
               db.SaveChanges();

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
                var newAppointment = new Appointment()
                {   
                    DuiC = txtDuiShow.Text,
                    IdCabin = randomCavin,
                    AppointmentAddress =  query2,
                    AppointmentDate = dtRan
                };
                db.Add(newAppointment);
                db.SaveChanges();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            FileStream fs = new FileStream(@"C:\Users\USUARIO\Desktop\ProyectoBDPOO\PDFAppointment.pdf", FileMode.Create);
            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f); 
            PdfWriter.GetInstance(pdfDoc, fs);
            pdfDoc.Open();
            
            //Fuente del pdf
            iTextSharp.text.Font StandarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8,
                iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            
            //Encabezado
            pdfDoc.Add(new Paragraph("Informacion sobre su primera cita"));
            pdfDoc.Add(Chunk.NEWLINE);

            PdfPTable tabl = new PdfPTable(4);
            tabl.WidthPercentage = 100;
            
            //titulo de las columnas 
            PdfPCell clDUI = new PdfPCell(new Phrase("DUI", StandarFont));
            clDUI.BorderWidth = 0;
            clDUI.BorderWidthBottom = 0.75f;
            
            PdfPCell clAppointmentDate = new PdfPCell(new Phrase("Fecha", StandarFont));
            clAppointmentDate.BorderWidth = 0;
            clAppointmentDate.BorderWidthBottom = 0.75f;
            
            PdfPCell clPlace = new PdfPCell(new Phrase("Lugar", StandarFont));
            clPlace.BorderWidth = 0;
            clPlace.BorderWidthBottom = 0.75f;
            
            PdfPCell clCabin = new PdfPCell(new Phrase("Cabina", StandarFont));
            clCabin.BorderWidth = 0;
            clCabin.BorderWidthBottom = 0.75f;

            tabl.AddCell(clDUI);
            tabl.AddCell(clAppointmentDate);
            tabl.AddCell(clPlace);
            tabl.AddCell(clCabin);


            clDUI = new PdfPCell(new Phrase(txtDuiShow.Text, StandarFont));
            clAppointmentDate = new PdfPCell(new Phrase(txt_fecha.Text, StandarFont));
            clPlace = new PdfPCell(new Phrase(text_Lugar.Text, StandarFont));
            clCabin = new PdfPCell(new Phrase(txtidcabin.Text, StandarFont));
            
            tabl.AddCell(clDUI);
            tabl.AddCell(clAppointmentDate);
            tabl.AddCell(clPlace);
            tabl.AddCell(clCabin);
            
            pdfDoc.Add(tabl);
            pdfDoc.Close();
            fs.Close();
            
            MessageBox.Show("PDF exportado correctamente!", "Gobierno de El Salvador",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    
}
