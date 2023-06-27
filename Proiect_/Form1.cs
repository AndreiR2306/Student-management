using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int j = 0; //va contoriza cate incercari avem 
        private void cmdOk_Click(object sender, EventArgs e)
        {

            j = j + 1;
            if (txtUsername.Text == "user")
            {
                if (txtPassword.Text == "password")
                {
                    FrmMain m = new FrmMain();
                    m.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Username-ul sau parola sunt incorecte!");
                }
            }else {
                MessageBox.Show("Username-ul sau parola sunt incorecte!");
            }
            if (j == 3)
            {
                MessageBox.Show("Ati avute 3 incercari!");
                Application.Exit();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
