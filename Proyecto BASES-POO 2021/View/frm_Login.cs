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
            var db = new PROJECT_BD_POOContext();

           List<Cabin> cabinn = db.Cabins.ToList();
           cmbCabinLog.DataSource = null;
           cmbCabinLog.DataSource = cabinn;
           cmbCabinLog.ValueMember = "IdCabin";
           cmbCabinLog.DisplayMember = "IdCabin";
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
            //Creando una lista de los managers en la bd
            var listaUsuarios = db.Managers
                .OrderBy(c => c.IdManager)
                .ToList();
            
            //buscando que en la base de datos se encuentre el manager que quiere ingresar al sistema
            var result = listaUsuarios.Where(u =>
                    u.UserM.Equals(txt_Usuario.Text) && 
                    u.Psw.Equals(txt_Contraseña.Text))
                .ToList();
            
            //Obteniendo el id exacto del manager que quiere entrar al sistema
            var query = (from a in db.Managers
                where a.UserM == txt_Usuario.Text
                select a.IdManager).FirstOrDefault();  
            
            //Con el id obtenido se busca su numero de cabina
            var query2 = (from a in db.Cabins
                where a.IdManager == query
                select a.IdCabin).FirstOrDefault();
            
            //Si el resultado no existe en la base o estan mal escritas las entradas, se le notificara del error al gestor
            if (result.Count == 0)
            {
                MessageBox.Show("El usuario no existe o\n su usuario y/o contraseña estan mal escritas \n por favor comprubelos nuevamente", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si el usuario si existe y la cabina que selecciono es igual a la asignada en la base, se procede a entrar al menu principal
            else if (query2.Equals(cmbCabinLog.SelectedIndex+1))
            {
                MessageBox.Show("Bienvenido", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Se guarda los datos de inicio de sesion del gestor y la fecha y hora exactas en la que entro
                var newSingIn = new SessionU
                {   
                    IdCabin = query2 ,
                    IdManager = query, 
                    SessionDate = DateTime.Now
                };
                db.Add(newSingIn);
                db.SaveChanges();
                //se llama al nuevo formulario del menu principal 
               frm_mainMenu windowsSingIn = new frm_mainMenu();
               windowsSingIn.Show();
               this.Hide();
               
            }
            else
            {
                MessageBox.Show("Esta intentado entrar en una cabina que no es suya", "Gobierno de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}