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
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        //butomnul exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        //adaugare elevi
        private void adaugareElev_Click(object sender, EventArgs e)
        {
            frmAdaugareElev adElev = new frmAdaugareElev();
            adElev.Show();
        }

        //editare elevi 
        private void editareElev_Click(object sender, EventArgs e)
        {
            frmEditareElev edElev = new frmEditareElev();
            edElev.Show();
        }

       

        //adaugare profesor
        private void adaugareProfesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdaugareProfesor adProfesor = new frmAdaugareProfesor();
            adProfesor.Show();
        }

        //stergere profesor
        private void stergereProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //discipline 
        private void disciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscipline fDiscipline = new frmDiscipline();
            fDiscipline.Show();
        }

        //cautare elevi
        private void eleviToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCautareElevi cautElevi = new frmCautareElevi();
            cautElevi.Show();
        }



        private void profesoriTool_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Cautare adresa elevi
        private void adresaEleviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCautaAdresaElevi frmCautareAdrese = new frmCautaAdresaElevi();
            frmCautareAdrese.Show();
        }

        //Report
        private void raportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frReport = new frmReport();
            frReport.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //cautare adresa prof
        private void adresaProfesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCautareAdresaProfi frmAdrProf = new frmCautareAdresaProfi();
            frmAdrProf.Show();
        }

        //cautare Profesori
        private void cautaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCautareProfesor frmCautprof= new frmCautareProfesor();
            frmCautprof.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
