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
            this.elimina = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.aggiungi = new System.Windows.Forms.Button();
            this.apri = new System.Windows.Forms.Button();
            this.tabella = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.elimina);
            this.flowLayoutPanel1.Controls.Add(this.modifica);
            this.flowLayoutPanel1.Controls.Add(this.aggiungi);
            this.flowLayoutPanel1.Controls.Add(this.apri);
            this.flowLayoutPanel1.Controls.Add(this.find);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 450);
            this.flowLayoutPanel1.TabIndex = 1;
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
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
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
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
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
            // apri
            // 
            this.apri.BackColor = System.Drawing.Color.Aqua;
            this.apri.Location = new System.Drawing.Point(3, 195);
            this.apri.Name = "apri";
            this.apri.Size = new System.Drawing.Size(144, 58);
            this.apri.TabIndex = 3;
            this.apri.Text = "Apri Rubrica";
            this.apri.UseVisualStyleBackColor = false;
            this.apri.Click += new System.EventHandler(this.apri_Click);
            // 
            // tabella
            // 
            this.tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabella.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cognome,
            this.telefono,
            this.email,
            this.nascita,
            this.indirizzo});
            this.tabella.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabella.Location = new System.Drawing.Point(206, 12);
            this.tabella.Name = "tabella";
            this.tabella.Size = new System.Drawing.Size(994, 450);
            this.tabella.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "Identificativo utente";
            this.id.Width = 30;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.ToolTipText = "Nome utente";
            // 
            // cognome
            // 
            this.cognome.HeaderText = "Cognome";
            this.cognome.Name = "cognome";
            this.cognome.ReadOnly = true;
            this.cognome.ToolTipText = "Cognome utenet";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Numero di Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.ToolTipText = "Numero di telefono";
            this.telefono.Width = 120;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.ToolTipText = "Email utente";
            this.email.Width = 150;
            // 
            // nascita
            // 
            this.nascita.HeaderText = "Data di nascita";
            this.nascita.Name = "nascita";
            this.nascita.ReadOnly = true;
            this.nascita.ToolTipText = "Data di nascita utente";
            this.nascita.Width = 150;
            // 
            // indirizzo
            // 
            this.indirizzo.HeaderText = "Indirizzo";
            this.indirizzo.Name = "indirizzo";
            this.indirizzo.ReadOnly = true;
            this.indirizzo.ToolTipText = "Indirizzo di casa dell\'utente";
            this.indirizzo.Width = 300;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Crimson;
            this.find.Location = new System.Drawing.Point(3, 259);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(144, 58);
            this.find.TabIndex = 4;
            this.find.Text = "Cerca";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1291, 450);
            this.Controls.Add(this.tabella);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.DataGridView tabella;
        private System.Windows.Forms.Button apri;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascita;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzo;
        private System.Windows.Forms.Button find;
    }
}

