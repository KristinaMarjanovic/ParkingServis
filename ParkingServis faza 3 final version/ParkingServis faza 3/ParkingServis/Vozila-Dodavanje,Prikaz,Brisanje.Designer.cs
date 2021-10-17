namespace ParkingServis
{
    partial class VozilaForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DodajVozilo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListaVozila_groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrikaziVozila = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Obrisi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RegistarskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSaobracajneDozvole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ListaVozila_groupBox2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DodajVozilo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje vozila";
            // 
            // DodajVozilo
            // 
            this.DodajVozilo.Location = new System.Drawing.Point(99, 167);
            this.DodajVozilo.Name = "DodajVozilo";
            this.DodajVozilo.Size = new System.Drawing.Size(75, 23);
            this.DodajVozilo.TabIndex = 5;
            this.DodajVozilo.Text = "Dodaj vozilo";
            this.DodajVozilo.UseVisualStyleBackColor = true;
            this.DodajVozilo.Click += new System.EventHandler(this.DodajVozilo_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj saobracajne dozvole:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registarski broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proizvodjac:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistarskiBroj,
            this.Proizvodjac,
            this.Model,
            this.BrojSaobracajneDozvole});
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ListaVozila_groupBox2
            // 
            this.ListaVozila_groupBox2.Controls.Add(this.PrikaziVozila);
            this.ListaVozila_groupBox2.Controls.Add(this.dataGridView1);
            this.ListaVozila_groupBox2.Location = new System.Drawing.Point(352, 12);
            this.ListaVozila_groupBox2.Name = "ListaVozila_groupBox2";
            this.ListaVozila_groupBox2.Size = new System.Drawing.Size(500, 230);
            this.ListaVozila_groupBox2.TabIndex = 2;
            this.ListaVozila_groupBox2.TabStop = false;
            this.ListaVozila_groupBox2.Text = "Lista svih vozila";
            // 
            // PrikaziVozila
            // 
            this.PrikaziVozila.Location = new System.Drawing.Point(225, 193);
            this.PrikaziVozila.Name = "PrikaziVozila";
            this.PrikaziVozila.Size = new System.Drawing.Size(119, 23);
            this.PrikaziVozila.TabIndex = 2;
            this.PrikaziVozila.Text = "Prikazi vozila";
            this.PrikaziVozila.UseVisualStyleBackColor = true;
            this.PrikaziVozila.Click += new System.EventHandler(this.PrikaziVozila_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.Obrisi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje vozila";
            // 
            // Obrisi
            // 
            this.Obrisi.Location = new System.Drawing.Point(99, 76);
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Size = new System.Drawing.Size(75, 23);
            this.Obrisi.TabIndex = 7;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseVisualStyleBackColor = true;
            this.Obrisi.Click += new System.EventHandler(this.Obrisi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Registarski broj:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(161, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // RegistarskiBroj
            // 
            this.RegistarskiBroj.HeaderText = "Registarski broj";
            this.RegistarskiBroj.Name = "RegistarskiBroj";
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.Name = "Proizvodjac";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // BrojSaobracajneDozvole
            // 
            this.BrojSaobracajneDozvole.HeaderText = "Broj saobracajne dozvole";
            this.BrojSaobracajneDozvole.Name = "BrojSaobracajneDozvole";
            // 
            // VozilaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ListaVozila_groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VozilaForma";
            this.Text = "Vozila";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ListaVozila_groupBox2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DodajVozilo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ListaVozila_groupBox2;
        private System.Windows.Forms.Button PrikaziVozila;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Obrisi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistarskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSaobracajneDozvole;
    }
}