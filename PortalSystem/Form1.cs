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

namespace PortalSystem
{
    public partial class Form1 : Form
    {
       // string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectToDb()
        {
            var cfg = new Configuration();//step 1
            string str = "Data Source=SANTOSHLAPTOP\\MSSQL2019; Initial Catalog=NHibernateDemoDB;Integrated Security=true";//step 2
            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionString = str;
                x.Driver<SqlClientDriver>(); x.Dialect<MsSql2008Dialect>();
            });

            //you will add a Assembly details (NHibernate will automatically pick from the Solution)
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            //you will create a object for SessionFactory using the method BuildSessionFactory();
            var sefact = cfg.BuildSessionFactory(); //this will maintain the session state for particular object(objectwise)

            using (var session = sefact.OpenSession())
            {
                using (var tr = session.BeginTransaction())
                {
                    try
                    {
                        //you will write your logic for the application
                        //in this example, we are just connecting to DB for test connection
                        dgStudentDetails.DataSource = session.CreateCriteria(typeof(Student)).List();
                        tr.Commit();
                        lblResult.Text = "Connected to NHibernateDemoDB Successfully";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "NHibernate Error!!");
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToDb();
        }
    }
}
