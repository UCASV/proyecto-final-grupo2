using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_vaccinationProcess : Form
    {
        public frm_vaccinationProcess(string a)
        {
            InitializeComponent();
            this.txtPatientProcess.Text = a;
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
            query.SideEffects = txtSideEfeccts.Text;
            //mensaje mostrado cuando se registran los datos del proceso de vacunación del ciudadano correctamente 
            //También puede quedar vacio
            MessageBox.Show("Se ha registrado todo con exito", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
            this.Hide();

        }
    }
}