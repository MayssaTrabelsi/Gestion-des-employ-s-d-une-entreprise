using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        public OracleConnection GetDBConnection()
        {
            string connectionString = "DATA SOURCE = (DESCRIPTION ="
               + "(ADDRESS = (PROTOCOL = TCP)(HOST =LAPTOP-JKUMV0K4)(PORT = 1521))" +
   "(CONNECT_DATA =" +
    " (SERVER = DEDICATED)" +
    " (SERVICE_NAME = XE)" +
  " ) ); USER ID = SYSTEM;Password=manager;";
            OracleConnection conn = new OracleConnection(connectionString);
            // conn.ConnectionString = connectionString;
            //  conn.ConnectionString = connectionString;
            //MessageBox.Show("hhhhhh");
            return conn;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
            this.Hide();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();
            this.Hide();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4();
            F.Show();
            this.Hide();
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            Form5 fgrid = new Form5();
            fgrid.Show();
            this.Hide();
            OracleConnection conn = GetDBConnection();
            conn.Open();
            //  button1.Text = "fsgfd";
            OracleDataAdapter ada = new OracleDataAdapter("select * from employe", conn);
            DataTable dt = new DataTable();
            Console.WriteLine(dt);
            ada.Fill(dt);
            fgrid.dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
