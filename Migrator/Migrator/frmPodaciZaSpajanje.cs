using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migrator
{
    public partial class frmIzvorniPosluzitelj : Form
    {
        //spremnik za glavnu formu koji ti treba da znas koji SUBP je odabran
        public frmGlavna glavna = new frmGlavna();

        public frmIzvorniPosluzitelj(frmGlavna glavnaProsljedjena)
        {
            InitializeComponent();
            glavna = glavnaProsljedjena;
            if (glavna.chxSQLServer.Checked == true)
                chxWindowsA.Enabled = true;
        }


        public frmIzvorniPosluzitelj()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            frmGlavna glavnaBack = new frmGlavna();
            this.Hide();
            glavnaBack.ShowDialog();
        }
        string ConnString;
        private void btnDalje2_Click(object sender, EventArgs e)
        {
            if(chxWindowsA.Checked==false)
                ConnString = "server=" + txtIzvorniPosluzitelj.Text + ";" + "user=" + txtIzvornoKorisnickoIme.Text + ";" + "pwd=" + txtIzvornaLozinka.Text + ";" + "database=" + txtIzvornaBaza.Text + ";";
            else
                ConnString = "Server=" + txtIzvorniPosluzitelj.Text + ";" + "Database=" + txtIzvornaBaza.Text + ";" + "User Id=" + txtIzvornoKorisnickoIme.Text + ";" + "Trusted_Connection=True;";
            PrikazTablica tablice = new PrikazTablica(this, ConnString);
            this.Hide();
            tablice.ShowDialog();
        }

        private void btnTestirajIzvorniPosluzitelj_Click(object sender, EventArgs e)
        {
            ConnString = "server=" + txtIzvorniPosluzitelj.Text + ";" + "user=" + txtIzvornoKorisnickoIme.Text + ";" + "pwd=" + txtIzvornaLozinka.Text + ";" + "database=" + txtIzvornaBaza.Text + ";";
            MigratorModel model = new MigratorModel();
            if (glavna.chxSQLServer.Checked == true)
            {
                if (chxWindowsA.Checked == true)
                {
                    ConnString = "Server=" + txtIzvorniPosluzitelj.Text + ";" + "Database=" + txtIzvornaBaza.Text + ";" + "User Id=" + txtIzvornoKorisnickoIme.Text + ";" + "Trusted_Connection=True;";
                    if (model.SqlServer(ConnString) == true)
                        MessageBox.Show("Connection succeeded!", "Message");
                    else
                        MessageBox.Show("Connection failed!", "Warning");
                }
                else if(chxWindowsA.Checked==false)
                {
                    ConnString = "server=" + txtIzvorniPosluzitelj.Text + ";" + "user=" + txtIzvornoKorisnickoIme.Text + ";" + "pwd=" + txtIzvornaLozinka.Text + ";" + "database=" + txtIzvornaBaza.Text + ";";
                    if (model.SqlServer(ConnString) == true)
                        MessageBox.Show("Connection succeeded!", "Message");
                    else
                        MessageBox.Show("Connection failed!", "Warning");
                }
            }
            if (glavna.chxMySql.Checked == true)
            {
                if (model.Mysql(ConnString) == true)
                    MessageBox.Show("Connection succeeded!", "Message");
                else
                    MessageBox.Show("Connection failed!", "Warning");
            }
            if (glavna.chxPostgreSQL.Checked == true)
            {
                if (model.PostgreSQL(ConnString) == true)
                    MessageBox.Show("Connection succeeded!", "Message");
                else
                    MessageBox.Show("Connection failed!", "Warning");
            }
        }

        private void frmIzvorniPosluzitelj_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
