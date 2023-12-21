namespace Rubrica
{
    partial class Aggiuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aggiuni));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nome = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cognome = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invio = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nome);
            this.flowLayoutPanel1.Controls.Add(this.name);
            this.flowLayoutPanel1.Controls.Add(this.cognome);
            this.flowLayoutPanel1.Controls.Add(this.surname);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.phone);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.email);
            this.flowLayoutPanel1.Controls.Add(this.invio);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 14);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 300);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(4, 0);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(4, 18);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(168, 20);
            this.name.TabIndex = 0;
            // 
            // cognome
            // 
            this.cognome.AutoSize = true;
            this.cognome.Location = new System.Drawing.Point(4, 43);
            this.cognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cognome.Name = "cognome";
            this.cognome.Size = new System.Drawing.Size(52, 13);
            this.cognome.TabIndex = 4;
            this.cognome.Text = "Cognome";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(4, 61);
            this.surname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(168, 20);
            this.surname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero di telefono";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(4, 104);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(168, 20);
            this.phone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // invio
            // 
            this.invio.Location = new System.Drawing.Point(3, 175);
            this.invio.Name = "invio";
            this.invio.Size = new System.Drawing.Size(69, 33);
            this.invio.TabIndex = 4;
            this.invio.Text = "Invio";
            this.invio.UseVisualStyleBackColor = true;
            this.invio.Click += new System.EventHandler(this.invio_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(4, 147);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 20);
            this.email.TabIndex = 3;
            // 
            // Aggiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aggiuni";
            this.Text = "Aggiuni";
            this.Load += new System.EventHandler(this.Aggiuni_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label cognome;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button invio;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
    }
}