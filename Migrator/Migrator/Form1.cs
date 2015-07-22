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
    public partial class frmGlavna : Form
    {

        public static string postgreInstalation=null;

        public frmGlavna()
        {
            InitializeComponent();
        }

        StringBuilder sbPG_dumpPath = new StringBuilder();
        String strPG_dumpPath = String.Empty;
        string strInstallLocation = string.Empty;

        private void btnDalje_Click(object sender, EventArgs e)
        {
            if (chxPostgreSQL.Checked == false && chxMySql.Checked == false && chxSQLServer.Checked == false)
            {
                MessageBox.Show("Choose one DBMS!", "Warning");
            }
            else if (chxPostgreSQL.Checked == true)
            {
                MigratorModel traziPostgre = new MigratorModel();
                postgreInstalation = traziPostgre.verifyPostgreInstalation();
                if (postgreInstalation.Length > 4)
                {
                    MessageBox.Show("Your System is INSATALLED with Postgres", "Message");
                    frmIzvorniPosluzitelj frmIzvorni = new frmIzvorniPosluzitelj(this);
                    this.Hide();
                    frmIzvorni.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your System is NOT INSATALLED with Postgres", "Message");
                }
            }
            else
            {

                frmIzvorniPosluzitelj frmIzvorni = new frmIzvorniPosluzitelj(this);
                this.Hide();
                frmIzvorni.ShowDialog();
            }
        }
            

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void frmGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
