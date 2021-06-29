using System.ComponentModel;

namespace Proyecto_BASES_POO_2021
{
    partial class frm_EmployeeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmployeeInfo));
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_employeeInfo = new System.Windows.Forms.DataGridView();
            this.lbl_employeeInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_employeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1070, 714);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(135, 55);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "cerrar";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dgv_employeeInfo
            // 
            this.dgv_employeeInfo.AllowUserToAddRows = false;
            this.dgv_employeeInfo.AllowUserToDeleteRows = false;
            this.dgv_employeeInfo.AllowUserToResizeColumns = false;
            this.dgv_employeeInfo.AllowUserToResizeRows = false;
            this.dgv_employeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_employeeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employeeInfo.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_employeeInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_employeeInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_employeeInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employeeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_employeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_employeeInfo.EnableHeadersVisualStyles = false;
            this.dgv_employeeInfo.GridColor = System.Drawing.Color.DarkCyan;
            this.dgv_employeeInfo.Location = new System.Drawing.Point(42, 108);
            this.dgv_employeeInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_employeeInfo.Name = "dgv_employeeInfo";
            this.dgv_employeeInfo.ReadOnly = true;
            this.dgv_employeeInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_employeeInfo.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_employeeInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_employeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employeeInfo.Size = new System.Drawing.Size(1162, 597);
            this.dgv_employeeInfo.TabIndex = 2;
            // 
            // lbl_employeeInfo
            // 
            this.lbl_employeeInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_employeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_employeeInfo.Location = new System.Drawing.Point(354, 34);
            this.lbl_employeeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_employeeInfo.Name = "lbl_employeeInfo";
            this.lbl_employeeInfo.Size = new System.Drawing.Size(508, 48);
            this.lbl_employeeInfo.TabIndex = 3;
            this.lbl_employeeInfo.Text = "Información de empleados";
            // 
            // frm_EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1242, 788);
            this.Controls.Add(this.lbl_employeeInfo);
            this.Controls.Add(this.dgv_employeeInfo);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_EmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frm_EmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgv_employeeInfo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_employeeInfo;

        private System.Windows.Forms.Button btn_close;

        private System.Windows.Forms.DataGridView dgv_employeeInfo;

        #endregion
    }
}