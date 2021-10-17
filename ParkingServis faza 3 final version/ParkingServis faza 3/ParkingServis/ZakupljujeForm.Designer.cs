namespace ParkingServis
{
    partial class ZakupljujeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrikaziZauzetaMesta = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDZakupca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegBrVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProizvodjacVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDZakupca,
            this.RegBrVozila,
            this.ProizvodjacVozila,
            this.Model,
            this.Od,
            this.Do});
            this.dataGridView1.Location = new System.Drawing.Point(29, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrikaziZauzetaMesta);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista zakupljenih mesta";
            // 
            // PrikaziZauzetaMesta
            // 
            this.PrikaziZauzetaMesta.Location = new System.Drawing.Point(343, 185);
            this.PrikaziZauzetaMesta.Name = "PrikaziZauzetaMesta";
            this.PrikaziZauzetaMesta.Size = new System.Drawing.Size(92, 54);
            this.PrikaziZauzetaMesta.TabIndex = 1;
            this.PrikaziZauzetaMesta.Text = "Prikazi zakupljena mesta";
            this.PrikaziZauzetaMesta.UseVisualStyleBackColor = true;
            this.PrikaziZauzetaMesta.Click += new System.EventHandler(this.PrikaziZauzetaMesta_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID parking mesta";
            this.ID.Name = "ID";
            // 
            // IDZakupca
            // 
            this.IDZakupca.HeaderText = "IDZakupca";
            this.IDZakupca.Name = "IDZakupca";
            // 
            // RegBrVozila
            // 
            this.RegBrVozila.HeaderText = "Registarski broj vozila";
            this.RegBrVozila.Name = "RegBrVozila";
            // 
            // ProizvodjacVozila
            // 
            this.ProizvodjacVozila.HeaderText = "Proizvodjac vozila";
            this.ProizvodjacVozila.Name = "ProizvodjacVozila";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Od
            // 
            this.Od.HeaderText = "Od";
            this.Od.Name = "Od";
            // 
            // Do
            // 
            this.Do.HeaderText = "Do";
            this.Do.Name = "Do";
            // 
            // ZakupljujeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 322);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZakupljujeForm";
            this.Text = "ZakupljujeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PrikaziZauzetaMesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDZakupca;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegBrVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodjacVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Do;
    }
}