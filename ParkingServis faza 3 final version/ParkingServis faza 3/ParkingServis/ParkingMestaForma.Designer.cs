namespace ParkingServis
{
    partial class ParkingMestaForma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrikaziSvaParkingMesta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ObrisiParkingMesto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IdMestaNaUlici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivUlice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrikaziMestaNaUlici = new System.Windows.Forms.Button();
            this.StatusMestaNaUlici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.PrikaziMestaUnutarParkinga = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.PrikaziParkingMestaUnutarGaraze = new System.Windows.Forms.Button();
            this.IdParkingMesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdParkinga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusMestaNaParkingu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdParkingMestaUGarazi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGaraze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sprat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusParkingMestaUGarazi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrikaziSvaParkingMesta);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikazi sva parking mesta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(32, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 125);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // PrikaziSvaParkingMesta
            // 
            this.PrikaziSvaParkingMesta.Location = new System.Drawing.Point(143, 160);
            this.PrikaziSvaParkingMesta.Name = "PrikaziSvaParkingMesta";
            this.PrikaziSvaParkingMesta.Size = new System.Drawing.Size(75, 23);
            this.PrikaziSvaParkingMesta.TabIndex = 1;
            this.PrikaziSvaParkingMesta.Text = "Prikazi";
            this.PrikaziSvaParkingMesta.UseVisualStyleBackColor = true;
            this.PrikaziSvaParkingMesta.Click += new System.EventHandler(this.PrikaziSvaParkingMesta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ObrisiParkingMesto);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(491, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Obrisi parking mesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id parking mesta:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ObrisiParkingMesto
            // 
            this.ObrisiParkingMesto.Location = new System.Drawing.Point(93, 105);
            this.ObrisiParkingMesto.Name = "ObrisiParkingMesto";
            this.ObrisiParkingMesto.Size = new System.Drawing.Size(75, 23);
            this.ObrisiParkingMesto.TabIndex = 2;
            this.ObrisiParkingMesto.Text = "Obrisi";
            this.ObrisiParkingMesto.UseVisualStyleBackColor = true;
            this.ObrisiParkingMesto.Click += new System.EventHandler(this.ObrisiParkingMesto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PrikaziMestaNaUlici);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 257);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parking mesta na ulici";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMestaNaUlici,
            this.NazivUlice,
            this.StatusMestaNaUlici});
            this.dataGridView2.Location = new System.Drawing.Point(17, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 176);
            this.dataGridView2.TabIndex = 0;
            // 
            // IdMestaNaUlici
            // 
            this.IdMestaNaUlici.HeaderText = "Id parking mesta";
            this.IdMestaNaUlici.Name = "IdMestaNaUlici";
            // 
            // NazivUlice
            // 
            this.NazivUlice.HeaderText = "Naziv ulice";
            this.NazivUlice.Name = "NazivUlice";
            // 
            // PrikaziMestaNaUlici
            // 
            this.PrikaziMestaNaUlici.Location = new System.Drawing.Point(155, 210);
            this.PrikaziMestaNaUlici.Name = "PrikaziMestaNaUlici";
            this.PrikaziMestaNaUlici.Size = new System.Drawing.Size(75, 23);
            this.PrikaziMestaNaUlici.TabIndex = 1;
            this.PrikaziMestaNaUlici.Text = "Prikazi";
            this.PrikaziMestaNaUlici.UseVisualStyleBackColor = true;
            this.PrikaziMestaNaUlici.Click += new System.EventHandler(this.PrikaziMestaNaUlici_Click);
            // 
            // StatusMestaNaUlici
            // 
            this.StatusMestaNaUlici.HeaderText = "Status";
            this.StatusMestaNaUlici.Name = "StatusMestaNaUlici";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PrikaziMestaUnutarParkinga);
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Location = new System.Drawing.Point(397, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 257);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parking mesta unutar parkinga";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdParkingMesta,
            this.IdParkinga,
            this.RedniBroj,
            this.StatusMestaNaParkingu});
            this.dataGridView3.Location = new System.Drawing.Point(17, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(443, 176);
            this.dataGridView3.TabIndex = 0;
            // 
            // PrikaziMestaUnutarParkinga
            // 
            this.PrikaziMestaUnutarParkinga.Location = new System.Drawing.Point(205, 210);
            this.PrikaziMestaUnutarParkinga.Name = "PrikaziMestaUnutarParkinga";
            this.PrikaziMestaUnutarParkinga.Size = new System.Drawing.Size(75, 23);
            this.PrikaziMestaUnutarParkinga.TabIndex = 1;
            this.PrikaziMestaUnutarParkinga.Text = "Prikazi";
            this.PrikaziMestaUnutarParkinga.UseVisualStyleBackColor = true;
            this.PrikaziMestaUnutarParkinga.Click += new System.EventHandler(this.PrikaziMestaUnutarParkinga_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PrikaziParkingMestaUnutarGaraze);
            this.groupBox5.Controls.Add(this.dataGridView4);
            this.groupBox5.Location = new System.Drawing.Point(878, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(469, 257);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parking mesta unutar garaze";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdParkingMestaUGarazi,
            this.IdGaraze,
            this.Sprat,
            this.StatusParkingMestaUGarazi});
            this.dataGridView4.Location = new System.Drawing.Point(12, 28);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(446, 176);
            this.dataGridView4.TabIndex = 0;
            // 
            // PrikaziParkingMestaUnutarGaraze
            // 
            this.PrikaziParkingMestaUnutarGaraze.Location = new System.Drawing.Point(167, 210);
            this.PrikaziParkingMestaUnutarGaraze.Name = "PrikaziParkingMestaUnutarGaraze";
            this.PrikaziParkingMestaUnutarGaraze.Size = new System.Drawing.Size(75, 23);
            this.PrikaziParkingMestaUnutarGaraze.TabIndex = 1;
            this.PrikaziParkingMestaUnutarGaraze.Text = "Prikazi";
            this.PrikaziParkingMestaUnutarGaraze.UseVisualStyleBackColor = true;
            this.PrikaziParkingMestaUnutarGaraze.Click += new System.EventHandler(this.PrikaziParkingMestaUnutarGaraze_Click);
            // 
            // IdParkingMesta
            // 
            this.IdParkingMesta.HeaderText = "Id parking mesta";
            this.IdParkingMesta.Name = "IdParkingMesta";
            // 
            // IdParkinga
            // 
            this.IdParkinga.HeaderText = "Id parkinga u kome se nalazi";
            this.IdParkinga.Name = "IdParkinga";
            // 
            // RedniBroj
            // 
            this.RedniBroj.HeaderText = "Redni broj";
            this.RedniBroj.Name = "RedniBroj";
            // 
            // StatusMestaNaParkingu
            // 
            this.StatusMestaNaParkingu.HeaderText = "Status";
            this.StatusMestaNaParkingu.Name = "StatusMestaNaParkingu";
            // 
            // IdParkingMestaUGarazi
            // 
            this.IdParkingMestaUGarazi.HeaderText = "Id parking mesta";
            this.IdParkingMestaUGarazi.Name = "IdParkingMestaUGarazi";
            // 
            // IdGaraze
            // 
            this.IdGaraze.HeaderText = "Id garaze u kojoj se nalazi";
            this.IdGaraze.Name = "IdGaraze";
            // 
            // Sprat
            // 
            this.Sprat.HeaderText = "Sprat";
            this.Sprat.Name = "Sprat";
            // 
            // StatusParkingMestaUGarazi
            // 
            this.StatusParkingMestaUGarazi.HeaderText = "Status";
            this.StatusParkingMestaUGarazi.Name = "StatusParkingMestaUGarazi";
            // 
            // ParkingMestaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 568);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParkingMestaForma";
            this.Text = "ParkingMestaForma";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PrikaziSvaParkingMesta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ObrisiParkingMesto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PrikaziMestaNaUlici;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMestaNaUlici;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivUlice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusMestaNaUlici;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button PrikaziMestaUnutarParkinga;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button PrikaziParkingMestaUnutarGaraze;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdParkingMesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdParkinga;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedniBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusMestaNaParkingu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdParkingMestaUGarazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGaraze;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sprat;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusParkingMestaUGarazi;
    }
}