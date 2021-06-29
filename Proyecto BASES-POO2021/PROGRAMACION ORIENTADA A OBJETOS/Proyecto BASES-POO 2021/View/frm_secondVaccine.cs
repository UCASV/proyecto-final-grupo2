using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
            btnPdfExport.Enabled = false;
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

            var datemin = DateTime.Now.AddDays(42);
            //dias para personas que no son de prioridad
            var newdatemax = DateTime.Now.AddDays(47);
            var newdatemax2 = DateTime.Now.AddDays(56);
            
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
                var newAppointment = new Appointment()
                {   
                    DuiC = txt_citizenDUI.Text,
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
            
                txt_secondAppointment.Text = dtRan.ToString("dd/MM/yyyy  hh:mm:ss tt");

                //Realiza la insercion de datos en la base
                //Quitar comentarios al realizar el waiting time
                var newAppointment = new Appointment()
                {   
                    DuiC = txt_citizenDUI.Text,
                    IdCabin = randomCavin,
                    AppointmentAddress =  query2,
                    AppointmentDate = dtRan

                };
                db.Add(newAppointment);
                db.SaveChanges();

            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath =  @"C:\Users\USUARIO\Desktop\proyecto-final-grupo2\Proyecto BASES-POO2021\PROGRAMACION ORIENTADA A OBJETOS\PDF\PDFS_SEGUNDA_CITA\";
            FileStream fs = new FileStream(folderPath + txtPdfName.Text + ".pdf", FileMode.Create);
            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f); 
            PdfWriter.GetInstance(pdfDoc, fs);
            pdfDoc.Open();
            
            //Fuente del pdf
            iTextSharp.text.Font StandarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 15,
                iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            
            //Encabezado
            pdfDoc.Add(new Paragraph("Informacion sobre su segunda cita"));
            pdfDoc.Add(Chunk.NEWLINE);

            PdfPTable tabl = new PdfPTable(5);
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
            
            PdfPCell clPriority = new PdfPCell(new Phrase("Prioridad", StandarFont));
            clPriority.BorderWidth = 0;
            clPriority.BorderWidthBottom = 0.75f;
            
            //Se agrega los titulos
            tabl.AddCell(clDUI);
            tabl.AddCell(clAppointmentDate);
            tabl.AddCell(clPlace);
            tabl.AddCell(clCabin);
            tabl.AddCell(clPriority);

            //Llenando columnas
            clDUI = new PdfPCell(new Phrase(txt_citizenDUI.Text, StandarFont));
            clAppointmentDate = new PdfPCell(new Phrase(txt_secondAppointment.Text, StandarFont));
            clPlace = new PdfPCell(new Phrase(txt_Place.Text, StandarFont));
            clCabin = new PdfPCell(new Phrase(txt_cabin.Text, StandarFont));
            clPriority = new PdfPCell(new Phrase(chb_Priority.Checked.ToString(), StandarFont));
            
            tabl.AddCell(clDUI);
            tabl.AddCell(clAppointmentDate);
            tabl.AddCell(clPlace);
            tabl.AddCell(clCabin);
            tabl.AddCell(clPriority);
            
            pdfDoc.Add(tabl);
            pdfDoc.Close();
            fs.Close();
            
            MessageBox.Show("PDF creado y exportado correctamente!", "Gobierno de El Salvador",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPdfName_TextChanged(object sender, EventArgs e)
        {
            if (txtPdfName.Text.Length > 0)
            {
                btnPdfExport.Enabled = true;
            }
            else if (txtPdfName.Text.Length == 0)
            {
                btnPdfExport.Enabled = false;
            }
        }
    }
}