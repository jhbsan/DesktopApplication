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
    public partial class Form1 : Form
    {
        public string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
        public string dbname = "NHibernateDemoDB";
        public Form1()
        {
            InitializeComponent();
        }
        public void SetDbConnection()
        {
            var cfg = new Configuration();
            //string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
            cfg.DataBaseIntegration(x => {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();

            //displaying result to user
            lblResult.Text = "Connected to DB '"+dbname+"' Successfully";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
                        dgEmployee.DataSource = session.CreateCriteria(typeof(Employee)).List();
                        tx.Commit();
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"NHibernate Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void btnGetEmployeeDetails_Click(object sender, EventArgs e)
        {
            SetDbConnection();
            BindGridData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCRUD crudfrm=new frmCRUD();
            crudfrm.Show();
        }
    }
}
