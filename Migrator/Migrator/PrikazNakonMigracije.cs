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
    public partial class PrikazNakonMigracije : Form
    {
        string spremnik_za_vezu = null;
        MigratorModel model = new MigratorModel();
        frmPodaciZaSpajanjeCiljniPosluzitelj spremnik3 = new frmPodaciZaSpajanjeCiljniPosluzitelj();
        public PrikazNakonMigracije(frmPodaciZaSpajanjeCiljniPosluzitelj sp, string ConnString)
        {
            InitializeComponent();
            spremnik3 = sp;
            spremnik_za_vezu = ConnString;
        }

        public PrikazNakonMigracije()
        {
            InitializeComponent();
        }

        private void mgTablice_CheckedChanged(object sender, EventArgs e)
        {
            dgvPopisTablica.DataSource = null;
            dgvPopisTablica.Refresh();
            BindingSource tablice = new BindingSource();
            if (spremnik3.spremnik2.spremnik.glavna.chxSQLServer.Checked == true)
            {
                tablice.DataSource = model.SqlServerTablice(spremnik_za_vezu);
                dgvPopisTablica.DataSource = tablice;
                if (tablice.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxMySql.Checked == true)
            {
                tablice.DataSource = model.MySqlTables(spremnik_za_vezu);
                dgvPopisTablica.DataSource = tablice;
                if (tablice.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxPostgreSQL.Checked == true)
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
            if (spremnik3.spremnik2.spremnik.glavna.chxSQLServer.Checked == true)
            {
                pogledi.DataSource = model.SqlServerPogledi(spremnik_za_vezu);
                dgvPopisTablica.DataSource = pogledi;
                if (pogledi.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxMySql.Checked == true)
            {
                pogledi.DataSource = model.MySqlViews(spremnik_za_vezu);
                dgvPopisTablica.DataSource = pogledi;
                if (pogledi.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxPostgreSQL.Checked == true)
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
            if (spremnik3.spremnik2.spremnik.glavna.chxSQLServer.Checked == true)
            {
                procedure.DataSource = model.SqlServerProcedure(spremnik_za_vezu);
                dgvPopisTablica.DataSource = procedure;
                if (procedure.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxMySql.Checked == true)
            {
                procedure.DataSource = model.MySqlProcedures(spremnik_za_vezu);
                dgvPopisTablica.DataSource = procedure;
                if (procedure.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxPostgreSQL.Checked == true)
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
            if (spremnik3.spremnik2.spremnik.glavna.chxSQLServer.Checked == true)
            {
                okidaci.DataSource = model.SqlServerOkidaci(spremnik_za_vezu);
                dgvPopisTablica.DataSource = okidaci;
                if (okidaci.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxMySql.Checked == true)
            {
                okidaci.DataSource = model.MySqlTriggers(spremnik_za_vezu);
                dgvPopisTablica.DataSource = okidaci;
                if (okidaci.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
            if (spremnik3.spremnik2.spremnik.glavna.chxPostgreSQL.Checked == true)
            {
                okidaci.DataSource = model.PostgreSQLOkidaci(spremnik_za_vezu);
                dgvPopisTablica.DataSource = okidaci;
                if (okidaci.Count > 0)
                    dgvPopisTablica.Columns[0].Width = 270;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnPocetak_Click(object sender, EventArgs e)
        {
            frmGlavna pocetak = new frmGlavna();
            this.Hide();
            pocetak.Show();
        }

        private void PrikazNakonMigracije_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
