using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_vaccinationProcess : Form
    {
        public frm_vaccinationProcess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpFirstDateVaccine.Value = DateTime.UtcNow;
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
            query.SideEffects = txtSideEfeccts.Text;
            MessageBox.Show("Enfermedad/es registrada/s", "Gobierno de El Salvador",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
        }
    }
}