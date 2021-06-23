using System.ComponentModel;

namespace Proyecto_BASES_POO_2021
{
    partial class frm_vaccinationProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vaccinationProcess));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSideEfeccts = new System.Windows.Forms.TextBox();
            this.txtPatientProcess = new System.Windows.Forms.TextBox();
            this.lblSide_effects = new System.Windows.Forms.Label();
            this.lblPatientProcess = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnacceptarVaccine = new System.Windows.Forms.Button();
            this.lblDateVaccine = new System.Windows.Forms.Label();
            this.dtpFirstDateVaccine = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVolver_vaccine = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (1)))), ((int) (((byte) (147)))), ((int) (((byte) (204)))));
            this.panel2.Controls.Add(this.txtSideEfeccts);
            this.panel2.Controls.Add(this.txtPatientProcess);
            this.panel2.Location = new System.Drawing.Point(166, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 263);
            this.panel2.TabIndex = 1;
            // 
            // txtSideEfeccts
            // 
            this.txtSideEfeccts.Location = new System.Drawing.Point(23, 75);
            this.txtSideEfeccts.Multiline = true;
            this.txtSideEfeccts.Name = "txtSideEfeccts";
            this.txtSideEfeccts.Size = new System.Drawing.Size(331, 152);
            this.txtSideEfeccts.TabIndex = 3;
            // 
            // txtPatientProcess
            // 
            this.txtPatientProcess.Enabled = false;
            this.txtPatientProcess.Location = new System.Drawing.Point(23, 29);
            this.txtPatientProcess.Name = "txtPatientProcess";
            this.txtPatientProcess.Size = new System.Drawing.Size(172, 26);
            this.txtPatientProcess.TabIndex = 0;
            // 
            // lblSide_effects
            // 
            this.lblSide_effects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSide_effects.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSide_effects.Location = new System.Drawing.Point(12, 77);
            this.lblSide_effects.Name = "lblSide_effects";
            this.lblSide_effects.Size = new System.Drawing.Size(148, 63);
            this.lblSide_effects.TabIndex = 2;
            this.lblSide_effects.Text = "Efectos secundarios:";
            // 
            // lblPatientProcess
            // 
            this.lblPatientProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPatientProcess.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPatientProcess.Location = new System.Drawing.Point(12, 26);
            this.lblPatientProcess.Name = "lblPatientProcess";
            this.lblPatientProcess.Size = new System.Drawing.Size(119, 31);
            this.lblPatientProcess.TabIndex = 1;
            this.lblPatientProcess.Text = "Paciente:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 349);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (1)))), ((int) (((byte) (102)))), ((int) (((byte) (180)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnacceptarVaccine);
            this.panel3.Controls.Add(this.lblDateVaccine);
            this.panel3.Controls.Add(this.dtpFirstDateVaccine);
            this.panel3.Location = new System.Drawing.Point(526, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 263);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (132)))), ((int) (((byte) (165)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(29, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Obtener fecha y hora actual";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnacceptarVaccine
            // 
            this.btnacceptarVaccine.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (132)))), ((int) (((byte) (165)))));
            this.btnacceptarVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnacceptarVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnacceptarVaccine.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnacceptarVaccine.Location = new System.Drawing.Point(269, 212);
            this.btnacceptarVaccine.Name = "btnacceptarVaccine";
            this.btnacceptarVaccine.Size = new System.Drawing.Size(128, 43);
            this.btnacceptarVaccine.TabIndex = 16;
            this.btnacceptarVaccine.Text = "Enviar";
            this.btnacceptarVaccine.UseVisualStyleBackColor = false;
            this.btnacceptarVaccine.Click += new System.EventHandler(this.btnacceptarVaccine_Click);
            // 
            // lblDateVaccine
            // 
            this.lblDateVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDateVaccine.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDateVaccine.Location = new System.Drawing.Point(29, 24);
            this.lblDateVaccine.Name = "lblDateVaccine";
            this.lblDateVaccine.Size = new System.Drawing.Size(320, 56);
            this.lblDateVaccine.TabIndex = 2;
            this.lblDateVaccine.Text = "Fecha de aplicacion de la vacuna:";
            // 
            // dtpFirstDateVaccine
            // 
            this.dtpFirstDateVaccine.Location = new System.Drawing.Point(29, 83);
            this.dtpFirstDateVaccine.Name = "dtpFirstDateVaccine";
            this.dtpFirstDateVaccine.Size = new System.Drawing.Size(320, 26);
            this.dtpFirstDateVaccine.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (146)))), ((int) (((byte) (213)))));
            this.panel4.Controls.Add(this.btnVolver_vaccine);
            this.panel4.Controls.Add(this.lblPatientProcess);
            this.panel4.Controls.Add(this.lblSide_effects);
            this.panel4.Location = new System.Drawing.Point(0, 349);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 263);
            this.panel4.TabIndex = 4;
            // 
            // btnVolver_vaccine
            // 
            this.btnVolver_vaccine.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (132)))), ((int) (((byte) (165)))));
            this.btnVolver_vaccine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver_vaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVolver_vaccine.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver_vaccine.Location = new System.Drawing.Point(12, 214);
            this.btnVolver_vaccine.Name = "btnVolver_vaccine";
            this.btnVolver_vaccine.Size = new System.Drawing.Size(128, 43);
            this.btnVolver_vaccine.TabIndex = 15;
            this.btnVolver_vaccine.Text = "Volver";
            this.btnVolver_vaccine.UseVisualStyleBackColor = false;
            this.btnVolver_vaccine.Click += new System.EventHandler(this.btnVolver_vaccine_Click);
            // 
            // frm_vaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(935, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_vaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_vaccinationProcess";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnVolver_vaccine;
        private System.Windows.Forms.Button btnacceptarVaccine;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DateTimePicker dtpFirstDateVaccine;
        private System.Windows.Forms.Label lblDateVaccine;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox txtSideEfeccts;

        private System.Windows.Forms.Label lblPatientProcess;
        private System.Windows.Forms.TextBox txtPatientProcess;

        
        private System.Windows.Forms.Label lblSide_effects;

        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}