namespace Migrator
{
    partial class PrikazTablica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazTablica));
            this.lblPrikazPodataka = new System.Windows.Forms.Label();
            this.btnDalje3 = new System.Windows.Forms.Button();
            this.btnNatrag2 = new System.Windows.Forms.Button();
            this.dgvPopisTablica = new System.Windows.Forms.DataGridView();
            this.chkTablice = new System.Windows.Forms.CheckBox();
            this.chkPogledi = new System.Windows.Forms.CheckBox();
            this.chkProcedure = new System.Windows.Forms.CheckBox();
            this.chkOkidaci = new System.Windows.Forms.CheckBox();
            this.mgTablice = new System.Windows.Forms.RadioButton();
            this.mgPogledi = new System.Windows.Forms.RadioButton();
            this.mgProcedure = new System.Windows.Forms.RadioButton();
            this.mgOkidaci = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chxSve = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTablica)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrikazPodataka
            // 
            this.lblPrikazPodataka.AutoSize = true;
            this.lblPrikazPodataka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazPodataka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrikazPodataka.Location = new System.Drawing.Point(9, 85);
            this.lblPrikazPodataka.Name = "lblPrikazPodataka";
            this.lblPrikazPodataka.Size = new System.Drawing.Size(45, 21);
            this.lblPrikazPodataka.TabIndex = 3;
            this.lblPrikazPodataka.Text = "Data:";
            // 
            // btnDalje3
            // 
            this.btnDalje3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDalje3.Location = new System.Drawing.Point(447, 345);
            this.btnDalje3.Name = "btnDalje3";
            this.btnDalje3.Size = new System.Drawing.Size(88, 33);
            this.btnDalje3.TabIndex = 6;
            this.btnDalje3.Text = "Next";
            this.btnDalje3.UseVisualStyleBackColor = true;
            this.btnDalje3.Click += new System.EventHandler(this.btnDalje3_Click);
            // 
            // btnNatrag2
            // 
            this.btnNatrag2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag2.Location = new System.Drawing.Point(323, 345);
            this.btnNatrag2.Name = "btnNatrag2";
            this.btnNatrag2.Size = new System.Drawing.Size(88, 33);
            this.btnNatrag2.TabIndex = 7;
            this.btnNatrag2.Text = "Back";
            this.btnNatrag2.UseVisualStyleBackColor = true;
            this.btnNatrag2.Click += new System.EventHandler(this.btnNatrag2_Click);
            // 
            // dgvPopisTablica
            // 
            this.dgvPopisTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisTablica.Location = new System.Drawing.Point(12, 109);
            this.dgvPopisTablica.Name = "dgvPopisTablica";
            this.dgvPopisTablica.Size = new System.Drawing.Size(248, 214);
            this.dgvPopisTablica.TabIndex = 9;
            this.dgvPopisTablica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisTablica_CellClick);
            // 
            // chkTablice
            // 
            this.chkTablice.AutoSize = true;
            this.chkTablice.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkTablice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkTablice.Location = new System.Drawing.Point(14, 31);
            this.chkTablice.Name = "chkTablice";
            this.chkTablice.Size = new System.Drawing.Size(77, 27);
            this.chkTablice.TabIndex = 10;
            this.chkTablice.Text = "Tables";
            this.chkTablice.UseVisualStyleBackColor = true;
            // 
            // chkPogledi
            // 
            this.chkPogledi.AutoSize = true;
            this.chkPogledi.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkPogledi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkPogledi.Location = new System.Drawing.Point(14, 64);
            this.chkPogledi.Name = "chkPogledi";
            this.chkPogledi.Size = new System.Drawing.Size(72, 27);
            this.chkPogledi.TabIndex = 11;
            this.chkPogledi.Text = "Views";
            this.chkPogledi.UseVisualStyleBackColor = true;
            // 
            // chkProcedure
            // 
            this.chkProcedure.AutoSize = true;
            this.chkProcedure.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkProcedure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkProcedure.Location = new System.Drawing.Point(14, 96);
            this.chkProcedure.Name = "chkProcedure";
            this.chkProcedure.Size = new System.Drawing.Size(194, 27);
            this.chkProcedure.TabIndex = 12;
            this.chkProcedure.Text = "Procedures/Functions";
            this.chkProcedure.UseVisualStyleBackColor = true;
            // 
            // chkOkidaci
            // 
            this.chkOkidaci.AutoSize = true;
            this.chkOkidaci.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkOkidaci.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkOkidaci.Location = new System.Drawing.Point(15, 129);
            this.chkOkidaci.Name = "chkOkidaci";
            this.chkOkidaci.Size = new System.Drawing.Size(90, 27);
            this.chkOkidaci.TabIndex = 13;
            this.chkOkidaci.Text = "Triggers";
            this.chkOkidaci.UseVisualStyleBackColor = true;
            // 
            // mgTablice
            // 
            this.mgTablice.AutoSize = true;
            this.mgTablice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mgTablice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mgTablice.Location = new System.Drawing.Point(6, 27);
            this.mgTablice.Name = "mgTablice";
            this.mgTablice.Size = new System.Drawing.Size(72, 25);
            this.mgTablice.TabIndex = 15;
            this.mgTablice.TabStop = true;
            this.mgTablice.Text = "Tables";
            this.mgTablice.UseVisualStyleBackColor = true;
            this.mgTablice.CheckedChanged += new System.EventHandler(this.mgTablice_CheckedChanged);
            // 
            // mgPogledi
            // 
            this.mgPogledi.AutoSize = true;
            this.mgPogledi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mgPogledi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mgPogledi.Location = new System.Drawing.Point(113, 26);
            this.mgPogledi.Name = "mgPogledi";
            this.mgPogledi.Size = new System.Drawing.Size(69, 25);
            this.mgPogledi.TabIndex = 16;
            this.mgPogledi.TabStop = true;
            this.mgPogledi.Text = "Views";
            this.mgPogledi.UseVisualStyleBackColor = true;
            this.mgPogledi.CheckedChanged += new System.EventHandler(this.mgPogledi_CheckedChanged);
            // 
            // mgProcedure
            // 
            this.mgProcedure.AutoSize = true;
            this.mgProcedure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mgProcedure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mgProcedure.Location = new System.Drawing.Point(221, 27);
            this.mgProcedure.Name = "mgProcedure";
            this.mgProcedure.Size = new System.Drawing.Size(179, 25);
            this.mgProcedure.TabIndex = 17;
            this.mgProcedure.TabStop = true;
            this.mgProcedure.Text = "Procedures/Functions";
            this.mgProcedure.UseVisualStyleBackColor = true;
            this.mgProcedure.CheckedChanged += new System.EventHandler(this.mgProcedure_CheckedChanged);
            // 
            // mgOkidaci
            // 
            this.mgOkidaci.AutoSize = true;
            this.mgOkidaci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mgOkidaci.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mgOkidaci.Location = new System.Drawing.Point(414, 27);
            this.mgOkidaci.Name = "mgOkidaci";
            this.mgOkidaci.Size = new System.Drawing.Size(85, 25);
            this.mgOkidaci.TabIndex = 18;
            this.mgOkidaci.TabStop = true;
            this.mgOkidaci.Text = "Triggers";
            this.mgOkidaci.UseVisualStyleBackColor = true;
            this.mgOkidaci.CheckedChanged += new System.EventHandler(this.mgOkidaci_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPrikaz);
            this.panel1.Controls.Add(this.mgProcedure);
            this.panel1.Controls.Add(this.mgTablice);
            this.panel1.Controls.Add(this.mgPogledi);
            this.panel1.Controls.Add(this.mgOkidaci);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 70);
            this.panel1.TabIndex = 20;
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrikaz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrikaz.Location = new System.Drawing.Point(2, 2);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(98, 21);
            this.lblPrikaz.TabIndex = 14;
            this.lblPrikaz.Text = "Display data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Migrate:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chxSve);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkOkidaci);
            this.panel2.Controls.Add(this.chkProcedure);
            this.panel2.Controls.Add(this.chkPogledi);
            this.panel2.Controls.Add(this.chkTablice);
            this.panel2.Location = new System.Drawing.Point(323, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 214);
            this.panel2.TabIndex = 22;
            // 
            // chxSve
            // 
            this.chxSve.AutoSize = true;
            this.chxSve.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chxSve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chxSve.Location = new System.Drawing.Point(14, 180);
            this.chxSve.Name = "chxSve";
            this.chxSve.Size = new System.Drawing.Size(87, 27);
            this.chxSve.TabIndex = 22;
            this.chxSve.Text = "All data";
            this.chxSve.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowse.Location = new System.Drawing.Point(107, 345);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(153, 33);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Choose file";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // PrikazTablica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(546, 391);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPopisTablica);
            this.Controls.Add(this.btnNatrag2);
            this.Controls.Add(this.btnDalje3);
            this.Controls.Add(this.lblPrikazPodataka);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrikazTablica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data display";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrikazTablica_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTablica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrikazPodataka;
        public System.Windows.Forms.Button btnDalje3;
        public System.Windows.Forms.Button btnNatrag2;
        private System.Windows.Forms.DataGridView dgvPopisTablica;
        public System.Windows.Forms.CheckBox chkTablice;
        public System.Windows.Forms.CheckBox chkPogledi;
        public System.Windows.Forms.CheckBox chkProcedure;
        public System.Windows.Forms.CheckBox chkOkidaci;
        private System.Windows.Forms.RadioButton mgTablice;
        private System.Windows.Forms.RadioButton mgPogledi;
        private System.Windows.Forms.RadioButton mgProcedure;
        private System.Windows.Forms.RadioButton mgOkidaci;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.CheckBox chxSve;
        public System.Windows.Forms.Button btnBrowse;
    }
}