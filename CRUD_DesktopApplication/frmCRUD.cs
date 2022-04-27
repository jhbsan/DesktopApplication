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
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (gpCreate.Visible == false)
            {
                gpCreate.Visible = true;
            }
            else
            {
                gpCreate.Visible=false;
            }
        }
    }
}
