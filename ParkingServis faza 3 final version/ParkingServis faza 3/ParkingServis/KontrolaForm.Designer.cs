namespace ParkingServis
{
    partial class KontrolaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDKontrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodParkiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VremeKontrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPMesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistarskiBrVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzvrsiKontrolu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKontrole,
            this.PeriodParkiranja,
            this.VremeKontrole,
            this.IdPMesta,
            this.RegistarskiBrVozila});
            this.dataGridView1.Location = new System.Drawing.Point(23, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // IDKontrole
            // 
            this.IDKontrole.HeaderText = "IDKontrole";
            this.IDKontrole.Name = "IDKontrole";
            // 
            // PeriodParkiranja
            // 
            this.PeriodParkiranja.HeaderText = "Period parkiranja";
            this.PeriodParkiranja.Name = "PeriodParkiranja";
            // 
            // VremeKontrole
            // 
            this.VremeKontrole.HeaderText = "Vreme kontrole";
            this.VremeKontrole.Name = "VremeKontrole";
            // 
            // IdPMesta
            // 
            this.IdPMesta.HeaderText = "Id parking mesta";
            this.IdPMesta.Name = "IdPMesta";
            // 
            // RegistarskiBrVozila
            // 
            this.RegistarskiBrVozila.HeaderText = "Registarski broj vozila";
            this.RegistarskiBrVozila.Name = "RegistarskiBrVozila";
            // 
            // btnIzvrsiKontrolu
            // 
            this.btnIzvrsiKontrolu.Location = new System.Drawing.Point(208, 187);
            this.btnIzvrsiKontrolu.Name = "btnIzvrsiKontrolu";
            this.btnIzvrsiKontrolu.Size = new System.Drawing.Size(132, 45);
            this.btnIzvrsiKontrolu.TabIndex = 1;
            this.btnIzvrsiKontrolu.Text = "Prikazi izvrsene kontrole";
            this.btnIzvrsiKontrolu.UseVisualStyleBackColor = true;
            this.btnIzvrsiKontrolu.Click += new System.EventHandler(this.btnIzvrsiKontrolu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnIzvrsiKontrolu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz izvrsenih kontrola";
            // 
            // KontrolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 441);
            this.Controls.Add(this.groupBox1);
            this.Name = "KontrolaForm";
            this.Text = "KontrolaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKontrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodParkiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn VremeKontrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPMesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistarskiBrVozila;
        private System.Windows.Forms.Button btnIzvrsiKontrolu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}