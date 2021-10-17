namespace ParkingServis
{
    partial class KarteZaParkiranje
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
            this.PretplatneKarte_groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrikaziPretplatneKarte = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerijskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumProdaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodVazenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistarskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PojedinacneKarte_groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrikaziJednokratneKarte = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SerijskiBroj2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiosk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PretplatneKarte_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PojedinacneKarte_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PretplatneKarte_groupBox1
            // 
            this.PretplatneKarte_groupBox1.Controls.Add(this.PrikaziPretplatneKarte);
            this.PretplatneKarte_groupBox1.Controls.Add(this.dataGridView1);
            this.PretplatneKarte_groupBox1.Location = new System.Drawing.Point(53, 12);
            this.PretplatneKarte_groupBox1.Name = "PretplatneKarte_groupBox1";
            this.PretplatneKarte_groupBox1.Size = new System.Drawing.Size(861, 216);
            this.PretplatneKarte_groupBox1.TabIndex = 0;
            this.PretplatneKarte_groupBox1.TabStop = false;
            this.PretplatneKarte_groupBox1.Text = "Pretplatne karte";
            // 
            // PrikaziPretplatneKarte
            // 
            this.PrikaziPretplatneKarte.Location = new System.Drawing.Point(333, 175);
            this.PrikaziPretplatneKarte.Name = "PrikaziPretplatneKarte";
            this.PrikaziPretplatneKarte.Size = new System.Drawing.Size(154, 23);
            this.PrikaziPretplatneKarte.TabIndex = 1;
            this.PrikaziPretplatneKarte.Text = "Prikazi pretplatne karte";
            this.PrikaziPretplatneKarte.UseVisualStyleBackColor = true;
            this.PrikaziPretplatneKarte.Click += new System.EventHandler(this.PrikaziPretplatneKarte_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerijskiBroj,
            this.DatumProdaje,
            this.Zona,
            this.Klijent,
            this.PeriodVazenja,
            this.RegistarskiBroj,
            this.Proizvodjac,
            this.Model});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // SerijskiBroj
            // 
            this.SerijskiBroj.HeaderText = "Serijski broj";
            this.SerijskiBroj.Name = "SerijskiBroj";
            // 
            // DatumProdaje
            // 
            this.DatumProdaje.HeaderText = "Datum prodaje";
            this.DatumProdaje.Name = "DatumProdaje";
            // 
            // Zona
            // 
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            // 
            // Klijent
            // 
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            // 
            // PeriodVazenja
            // 
            this.PeriodVazenja.HeaderText = "Period vazenja";
            this.PeriodVazenja.Name = "PeriodVazenja";
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
            // PojedinacneKarte_groupBox1
            // 
            this.PojedinacneKarte_groupBox1.Controls.Add(this.PrikaziJednokratneKarte);
            this.PojedinacneKarte_groupBox1.Controls.Add(this.dataGridView2);
            this.PojedinacneKarte_groupBox1.Location = new System.Drawing.Point(59, 260);
            this.PojedinacneKarte_groupBox1.Name = "PojedinacneKarte_groupBox1";
            this.PojedinacneKarte_groupBox1.Size = new System.Drawing.Size(324, 243);
            this.PojedinacneKarte_groupBox1.TabIndex = 1;
            this.PojedinacneKarte_groupBox1.TabStop = false;
            this.PojedinacneKarte_groupBox1.Text = "Jednokratne karte";
            // 
            // PrikaziJednokratneKarte
            // 
            this.PrikaziJednokratneKarte.Location = new System.Drawing.Point(77, 207);
            this.PrikaziJednokratneKarte.Name = "PrikaziJednokratneKarte";
            this.PrikaziJednokratneKarte.Size = new System.Drawing.Size(171, 23);
            this.PrikaziJednokratneKarte.TabIndex = 1;
            this.PrikaziJednokratneKarte.Text = "Prikazi jednokratne karte";
            this.PrikaziJednokratneKarte.UseVisualStyleBackColor = true;
            this.PrikaziJednokratneKarte.Click += new System.EventHandler(this.PrikaziJednokratneKarte_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerijskiBroj2,
            this.Kiosk});
            this.dataGridView2.Location = new System.Drawing.Point(18, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(282, 182);
            this.dataGridView2.TabIndex = 0;
            // 
            // SerijskiBroj2
            // 
            this.SerijskiBroj2.HeaderText = "Serijski broj";
            this.SerijskiBroj2.Name = "SerijskiBroj2";
            // 
            // Kiosk
            // 
            this.Kiosk.HeaderText = "Kiosk";
            this.Kiosk.Name = "Kiosk";
            // 
            // KarteZaParkiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 523);
            this.Controls.Add(this.PojedinacneKarte_groupBox1);
            this.Controls.Add(this.PretplatneKarte_groupBox1);
            this.Name = "KarteZaParkiranje";
            this.Text = "KarteZaParkiranje";
            this.PretplatneKarte_groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PojedinacneKarte_groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PretplatneKarte_groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PrikaziPretplatneKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerijskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumProdaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodVazenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistarskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.GroupBox PojedinacneKarte_groupBox1;
        private System.Windows.Forms.Button PrikaziJednokratneKarte;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerijskiBroj2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiosk;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}