namespace Rubrica
{
    partial class Elimina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elimina));
            this.indietro = new System.Windows.Forms.Button();
            this.tabella = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).BeginInit();
            this.SuspendLayout();
            // 
            // indietro
            // 
            this.indietro.BackColor = System.Drawing.Color.Transparent;
            this.indietro.FlatAppearance.BorderSize = 0;
            this.indietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro.Image = global::Rubrica.Properties.Resources._1904658_arrow_arrow_left_change_direction_left_next_undo_122508;
            this.indietro.Location = new System.Drawing.Point(9, 9);
            this.indietro.Margin = new System.Windows.Forms.Padding(0);
            this.indietro.Name = "indietro";
            this.indietro.Size = new System.Drawing.Size(46, 41);
            this.indietro.TabIndex = 11;
            this.indietro.TabStop = false;
            this.indietro.UseVisualStyleBackColor = false;
            this.indietro.Click += new System.EventHandler(this.indietro_Click);
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
            this.tabella.Location = new System.Drawing.Point(58, 9);
            this.tabella.Name = "tabella";
            this.tabella.Size = new System.Drawing.Size(978, 399);
            this.tabella.TabIndex = 12;
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
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(58, 414);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(91, 21);
            this.remove.TabIndex = 13;
            this.remove.Text = "Rimuovi";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Elimina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.ControlBox = false;
            this.Controls.Add(this.remove);
            this.Controls.Add(this.tabella);
            this.Controls.Add(this.indietro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Elimina";
            this.Text = "Elimina";
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indietro;
        private System.Windows.Forms.DataGridView tabella;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascita;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzo;
        private System.Windows.Forms.Button remove;
    }
}