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
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.text_place = new System.Windows.Forms.TextBox();
            this.txtidcabin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txtDuiShow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPriority = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtPdfAppointmentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_fecha.Location = new System.Drawing.Point(46, 168);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(236, 62);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha y hora:";
            // 
            // lbl_lugar
            // 
            this.lbl_lugar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_lugar.Location = new System.Drawing.Point(46, 255);
            this.lbl_lugar.Name = "lbl_lugar";
            this.lbl_lugar.Size = new System.Drawing.Size(226, 88);
            this.lbl_lugar.TabIndex = 5;
            this.lbl_lugar.Text = "Lugar de vacunación:";
            // 
            // lbl_medico
            // 
            this.lbl_medico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_medico.Location = new System.Drawing.Point(93, 9);
            this.lbl_medico.Name = "lbl_medico";
            this.lbl_medico.Size = new System.Drawing.Size(418, 72);
            this.lbl_medico.TabIndex = 6;
            this.lbl_medico.Text = "Centro Médico";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_aceptar.Location = new System.Drawing.Point(12, 485);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(142, 42);
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
            this.pictureBox1.Location = new System.Drawing.Point(712, 485);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 168);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(280, 268);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExportPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExportPdf.Location = new System.Drawing.Point(772, 485);
            this.btnExportPdf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(152, 42);
            this.btnExportPdf.TabIndex = 15;
            this.btnExportPdf.Text = "Convertir a PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_place
            // 
            this.text_place.Enabled = false;
            this.text_place.Location = new System.Drawing.Point(346, 255);
            this.text_place.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_place.Multiline = true;
            this.text_place.Name = "text_place";
            this.text_place.Size = new System.Drawing.Size(242, 64);
            this.text_place.TabIndex = 18;
            // 
            // txtidcabin
            // 
            this.txtidcabin.Enabled = false;
            this.txtidcabin.Location = new System.Drawing.Point(346, 375);
            this.txtidcabin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidcabin.Name = "txtidcabin";
            this.txtidcabin.Size = new System.Drawing.Size(241, 26);
            this.txtidcabin.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(46, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cabina:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(280, 365);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // txt_date
            // 
            this.txt_date.Enabled = false;
            this.txt_date.Location = new System.Drawing.Point(346, 178);
            this.txt_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(241, 26);
            this.txt_date.TabIndex = 22;
            // 
            // txtDuiShow
            // 
            this.txtDuiShow.Enabled = false;
            this.txtDuiShow.Location = new System.Drawing.Point(346, 98);
            this.txtDuiShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuiShow.Name = "txtDuiShow";
            this.txtDuiShow.Size = new System.Drawing.Size(241, 26);
            this.txtDuiShow.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 38);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dui:";
            // 
            // chkPriority
            // 
            this.chkPriority.BackColor = System.Drawing.Color.Transparent;
            this.chkPriority.Enabled = false;
            this.chkPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chkPriority.Location = new System.Drawing.Point(603, 375);
            this.chkPriority.Name = "chkPriority";
            this.chkPriority.Size = new System.Drawing.Size(124, 29);
            this.chkPriority.TabIndex = 25;
            this.chkPriority.Text = "Prioridad";
            this.chkPriority.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(280, 86);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // txtPdfAppointmentName
            // 
            this.txtPdfAppointmentName.Location = new System.Drawing.Point(712, 449);
            this.txtPdfAppointmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPdfAppointmentName.Name = "txtPdfAppointmentName";
            this.txtPdfAppointmentName.Size = new System.Drawing.Size(211, 26);
            this.txtPdfAppointmentName.TabIndex = 27;
            this.txtPdfAppointmentName.TextChanged += new System.EventHandler(this.txtPdfAppointmentName_TextChanged);
            // 
            // frm_show_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 542);
            this.Controls.Add(this.txtPdfAppointmentName);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.chkPriority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuiShow);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidcabin);
            this.Controls.Add(this.text_place);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_medico);
            this.Controls.Add(this.lbl_lugar);
            this.Controls.Add(this.lbl_fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_show_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Cita";
            this.Load += new System.EventHandler(this.frm_show_info_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPdfAppointmentName;

        private System.Windows.Forms.Button btnExportPdf;

        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.CheckBox chkPriority;

        private System.Windows.Forms.TextBox txtDuiShow;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtidcabin;

        private System.Windows.Forms.TextBox text_place;

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txt_date;


        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btn_aceptar;

        private System.Windows.Forms.Label lbl_medico;

        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_lugar;

        #endregion
    }
}