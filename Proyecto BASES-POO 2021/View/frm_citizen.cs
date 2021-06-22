using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_citizen : Form
    {
        public frm_citizen()
        {
            InitializeComponent();
        }

        private void btnVolver_ctzn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frm_citizen_Load(object sender, EventArgs e)
        {
           
            //Poblamos la comboBox
            var db = new PROJECT_BD_POOContext();     
                
            List<Institution> institutionn = db.Institutions.ToList();
            
            cmbInstitution.DataSource = null;
            cmbInstitution.DataSource = institutionn;
            cmbInstitution.ValueMember = "IdInstitution";
            cmbInstitution.DisplayMember = "InstitutionName";
            
        }
        

        private void btn_enviar_ctzn_Click(object sender, EventArgs e)
        {
            bool verification = msktxt_dui_ctzn.Text.Length > 8 &&
                                txtNombre_ctzn.Text.Length > 2 &&
                                msktxt_phone_ctzn.Text.Length > 8 &&
                                txtAdress_ctzn.Text.Length > 5 &&
                                txtEmail_ctzn.Text.Length > 5;

            bool verification2 = radSi1.Checked == true ||
                                 radSi2.Checked == true ||
                                 radSi3.Checked == true ||
                                 radSi4.Checked == true;
            
           
            if (verification)
            {
                var db = new PROJECT_BD_POOContext();
                Institution I = (Institution) cmbInstitution.SelectedItem;
                Institution ci = db.Set<Institution>()
                    .SingleOrDefault(c => c.IdInstitution == I.IdInstitution);
                //Verificacion para saber si la persona es de prioridad o no
                var priority = true;   
                       
                if (verification2)
                    priority = true;
                else
                    priority = false;
               
                var newCitizen = new CitizenForm{
                
                DuiC = msktxt_dui_ctzn.Text,
                FirstVaccineDate = DateTime.Now,
                CitizenName = txtNombre_ctzn.Text,
                CitizenAddress = txtAdress_ctzn.Text,
                Telephone = msktxt_phone_ctzn.Text,
                CitizenEmail = txtEmail_ctzn.Text,
                IdInstitution = cmbInstitution.SelectedIndex + 1,
                PriorityGroup = priority
                };
                db.Add(newCitizen);
                db.SaveChanges();

                MessageBox.Show("Ciudadadno registrado exitosamente!", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrio un error!", "Gobierno de El Salvador",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Hide();
                        
            }

        }
        
    }
}
