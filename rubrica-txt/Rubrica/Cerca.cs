using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubrica
{
    public partial class Cerca : Form
    {
        private class Contatto
        {
            private string Nome;
            private string Cognome;
            private ulong Numero;
            private string Email;
            private string Nascita;
            private string Indirizzo;

            public Contatto(string n, string c, ulong num, string mail, string nato, string casa)
            {
                Nome = n;
                Cognome = c;
                Numero = num;
                Email = mail;
                Nascita = nato;
                Indirizzo = casa;
            }

            public string nome
            {
                get { return Nome; }
                set { Nome = value; }
            }
            public string cognome
            {
                get { return Cognome; }
                set { Cognome = value; }
            }
            public ulong numero
            {
                get { return Numero; }
                set { Numero = value; }
            }
            public string email
            {
                get { return Email; }
                set { Email = value; }
            }
            public string nascita
            {
                get { return Nascita; }
                set { Nascita = value; }
            }
            public string indirizzo
            {
                get { return Indirizzo; }
                set { Indirizzo = value; }
            }
        }

        public string filePath = string.Empty;
        public Cerca(string path)
        {
            InitializeComponent();
            filePath = path;
        }

        private void indietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void render_clear()
        {
            string text;
            try
            {
                using (var sw = new StreamReader(filePath, Encoding.UTF8))
                {
                    text = sw.ReadToEnd();
                }

                string[] utenti = text.Split('\n');

                List<Contatto> contatti = new List<Contatto>();
                string[] info;
                foreach (var i in utenti)
                {
                    if (i == "")
                    {
                        break;
                    }
                    info = i.Split(',');
                    contatti.Add(new Contatto(info[0], info[1], Convert.ToUInt64(info[2]), info[3], info[4], info[5]));
                }

                var cont = 0;
                foreach (var x in contatti)
                {
                    var id = Convert.ToString(cont);
                    string[] riga = new string[] { id, x.nome, x.cognome, Convert.ToString(x.numero), x.email, x.nascita, x.indirizzo };
                    tabella.Rows.Add(riga);
                    cont++;
                }
            }
            catch
            {
                MessageBox.Show("Nessun file selezionato");
            }
        }

        public void render(List<string> campi)
        {
            string[] readText = File.ReadAllLines(filePath);
            int i = 0;
            foreach (string s in readText)
            {
                string[] subs = s.Split(',');
                if ((campi[0] == subs[0] || subs[0].Contains(campi[0]))
                   && (campi[1] == subs[1] || subs[1].Contains(campi[1]))
                   && (campi[2] == subs[2] || subs[2].Contains(campi[2]))
                   && (campi[3] == subs[3] || subs[3].Contains(campi[3]))
                   && (campi[4] == subs[4] || subs[4].Contains(campi[4]))
                   && (campi[5] == subs[5] || subs[5].Contains(campi[5]))
                  )
                {
                    tabella.Rows.Add(i.ToString(), subs[0], subs[1], subs[2], subs[3], subs[4], subs[5]);
                    i++;
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            List<string> init = new List<string>();

            init.Add(name.Text);
            init.Add(surname.Text);
            init.Add(phone.Text);
            init.Add(mail.Text);
            init.Add(nato.Text);
            init.Add(address.Text);

            tabella.Rows.Clear();

            if (init[0].Length + init[1].Length + init[2].Length + init[3].Length + init[4].Length + init[5].Length == 0)
            {
                render_clear();
            } else
            {
                render(init);
            }
        }
    }
}
