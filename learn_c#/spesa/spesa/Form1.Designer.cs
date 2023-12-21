namespace spesa
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.data = new System.Windows.Forms.DataGridView();
            this.Seleziona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Articolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invio = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.risultato = new System.Windows.Forms.Label();
            this.tessera = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleziona,
            this.Articolo,
            this.Prezzo,
            this.QTA});
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(799, 334);
            this.data.TabIndex = 0;
            // 
            // Seleziona
            // 
            this.Seleziona.HeaderText = "Seleziona";
            this.Seleziona.Name = "Seleziona";
            // 
            // Articolo
            // 
            this.Articolo.HeaderText = "Articolo";
            this.Articolo.Name = "Articolo";
            this.Articolo.ReadOnly = true;
            this.Articolo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Prezzo
            // 
            this.Prezzo.HeaderText = "Prezzo";
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.ReadOnly = true;
            // 
            // QTA
            // 
            this.QTA.HeaderText = "QTA";
            this.QTA.Name = "QTA";
            // 
            // invio
            // 
            this.invio.BackColor = System.Drawing.Color.LawnGreen;
            this.invio.Location = new System.Drawing.Point(84, 381);
            this.invio.Name = "invio";
            this.invio.Size = new System.Drawing.Size(75, 23);
            this.invio.TabIndex = 3;
            this.invio.Text = "Invio";
            this.invio.UseVisualStyleBackColor = false;
            this.invio.Click += new System.EventHandler(this.invio_Click);
            // 
            // erase
            // 
            this.erase.BackColor = System.Drawing.Color.IndianRed;
            this.erase.Location = new System.Drawing.Point(3, 381);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(75, 23);
            this.erase.TabIndex = 2;
            this.erase.Text = "cancella";
            this.erase.UseVisualStyleBackColor = false;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Costo totale:";
            // 
            // risultato
            // 
            this.risultato.AutoSize = true;
            this.risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultato.Location = new System.Drawing.Point(602, 381);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(35, 24);
            this.risultato.TabIndex = 4;
            this.risultato.Text = "0 €";
            // 
            // tessera
            // 
            this.tessera.AutoSize = true;
            this.tessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tessera.Location = new System.Drawing.Point(12, 340);
            this.tessera.Name = "tessera";
            this.tessera.Size = new System.Drawing.Size(297, 28);
            this.tessera.TabIndex = 1;
            this.tessera.Text = "Tessera Fedeltà sconto del 10%";
            this.tessera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tessera);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.invio);
            this.Controls.Add(this.data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spesa";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleziona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTA;
        private System.Windows.Forms.Button invio;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label risultato;
        private System.Windows.Forms.CheckBox tessera;
    }
}

