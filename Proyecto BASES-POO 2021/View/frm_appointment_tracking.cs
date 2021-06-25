using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;
using Proyecto_BASES_POO_2021.viewModels;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_appointment_tracking : Form
    {   
        private bool showFromDBB = false;
        public frm_appointment_tracking()
        {
            InitializeComponent();
            
        }

        private void dataview()
        {
            
            var db = new PROJECT_BD_POOContext();
            var listaUsuarios = db.CitizenForms
                .OrderBy(c => c.DuiC)
                .ToList();
            //Verifica que exista el dui buscado en la base
            var result = listaUsuarios.Where(u =>
                    u.DuiC == mskDuitTracking.Text) 
                .ToList();
            if (result.Count == 0)
            {
                MessageBox.Show("El ciudadano no existe, por favor, proceda a realizar una cita", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!showFromDBB)
                {   
                    //Llena el primer dgv
                    var citizen = db.CitizenForms.ToList();
                    var mappedDSs = new List<CitizenFormVm>();
                    foreach (var item in citizen.Where(i => i.DuiC == mskDuitTracking.Text ))
                    {
                        mappedDSs.Add(ProjectMapper.MapCitizenFormVm(item));
                    }
                    dgvAppointment.DataSource = mappedDSs;
                    
                    //Llena el primer dgv
                    var appointmentss = db.Appointments.ToList();
                    var mappedDSss = new List<AppointmentVm>();
                    foreach (var items in appointmentss.Where(i => i.DuiC == mskDuitTracking.Text ))
                    {
                        mappedDSss.Add(ProjectMapper.MapAppointmentVm(items));
                    }
                    dgvAppointment2.DataSource = mappedDSss;
                } 
            }
            

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
           
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dataview();
        }

        private void btn_proceso_Click(object sender, EventArgs e)
        {   
            
            //Proceso de verificar si el ciudadano existe en la base 
            var db = new PROJECT_BD_POOContext();
            var listaUsuarios = db.CitizenForms
                .OrderBy(c => c.DuiC)
                .ToList();
            var result = listaUsuarios.Where(u =>
                    u.DuiC == mskDuitTracking.Text)
                .ToList();
            //si el resultado es nulo muestra un mensaje de error
            if (result.Count == 0)
            {
                MessageBox.Show("El ciudadano no existe, por favor, proceda a realizar una cita",
                    "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radSiC.Checked == false || radNoC2.Checked == true)
            {
                //Si el ciudadano no da su consentimiento no inicia el proceso de vacunación 
                MessageBox.Show("No se puede seguir el procesos sin el consentimiento del ciudadano", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //obteniendo fecha de la cita
                //cuando ya tiene dos citas se evalua que el día de la cita corresponda con el actual
                //para poder seleccionarla cita correcta
                var appointmentdate = (from a in db.Appointments
                    where a.DuiC ==  mskDuitTracking.Text && a.AppointmentDate.Day == DateTime.Now.Day
                    select a.AppointmentDate).FirstOrDefault();

                var newdate = DateTime.Now;
                var time = (newdate - appointmentdate).ToString(@"dd\d\ hh\h\ mm\m\ ");
                
                var querytime = (from a in db.Appointments
                    where a.DuiC == mskDuitTracking.Text && a.AppointmentDate.Day == DateTime.Now.Day
                    select a).FirstOrDefault();
                //Actualiza el tiempo esperado en la cita
                querytime.WaitingTime = time;  
                db.SaveChanges();
                
                //Cuenta las filas que hay en el dgv para pasarlas al otro form
                var rows = dgvAppointment2.RowCount;
                    this.Hide();
                    frm_vaccinationProcess vaccinationProcesss = new frm_vaccinationProcess(mskDuitTracking.Text, rows);
                    vaccinationProcesss.ShowDialog();
                    this.Show();
            }
        }

        private void btn_citaTracker_Click(object sender, EventArgs e)
        {   
            //Lleva al formulario para iniciar el proceso de realizar cita
            this.Hide();
            frm_citizen windowsSingIn = new frm_citizen();
            windowsSingIn.ShowDialog();
            this.Show();
        }


        private void frm_appointment_tracking_Load(object sender, EventArgs e)
        {

        }

        private void btn_pdf_citas_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgvAppointment2.ColumnCount);
            //Adding Header row
            foreach (DataGridViewColumn column in dgvAppointment2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgvAppointment2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
 
            //Exporting to PDF
            string folderPath = @"C:\Users\USUARIO\Desktop\ProyectoBDPOO\PDFAppointment";
            
            using (FileStream stream = new FileStream(folderPath + "Info.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                MessageBox.Show("PDF exportado correctamente!", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
}
