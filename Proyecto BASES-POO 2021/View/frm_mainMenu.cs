using System;
using System.Windows.Forms;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_mainMenu : Form
    {
        public frm_mainMenu()
        {
            InitializeComponent();
            
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {   
            this.Hide();
            frm_citizen windowsSingIn = new frm_citizen();
            windowsSingIn.ShowDialog();
            this.Show();
            
        }

        private void realizarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_citizen windowsSingIn = new frm_citizen();
            windowsSingIn.ShowDialog();
            this.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_vaccinationProcess vaccinationProcesss = new frm_vaccinationProcess();
            vaccinationProcesss.ShowDialog();
            this.Show(); 
        }

        private void procesoDeVacunaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_vaccinationProcess vaccinationProcesss = new frm_vaccinationProcess();
            vaccinationProcesss.ShowDialog();
            this.Show(); 
        }

        private void btnAppointmentFollow_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_appointment_tracking windowappointment = new frm_appointment_tracking();
            windowappointment.ShowDialog();
            this.Show(); 
        }

        private void btnEmployeeInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_EmployeeInfo windowEmployeeInfo = new frm_EmployeeInfo();
            windowEmployeeInfo.ShowDialog();
            this.Show(); 
        }

        private void registroDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_appointment_tracking windowappointment = new frm_appointment_tracking();
            windowappointment.ShowDialog();
            this.Show(); 
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_EmployeeInfo windowEmployeeInfo = new frm_EmployeeInfo();
            windowEmployeeInfo.ShowDialog();
            this.Show(); 
        }
    }
}