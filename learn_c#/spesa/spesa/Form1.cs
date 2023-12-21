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

namespace spesa
{
    public partial class Form1 : Form
    {
        class prodotto
        {
            public string nome { get; set; }
            public double prezzo { get; set; }

            public prodotto(string n, double p)
            {
                nome = n;
                prezzo = p;
            }
        }

        private void new_obj()
        {
            string text;
            try
            {
                using (var sw = new StreamReader("./prodotti.txt", Encoding.UTF8))
                { text = sw.ReadToEnd(); }

                string[] articoli = text.Split('\n');
                List<prodotto> prodottos = new List<prodotto>();
                string[] info;
                foreach (var i in articoli)
                {
                    if (i == "")
                        break;
                    info = i.Split(';');
                    prodottos.Add(new prodotto(info[0], Convert.ToDouble(info[1])));
                }

                foreach (var x in prodottos)
                {
                    string[] line = new string[] { "false", x.nome, x.prezzo.ToString() + "€", "0" };
                    data.Rows.Add(line);
                }
            } catch
            {
                MessageBox.Show("Non ci sono prodotti disponibili!");
                return;
            }
            
        }

        public Form1()
        {
            InitializeComponent();
            new_obj();
        }

        private void scontrino()
        {
            double tot = 0;
            string text = "Scontrino lista della spesa\n-----------------------------------------\n";
            foreach (DataGridViewRow check in data.Rows)
            {
                var cella = check.Cells[0] as DataGridViewCheckBoxCell;
                if (cella.Value as bool? == true)
                {
                    text += check.Cells[1].Value.ToString() + "\t\t" + check.Cells[2].Value.ToString() + " * " + check.Cells[3].Value.ToString() + "\n";
                    tot += Convert.ToDouble(check.Cells[2].Value.ToString().Split('€')[0]) * Convert.ToDouble(check.Cells[3].Value.ToString());
                }
            }

            if (tessera.Checked)
                text += "\n-----------------------------------------\n" + "Totale\t\t" + tot.ToString() + "€  - 10% = \n" + "\t\t" + (tot - (tot / 10)).ToString() + "€";
            else
                text += "\n-----------------------------------------\n" + "Totale\t\t" + tot.ToString() + "€";
            
            using (StreamWriter sw = File.CreateText("./scontrino.txt"))
            {sw.WriteLine(text);}
        }

        private void invio_Click(object sender, EventArgs e)
        {
            double tot = 0;
            foreach (DataGridViewRow check in data.Rows)
            {
                var cella = check.Cells[0] as DataGridViewCheckBoxCell;
                if (cella.Value as bool? == true)
                    tot += Convert.ToDouble(check.Cells[2].Value.ToString().Split('€')[0]) * Convert.ToDouble(check.Cells[3].Value.ToString());
            }

            if (tessera.Checked)
                tot = tot - (tot / 10);

            risultato.Text = tot.ToString() + " €";

            scontrino();

            MessageBox.Show("Spesa effettuata correttamente\nScontrino stampato");
            erase_Click(sender, e);
        }

        private void erase_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            new_obj();
            risultato.Text = "0 €";
            tessera.Checked = false;
        }
    }
}
