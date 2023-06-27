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
    public partial class frmDiscipline : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;


        public frmDiscipline()
        {
            InitializeComponent();
        }

        void getDiscipline()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Liceu_2007.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Discipline", conn);
            conn.Open();
            adapter.Fill(dt);
            dgwElevi.DataSource = dt;
            conn.Close();
        }

        private void frmDiscipline_Load(object sender, EventArgs e)
        {
            getDiscipline();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Discipline (Cod_dis, Nume_disciplina) VALUES (@codDiscipline, @numeDisciplina)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@codDiscipline", txtCodDisciplina.Text);
            cmd.Parameters.AddWithValue("@numeDisciplina", txtNumeDisciplina.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datele au fost introduse cu succes!");
            getDiscipline();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Discipline WHERE (Cod_dis=@codDiscipline OR Nume_disciplina=@numeDisciplina)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@codDiscipline", txtCodDisciplina.Text);
            cmd.Parameters.AddWithValue("@numeDisciplina", txtNumeDisciplina.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datele au fost sterse cu succes!");
            getDiscipline();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Nume disciplina: '%" + txtNumeDisciplina.Text + "'";
            dgwElevi.DataSource = dv;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgwElevi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCodDisciplina.Text = dgwElevi.CurrentRow.Cells[0].Value.ToString();
            txtNumeDisciplina.Text = dgwElevi.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
