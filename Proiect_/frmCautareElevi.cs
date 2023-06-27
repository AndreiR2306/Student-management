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
    public partial class frmCautareElevi : Form
    {
        //conexiunea la baza de date 
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");
        public frmCautareElevi()
        {
            InitializeComponent();
        }

        //apasat din greseala 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        //elementele care au _KeyPress se declanșează sau se execută ori de câte ori un utilizator apasă o tastă în TextBox
        //Daca datele indroduse se regasesc in baza de date, se va evidentia codul elevilor.
        private void txtCodElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodElev.Text != "")
            {
                dgwElevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                //slectam din baza de date informatiile daca numele elevului introdus de noi se gaseste in baza de date
                string query = "SELECT * FROM Elevi WHERE Cod_elev like '%" + txtCodElev.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                //daca se gaseste in baza de date ceea ce cautam, se va evidentia cu o alta culoare prima coloana din tabel
                dv = new DataView(ds.Tables[0]);
                dgwElevi.DataSource = dv;
                con.Close();
            }else if(txtCodElev.Text == "")
            {
                dgwElevi.Refresh();
            }
        }

        private void txtNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNume.Text != "")
            {
                dgwElevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                //slectam din baza de date informatiile daca numele elevului se gaseste in baza de date
                string query = "SELECT * FROM Elevi WHERE Nume_elev like '%" + txtNume.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwElevi.DataSource = dv;
                con.Close();
            }
            else if (txtNume.Text == "")
            {
                dgwElevi.Refresh();
            }
        }

        private void txtPrenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrenume.Text != "")
            {
                dgwElevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Elevi WHERE Pren_elev like '%" + txtPrenume.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwElevi.DataSource = dv;
                con.Close();
            }
            else if (txtPrenume.Text == "")
            {
                dgwElevi.Refresh();
            }
        }

        private void txtClasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtClasa.Text != "")
            {
                dgwElevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Elevi WHERE Cod_clasa like '%" + txtClasa.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwElevi.DataSource = dv;
                con.Close();
            }
            else if (txtClasa.Text == "")
            {
                dgwElevi.Refresh();
            }
        }

        private void txtCodElev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
