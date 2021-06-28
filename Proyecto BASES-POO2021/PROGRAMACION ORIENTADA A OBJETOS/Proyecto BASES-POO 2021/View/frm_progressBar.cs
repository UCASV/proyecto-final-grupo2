using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Resources.Extensions;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_progressBar : Form
    {
        public frm_progressBar()
        {
            InitializeComponent();
        }

        public void progress()
        {
            pgb_load.ForeColor = Color.DarkCyan;
            pgb_load.Increment(1);
            lbl_loading.Text = pgb_load.Value.ToString() + "%";
            if (pgb_load.Value==pgb_load.Maximum)
            {
                tm_progressBar.Stop();
                this.Hide();
                frm_Login principal = new frm_Login();
                principal.ShowDialog();
            }
        }


        private void tm_progressBar_Elapsed(object sender, ElapsedEventArgs e)
        {
            progress();
        }
    }
}