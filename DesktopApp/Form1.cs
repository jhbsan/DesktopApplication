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

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLastName.Focus();
        }

        public void SetDbConnection()
        {
            var cfg = new Configuration();
            string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
            cfg.DataBaseIntegration(x => {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();

            //displaying result to user
            lblResult.Text = "Connected Successfully";
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            SetDbConnection();
        }

        private void btnStudentDataInsert_Click(object sender, EventArgs e)
        {
            if(txtLastName.Text!="" && txtFirstName.Text!="")
            {
                InsertDataintoDB();
            }
            else
            {
                MessageBox.Show("Please Enter the LastName / FirstName then Try to Save");
            }
        }

        public void InsertDataintoDB()
        {
            var cfg = new Configuration();
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
                    var std = new Student
                    {
                        LastName = txtLastName.Text,
                        FirstName = txtFirstName.Text,
                    };
                    session.Save(std);
                    
                    tx.Commit();
                   lblInsertResult.Text= "Data Inserted successfully into Database";
                }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastName.Text = null;
            txtFirstName.Text = null;
            lblInsertResult.Text = "";
            txtLastName.Focus();
        }
    }
}
