namespace Lista_Spesa
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.tabella = new System.Windows.Forms.DataGridView();
            this.selezionata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodotto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rimanente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra = new System.Windows.Forms.Button();
            this.tessera = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.risultato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).BeginInit();
            this.SuspendLayout();
            // 
            // tabella
            // 
            this.tabella.AllowUserToAddRows = false;
            this.tabella.AllowUserToDeleteRows = false;
            this.tabella.AllowUserToResizeColumns = false;
            this.tabella.AllowUserToResizeRows = false;
            this.tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabella.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selezionata,
            this.prodotto,
            this.prezzo,
            this.quantita,
            this.rimanente});
            this.tabella.Location = new System.Drawing.Point(0, 0);
            this.tabella.Name = "tabella";
            this.tabella.Size = new System.Drawing.Size(788, 343);
            this.tabella.TabIndex = 0;
            // 
            // selezionata
            // 
            this.selezionata.HeaderText = "Selezionata";
            this.selezionata.Name = "selezionata";
            // 
            // prodotto
            // 
            this.prodotto.HeaderText = "Prodotto";
            this.prodotto.Name = "prodotto";
            this.prodotto.ReadOnly = true;
            // 
            // prezzo
            // 
            this.prezzo.HeaderText = "Prezzo";
            this.prezzo.Name = "prezzo";
            this.prezzo.ReadOnly = true;
            // 
            // quantita
            // 
            this.quantita.HeaderText = "QTA selezionata";
            this.quantita.Name = "quantita";
            // 
            // rimanente
            // 
            this.rimanente.HeaderText = "QTA rimanente";
            this.rimanente.Name = "rimanente";
            this.rimanente.ReadOnly = true;
            // 
            // compra
            // 
            this.compra.BackColor = System.Drawing.Color.Lime;
            this.compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.Location = new System.Drawing.Point(12, 349);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(103, 39);
            this.compra.TabIndex = 1;
            this.compra.Text = "Compra";
            this.compra.UseVisualStyleBackColor = false;
            this.compra.Click += new System.EventHandler(this.compra_Click);
            // 
            // tessera
            // 
            this.tessera.AutoSize = true;
            this.tessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tessera.Location = new System.Drawing.Point(135, 355);
            this.tessera.Name = "tessera";
            this.tessera.Size = new System.Drawing.Size(165, 28);
            this.tessera.TabIndex = 2;
            this.tessera.Text = "Tessera Fedeltà";
            this.tessera.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conto finale:";
            // 
            // risultato
            // 
            this.risultato.AutoSize = true;
            this.risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultato.Location = new System.Drawing.Point(144, 417);
            this.risultato.MinimumSize = new System.Drawing.Size(200, 0);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(200, 24);
            this.risultato.TabIndex = 4;
            this.risultato.Text = "0";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tessera);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.tabella);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista";
            this.Text = "Lista della Spesa";
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabella;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selezionata;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodotto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantita;
        private System.Windows.Forms.DataGridViewTextBoxColumn rimanente;
        private System.Windows.Forms.Button compra;
        private System.Windows.Forms.CheckBox tessera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label risultato;
    }
}