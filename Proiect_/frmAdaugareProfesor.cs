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

namespace Proiect_
{
    public partial class frmAdaugareProfesor : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public frmAdaugareProfesor()
        {
            InitializeComponent();
        }


        //conexiunea la baza de date si preluarea datelor din aceasta pentru a le afisa
        void getElevi()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");
            dt = new DataTable();
            //select - functia care selecreaza toate informatiile din tabela Profesori 
            adapter = new OleDbDataAdapter("SELECT * FROM Profesori", conn);
            conn.Open();
            adapter.Fill(dt);
            dgwElevi.DataSource = dt;
            conn.Close();
        }

        private void frmAdaugareProfesor_Load(object sender, EventArgs e)
        {
            getElevi();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Profesori (Cod_prof, Nume_prof, Pren_prof, Data_prof, Salariu, Casatorit, Gen_prof, CV_prof, Telefon, Diriginte) VALUES" +
                "(@codProf, @numeProf, @prenumeProf, @dateProf, @salariu, @casatorit, @genProf, @cvProf, @telefon, @diriginte)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@codProf", txtCodProfesor.Text);
            cmd.Parameters.AddWithValue("@numeProf", txtNume.Text);
            cmd.Parameters.AddWithValue("@prenumeProf", txtPrenume.Text);
            cmd.Parameters.AddWithValue("@dateProf", txtDataProfesor.Text);
            cmd.Parameters.AddWithValue("@salariu", txtSalariu.Text);
            cmd.Parameters.AddWithValue("@casatorit", txtCasatorit.Text);
            cmd.Parameters.AddWithValue("@genProf", txtGen.Text);
            cmd.Parameters.AddWithValue("@cvProf", txtCV.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@diriginte", txtDiriginte.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datele au fost introduse cu succes!");
            getElevi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Profesori WHERE Cod_prof=@codProf OR Nume_prof=@numeProf OR Pren_prof=@prenumeProf OR Data_prof=@dateProf OR Salariu=@salariu OR Casatorit=@casatorit OR Gen_prof=@genProf OR CV_prof=@cvProf OR Telefon=@telefon OR Diriginte=@diriginte";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@codProf", txtCodProfesor.Text);
            cmd.Parameters.AddWithValue("@numeProf", txtNume.Text);
            cmd.Parameters.AddWithValue("@prenumeProf", txtPrenume.Text);
            cmd.Parameters.AddWithValue("@dateProf", txtDataProfesor.Text);
            cmd.Parameters.AddWithValue("@salariu", txtSalariu.Text);
            cmd.Parameters.AddWithValue("@casatorit", txtCasatorit.Text);
            cmd.Parameters.AddWithValue("@genProf", txtGen.Text);
            cmd.Parameters.AddWithValue("@cvProf", txtCV.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@diriginte", txtDiriginte.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datele au fost sterse cu succes!");
            getElevi();
        }
    }
}
