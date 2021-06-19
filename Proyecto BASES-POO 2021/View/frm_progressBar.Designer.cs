using System.ComponentModel;

namespace Proyecto_BASES_POO_2021
{
    partial class frm_progressBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_progressBar));
            this.pgb_load = new System.Windows.Forms.ProgressBar();
            this.tm_progressBar = new System.Timers.Timer();
            this.lbl_charge = new System.Windows.Forms.Label();
            this.lbl_loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.tm_progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb_load
            // 
            this.pgb_load.Location = new System.Drawing.Point(2, 209);
            this.pgb_load.Name = "pgb_load";
            this.pgb_load.Size = new System.Drawing.Size(427, 11);
            this.pgb_load.TabIndex = 0;
            // 
            // tm_progressBar
            // 
            this.tm_progressBar.Enabled = true;
            this.tm_progressBar.Interval = 20D;
            this.tm_progressBar.SynchronizingObject = this;
            this.tm_progressBar.Elapsed += new System.Timers.ElapsedEventHandler(this.tm_progressBar_Elapsed);
            // 
            // lbl_charge
            // 
            this.lbl_charge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_charge.ForeColor = System.Drawing.Color.White;
            this.lbl_charge.Location = new System.Drawing.Point(323, 191);
            this.lbl_charge.Name = "lbl_charge";
            this.lbl_charge.Size = new System.Drawing.Size(68, 15);
            this.lbl_charge.TabIndex = 1;
            this.lbl_charge.Text = "Cargando...";
            // 
            // lbl_loading
            // 
            this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loading.ForeColor = System.Drawing.Color.White;
            this.lbl_loading.Location = new System.Drawing.Point(384, 189);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(36, 17);
            this.lbl_loading.TabIndex = 2;
            // 
            // frm_progressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 223);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.lbl_charge);
            this.Controls.Add(this.pgb_load);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_progressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando Sistema";
            ((System.ComponentModel.ISupportInitialize) (this.tm_progressBar)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Label lbl_charge;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ProgressBar pgb_load;

        private System.Timers.Timer tm_progressBar;


        #endregion
    }
}