namespace ParkingServis
{
    partial class GarazaForma
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
            this.PrikaziGaraze = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polozaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontazniObjekat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSpratova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Zapamti = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Obrisi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdGaraze = new System.Windows.Forms.TextBox();
            this.MestaUnutarGaraze = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Sprat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrikaziGaraze);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz garaza";
            // 
            // PrikaziGaraze
            // 
            this.PrikaziGaraze.Location = new System.Drawing.Point(197, 145);
            this.PrikaziGaraze.Name = "PrikaziGaraze";
            this.PrikaziGaraze.Size = new System.Drawing.Size(139, 23);
            this.PrikaziGaraze.TabIndex = 1;
            this.PrikaziGaraze.Text = "Prikazi";
            this.PrikaziGaraze.UseVisualStyleBackColor = true;
            this.PrikaziGaraze.Click += new System.EventHandler(this.PrikaziGaraze_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Polozaj,
            this.MontazniObjekat,
            this.BrojSpratova});
            this.dataGridView1.Location = new System.Drawing.Point(33, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 100);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Polozaj
            // 
            this.Polozaj.HeaderText = "Polozaj";
            this.Polozaj.Name = "Polozaj";
            // 
            // MontazniObjekat
            // 
            this.MontazniObjekat.HeaderText = "MontazniObjekat";
            this.MontazniObjekat.Name = "MontazniObjekat";
            // 
            // BrojSpratova
            // 
            this.BrojSpratova.HeaderText = "Broj spratova";
            this.BrojSpratova.Name = "BrojSpratova";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Zapamti);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj novu garazu";
            // 
            // Zapamti
            // 
            this.Zapamti.Location = new System.Drawing.Point(145, 151);
            this.Zapamti.Name = "Zapamti";
            this.Zapamti.Size = new System.Drawing.Size(75, 23);
            this.Zapamti.TabIndex = 9;
            this.Zapamti.Text = "Zapamti";
            this.Zapamti.UseVisualStyleBackColor = true;
            this.Zapamti.Click += new System.EventHandler(this.Zapamti_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj spratova:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Montazni objekat(da/ne):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Polozaj(podzemna/nadzemna):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(292, 167);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Obrisi);
            this.groupBox3.Location = new System.Drawing.Point(592, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 121);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obrisi garazu";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id garaze:";
            // 
            // Obrisi
            // 
            this.Obrisi.Location = new System.Drawing.Point(61, 77);
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Size = new System.Drawing.Size(75, 23);
            this.Obrisi.TabIndex = 0;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseVisualStyleBackColor = true;
            this.Obrisi.Click += new System.EventHandler(this.Obrisi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id garaze";
            // 
            // txtIdGaraze
            // 
            this.txtIdGaraze.Location = new System.Drawing.Point(107, 23);
            this.txtIdGaraze.Name = "txtIdGaraze";
            this.txtIdGaraze.Size = new System.Drawing.Size(100, 20);
            this.txtIdGaraze.TabIndex = 12;
            // 
            // MestaUnutarGaraze
            // 
            this.MestaUnutarGaraze.Location = new System.Drawing.Point(233, 19);
            this.MestaUnutarGaraze.Name = "MestaUnutarGaraze";
            this.MestaUnutarGaraze.Size = new System.Drawing.Size(115, 36);
            this.MestaUnutarGaraze.TabIndex = 13;
            this.MestaUnutarGaraze.Text = "Prikazi mesta unutar garaze";
            this.MestaUnutarGaraze.UseVisualStyleBackColor = true;
            this.MestaUnutarGaraze.Click += new System.EventHandler(this.MestaUnutarGaraze_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sprat,
            this.Status});
            this.dataGridView3.Location = new System.Drawing.Point(103, 66);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(245, 129);
            this.dataGridView3.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Controls.Add(this.MestaUnutarGaraze);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtIdGaraze);
            this.groupBox4.Location = new System.Drawing.Point(418, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 216);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mesta unutar garaze";
            // 
            // Sprat
            // 
            this.Sprat.HeaderText = "Sprat";
            this.Sprat.Name = "Sprat";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // GarazaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 468);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GarazaForma";
            this.Text = "GarazaForma";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PrikaziGaraze;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polozaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontazniObjekat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSpratova;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Zapamti;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Obrisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdGaraze;
        private System.Windows.Forms.Button MestaUnutarGaraze;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sprat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}