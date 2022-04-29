using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using System.Data.SqlClient;
using System.Collections;
using NHibernate.Bytecode.Lightweight;
using System.IO;

namespace CRUD_DesktopApplication
{
    public partial class frmCRUD : Form
    {
        public string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        public void clearfileds()
        {
            txtFullName.Text = "";
            txtDepartment.Text = "";
            txtEmailAddress.Text = "";
            txtSalary.Text = "";
            DojPicker.Value = DateTime.Now;
        }
        public void SaveEmployeeDetails()
        {
            var cfg = new Configuration();
            string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
            cfg.DataBaseIntegration(x => {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            try
            {
                using (var session = sefact.OpenSession())
                {
                    using (var tr = session.BeginTransaction())
                    {
                        var emp = new Employee
                        {
                            EmpName = txtFullName.Text.ToString(),
                            DateofJoining = (Convert.ToDateTime(DojPicker.Value.ToString())),
                            Department = txtDepartment.Text.ToString(),
                            EmailID = txtEmailAddress.Text.ToString(),
                            Salary = (decimal)Convert.ToDouble(txtSalary.Text)
                        };

                        session.Save(emp);
                        tr.Commit();
                        MessageBox.Show("Employee Data Saved successfully!!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NHibernate Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BindGridData()
        {
            var cfg = new Configuration();
            string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
            cfg.DataBaseIntegration(x => {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            try
            {
                //logic to read from DB and binding to Data GridView
                using (var session = sefact.OpenSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        dgEmployeesShow.DataSource = session.CreateCriteria(typeof(Employee)).List();
                        dgFetchAllEmployees.DataSource = session.CreateCriteria(typeof(Employee)).List();
                        dgUpdateResult.DataSource=session.CreateCriteria(typeof(Employee)).List();
                        DgDelete.DataSource= session.CreateCriteria(typeof(Employee)).List();
                        tx.Commit();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NHibernate Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnSaveEmployeeDetails_Click(object sender, EventArgs e)
        {
            SaveEmployeeDetails();
            clearfileds();
            BindGridData();
        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            gpCreate.Visible = false;
            gpFetch.Visible = false;
            GpUpdate.Visible = false;
            
            
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (gpCreate.Visible == false)
            {
                gpCreate.Visible = true;
                gpFetch.Visible = false;
            }
            else
            {
                gpCreate.Visible=false;
            }
            
        }

        private void btnFetchEmployeeDetails_Click(object sender, EventArgs e)
        {
            if(gpFetch.Visible==false)
            {
                gpFetch.Visible = true;
                gpCreate.Visible = true;
                GpUpdate.Visible = false;
                GpDelete.Visible = false;
            }
            else
            {
                gpFetch.Visible=false;
                gpCreate.Visible=false;
            } 
        }

        private void btnUpdateEmployeeDetails_Click(object sender, EventArgs e)
        {
            if (GpUpdate.Visible == false)
            {
                gpCreate.Visible = true;
                gpFetch.Visible = true;
                GpUpdate.Visible = true;
                GpDelete.Visible=false;
            }
            else
            {
                GpUpdate.Visible = false;
                gpFetch.Visible = false;
                gpCreate.Visible = false;
            }
        }

        private void btnDeleteEmployeDetails_Click(object sender, EventArgs e)
        {
            if (GpDelete.Visible == false)
            {
                GpDelete.Visible = true;
                gpFetch.Visible = true;
                GpUpdate.Visible = true;
                gpCreate.Visible = true;
            }
            else
            {
                GpUpdate.Visible = false;
                gpFetch.Visible = false;
                gpCreate.Visible = (GpUpdate.Visible);
            }

        }

        //getting employee details by ID
        public void GetEmployeeByID()
        {
            var cfg = new Configuration();
            int idvalue = Convert.ToInt32(txtEmployeeID.Text);

            string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
            cfg.DataBaseIntegration(x => {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    
                    //var emp=session.EnableFilter("myFilter").SetParameter("myFilterParam",idvalue);
                    //var results = session.CreateQuery("from Employee as e where e.EmpID = emp").List<Employee>();
                    //dgFetchID.DataSource=results; 
                    tx.Commit();
                }
            }
        }
        private void btnFetchAllEmployeeDetails_Click(object sender, EventArgs e)
        {
            BindGridData();
        }

        private void btnFetchByID_Click(object sender, EventArgs e)
        {
            GetEmployeeByID();
            txtEmployeeID.Text = "";
            txtEmployeeID.Focus();
        }

        public void UpdateEmployeeDetails()
        {
            var cfg = new Configuration();
            int idvalue = Convert.ToInt32(txtUpdate.Text);

            string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
            cfg.DataBaseIntegration(x => {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var emp = session.Get<Employee>(idvalue);
                    emp.EmpName = txtFullNameforUpdate.Text.ToString();
                    emp.EmailID = txtEmailforUpdate.Text.ToString();
                    session.Update(emp);
                    tx.Commit();
                    lblUpdateResult.Text = "Updated Successfully";
                }
            }
            BindGridData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployeeDetails();
            txtUpdate.Text = "";
            txtEmailforUpdate.Text = "";
            txtFullNameforUpdate.Text = "";
            txtUpdate.Focus();
        }

        public void DeleteEmployeeDetails()
        {
            var cfg = new Configuration();
            int idvalue = Convert.ToInt32(txtDelete.Text);

            string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
            cfg.DataBaseIntegration(x => {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var emp = session.Get<Employee>(idvalue);
                    session.Delete(emp);
                    tx.Commit();
                    lblDeleteResult.Text = "Deleted Employee Details Successfully";
                }
            }
            BindGridData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteEmployeeDetails();
            txtDelete.Text = "";
            txtDelete.Focus();
        }
    }
}
