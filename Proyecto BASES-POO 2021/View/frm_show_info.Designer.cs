using System;
using System.ComponentModel;

namespace Proyecto_BASES_POO_2021
{
    partial class frm_show_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_show_info));
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_lugar = new System.Windows.Forms.Label();
            this.lbl_medico = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_lugar = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_siguienteFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_fecha.Location = new System.Drawing.Point(30, 116);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(202, 49);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha y hora:";
            // 
            // lbl_lugar
            // 
            this.lbl_lugar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_lugar.Location = new System.Drawing.Point(30, 185);
            this.lbl_lugar.Name = "lbl_lugar";
            this.lbl_lugar.Size = new System.Drawing.Size(202, 67);
            this.lbl_lugar.TabIndex = 5;
            this.lbl_lugar.Text = "Cabina de vacunación:";
            // 
            // lbl_medico
            // 
            this.lbl_medico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_medico.Location = new System.Drawing.Point(80, 34);
            this.lbl_medico.Name = "lbl_medico";
            this.lbl_medico.Size = new System.Drawing.Size(321, 49);
            this.lbl_medico.TabIndex = 6;
            this.lbl_medico.Text = "Centro Médico";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_aceptar.Location = new System.Drawing.Point(328, 295);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(127, 34);
            this.btn_aceptar.TabIndex = 11;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(238, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(238, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(578, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Convertir a PDF";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_lugar
            // 
            this.txt_lugar.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_lugar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_lugar.Location = new System.Drawing.Point(298, 209);
            this.txt_lugar.Name = "txt_lugar";
            this.txt_lugar.ReadOnly = true;
            this.txt_lugar.Size = new System.Drawing.Size(189, 22);
            this.txt_lugar.TabIndex = 17;
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_fecha.Location = new System.Drawing.Point(298, 126);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(189, 22);
            this.txt_fecha.TabIndex = 18;
            // 
            // txt_siguienteFecha
            // 
            this.txt_siguienteFecha.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_siguienteFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_siguienteFecha.Location = new System.Drawing.Point(550, 126);
            this.txt_siguienteFecha.Name = "txt_siguienteFecha";
            this.txt_siguienteFecha.ReadOnly = true;
            this.txt_siguienteFecha.Size = new System.Drawing.Size(189, 22);
            this.txt_siguienteFecha.TabIndex = 19;
            // 
            // frm_show_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 399);
            this.Controls.Add(this.txt_siguienteFecha);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_lugar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_medico);
            this.Controls.Add(this.lbl_lugar);
            this.Controls.Add(this.lbl_fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_show_info";
            this.Text = "Información Cita";
            this.Load += new System.EventHandler(this.frm_show_info_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_siguienteFecha;

        private System.Windows.Forms.TextBox txt_fecha;

        private System.Windows.Forms.TextBox textBox1;


        private System.Windows.Forms.TextBox txt_lugar;

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btn_aceptar;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label lbl_medico;

        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_lugar;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}