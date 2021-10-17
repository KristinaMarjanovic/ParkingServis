namespace ParkingServis
{
    partial class Zakupci
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
            this.FizickaLica_groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrikaziFizickaLica = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLicneKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojVozackeDozvole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PravnaLica_groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrikaziPravnaLica = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeOvlascenogLica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DodajZakupca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IdZakupca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaZakupca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrikaziSveZakupce = new System.Windows.Forms.Button();
            this.FizickaLica_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PravnaLica_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // FizickaLica_groupBox1
            // 
            this.FizickaLica_groupBox1.Controls.Add(this.PrikaziFizickaLica);
            this.FizickaLica_groupBox1.Controls.Add(this.dataGridView1);
            this.FizickaLica_groupBox1.Location = new System.Drawing.Point(12, 250);
            this.FizickaLica_groupBox1.Name = "FizickaLica_groupBox1";
            this.FizickaLica_groupBox1.Size = new System.Drawing.Size(798, 235);
            this.FizickaLica_groupBox1.TabIndex = 0;
            this.FizickaLica_groupBox1.TabStop = false;
            this.FizickaLica_groupBox1.Text = "Fizicka lica";
            // 
            // PrikaziFizickaLica
            // 
            this.PrikaziFizickaLica.Location = new System.Drawing.Point(348, 193);
            this.PrikaziFizickaLica.Name = "PrikaziFizickaLica";
            this.PrikaziFizickaLica.Size = new System.Drawing.Size(173, 23);
            this.PrikaziFizickaLica.TabIndex = 1;
            this.PrikaziFizickaLica.Text = "Prikazi fizicka lica";
            this.PrikaziFizickaLica.UseVisualStyleBackColor = true;
            this.PrikaziFizickaLica.Click += new System.EventHandler(this.PrikaziFizickaLica_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.JMBG,
            this.Adresa,
            this.BrojLicneKarte,
            this.BrojVozackeDozvole});
            this.dataGridView1.Location = new System.Drawing.Point(29, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // JMBG
            // 
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            // 
            // Adresa
            // 
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // BrojLicneKarte
            // 
            this.BrojLicneKarte.HeaderText = "Broj licne karte";
            this.BrojLicneKarte.Name = "BrojLicneKarte";
            // 
            // BrojVozackeDozvole
            // 
            this.BrojVozackeDozvole.HeaderText = "Broj vozacke dozvole";
            this.BrojVozackeDozvole.Name = "BrojVozackeDozvole";
            // 
            // PravnaLica_groupBox1
            // 
            this.PravnaLica_groupBox1.Controls.Add(this.PrikaziPravnaLica);
            this.PravnaLica_groupBox1.Controls.Add(this.dataGridView2);
            this.PravnaLica_groupBox1.Location = new System.Drawing.Point(12, 522);
            this.PravnaLica_groupBox1.Name = "PravnaLica_groupBox1";
            this.PravnaLica_groupBox1.Size = new System.Drawing.Size(538, 181);
            this.PravnaLica_groupBox1.TabIndex = 1;
            this.PravnaLica_groupBox1.TabStop = false;
            this.PravnaLica_groupBox1.Text = "Pravna lica";
            // 
            // PrikaziPravnaLica
            // 
            this.PrikaziPravnaLica.Location = new System.Drawing.Point(212, 144);
            this.PrikaziPravnaLica.Name = "PrikaziPravnaLica";
            this.PrikaziPravnaLica.Size = new System.Drawing.Size(150, 23);
            this.PrikaziPravnaLica.TabIndex = 1;
            this.PrikaziPravnaLica.Text = "Prikazi pravna lica";
            this.PrikaziPravnaLica.UseVisualStyleBackColor = true;
            this.PrikaziPravnaLica.Click += new System.EventHandler(this.PrikaziPravnaLica_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id1,
            this.PIB,
            this.Adresa1,
            this.ImeOvlascenogLica});
            this.dataGridView2.Location = new System.Drawing.Point(55, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(466, 108);
            this.dataGridView2.TabIndex = 0;
            // 
            // Id1
            // 
            this.Id1.HeaderText = "Id";
            this.Id1.Name = "Id1";
            // 
            // PIB
            // 
            this.PIB.HeaderText = "PIB";
            this.PIB.Name = "PIB";
            // 
            // Adresa1
            // 
            this.Adresa1.HeaderText = "Adresa";
            this.Adresa1.Name = "Adresa1";
            // 
            // ImeOvlascenogLica
            // 
            this.ImeOvlascenogLica.HeaderText = "Ime ovlascenog lica";
            this.ImeOvlascenogLica.Name = "ImeOvlascenogLica";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DodajZakupca);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(447, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj zakupca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // DodajZakupca
            // 
            this.DodajZakupca.Location = new System.Drawing.Point(61, 135);
            this.DodajZakupca.Name = "DodajZakupca";
            this.DodajZakupca.Size = new System.Drawing.Size(75, 23);
            this.DodajZakupca.TabIndex = 4;
            this.DodajZakupca.Text = "Dodaj";
            this.DodajZakupca.UseVisualStyleBackColor = true;
            this.DodajZakupca.Click += new System.EventHandler(this.DodajZakupca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PrikaziSveZakupce);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 215);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prikazi sve zakupce";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdZakupca,
            this.AdresaZakupca});
            this.dataGridView3.Location = new System.Drawing.Point(29, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(255, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // IdZakupca
            // 
            this.IdZakupca.HeaderText = "Id zakupca";
            this.IdZakupca.Name = "IdZakupca";
            // 
            // AdresaZakupca
            // 
            this.AdresaZakupca.HeaderText = "Adresa";
            this.AdresaZakupca.Name = "AdresaZakupca";
            // 
            // PrikaziSveZakupce
            // 
            this.PrikaziSveZakupce.Location = new System.Drawing.Point(78, 175);
            this.PrikaziSveZakupce.Name = "PrikaziSveZakupce";
            this.PrikaziSveZakupce.Size = new System.Drawing.Size(142, 23);
            this.PrikaziSveZakupce.TabIndex = 4;
            this.PrikaziSveZakupce.Text = "Prikazi sve zakupce";
            this.PrikaziSveZakupce.UseVisualStyleBackColor = true;
            this.PrikaziSveZakupce.Click += new System.EventHandler(this.PrikaziSveZakupce_Click);
            // 
            // Zakupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 735);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PravnaLica_groupBox1);
            this.Controls.Add(this.FizickaLica_groupBox1);
            this.Name = "Zakupci";
            this.Text = "Zakupci";
            this.FizickaLica_groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PravnaLica_groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FizickaLica_groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PrikaziFizickaLica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLicneKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojVozackeDozvole;
        private System.Windows.Forms.GroupBox PravnaLica_groupBox1;
        private System.Windows.Forms.Button PrikaziPravnaLica;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeOvlascenogLica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DodajZakupca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PrikaziSveZakupce;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZakupca;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaZakupca;
    }
}