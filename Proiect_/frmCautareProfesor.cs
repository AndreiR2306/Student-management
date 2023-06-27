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
    public partial class frmCautareProfesor : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");

        public frmCautareProfesor()
        {
            InitializeComponent();
        }

        private void txtCodProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodProf.Text != "")
            {
                dgwProf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                //slectam din baza de date informatiile daca numele elevului se gaseste in baza de date
                string query = "SELECT * FROM Profesori WHERE Cod_prof like '%" + txtCodProf.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwProf.DataSource = dv;
                con.Close();
            }
            else if (txtCodProf.Text == "")
            {
                dgwProf.Refresh();
            }
        }

        private void txtNumeProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNumeProf.Text != "")
            {
                dgwProf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                //slectam din baza de date informatiile daca numele elevului se gaseste in baza de date
                string query = "SELECT * FROM Profesori WHERE Nume_prof like '%" + txtNumeProf.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwProf.DataSource = dv;
                con.Close();
            }
            else if (txtNumeProf.Text == "")
            {
                dgwProf.Refresh();
            }
        }

        private void txtPrenumeProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrenumeProf.Text != "")
            {
                dgwProf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                //slectam din baza de date informatiile daca numele elevului se gaseste in baza de date
                string query = "SELECT * FROM Profesori WHERE Pren_prof like '%" + txtPrenumeProf.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwProf.DataSource = dv;
                con.Close();
            }
            else if (txtPrenumeProf.Text == "")
            {
                dgwProf.Refresh();
            }
        }

        private void txtDiriginte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDiriginte.Text != "")
            {
                dgwProf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                //slectam din baza de date informatiile daca numele elevului se gaseste in baza de date
                string query = "SELECT * FROM Profesori WHERE Diriginte like '%" + txtDiriginte.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwProf.DataSource = dv;
                con.Close();
            }
            else if (txtDiriginte.Text == "")
            {
                dgwProf.Refresh();
            }
        }

        private void frmCautareProfesor_Load(object sender, EventArgs e)
        {

        }

        private void txtCodProf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
