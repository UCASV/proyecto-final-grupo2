using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;
using Proyecto_BASES_POO_2021.viewModels;

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
            var result = listaUsuarios.Where(u =>
                    u.DuiC == maskedTextBox1.Text) 
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
                    foreach (var item in citizen.Where(i => i.DuiC == maskedTextBox1.Text ))
                    {
                        mappedDSs.Add(ProjectMapper.MapCitizenFormVm(item));
                    }
                    dgvAppointment.DataSource = mappedDSs;
                    
                    //Llena el primer dgv
                    var appointmentss = db.Appointments.ToList();
                    var mappedDSss = new List<AppointmentVm>();
                    foreach (var items in appointmentss.Where(i => i.DuiC == maskedTextBox1.Text ))
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
                    u.DuiC == maskedTextBox1.Text)
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
                //Cuenta las filas que hay en el dgv para pasarlas al otro form
                var rows = dgvAppointment2.RowCount;
                    this.Hide();
                    frm_vaccinationProcess vaccinationProcesss = new frm_vaccinationProcess(maskedTextBox1.Text, rows);
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


    }
}