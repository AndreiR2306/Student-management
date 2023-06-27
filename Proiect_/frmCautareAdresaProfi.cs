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
    public partial class frmCautareAdresaProfi : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");

        public frmCautareAdresaProfi()
        {
            InitializeComponent();
        }

        private void txtCodProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCodProf.Text != "")
            {
                dgwAdrese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Adrese_prof WHERE Cod_prof like '%" + txtCodProf.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwAdrese.DataSource = dv;
                con.Close();
            }
            else if (txtCodProf.Text == "")
            {
                dgwAdrese.Refresh();
            }
        }

        private void txtLocalitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocalitate.Text != "")
            {
                dgwAdrese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Adrese_prof WHERE Loc_prof like '%" + txtLocalitate.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwAdrese.DataSource = dv;
                con.Close();
            }
            else if (txtLocalitate.Text == "")
            {
                dgwAdrese.Refresh();
            }
        }

        private void txtStrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtStrada.Text != "")
            {
                //OleDbCommand, OleDbDataAdapter și OleDbConnection sunt folosite pentru a selecta înregistrări dintr-o sursă de date Access și pentru
                //          a umple un DataSet cu rândurile selectate. DataSet-ul completat este apoi returnat. Pentru a realiza acest lucru,
                //          metoda primește un DataSet inițializat, un șir de conexiune și un șir de interogare care este o instrucțiune SQL SELECT.
                dgwAdrese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "SELECT * FROM Adrese_prof WHERE Strada_prof like '%" + txtStrada.Text + "%';";

                con.Open();
                adap = new OleDbDataAdapter(query, con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgwAdrese.DataSource = dv;
                con.Close();
            }
            else if (txtStrada.Text == "")
            {
                dgwAdrese.Refresh();
            }
        }
    }
}
