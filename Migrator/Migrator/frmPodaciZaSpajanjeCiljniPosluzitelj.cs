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
    public partial class frmPodaciZaSpajanjeCiljniPosluzitelj : Form
    {
        public PrikazTablica spremnik2=new PrikazTablica();
        MigratorModel model = new MigratorModel();
        string ConnString;

        public frmPodaciZaSpajanjeCiljniPosluzitelj(PrikazTablica prikazTablica)
        {
            InitializeComponent();
            spremnik2 = prikazTablica;
            if (spremnik2.spremnik.glavna.chxSQLServer.Checked == true)
                chxWindowsACiljni.Enabled = true;
        }

        public frmPodaciZaSpajanjeCiljniPosluzitelj()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNatrag3_Click(object sender, EventArgs e)
        {
            PrikazTablica tabliceBack = new PrikazTablica();
            this.Hide();
            tabliceBack.Show();
        }
        private void btnTestirajCiljniPosluzitelj_Click(object sender, EventArgs e)
        {
            ConnString = "server=" + txtCiljniPosluzitelj.Text + ";" + "user=" + txtCiljnoKorisnickoIme.Text + ";" + "pwd=" + txtCiljnaLozinka.Text + ";" + "database=" + txtCiljnaBaza.Text + ";";
            if (spremnik2.spremnik.glavna.chxSQLServer.Checked == true)
            {
                if (chxWindowsACiljni.Checked== true)
                {
                    ConnString = "Server=" + txtCiljniPosluzitelj.Text + ";" + "Database=" + txtCiljnaBaza.Text + ";" + "User Id=" + txtCiljnoKorisnickoIme.Text + ";" + "Trusted_Connection=True;";
                    if (model.SqlServer(ConnString) == true)
                        MessageBox.Show("Connection succeeded!", "Message");
                    else
                        MessageBox.Show("Connection failed!", "Warning");
                }
                else if (chxWindowsACiljni.Checked == false)
                {
                    ConnString = "server=" + txtCiljniPosluzitelj.Text + ";" + "user=" + txtCiljnoKorisnickoIme.Text + ";" + "pwd=" + txtCiljnaLozinka.Text + ";" + "database=" + txtCiljnaBaza.Text + ";";
                    if (model.SqlServer(ConnString) == true)
                        MessageBox.Show("Connection succeeded!", "Message");
                    else
                        MessageBox.Show("Connection failed!", "Warning");
                }
            }
            if (spremnik2.spremnik.glavna.chxMySql.Checked == true)
            {
                if (model.Mysql(ConnString) == true)
                    MessageBox.Show("Connection succeeded!", "Message");
                else
                    MessageBox.Show("Connection failed!", "Warning");
            }
            if (spremnik2.spremnik.glavna.chxPostgreSQL.Checked == true)
            {
                if (model.PostgreSQL(ConnString) == true)
                    MessageBox.Show("Connection succeeded!", "Message");
                else
                    MessageBox.Show("Connection failed!", "Warning");
            }
        }

        private void btnMigriraj_Click(object sender, EventArgs e)
        {
            if (spremnik2.spremnik.glavna.chxMySql.Checked == true)
            {
                try
                {
                    if (spremnik2.chxSve.Checked == true)
                        model.MySqlImport(true, spremnik2.oznaceneTablice, false, false, false, ConnString, spremnik2.mjestoB);
                    if (spremnik2.chkTablice.Checked == true)
                        model.MySqlImport(false, spremnik2.oznaceneTablice, false, false, false, ConnString, spremnik2.mjestoT);
                    if (spremnik2.chkPogledi.Checked == true)
                        model.MySqlImport(false, spremnik2.oznaceneTablice, true, false, false, ConnString, spremnik2.mjestoPo);
                    if (spremnik2.chkProcedure.Checked == true)
                        model.MySqlImport(false, spremnik2.oznaceneTablice, false, true, false, ConnString, spremnik2.mjestoPr);
                    if (spremnik2.chkOkidaci.Checked == true)
                        model.MySqlImport(false, spremnik2.oznaceneTablice, false, false, true, ConnString, spremnik2.mjestoO);
                    MessageBox.Show("Migration completed!", "Message");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Migration failed");
                }
            }
            if (spremnik2.spremnik.glavna.chxSQLServer.Checked == true)
            {
                try
                {
                    if (spremnik2.chxSve.Checked == true)
                    {
                        model.SqlServerImport(ConnString, spremnik2.mjestoB);
                        model.SqlServerImport(ConnString, spremnik2.SqlServerPodaci);
                    }
                    MessageBox.Show("Migration completed!", "Message");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Migration failed");
                }
            }
            if (spremnik2.spremnik.glavna.chxPostgreSQL.Checked == true)
            {
                string cmd = null;
                try
                {
                    if (spremnik2.chxSve.Checked == true)
                    {
                        cmd = "-i -h " + txtCiljniPosluzitelj.Text + " -p 5432 -U " + txtCiljnoKorisnickoIme.Text + " -d " + txtCiljnaBaza.Text + " -v " + spremnik2.mjestoB;
                        model.PostgreSQLBackupImport("pg_restore", cmd);
                    }
                    if (spremnik2.chkTablice.Checked == true)
                    {
                        foreach (string i in spremnik2.oznaceneTablice)
                        {
                            cmd = "-i -h " + txtCiljniPosluzitelj.Text + " -p 5432 -U " + txtCiljnoKorisnickoIme.Text + " -d " + txtCiljnaBaza.Text + " -v " + spremnik2.mjestoT + @"\\" + i + ".bin";
                            model.PostgreSQLBackupImport("pg_restore", cmd);
                        }
                    }
                    if (spremnik2.chkPogledi.Checked == true)
                    {
                        foreach (string i in spremnik2.oznaceniPogledi)
                        {
                            cmd = "-i -h " + txtCiljniPosluzitelj.Text + " -p 5432 -U " + txtCiljnoKorisnickoIme.Text + " -d " + txtCiljnaBaza.Text + " -v " + spremnik2.mjestoPo + @"\\" + i + ".bin";
                            model.PostgreSQLBackupImport("pg_restore", cmd);
                        }
                    }
                    if (spremnik2.chkProcedure.Checked == true)
                    {
                        foreach (string i in spremnik2.oznaceneProcedure)
                        {
                            cmd = " -h " + txtCiljniPosluzitelj.Text + " -p 5432 -U " + txtCiljnoKorisnickoIme.Text + " -d " + txtCiljnaBaza.Text + " --function=" + i + "() -v " + spremnik2.mjestoB;
                            model.PostgreSQLBackupImport("pg_restore", cmd);
                        }
                    }
                    if (spremnik2.chkOkidaci.Checked == true)
                    {
                        foreach (string i in spremnik2.oznaceniOkidaci)
                        {
                            cmd = " -h " + txtCiljniPosluzitelj.Text + " -p 5432 -U " + txtCiljnoKorisnickoIme.Text + " -d " + txtCiljnaBaza.Text + " --trigger=" + i + " -v " + spremnik2.mjestoB;
                            model.PostgreSQLBackupImport("pg_restore", cmd);
                        }
                    }
                    MessageBox.Show("Migration completed!", "Message");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Migration failed");
                }
            }
            PrikazNakonMigracije nakonMG = new PrikazNakonMigracije(this, ConnString);
            this.Hide();
            nakonMG.ShowDialog();
        }

        private void frmPodaciZaSpajanjeCiljniPosluzitelj_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
