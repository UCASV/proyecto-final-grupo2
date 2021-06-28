using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_vaccinationProcess : Form
    {
        public frm_vaccinationProcess(string a, int rows)
        {
            InitializeComponent();
            this.txtPatientProcess.Text = a;
            //recibe las filas de el dgv para saber cuantas citas 
            this.txtAppointmentCount.Text = rows.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpFirstDateVaccine.Value = DateTime.Now;
        }

        private void btnVolver_vaccine_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnacceptarVaccine_Click(object sender, EventArgs e)
        {
            var db = new PROJECT_BD_POOContext();
            var query = (from a in db.CitizenForms
                where a.DuiC == txtPatientProcess.Text
                select a).FirstOrDefault();
            //llenar los efectos secundarios de la vacuna en el usuario
            query.VaccineDate = dtpFirstDateVaccine.Value;
            //mensaje mostrado cuando se registran los datos del proceso de vacunación del ciudadano correctamente 
            //También puede quedar vacio
            MessageBox.Show("Se ha registrado todo con exito", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //guardamos los cambios en la base de datos
            db.SaveChanges();
            this.Hide();
        }
        
        private void frm_vaccinationProcess_Load(object sender, EventArgs e)
        {
            btn_second.Enabled = true;
        }

        private void btn_second_Click(object sender, EventArgs e)
        {
            //Verifica que el usuario no pueda realizar más de dos citas 
            int rowss = Convert.ToInt16(txtAppointmentCount.Text);
            if ( rowss > 1)
            {
                MessageBox.Show("El ciudadano ya realizo sus dos citas, no es posible crear otra cita", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_second.Enabled = false;
            }
            else
            {
                btn_second.Enabled = false;
                this.Hide();
                frm_secondVaccine secondvaccine = new frm_secondVaccine(txtPatientProcess.Text);
                secondvaccine.ShowDialog();
                this.Show();
            }
        }
    }
}