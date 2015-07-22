namespace Migrator
{
    partial class frmIzvorniPosluzitelj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvorniPosluzitelj));
            this.lblPosluzitelj = new System.Windows.Forms.Label();
            this.txtIzvorniPosluzitelj = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtIzvornoKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtIzvornaLozinka = new System.Windows.Forms.TextBox();
            this.btnTestirajIzvorniPosluzitelj = new System.Windows.Forms.Button();
            this.btnDalje2 = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblBaza = new System.Windows.Forms.Label();
            this.txtIzvornaBaza = new System.Windows.Forms.TextBox();
            this.chxWindowsA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPosluzitelj
            // 
            this.lblPosluzitelj.AutoSize = true;
            this.lblPosluzitelj.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosluzitelj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPosluzitelj.Location = new System.Drawing.Point(12, 29);
            this.lblPosluzitelj.Name = "lblPosluzitelj";
            this.lblPosluzitelj.Size = new System.Drawing.Size(49, 23);
            this.lblPosluzitelj.TabIndex = 0;
            this.lblPosluzitelj.Text = "Host:";
            // 
            // txtIzvorniPosluzitelj
            // 
            this.txtIzvorniPosluzitelj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIzvorniPosluzitelj.Location = new System.Drawing.Point(16, 55);
            this.txtIzvorniPosluzitelj.Multiline = true;
            this.txtIzvorniPosluzitelj.Name = "txtIzvorniPosluzitelj";
            this.txtIzvorniPosluzitelj.Size = new System.Drawing.Size(311, 26);
            this.txtIzvorniPosluzitelj.TabIndex = 1;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(12, 84);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(91, 23);
            this.lblKorisnickoIme.TabIndex = 2;
            this.lblKorisnickoIme.Text = "Username:";
            // 
            // txtIzvornoKorisnickoIme
            // 
            this.txtIzvornoKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIzvornoKorisnickoIme.Location = new System.Drawing.Point(16, 110);
            this.txtIzvornoKorisnickoIme.Multiline = true;
            this.txtIzvornoKorisnickoIme.Name = "txtIzvornoKorisnickoIme";
            this.txtIzvornoKorisnickoIme.Size = new System.Drawing.Size(260, 26);
            this.txtIzvornoKorisnickoIme.TabIndex = 2;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLozinka.Location = new System.Drawing.Point(12, 139);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(85, 23);
            this.lblLozinka.TabIndex = 4;
            this.lblLozinka.Text = "Password:";
            // 
            // txtIzvornaLozinka
            // 
            this.txtIzvornaLozinka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzvornaLozinka.Location = new System.Drawing.Point(16, 165);
            this.txtIzvornaLozinka.Multiline = true;
            this.txtIzvornaLozinka.Name = "txtIzvornaLozinka";
            this.txtIzvornaLozinka.PasswordChar = '*';
            this.txtIzvornaLozinka.Size = new System.Drawing.Size(260, 26);
            this.txtIzvornaLozinka.TabIndex = 3;
            // 
            // btnTestirajIzvorniPosluzitelj
            // 
            this.btnTestirajIzvorniPosluzitelj.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTestirajIzvorniPosluzitelj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTestirajIzvorniPosluzitelj.Location = new System.Drawing.Point(16, 308);
            this.btnTestirajIzvorniPosluzitelj.Name = "btnTestirajIzvorniPosluzitelj";
            this.btnTestirajIzvorniPosluzitelj.Size = new System.Drawing.Size(140, 33);
            this.btnTestirajIzvorniPosluzitelj.TabIndex = 6;
            this.btnTestirajIzvorniPosluzitelj.Text = "Test connection";
            this.btnTestirajIzvorniPosluzitelj.UseVisualStyleBackColor = true;
            this.btnTestirajIzvorniPosluzitelj.Click += new System.EventHandler(this.btnTestirajIzvorniPosluzitelj_Click);
            // 
            // btnDalje2
            // 
            this.btnDalje2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDalje2.Location = new System.Drawing.Point(333, 308);
            this.btnDalje2.Name = "btnDalje2";
            this.btnDalje2.Size = new System.Drawing.Size(88, 33);
            this.btnDalje2.TabIndex = 7;
            this.btnDalje2.Text = "Next";
            this.btnDalje2.UseVisualStyleBackColor = true;
            this.btnDalje2.Click += new System.EventHandler(this.btnDalje2_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Location = new System.Drawing.Point(239, 308);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(88, 33);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "Back";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblBaza
            // 
            this.lblBaza.AutoSize = true;
            this.lblBaza.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaza.Location = new System.Drawing.Point(12, 194);
            this.lblBaza.Name = "lblBaza";
            this.lblBaza.Size = new System.Drawing.Size(133, 23);
            this.lblBaza.TabIndex = 11;
            this.lblBaza.Text = "Database name:";
            // 
            // txtIzvornaBaza
            // 
            this.txtIzvornaBaza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzvornaBaza.Location = new System.Drawing.Point(16, 220);
            this.txtIzvornaBaza.Multiline = true;
            this.txtIzvornaBaza.Name = "txtIzvornaBaza";
            this.txtIzvornaBaza.Size = new System.Drawing.Size(260, 26);
            this.txtIzvornaBaza.TabIndex = 5;
            // 
            // chxWindowsA
            // 
            this.chxWindowsA.AutoSize = true;
            this.chxWindowsA.Enabled = false;
            this.chxWindowsA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chxWindowsA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chxWindowsA.Location = new System.Drawing.Point(16, 265);
            this.chxWindowsA.Name = "chxWindowsA";
            this.chxWindowsA.Size = new System.Drawing.Size(260, 24);
            this.chxWindowsA.TabIndex = 12;
            this.chxWindowsA.Text = "Sql Server Windows Authentication";
            this.chxWindowsA.UseVisualStyleBackColor = true;
            // 
            // frmIzvorniPosluzitelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(433, 350);
            this.Controls.Add(this.chxWindowsA);
            this.Controls.Add(this.txtIzvornaBaza);
            this.Controls.Add(this.lblBaza);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDalje2);
            this.Controls.Add(this.btnTestirajIzvorniPosluzitelj);
            this.Controls.Add(this.txtIzvornaLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtIzvornoKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtIzvorniPosluzitelj);
            this.Controls.Add(this.lblPosluzitelj);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIzvorniPosluzitelj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start host";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIzvorniPosluzitelj_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosluzitelj;
        public System.Windows.Forms.TextBox txtIzvorniPosluzitelj;
        private System.Windows.Forms.Label lblKorisnickoIme;
        public System.Windows.Forms.TextBox txtIzvornoKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        public System.Windows.Forms.TextBox txtIzvornaLozinka;
        private System.Windows.Forms.Button btnTestirajIzvorniPosluzitelj;
        private System.Windows.Forms.Button btnDalje2;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblBaza;
        public System.Windows.Forms.TextBox txtIzvornaBaza;
        public System.Windows.Forms.CheckBox chxWindowsA;
    }
}