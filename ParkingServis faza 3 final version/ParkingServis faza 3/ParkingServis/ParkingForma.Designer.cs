namespace ParkingServis
{
    partial class ParkingForma
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
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojParkingMesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnoVreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prikazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IdParkingMesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrikaziParkingMesta = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Prikazi);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz svih parkinga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Adresa,
            this.Zona,
            this.BrojParkingMesta,
            this.RadnoVreme});
            this.dataGridView1.Location = new System.Drawing.Point(59, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Adresa
            // 
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // Zona
            // 
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            // 
            // BrojParkingMesta
            // 
            this.BrojParkingMesta.HeaderText = "Broj parking mesta";
            this.BrojParkingMesta.Name = "BrojParkingMesta";
            // 
            // RadnoVreme
            // 
            this.RadnoVreme.HeaderText = "Radno vreme";
            this.RadnoVreme.Name = "RadnoVreme";
            // 
            // Prikazi
            // 
            this.Prikazi.Location = new System.Drawing.Point(322, 207);
            this.Prikazi.Name = "Prikazi";
            this.Prikazi.Size = new System.Drawing.Size(110, 23);
            this.Prikazi.TabIndex = 1;
            this.Prikazi.Text = "Prikazi";
            this.Prikazi.UseVisualStyleBackColor = true;
            this.Prikazi.Click += new System.EventHandler(this.Prikazi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PrikaziParkingMesta);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parkingu pripadaju mesta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id parkinga:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdParkingMesta,
            this.RedniBroj,
            this.Status});
            this.dataGridView2.Location = new System.Drawing.Point(140, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(355, 144);
            this.dataGridView2.TabIndex = 4;
            // 
            // IdParkingMesta
            // 
            this.IdParkingMesta.HeaderText = "Id parking mesta";
            this.IdParkingMesta.Name = "IdParkingMesta";
            // 
            // RedniBroj
            // 
            this.RedniBroj.HeaderText = "Redni broj";
            this.RedniBroj.Name = "RedniBroj";
            // 
            // PrikaziParkingMesta
            // 
            this.PrikaziParkingMesta.Location = new System.Drawing.Point(262, 28);
            this.PrikaziParkingMesta.Name = "PrikaziParkingMesta";
            this.PrikaziParkingMesta.Size = new System.Drawing.Size(205, 23);
            this.PrikaziParkingMesta.TabIndex = 5;
            this.PrikaziParkingMesta.Text = "Prikazi parking mesta unutar parkinga";
            this.PrikaziParkingMesta.UseVisualStyleBackColor = true;
            this.PrikaziParkingMesta.Click += new System.EventHandler(this.PrikaziParkingMesta_Click);
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // ParkingForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParkingForma";
            this.Text = "ParkingForma";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Prikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojParkingMesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnoVreme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PrikaziParkingMesta;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdParkingMesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedniBroj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}