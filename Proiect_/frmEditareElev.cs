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
    public partial class frmEditareElev : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public frmEditareElev()
        {
            InitializeComponent();
        }

        void getElevi()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Elevi", conn);
            conn.Open();
            adapter.Fill(dt);
            dgwElevi.DataSource = dt;
            conn.Close();
        }

        private void frmEditareElev_Load(object sender, EventArgs e)
        {
            getElevi();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "UPDATE Elevi SET Nume_elev='" + txtNume.Text+"' Pren_elev='" + txtPrenume.Text + "' Cod_clasa=" + txtCodClasa.Text + "' Data_elev=" + txtDataElev.Text + "' Telefon=" + txtTelefon.Text + "' Gen_elevi=" + txtGen.Text + "' WHERE Cod_elev='" + txtCodElev.Text + "'";
                MessageBox.Show(query);
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data edit Successfull");
                conn.Close();
                getElevi();
            } catch( Exception ex) {
                MessageBox.Show("Error " + ex);
            }
            
            /*
            for (int i = 0; i < dgwElevi.Rows.Count - 1; i++)
            {
                string query = "UPDATE Elevi SET Nume_elev=@numeE, Pren_elv=@prenE, Cod_clasa=@codC, Data_elev=@dataE, Telefon=@telef, Gen_elev=@gen WHERE Cod_elev=@codElev";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeE", dgwElevi.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@prenE", dgwElevi.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@codC", dgwElevi.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@dataE", dgwElevi.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@telef", dgwElevi.Rows[i].Cells[6].Value);
                cmd.Parameters.AddWithValue("@gen", dgwElevi.Rows[i].Cells[7].Value);
                cmd.Parameters.AddWithValue("@Cod_elev", dgwElevi.Rows[i].Cells[0].Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Datele au fost editate cu succes!");
                getElevi();

            }*/
            
        }

        private void dgwElevi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCodElev.Text = dgwElevi.CurrentRow.Cells[0].Value.ToString();
            txtNume.Text = dgwElevi.CurrentRow.Cells[1].Value.ToString();
            txtPrenume.Text = dgwElevi.CurrentRow.Cells[2].Value.ToString();
            txtCodClasa.Text = dgwElevi.CurrentRow.Cells[3].Value.ToString();
            txtDataElev.Text =dgwElevi.CurrentRow.Cells[4].Value.ToString();
            txtTelefon.Text = dgwElevi.CurrentRow.Cells[5].Value.ToString();
            txtGen.Text = dgwElevi.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
