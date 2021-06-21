using System;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_appointment_tracking : Form
    {
        public frm_appointment_tracking()
        {
            InitializeComponent();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}