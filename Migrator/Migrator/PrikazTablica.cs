using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migrator
{
    public partial class PrikazTablica : Form
    {
        public frmIzvorniPosluzitelj spremnik = new frmIzvorniPosluzitelj();
        string spremnik_za_vezu;

        public PrikazTablica(frmIzvorniPosluzitelj izvorniPosluzitelj, string constring)
        {
            InitializeComponent();
            spremnik = izvorniPosluzitelj;
            spremnik_za_vezu = constring;
            if (spremnik.glavna.chxSQLServer.Checked == true)
            {
                chkTablice.Enabled = false;
                chkProcedure.Enabled = false;
                chkPogledi.Enabled = false;
                chkOkidaci.Enabled = false;
            }
        }

        public PrikazTablica()
        {
            InitializeComponent();
            oznaceneTablice = null;
            oznaceneProcedure = null;
            oznaceniOkidaci = null;
            oznaceniPogledi = null;
        }

        MigratorModel model = new MigratorModel();

        private void btnNatrag2_Click(object sender, EventArgs e)
        {
            frmIzvorniPosluzitelj izvorniPosluziteljBack = new frmIzvorniPosluzitelj();
            this.Hide();
            izvorniPosluziteljBack.ShowDialog();
        }
        public string pohrana2;
        private void btnDalje3_Click(object sender, EventArgs e)
        {
            frmPodaciZaSpajanjeCiljniPosluzitelj ciljniPosluzitelj = new frmPodaciZaSpajanjeCiljniPosluzitelj(this);
            if (mjestoB != null)
            {
                if (chkOkidaci.Checked == false && chkPogledi.Checked == false && chkProcedure.Checked == false && chkTablice.Checked == false && chxSve.Checked == false)
                    MessageBox.Show("Choose migration option!", "Message");
                else
                {
                    if (spremnik.glavna.chxMySql.Checked == true)
                    {
                        try
                        {
                            if (chxSve.Checked == true)
                            {
                                mjestoB += @"\\MySqlBaza.sql";
                                model.MySQLExport(true, oznaceneTablice, false, false, false, spremnik_za_vezu, mjestoB);
                            }
                            if (chkTablice.Checked == true)
                            {
                                if (oznaceneTablice.Count < 1)
                                {
                                    MessageBox.Show("Pick some tables", "Message");
                                    return;
                                }
                                mjestoT += @"\\MySqlTablice.sql";
                                model.MySQLExport(false, oznaceneTablice, false, false, false, spremnik_za_vezu, mjestoT);
                                oznaceneTablice.Clear();
                                ///////////*********************************************/////////////// tu pazi !!!!!!!!!!
                            }
                            if (chkPogledi.Checked == true)
                            {
                                mjestoPo += @"\\MySqlPogledi.sql";
                                model.MySQLExport(false, oznaceneTablice, true, false, false, spremnik_za_vezu, mjestoPo);
                            }
                            if (chkProcedure.Checked == true)
                            {
                                mjestoPr += @"\\MySqlProcedure.sql";
                                model.MySQLExport(false, oznaceneTablice, false, true, false, spremnik_za_vezu, mjestoPr);
                            }
                            if (chkOkidaci.Checked == true)
                            {
                                mjestoO += @"\\MySqlOkidaci.sql";
                                model.MySQLExport(false, oznaceneTablice, false, false, true, spremnik_za_vezu, mjestoO);
                            }
                            MessageBox.Show("Backup completed", "Message");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error");
                        }
                    }
                    if (spremnik.glavna.chxSQLServer.Checked == true)
                    {
                        try
                        {

                            if (chxSve.Checked == true)
                            {
                                mjestoB += @"\\SqlServerShemaBaze.sql";
                                model.SQLServerExportStrukturaBaze(spremnik_za_vezu, spremnik.txtIzvornaBaza.Text, mjestoB);
                                SqlServerPodaci += @"\\SqlServerPodaci.sql";
                                model.SQLServerExportPodaci(spremnik_za_vezu, spremnik.txtIzvornaBaza.Text, SqlServerPodaci);
                            }
                            MessageBox.Show("Backup completed", "Message");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error");
                        }
                    }
                    if (spremnik.glavna.chxPostgreSQL.Checked == true)
                    {
                        string cmd = null;
                        try
                        {
                            if (chxSve.Checked == true)
                            {
                                mjestoB += @"\\PSQLBaza.bin";
                                cmd = "-Fc -d " + spremnik.txtIzvornaBaza.Text + " -h " + spremnik.txtIzvorniPosluzitelj.Text + " -p 5432 " + " -U " + spremnik.txtIzvornoKorisnickoIme.Text + " -f " + mjestoB;
                                model.PostgreSQLBackupImport("pg_dump", cmd);
                            }
                            if (chkPogledi.Checked == true)
                            {
                                if (oznaceniPogledi.Count > 0)
                                {
                                    foreach (string i in oznaceniPogledi)
                                    {
                                        cmd = "-Fc -t " + i + " -U " + spremnik.txtIzvornoKorisnickoIme.Text + " -f " + mjestoPo + @"\\" + i + ".bin " + spremnik.txtIzvornaBaza.Text;
                                        model.PostgreSQLBackupImport("pg_dump", cmd);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Pick some views!", "Message");
                                    return;
                                }
                            }
                            if (chkTablice.Checked == true)
                            {
                                if (oznaceneTablice.Count > 0)
                                {
                                    foreach (string i in oznaceneTablice)
                                    {
                                        cmd = "-Fc -t " + i + " -U " + spremnik.txtIzvornoKorisnickoIme.Text + " -f " + mjestoT + @"\\" + i + ".bin " + spremnik.txtIzvornaBaza.Text;
                                        model.PostgreSQLBackupImport("pg_dump", cmd);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Pick some tables!", "Message");
                                    return;
                                }
                            }
                            if (chkProcedure.Checked == true)
                            {
                                if (oznaceneProcedure.Count < 1)
                                {
                                    MessageBox.Show("Pick some functions!", "Message");
                                    return;
                                }
                                else
                                {
                                    cmd = "-Fc -d " + spremnik.txtIzvornaBaza.Text + " -h " + spremnik.txtIzvorniPosluzitelj.Text + " -p 5432 " + " -U " + spremnik.txtIzvornoKorisnickoIme.Text + " -f " + mjestoB + @"\\PSQLBaza.bin";
                                    model.PostgreSQLBackupImport("pg_dump", cmd);
                                }
                            }
                            if (chkOkidaci.Checked == true)
                            {
                                if (oznaceniOkidaci.Count < 1)
                                {
                                    MessageBox.Show("Pick some triggers!", "Message");
                                    return;
                                }
                                else
                                {
                                    cmd = "-Fc -d " + spremnik.txtIzvornaBaza.Text + " -h " + spremnik.txtIzvorniPosluzitelj.Text + " -p 5432 " + " -U " + spremnik.txtIzvornoKorisnickoIme.Text + " -f " + mjestoB + @"\\PSQLBaza.bin";
                                    model.PostgreSQLBackupImport("pg_dump", cmd);
                                }
                            }
                            MessageBox.Show("Backup completed!", "Message");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error");
                        }
                    }
                    this.Hide();
                    ciljniPosluzitelj.ShowDialog();
                }
            }
            else
                MessageBox.Show("Choose file where backup will be stored!", "Warning");
        }

        private void mgTablice_CheckedChanged(object sender, EventArgs e)
        {
            dgvPopisTablica.DataSource = null;
            dgvPopisTablica.Refresh();
            BindingSource tablice = new BindingSource();
            if (spremnik.glavna.chxSQLServer.Checked == true)
            {
                tablice.DataSource = model.SqlServerTablice(spremnik_za_vezu);
                dgvPopisTablica.DataSource = tablice;
                if (tablice.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxMySql.Checked == true)
            {
                tablice.DataSource = model.MySqlTables(spremnik_za_vezu);
                dgvPopisTablica.DataSource = tablice;
                if (tablice.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxPostgreSQL.Checked == true)
            {
                tablice.DataSource = model.PostgreSQLTablice(spremnik_za_vezu);
                dgvPopisTablica.DataSource = tablice;
                if (tablice.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
        }

        private void mgPogledi_CheckedChanged(object sender, EventArgs e)
        {
            dgvPopisTablica.DataSource = null;
            dgvPopisTablica.Refresh();
            BindingSource pogledi = new BindingSource();
            if (spremnik.glavna.chxSQLServer.Checked == true)
            {
                pogledi.DataSource = model.SqlServerPogledi(spremnik_za_vezu);
                dgvPopisTablica.DataSource = pogledi;
                if (pogledi.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxMySql.Checked == true)
            {
                pogledi.DataSource = model.MySqlViews(spremnik_za_vezu);
                dgvPopisTablica.DataSource = pogledi;
                if (pogledi.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxPostgreSQL.Checked == true)
            {
                pogledi.DataSource = model.PostgreSQLPogledi(spremnik_za_vezu);
                dgvPopisTablica.DataSource = pogledi;
                if (pogledi.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
        }

        private void mgProcedure_CheckedChanged(object sender, EventArgs e)
        {
            dgvPopisTablica.DataSource = null;
            dgvPopisTablica.Refresh();
            BindingSource procedure = new BindingSource();
            if (spremnik.glavna.chxSQLServer.Checked == true)
            {
                procedure.DataSource = model.SqlServerProcedure(spremnik_za_vezu);
                dgvPopisTablica.DataSource = procedure;
                if (procedure.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxMySql.Checked == true)
            {
                procedure.DataSource = model.MySqlProcedures(spremnik_za_vezu);
                dgvPopisTablica.DataSource = procedure;
                if (procedure.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxPostgreSQL.Checked == true)
            {
                procedure.DataSource = model.PostgreSQLProcedure(spremnik_za_vezu);
                dgvPopisTablica.DataSource = procedure;
                if (procedure.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
        }

        private void mgOkidaci_CheckedChanged(object sender, EventArgs e)
        {
            dgvPopisTablica.DataSource = null;
            dgvPopisTablica.Refresh();
            BindingSource okidaci = new BindingSource();
            if (spremnik.glavna.chxSQLServer.Checked == true)
            {
                okidaci.DataSource = model.SqlServerOkidaci(spremnik_za_vezu);
                dgvPopisTablica.DataSource = okidaci;
                if (okidaci.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxMySql.Checked == true)
            {
                okidaci.DataSource = model.MySqlTriggers(spremnik_za_vezu);
                dgvPopisTablica.DataSource = okidaci;
                if (okidaci.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik.glavna.chxPostgreSQL.Checked == true)
            {
                okidaci.DataSource = model.PostgreSQLOkidaci(spremnik_za_vezu);
                dgvPopisTablica.DataSource = okidaci;
                if (okidaci.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
        }

        public List<string> oznaceneTablice = new List<string>();
        public List<string> oznaceniPogledi = new List<string>();
        public List<string> oznaceneProcedure = new List<string>();
        public List<string> oznaceniOkidaci = new List<string>();
        private void dgvPopisTablica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mgTablice.Checked == true)
                oznaceneTablice.Add(dgvPopisTablica.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (mgPogledi.Checked == true)
                oznaceniPogledi.Add(dgvPopisTablica.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (mgProcedure.Checked == true)
                oznaceneProcedure.Add(dgvPopisTablica.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (mgOkidaci.Checked == true)
                oznaceniOkidaci.Add(dgvPopisTablica.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        //treba ti zbog MySql-a i SqlServera-a
        public string mjestoB = null;
        public string mjestoT = null;
        public string mjestoPo = null;
        public string mjestoPr = null;
        public string mjestoO = null;
        public string SqlServerPodaci = null;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (fbd.SelectedPath.Contains(" "))
                {
                    MessageBox.Show("Please provide folder path which does NOT contains spaces!", "Warning");
                }
                else
                {
                    mjestoB = fbd.SelectedPath;
                    mjestoT = fbd.SelectedPath;
                    mjestoPo = fbd.SelectedPath;
                    mjestoPr = fbd.SelectedPath;
                    mjestoO = fbd.SelectedPath;
                    SqlServerPodaci = fbd.SelectedPath;
                }
            }
        }

        private void PrikazTablica_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
