namespace Rubrica
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.modifica = new System.Windows.Forms.Button();
            this.elimina = new System.Windows.Forms.Button();
            this.aggiungi = new System.Windows.Forms.Button();
            this.rubrica = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubrica)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.elimina);
            this.flowLayoutPanel1.Controls.Add(this.modifica);
            this.flowLayoutPanel1.Controls.Add(this.aggiungi);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // modifica
            // 
            this.modifica.BackColor = System.Drawing.Color.Orange;
            this.modifica.Location = new System.Drawing.Point(3, 67);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(144, 58);
            this.modifica.TabIndex = 1;
            this.modifica.Text = "Modifica Rubrica";
            this.modifica.UseVisualStyleBackColor = false;
            // 
            // elimina
            // 
            this.elimina.BackColor = System.Drawing.Color.Red;
            this.elimina.Location = new System.Drawing.Point(3, 3);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(144, 58);
            this.elimina.TabIndex = 0;
            this.elimina.Text = "Rimuovi Utente";
            this.elimina.UseVisualStyleBackColor = false;
            // 
            // aggiungi
            // 
            this.aggiungi.BackColor = System.Drawing.Color.LawnGreen;
            this.aggiungi.Location = new System.Drawing.Point(3, 131);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(144, 58);
            this.aggiungi.TabIndex = 2;
            this.aggiungi.Text = "Aggiungi Utente";
            this.aggiungi.UseVisualStyleBackColor = false;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // rubrica
            // 
            this.rubrica.BackgroundColor = System.Drawing.Color.Khaki;
            this.rubrica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rubrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rubrica.Location = new System.Drawing.Point(206, 12);
            this.rubrica.Name = "rubrica";
            this.rubrica.Size = new System.Drawing.Size(582, 426);
            this.rubrica.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rubrica);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rubrica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.DataGridView rubrica;
    }
}

