namespace Banca
{
    partial class Home
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
            this.soldi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bonifico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.invio = new System.Windows.Forms.Button();
            this.deposita = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.deposito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soldi
            // 
            this.soldi.AutoSize = true;
            this.soldi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldi.Location = new System.Drawing.Point(559, 417);
            this.soldi.MinimumSize = new System.Drawing.Size(200, 0);
            this.soldi.Name = "soldi";
            this.soldi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.soldi.Size = new System.Drawing.Size(200, 24);
            this.soldi.TabIndex = 0;
            this.soldi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ammontare conto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "BANCA di CALABRIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bonifico";
            // 
            // bonifico
            // 
            this.bonifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonifico.Location = new System.Drawing.Point(59, 150);
            this.bonifico.Name = "bonifico";
            this.bonifico.Size = new System.Drawing.Size(88, 29);
            this.bonifico.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "€";
            // 
            // invio
            // 
            this.invio.BackColor = System.Drawing.Color.SpringGreen;
            this.invio.Location = new System.Drawing.Point(59, 196);
            this.invio.Name = "invio";
            this.invio.Size = new System.Drawing.Size(98, 25);
            this.invio.TabIndex = 7;
            this.invio.Text = "invio";
            this.invio.UseVisualStyleBackColor = false;
            this.invio.Click += new System.EventHandler(this.invio_Click);
            // 
            // deposita
            // 
            this.deposita.BackColor = System.Drawing.Color.SpringGreen;
            this.deposita.Location = new System.Drawing.Point(611, 211);
            this.deposita.Name = "deposita";
            this.deposita.Size = new System.Drawing.Size(98, 25);
            this.deposita.TabIndex = 11;
            this.deposita.Text = "invio";
            this.deposita.UseVisualStyleBackColor = false;
            this.deposita.Click += new System.EventHandler(this.deposita_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(719, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "€";
            // 
            // deposito
            // 
            this.deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposito.Location = new System.Drawing.Point(611, 165);
            this.deposito.Name = "deposito";
            this.deposito.Size = new System.Drawing.Size(88, 29);
            this.deposito.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(607, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Deposito";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deposita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deposito);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.invio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bonifico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soldi);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soldi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bonifico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button invio;
        private System.Windows.Forms.Button deposita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deposito;
        private System.Windows.Forms.Label label7;
    }
}