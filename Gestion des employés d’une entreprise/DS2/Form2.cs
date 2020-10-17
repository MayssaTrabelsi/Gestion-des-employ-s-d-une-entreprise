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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") ||
               (comboBox1.SelectedIndex == -1) || (radioButton1.Checked = false) && (Homme.Checked = false))

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
                    MessageBox.Show("Employé existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myreader.Close();
                }
                else
                {
                    myreader.Close();
                    string requete_sql = "Insert into employe (mat,nom,prenom,datenaiss,sexe,fonction,enf) "
                    + " values (:mat,:nom,:prenom,:datenaiss,:sexe,:fonction,:enf) ";


                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = requete_sql;


                    // Créez un objet Parameter.
                    OracleParameter idParam = new OracleParameter("mat", OracleDbType.Int32);
                    idParam.Value = int.Parse(textBox1.Text);
                    cmd.Parameters.Add(idParam);

                    // Ajoutez le paramètre @name (Écrivez plus court).
                    OracleParameter nameParam = cmd.Parameters.Add("nom", OracleDbType.Varchar2);
                    nameParam.Value = textBox2.Text;
                    // Ajoutez le paramètre @name (Écrivez plus court).
                    OracleParameter prenomParam = cmd.Parameters.Add("prenom", OracleDbType.Varchar2);
                    prenomParam.Value = textBox3.Text;

                    OracleParameter dateParam = cmd.Parameters.Add("datenaiss", OracleDbType.Date);
                    dateParam.Value = dateTimePicker1.Value;

                    OracleParameter sexeParam = cmd.Parameters.Add("sexe", OracleDbType.Varchar2);
                    if (radioButton1.Checked)
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
                        MessageBox.Show("Opération réussie !", "Ajout employé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
            }




               
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Hide();
        }

        private void Vider_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            Homme.Checked = false;
            comboBox1.SelectedIndex = -1;
            ENF.Checked = false;
            dateTimePicker1.ResetText();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
