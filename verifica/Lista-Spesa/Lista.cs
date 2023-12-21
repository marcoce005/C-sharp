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

namespace Lista_Spesa
{
    public partial class Lista : Form
    {
        string n_utente, c_utente, i_utente;
        private object cath;

        class prodotti
        {
            public string nome { get; set; }
            public double prezzo { get; set; }
            public double qta { get; set; }

            public string unita_misura { get; set; }

            public prodotti(string n, double p, double q, string u)
            {
                nome = n;
                prezzo = p;
                qta = q;
                unita_misura = u;
            }
        }
        List<prodotti> prodottos = new List<prodotti>();

        private void compra_Click(object sender, EventArgs e)
        {
            double tot = 0;
            int cont = 0;
            foreach (DataGridViewRow check in tabella.Rows)
            {
                var cella = check.Cells[0] as DataGridViewCheckBoxCell;
                if (cella.Value as bool? == true)
                {
                    tot += Convert.ToDouble(check.Cells[2].Value.ToString().Split('€')[0]) * Convert.ToDouble(check.Cells[3].Value.ToString());
                    prodottos[cont].qta -= Convert.ToDouble(check.Cells[3].Value);
                }
                cont++;
            }

            if (tessera.Checked)
                tot = tot - (tot / 10);

            risultato.Text = tot.ToString() + " €";

            MessageBox.Show("Spesa effettuata correttamente\nGrazie, " + n_utente + " " + c_utente + " per aver scelto il nostro serizio.\nLa spesa ti sarà recapitata al seguente indirizzo:\n" + i_utente);
            render();
        }

        private void render() {
            tabella.Rows.Clear();
            foreach (var x in prodottos)
            {
                string[] line = new string[] { "false", x.nome, x.prezzo.ToString() + "€", "0", x.qta.ToString() + x.unita_misura };
                tabella.Rows.Add(line);
            }
        }

        private void new_prodotti()
        {
            string text, unit;
            try
            {
                using (var sw = new StreamReader("./spesa.txt", Encoding.UTF8))
                { text = sw.ReadToEnd(); }

                string[] articoli = text.Split('\n');
                
                string[] info;
                foreach (var i in articoli)
                {
                    if (i == "")
                        break;
                    info = i.Split(',');
                    info[1] = info[1].Split('e')[0];

                    char x = (info[2])[info[2].Length - 2];

                    if (x == 'g') {
                        info[2] = info[2].Split('k')[0];
                        unit = "kg";
                    }
                    else if (x == 'l')
                    {
                        info[2] = info[2].Split('l')[0];
                        unit = "l";
                    }
                    else
                    {
                        unit = "";
                    }
                    prodottos.Add(new prodotti(info[0], Convert.ToDouble(info[1]), Convert.ToDouble(info[2]), unit));
                }

                render();
            }
            catch
            {
                MessageBox.Show("Non ci sono prodotti disponibili!");
                return;
            }

        }

        public Lista(string n, string c, string i)
        {
            InitializeComponent();

            n_utente = n;
            c_utente = c;
            i_utente = i;

            new_prodotti();
        }
    }
}
