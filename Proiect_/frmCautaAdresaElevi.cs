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
    public partial class frmCautaAdresaElevi : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");

        public frmCautaAdresaElevi()
        {
            InitializeComponent();
        }

        private void txtCodElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodElev.Text != "")
            {
                dgwAdresaEle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Adrese_elevi WHERE Cod_elev like '%" + txtCodElev.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwAdresaEle.DataSource = dv;
                con.Close();
            }
            else if (txtCodElev.Text == "")
            {
                dgwAdresaEle.Refresh();
            }
        }

        private void txtLocElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocElev.Text != "")
            {
                dgwAdresaEle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Adrese_elevi WHERE Loc_elev like '%" + txtLocElev.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwAdresaEle.DataSource = dv;
                con.Close();
            }
            else if (txtLocElev.Text == "")
            {
                txtLocElev.Refresh();
            }
        }

        private void txtStradaElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtStradaElev.Text != "")
            {
                dgwAdresaEle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Adrese_elevi WHERE Strada_elev like '%" + txtStradaElev.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwAdresaEle.DataSource = dv;
                con.Close();
            }
            else if (txtStradaElev.Text == "")
            {
                dgwAdresaEle.Refresh();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCautaAdresaElevi_Load(object sender, EventArgs e)
        {

        }
    }
}
