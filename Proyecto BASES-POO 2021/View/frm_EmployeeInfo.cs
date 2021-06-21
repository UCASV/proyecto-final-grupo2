using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_BASES_POO_2021.ProjectContext;
using Proyecto_BASES_POO_2021.viewModels;

namespace Proyecto_BASES_POO_2021
{
    public partial class frm_EmployeeInfo : Form
    {

        private bool showFromDB = false;
        public frm_EmployeeInfo()
        {
            InitializeComponent();
        }

        private void frm_EmployeeInfo_Load(object sender, EventArgs e)
        {

            if (!showFromDB)
            {
                using (var db = new PROJECT_BD_POOContext())
                {
                    var employee = db.Managers.ToList();
                    var mappedDS = new List<ManagerVm>();
                    
                    employee.ForEach(e => mappedDS.Add(ProjectMapper.mapManagerVm(e)));

                    dgv_employeeInfo.DataSource = mappedDS;
                }
            }

            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}