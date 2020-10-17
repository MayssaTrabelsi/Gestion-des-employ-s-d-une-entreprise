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
using System.Data.SqlClient;



namespace DS2
{
    public partial class Form4 : Form
    {
        public Form4()
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

        private void Modifier_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") ||
                (comboBox1.SelectedIndex == -1) || (Femme.Checked = false) && (Homme.Checked = false))

                MessageBox.Show("Remplissez tous les champs!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {


                OracleConnection conn = GetDBConnection();

                OracleCommand cmd1 = new OracleCommand("select mat from employe where mat= :mat", conn);


                conn.Open();
                OracleParameter matParam = new OracleParameter("mat", OracleDbType.Int32);
                matParam.Value = int.Parse(textBox1.Text);
                cmd1.Parameters.Add(matParam);
                OracleDataReader myreader = cmd1.ExecuteReader();
                if (myreader.HasRows)
                {
                    string requete_sql = "update employe set nom=:nom ,prenom=:prenom,datenaiss=:datenaiss,sexe=:sexe,fonction=:fonction,enf=:enf where mat=" + (int.Parse(textBox1.Text));


                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = requete_sql;





                    // Ajoutez le paramètre @name (Écrivez plus court).
                    OracleParameter nameParam = cmd.Parameters.Add("nom", OracleDbType.Varchar2);
                    nameParam.Value = textBox2.Text;
                    // Ajoutez le paramètre @name (Écrivez plus court).
                    OracleParameter prenomParam = cmd.Parameters.Add("prenom", OracleDbType.Varchar2);
                    prenomParam.Value = textBox3.Text;

                    OracleParameter dateParam = cmd.Parameters.Add("datenaiss", OracleDbType.Date);
                    dateParam.Value = dateTimePicker1.Value;

                    OracleParameter sexeParam = cmd.Parameters.Add("sexe", OracleDbType.Varchar2);
                    if (Femme.Checked)
                        sexeParam.Value = "F";

                    if (Homme.Checked)
                        sexeParam.Value = "H";

                    OracleParameter FonctionParam = cmd.Parameters.Add("fonction", OracleDbType.Varchar2);
                    FonctionParam.Value = comboBox1.SelectedItem.ToString();

                    OracleParameter enfParam = cmd.Parameters.Add("enf", OracleDbType.Varchar2);
                    if (ENF.Checked)
                        enfParam.Value = "O";
                    if (ENF.Checked == false)
                        enfParam.Value = "N";




                    // Exécutez Command (pour delete, insert, update).
                    int rowCount = cmd.ExecuteNonQuery();

                    if (rowCount >= 1)
                        MessageBox.Show("Opération réussie !", "Modifier employé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Employé n'existe pas !", "Erreur", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    myreader.Close();
                }
                conn.Close();
            }

        }
    }
}
