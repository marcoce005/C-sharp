namespace prenotazioni
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
			this.title = new System.Windows.Forms.Label();
			this.cognome = new System.Windows.Forms.TextBox();
			this.data = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.telefono = new System.Windows.Forms.TextBox();
			this.submit = new System.Windows.Forms.Button();
			this.taglio = new System.Windows.Forms.CheckBox();
			this.piega = new System.Windows.Forms.CheckBox();
			this.shampoo = new System.Windows.Forms.CheckBox();
			this.barba = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(248, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(288, 51);
			this.title.TabIndex = 0;
			this.title.Text = "IL BARBIERE";
			// 
			// cognome
			// 
			this.cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cognome.Location = new System.Drawing.Point(135, 108);
			this.cognome.Name = "cognome";
			this.cognome.Size = new System.Drawing.Size(129, 29);
			this.cognome.TabIndex = 1;
			// 
			// data
			// 
			this.data.CustomFormat = "dddd dd/MM HH:mm";
			this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.data.Location = new System.Drawing.Point(279, 203);
			this.data.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
			this.data.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			this.data.Name = "data";
			this.data.Size = new System.Drawing.Size(235, 29);
			this.data.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(131, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Cognome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(555, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Telefono";
			// 
			// telefono
			// 
			this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telefono.Location = new System.Drawing.Point(511, 108);
			this.telefono.Name = "telefono";
			this.telefono.Size = new System.Drawing.Size(129, 29);
			this.telefono.TabIndex = 2;
			// 
			// submit
			// 
			this.submit.BackColor = System.Drawing.Color.Lime;
			this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submit.Location = new System.Drawing.Point(609, 386);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(179, 52);
			this.submit.TabIndex = 7;
			this.submit.Text = "Prenota";
			this.submit.UseVisualStyleBackColor = false;
			this.submit.Click += new System.EventHandler(this.submit_Click);
			// 
			// taglio
			// 
			this.taglio.AutoSize = true;
			this.taglio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.taglio.Location = new System.Drawing.Point(31, 274);
			this.taglio.Name = "taglio";
			this.taglio.Size = new System.Drawing.Size(116, 28);
			this.taglio.TabIndex = 8;
			this.taglio.Text = "Taglio 12€";
			this.taglio.UseVisualStyleBackColor = true;
			// 
			// piega
			// 
			this.piega.AutoSize = true;
			this.piega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.piega.Location = new System.Drawing.Point(31, 308);
			this.piega.Name = "piega";
			this.piega.Size = new System.Drawing.Size(112, 28);
			this.piega.TabIndex = 9;
			this.piega.Text = "Piega 10€";
			this.piega.UseVisualStyleBackColor = true;
			// 
			// shampoo
			// 
			this.shampoo.AutoSize = true;
			this.shampoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shampoo.Location = new System.Drawing.Point(31, 342);
			this.shampoo.Name = "shampoo";
			this.shampoo.Size = new System.Drawing.Size(136, 28);
			this.shampoo.TabIndex = 10;
			this.shampoo.Text = "Shampoo 7€";
			this.shampoo.UseVisualStyleBackColor = true;
			// 
			// barba
			// 
			this.barba.AutoSize = true;
			this.barba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.barba.Location = new System.Drawing.Point(31, 376);
			this.barba.Name = "barba";
			this.barba.Size = new System.Drawing.Size(113, 28);
			this.barba.TabIndex = 11;
			this.barba.Text = "Barba 10€";
			this.barba.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.barba);
			this.Controls.Add(this.shampoo);
			this.Controls.Add(this.piega);
			this.Controls.Add(this.taglio);
			this.Controls.Add(this.submit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.telefono);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.data);
			this.Controls.Add(this.cognome);
			this.Controls.Add(this.title);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox cognome;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Button submit;
		private System.Windows.Forms.CheckBox taglio;
		private System.Windows.Forms.CheckBox piega;
		private System.Windows.Forms.CheckBox shampoo;
		private System.Windows.Forms.CheckBox barba;
	}
}

