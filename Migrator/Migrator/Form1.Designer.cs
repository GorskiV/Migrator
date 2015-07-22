namespace Migrator
{
    partial class frmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.lblOdabirSUBP = new System.Windows.Forms.Label();
            this.btnDalje = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.chxMySql = new System.Windows.Forms.RadioButton();
            this.chxPostgreSQL = new System.Windows.Forms.RadioButton();
            this.chxSQLServer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdabirSUBP
            // 
            this.lblOdabirSUBP.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabirSUBP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOdabirSUBP.Location = new System.Drawing.Point(12, 12);
            this.lblOdabirSUBP.Name = "lblOdabirSUBP";
            this.lblOdabirSUBP.Size = new System.Drawing.Size(260, 54);
            this.lblOdabirSUBP.TabIndex = 4;
            this.lblOdabirSUBP.Text = "Select DBMS:";
            // 
            // btnDalje
            // 
            this.btnDalje.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDalje.Location = new System.Drawing.Point(389, 280);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(88, 33);
            this.btnDalje.TabIndex = 5;
            this.btnDalje.Text = "Next";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzadji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzadji.Location = new System.Drawing.Point(283, 280);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(88, 33);
            this.btnIzadji.TabIndex = 6;
            this.btnIzadji.Text = "Exit";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // chxMySql
            // 
            this.chxMySql.AutoSize = true;
            this.chxMySql.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chxMySql.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chxMySql.Location = new System.Drawing.Point(262, 132);
            this.chxMySql.Name = "chxMySql";
            this.chxMySql.Size = new System.Drawing.Size(74, 27);
            this.chxMySql.TabIndex = 7;
            this.chxMySql.TabStop = true;
            this.chxMySql.Text = "MySql";
            this.chxMySql.UseVisualStyleBackColor = true;
            // 
            // chxPostgreSQL
            // 
            this.chxPostgreSQL.AutoSize = true;
            this.chxPostgreSQL.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chxPostgreSQL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chxPostgreSQL.Location = new System.Drawing.Point(262, 180);
            this.chxPostgreSQL.Name = "chxPostgreSQL";
            this.chxPostgreSQL.Size = new System.Drawing.Size(109, 27);
            this.chxPostgreSQL.TabIndex = 8;
            this.chxPostgreSQL.TabStop = true;
            this.chxPostgreSQL.Text = "PostgreSql";
            this.chxPostgreSQL.UseVisualStyleBackColor = true;
            // 
            // chxSQLServer
            // 
            this.chxSQLServer.AutoSize = true;
            this.chxSQLServer.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chxSQLServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chxSQLServer.Location = new System.Drawing.Point(262, 228);
            this.chxSQLServer.Name = "chxSQLServer";
            this.chxSQLServer.Size = new System.Drawing.Size(103, 27);
            this.chxSQLServer.TabIndex = 9;
            this.chxSQLServer.TabStop = true;
            this.chxSQLServer.Text = "Sql Server";
            this.chxSQLServer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblOdabirSUBP);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 79);
            this.panel1.TabIndex = 10;
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(496, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chxSQLServer);
            this.Controls.Add(this.chxPostgreSQL);
            this.Controls.Add(this.chxMySql);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnDalje);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Migrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGlavna_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdabirSUBP;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Button btnIzadji;
        public System.Windows.Forms.RadioButton chxMySql;
        public System.Windows.Forms.RadioButton chxPostgreSQL;
        public System.Windows.Forms.RadioButton chxSQLServer;
        private System.Windows.Forms.Panel panel1;
    }
}

