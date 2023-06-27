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
    public partial class frmAdaugareElev : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public frmAdaugareElev()
        {
            InitializeComponent();
        }

        void getElevi()
        {
            //Crearea conexiuni cu baza de date Acces
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");
            dt = new DataTable();
            //selecteaza toti elevii ( datorita * )  din tabela Elevi
            adapter = new OleDbDataAdapter("SELECT * FROM Elevi", conn);
            conn.Open();
            adapter.Fill(dt);
            dgwElevi.DataSource = dt;
            conn.Close();
        }

        //greseala de apasare 
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Se afiseaza tabelul , apelarea functiei getElevi()
        private void frmAdaugareElev_Load(object sender, EventArgs e)
        {
            getElevi();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //se creaza un query nou care contine o interogare de tip SQL pentru inserarea valoriilor in baza de date
            //pentru Inserarea valorilor ne vom folosi de functia INSERT INTO ... VALUES 
            string query = "INSERT INTO Elevi (Cod_elev, Nume_elev, Pren_elev, Cod_clasa, Data_elev, Telefon, Gen_elev) VALUES" +
                "(@codElev, @numeElev, @prenumeElev, @codClasa, @dataElev, @telefon, @genElev)";
            
            //Ne vom folosi de query-ul declarat mai sus si de OleDbCommand pentru a executa comenzi SQL asupra bazei de date
            cmd = new OleDbCommand(query, conn);

            //Se adauga valorile pentru parametrii prin utilizarea metodei AddWithValue
            cmd.Parameters.AddWithValue("@codElev", txtCodElev.Text);
            cmd.Parameters.AddWithValue("@numeElev", txtNume.Text);
            cmd.Parameters.AddWithValue("@prenumeElev", txtPrenume.Text);
            cmd.Parameters.AddWithValue("@codClasa", txtCodClase.Text);
            cmd.Parameters.AddWithValue("@dataElev", txtDataElev.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@genElev", txtGen.Text);
            conn.Open();

            //metoda ExecuteNonQuery va returna numarul de randuri afectate de comanda
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datele au fost introduse cu succes!"); //simplu mesaj care se afiseaza pe ecran 
            getElevi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete - Sterge datele din tabela in functie de conditiile mentionate
            string query = "DELETE FROM Elevi WHERE Cod_elev=@codElev OR Nume_elev=@numeElev OR Pren_elev=@prenumeElev OR Cod_clasa=@codClasa OR Data_elev=@dataElev OR Telefon=@telefon  OR Gen_elev=@genElev";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@codElev", txtCodElev.Text);
            cmd.Parameters.AddWithValue("@numeElev", txtNume.Text);
            cmd.Parameters.AddWithValue("@prenumeElev", txtPrenume.Text);
            cmd.Parameters.AddWithValue("@codClasa", txtCodClase.Text);
            cmd.Parameters.AddWithValue("@dataElev", txtDataElev.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@genElev", txtGen.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datele au fost sterse cu succes!");
            getElevi();
        }

        //Butonul de close care inchide fereastra
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
