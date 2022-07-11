using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Eclerx.Question4.Jatin
{
    public partial class lblEmployeeDetails : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
      
        private DataSet ds = null;
        public lblEmployeeDetails()
        {
            InitializeComponent();
        }

        private void lblEmployeeDetails_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("usp_AddNewEmployee", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert
                    ds = new DataSet();
                    adapter.Fill(ds, "Employee");
                    //Create new row in the dataset
                    DataRow dr = ds.Tables["Employee"].NewRow();
                    dr["EmployeeId"] = txtEmpNo.Text;
                    dr["EmployeeName"] = txtEmpName.Text;
                    dr["EmployeeSalary"] = txtEmpSalary.Text;
                    dr["EmployeeType"] = RadioPayroll.Text.Contains("P");
                    dr["EmployeeType"] = RadioConsultant.Text.Contains("C");
                    //Add data row to dataset
                    ds.Tables["Employee"].Rows.Add(dr);
                    //Updating Dataset to Database
                    adapter.Update(ds, "EmployeeType");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.Resetbtn();
        }
        public void Resetbtn()
        {
            txtEmpNo.Text = "";
            txtEmpName.Clear();
            txtEmpSalary.Text = "";
            txtEmpNo.Focus();
        }
    }
}
