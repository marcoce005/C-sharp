namespace CodiceFiscaleReverse
{
    partial class CodFisReverse
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
            this.label1 = new System.Windows.Forms.Label();
            this.codice = new System.Windows.Forms.TextBox();
            this.calcola = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sesso = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.cognome = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.comune = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice Fiscale Reverse";
            // 
            // codice
            // 
            this.codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codice.Location = new System.Drawing.Point(252, 96);
            this.codice.Name = "codice";
            this.codice.Size = new System.Drawing.Size(300, 35);
            this.codice.TabIndex = 1;
            this.codice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcola
            // 
            this.calcola.BackColor = System.Drawing.Color.Lime;
            this.calcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcola.Location = new System.Drawing.Point(252, 154);
            this.calcola.Name = "calcola";
            this.calcola.Size = new System.Drawing.Size(100, 40);
            this.calcola.TabIndex = 2;
            this.calcola.Text = "Elabora";
            this.calcola.UseVisualStyleBackColor = false;
            this.calcola.Click += new System.EventHandler(this.calcola_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(452, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancella";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data di nascita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comune di nascita:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sesso:";
            // 
            // sesso
            // 
            this.sesso.AutoSize = true;
            this.sesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesso.ForeColor = System.Drawing.Color.DarkGreen;
            this.sesso.Location = new System.Drawing.Point(387, 316);
            this.sesso.Name = "sesso";
            this.sesso.Size = new System.Drawing.Size(0, 24);
            this.sesso.TabIndex = 9;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.DarkGreen;
            this.nome.Location = new System.Drawing.Point(387, 276);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(0, 24);
            this.nome.TabIndex = 10;
            // 
            // cognome
            // 
            this.cognome.AutoSize = true;
            this.cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognome.ForeColor = System.Drawing.Color.DarkGreen;
            this.cognome.Location = new System.Drawing.Point(387, 238);
            this.cognome.Name = "cognome";
            this.cognome.Size = new System.Drawing.Size(0, 24);
            this.cognome.TabIndex = 11;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.DarkGreen;
            this.data.Location = new System.Drawing.Point(387, 354);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(0, 24);
            this.data.TabIndex = 12;
            // 
            // comune
            // 
            this.comune.AutoSize = true;
            this.comune.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comune.ForeColor = System.Drawing.Color.DarkGreen;
            this.comune.Location = new System.Drawing.Point(387, 391);
            this.comune.Name = "comune";
            this.comune.Size = new System.Drawing.Size(0, 24);
            this.comune.TabIndex = 13;
            // 
            // CodFisReverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comune);
            this.Controls.Add(this.data);
            this.Controls.Add(this.cognome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.sesso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calcola);
            this.Controls.Add(this.codice);
            this.Controls.Add(this.label1);
            this.Name = "CodFisReverse";
            this.Text = "Codice Fiscale Reverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codice;
        private System.Windows.Forms.Button calcola;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sesso;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label cognome;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label comune;
    }
}

