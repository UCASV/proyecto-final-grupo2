using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void txt_Usuario_Click(object sender, EventArgs e)
        {
            txt_Usuario.Clear();
        }

        private void txt_Contraseña_Click(object sender, EventArgs e)
        {
            txt_Contraseña.Clear();
            txt_Contraseña.PasswordChar = '•';
        }
        
        private void botonIniciarS_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text;
            string contraseña = txt_Contraseña.Text;
            var db = new PROJECT_BD_POOContext();
            var listaUsuarios = db.Managers
                .OrderBy(c => c.IdManager)
                .ToList();

            var result = listaUsuarios.Where(u =>
                    u.UserM.Equals(txt_Usuario.Text) && 
                    u.Psw.Equals(txt_Contraseña.Text))
                .ToList();

            if (result.Count == 0)
                MessageBox.Show("El usuario no existe", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                MessageBox.Show("Bienvenido", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 
                frm_mainMenu windowsSingIn = new frm_mainMenu();
               windowsSingIn.Show();
               this.Hide();
            }
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}