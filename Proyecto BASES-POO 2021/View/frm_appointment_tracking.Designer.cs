using System.ComponentModel;

namespace Proyecto_BASES_POO_2021
{
    partial class frm_appointment_tracking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_appointment_tracking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.lbl_dui = new System.Windows.Forms.TextBox();
            this.mskDuitTracking = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_citas = new System.Windows.Forms.TextBox();
            this.btn_pdf_citas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_proceso = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_citaTracker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpC = new System.Windows.Forms.GroupBox();
            this.radNoC2 = new System.Windows.Forms.RadioButton();
            this.radSiC = new System.Windows.Forms.RadioButton();
            this.dgvAppointment2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pdfName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            this.grpC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_buscar.Location = new System.Drawing.Point(61, 84);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(144, 31);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(8, 386);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 37);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (97)))), ((int) (((byte) (124)))), ((int) (((byte) (131)))));
            this.dgvAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.EnableHeadersVisualStyles = false;
            this.dgvAppointment.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgvAppointment.Location = new System.Drawing.Point(0, 146);
            this.dgvAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (97)))), ((int) (((byte) (124)))), ((int) (((byte) (131)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointment.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointment.RowTemplate.Height = 24;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(833, 67);
            this.dgvAppointment.TabIndex = 3;
            // 
            // lbl_dui
            // 
            this.lbl_dui.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_dui.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_dui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_dui.ForeColor = System.Drawing.Color.Black;
            this.lbl_dui.Location = new System.Drawing.Point(215, 77);
            this.lbl_dui.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_dui.Name = "lbl_dui";
            this.lbl_dui.ReadOnly = true;
            this.lbl_dui.Size = new System.Drawing.Size(126, 23);
            this.lbl_dui.TabIndex = 4;
            this.lbl_dui.Text = "Ingrese su dui:";
            this.lbl_dui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskDuitTracking
            // 
            this.mskDuitTracking.Location = new System.Drawing.Point(215, 103);
            this.mskDuitTracking.Margin = new System.Windows.Forms.Padding(2);
            this.mskDuitTracking.Mask = "00000000-0";
            this.mskDuitTracking.Name = "mskDuitTracking";
            this.mskDuitTracking.Size = new System.Drawing.Size(126, 20);
            this.mskDuitTracking.TabIndex = 5;
            this.mskDuitTracking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 84);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_citas
            // 
            this.txt_citas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_citas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_citas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_citas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_citas.ForeColor = System.Drawing.Color.White;
            this.txt_citas.Location = new System.Drawing.Point(325, 21);
            this.txt_citas.Margin = new System.Windows.Forms.Padding(2);
            this.txt_citas.Name = "txt_citas";
            this.txt_citas.ReadOnly = true;
            this.txt_citas.Size = new System.Drawing.Size(225, 25);
            this.txt_citas.TabIndex = 8;
            this.txt_citas.Text = "Seguimiento de citas";
            this.txt_citas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_pdf_citas
            // 
            this.btn_pdf_citas.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_pdf_citas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pdf_citas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_pdf_citas.ForeColor = System.Drawing.Color.Black;
            this.btn_pdf_citas.Location = new System.Drawing.Point(702, 386);
            this.btn_pdf_citas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pdf_citas.Name = "btn_pdf_citas";
            this.btn_pdf_citas.Size = new System.Drawing.Size(119, 37);
            this.btn_pdf_citas.TabIndex = 9;
            this.btn_pdf_citas.Text = "Exportar a PDF";
            this.btn_pdf_citas.UseVisualStyleBackColor = false;
            this.btn_pdf_citas.Click += new System.EventHandler(this.btn_pdf_citas_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(665, 391);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btn_proceso
            // 
            this.btn_proceso.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_proceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_proceso.ForeColor = System.Drawing.Color.Black;
            this.btn_proceso.Location = new System.Drawing.Point(375, 382);
            this.btn_proceso.Margin = new System.Windows.Forms.Padding(2);
            this.btn_proceso.Name = "btn_proceso";
            this.btn_proceso.Size = new System.Drawing.Size(124, 42);
            this.btn_proceso.TabIndex = 12;
            this.btn_proceso.Text = "Ir a proceso de vacunación";
            this.btn_proceso.UseVisualStyleBackColor = false;
            this.btn_proceso.Click += new System.EventHandler(this.btn_proceso_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(337, 386);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // btn_citaTracker
            // 
            this.btn_citaTracker.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_citaTracker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_citaTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_citaTracker.ForeColor = System.Drawing.Color.Black;
            this.btn_citaTracker.Location = new System.Drawing.Point(687, 80);
            this.btn_citaTracker.Margin = new System.Windows.Forms.Padding(2);
            this.btn_citaTracker.Name = "btn_citaTracker";
            this.btn_citaTracker.Size = new System.Drawing.Size(137, 40);
            this.btn_citaTracker.TabIndex = 14;
            this.btn_citaTracker.Text = "Registrar cita";
            this.btn_citaTracker.UseVisualStyleBackColor = false;
            this.btn_citaTracker.Click += new System.EventHandler(this.btn_citaTracker_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Consentimiento:";
            // 
            // grpC
            // 
            this.grpC.Controls.Add(this.radNoC2);
            this.grpC.Controls.Add(this.radSiC);
            this.grpC.Controls.Add(this.label1);
            this.grpC.Location = new System.Drawing.Point(5, 318);
            this.grpC.Margin = new System.Windows.Forms.Padding(2);
            this.grpC.Name = "grpC";
            this.grpC.Padding = new System.Windows.Forms.Padding(2);
            this.grpC.Size = new System.Drawing.Size(354, 45);
            this.grpC.TabIndex = 16;
            this.grpC.TabStop = false;
            // 
            // radNoC2
            // 
            this.radNoC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radNoC2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radNoC2.Location = new System.Drawing.Point(226, 11);
            this.radNoC2.Margin = new System.Windows.Forms.Padding(2);
            this.radNoC2.Name = "radNoC2";
            this.radNoC2.Size = new System.Drawing.Size(110, 30);
            this.radNoC2.TabIndex = 17;
            this.radNoC2.TabStop = true;
            this.radNoC2.Text = "No acepto";
            this.radNoC2.UseVisualStyleBackColor = true;
            // 
            // radSiC
            // 
            this.radSiC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radSiC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radSiC.Location = new System.Drawing.Point(141, 12);
            this.radSiC.Margin = new System.Windows.Forms.Padding(2);
            this.radSiC.Name = "radSiC";
            this.radSiC.Size = new System.Drawing.Size(69, 29);
            this.radSiC.TabIndex = 16;
            this.radSiC.TabStop = true;
            this.radSiC.Text = "Acepto";
            this.radSiC.UseVisualStyleBackColor = true;
            // 
            // dgvAppointment2
            // 
            this.dgvAppointment2.AllowUserToAddRows = false;
            this.dgvAppointment2.AllowUserToDeleteRows = false;
            this.dgvAppointment2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointment2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment2.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (97)))), ((int) (((byte) (124)))), ((int) (((byte) (131)))));
            this.dgvAppointment2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointment2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvAppointment2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointment2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment2.EnableHeadersVisualStyles = false;
            this.dgvAppointment2.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgvAppointment2.Location = new System.Drawing.Point(0, 224);
            this.dgvAppointment2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointment2.Name = "dgvAppointment2";
            this.dgvAppointment2.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (97)))), ((int) (((byte) (124)))), ((int) (((byte) (131)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointment2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppointment2.RowTemplate.Height = 24;
            this.dgvAppointment2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment2.Size = new System.Drawing.Size(833, 75);
            this.dgvAppointment2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(637, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre del PDF:";
            // 
            // txt_pdfName
            // 
            this.txt_pdfName.Location = new System.Drawing.Point(704, 355);
            this.txt_pdfName.Name = "txt_pdfName";
            this.txt_pdfName.Size = new System.Drawing.Size(116, 20);
            this.txt_pdfName.TabIndex = 19;
            this.txt_pdfName.TextChanged += new System.EventHandler(this.txt_pdfName_TextChanged);
            // 
            // frm_appointment_tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(832, 431);
            this.Controls.Add(this.txt_pdfName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAppointment2);
            this.Controls.Add(this.grpC);
            this.Controls.Add(this.btn_citaTracker);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_proceso);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_pdf_citas);
            this.Controls.Add(this.txt_citas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mskDuitTracking);
            this.Controls.Add(this.lbl_dui);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_appointment_tracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguimiento de citas y cola de espera";
            this.Load += new System.EventHandler(this.frm_appointment_tracking_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            this.grpC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_pdfName;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.DataGridView dgvAppointment2;

        private System.Windows.Forms.GroupBox grpC;
        
        private System.Windows.Forms.RadioButton radSiC;
        private System.Windows.Forms.RadioButton radNoC2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btn_citaTracker;

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.Button btn_proceso;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.Button btn_pdf_citas;

        private System.Windows.Forms.TextBox txt_citas;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.TextBox lbl_dui;

        private System.Windows.Forms.DataGridView dgvAppointment;

        private System.Windows.Forms.Button btn_cancelar;

        private System.Windows.Forms.Button btn_buscar;

        private System.Windows.Forms.MaskedTextBox mskDuitTracking;
        

        #endregion
    }
}