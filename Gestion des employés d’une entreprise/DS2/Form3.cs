using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Oracle.DataAccess.Client;

namespace DS2
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Vider_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Femme.Checked = false;
            Homme.Checked = false;
            comboBox1.SelectedIndex = -1;
            ENF.Checked = false;
            dateTimePicker1.ResetText();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Remplissez la matricule", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                OracleConnection conn = GetDBConnection();
                OracleCommand cmd1 = new OracleCommand("select * from employe where mat= :mat", conn);


                conn.Open();
                OracleParameter matParam = new OracleParameter("mat", OracleDbType.Int32);
                matParam.Value = int.Parse(textBox1.Text);
                cmd1.Parameters.Add(matParam);
                OracleDataReader myreader = cmd1.ExecuteReader();
                if (myreader.HasRows)
                {

                    textBox2.Text = myreader[1].ToString();
                    textBox3.Text = myreader[2].ToString();
                    dateTimePicker1.Value = DateTime.Parse(myreader[3].ToString());
                    if (myreader[4].ToString().Equals("H"))
                        Homme.Checked = true;
                    else
                        Femme.Checked = false;
                    int i = 0;
                    foreach (string itm in comboBox1.Items)
                    {
                        if ((myreader[5].ToString()).Equals("itm"))
                        {
                            comboBox1.SelectedItem = itm;
                            comboBox1.SelectedIndex = i;
                            comboBox1.Text = itm;
                        }
                        i++;
                    }

                    if (myreader[5].ToString().Equals("O"))
                        ENF.Checked = true;

                    string requete_sql = "delete from employe where mat=" + (int.Parse(textBox1.Text));


                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = requete_sql;

                    // Exécutez Command (pour delete, insert, update).
                    int rowCount = cmd.ExecuteNonQuery();

                    if (rowCount >= 1)
                        MessageBox.Show("Opération réussie !", "Supprimer employé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Employé n'existe pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myreader.Close();
                }
                conn.Close();
            }
        }






     }

}
     
