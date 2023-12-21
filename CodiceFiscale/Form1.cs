using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodiceFiscale
{
    public partial class CodF : Form
    {
        class dati
        {
            public string cognome3 { get; set; }
            public string nome3 { get; set; }
            public string anno2 { get; set; }
            public char mese1 { get; set; }
            public string giorno2 { get; set; }
            public string catasto4 { get; set;}
            public char last_letter { get; set; }

            public dati()
            {
                cognome3 = "";
                nome3 = "";
                anno2 = "";
                giorno2 = "";
                catasto4 = "";
            }

            public void setCognome(TextBox cognome)
            {
                foreach (char x in cognome.Text.ToUpper())
                {
                    if (!"AEIOU".Contains(x) && cognome3.Length < 3)
                        cognome3 += x.ToString();
                }
                if (cognome3.Length != 3)
                {
                    foreach (char x in cognome.Text.ToUpper())
                    {
                        if ("AEIOU".Contains(x) && cognome3.Length < 3)
                            cognome3 += x.ToString();
                    }
                }
            }

            public void setNome(TextBox nome)
            {
                int cont = 1, cons = 0;
                foreach (char x in nome.Text.ToUpper())
                    if (!"AEIOU".Contains(x))
                        cons++;
                if (cons <= 3)
                {
                    foreach (char x in nome.Text.ToUpper())
                    {
                        if (!"AEIOU".Contains(x) && nome3.Length < 3)
                            nome3 += x.ToString();
                    }
                    if (nome3.Length != 3)
                    {
                        foreach (char x in nome.Text.ToUpper())
                        {
                            if ("AEIOU".Contains(x) && nome3.Length < 3)
                                nome3 += x.ToString();
                        }
                    }
                }
                else
                {
                    foreach (char x in nome.Text.ToUpper())
                    {
                        if (!"AEIOU".Contains(x) && nome3.Length < 3 && cont != 2)
                            nome3 += x.ToString();
                        if (!"AEIOU".Contains(x))
                            cont++;
                    }
                    if (nome3.Length != 3)
                    {
                        foreach (char x in nome.Text.ToUpper())
                        {
                            if ("AEIOU".Contains(x) && nome3.Length < 3)
                                nome3 += x.ToString();
                        }
                    }
                }
            }

            public void setMese(string x)
            {
                Dictionary<string, char> mesi = new Dictionary<string, char>()
                {
                    { "gennaio", 'A' },
                    { "febbraio", 'B' },
                    { "marzo", 'C' },
                    { "aprile", 'D' },
                    { "maggio", 'E' },
                    { "giugno", 'H' },
                    { "luglio", 'L' },
                    { "agosto", 'M' },
                    { "settembre", 'P' },
                    { "ottobre", 'R' },
                    { "novembre", 'S' },
                    { "dicembre", 'T' },
                };
                foreach (KeyValuePair<string, char> m in mesi)
                    if (m.Key == x.ToLower())
                    {
                        mese1 = m.Value;
                        break;
                    }
            }

            public void setGiorno(string x, CheckBox check)
            {
                if (x.Length == 1)
                    giorno2 = "0" + x;
                else
                    giorno2 = x;
                if (check.Checked)
                    giorno2 = (Convert.ToInt16(giorno2) + 40).ToString();
            }

            public void setCatasto(TextBox city)
            {
                string text;
                try
                {
                    using (var sw = new StreamReader("./cod_catasto.txt", Encoding.UTF8))
                        text = sw.ReadToEnd();

                    string[] line = text.Split('\n');
                    foreach (var x in line)
                    {
                        if (x.Split(';')[1].Remove(x.Split(';')[1].Length - 1) == city.Text.ToUpper().ToString())
                        {
                            catasto4 = x.Split(';')[0];
                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Codici del catasto non rilevato!!!");
                }
            }

            public int somma_pari(int[] vet)
            {
                int[] pari = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                int tot = 0, loc;
                for (int i = 0; i < 7; i++)
                {
                    if (vet[i] >= 48 && vet[i] <= 57)
                        loc = vet[i] - 48;
                    else
                        loc = vet[i] - 65 + 10;
                    tot += pari[loc];
                }
                return tot;
            }

            public int somma_dispari(int[] vet)
            {
                int[] dispari = { 1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23 };
                int tot = 0, loc;
                for (int i = 0; i < 8; i++)
                {
                    if (vet[i] >= 48 && vet[i] <= 57)
                        loc = vet[i] - 48;
                    else
                        loc = vet[i] - 65 + 10;
                    tot += dispari[loc];
                }
                return tot;
            }

            public void controlCode(string codice)
            {
                int[] vet_pari = new int[7], vet_dispari = new int[8];
                int p = 0, d = 0;

                for (int i = 1; i < 16; i++)
                    if (i % 2 == 0)
                        vet_pari[p++] = (int)codice[i - 1];
                    else
                        vet_dispari[d++] = (int)codice[i - 1];

                int tot_finale = ((somma_pari(vet_pari) + somma_dispari(vet_dispari)) % 26 ) + 65;
                last_letter = Convert.ToChar(tot_finale);
            }
        }

        public CodF()
        {
            InitializeComponent();
        }

        private void calcola_Click(object sender, EventArgs e)
        {
            var result_nome = Regex.IsMatch(nome.Text, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
            var result_cognome = Regex.IsMatch(cognome.Text, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
            var result_city = Regex.IsMatch(city.Text, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
            var result_prov = Regex.IsMatch(provincia.Text, "^[A-Z]+$");

            if (!result_nome || nome.Text == "")
            {
                MessageBox.Show("Errore nome non valido");
                return;
            } else if (!result_cognome || cognome.Text == "")
            {
                MessageBox.Show("Errore cognome non valido");
                return;
            } else if (!result_city || city.Text == "")
            {
                MessageBox.Show("Errore città non valida");
                return;
            } else if (!result_prov || provincia.Text == "" || provincia.Text.Length != 2)
            {
                MessageBox.Show("Errore provincia non valida");
                return;
            } else if (!MA.Checked && !FE.Checked || MA.Checked && FE.Checked)
            {
                MessageBox.Show("Errore genere non valido");
                return;
            }

            dati persona = new dati();
            persona.setCognome(cognome);
            persona.setNome(nome);
            persona.anno2 = nato.Text.Split(' ')[3].Substring(2, 2);
            persona.setMese(nato.Text.Split(' ')[2]);
            persona.setGiorno(nato.Text.Split(' ')[1], FE);
            persona.setCatasto(city);
            persona.controlCode(persona.cognome3 + persona.nome3 + persona.anno2 + persona.mese1 + persona.giorno2 + persona.catasto4);
            risultato.Text = persona.cognome3 + persona.nome3 + persona.anno2 + persona.mese1 + persona.giorno2 + persona.catasto4 + persona.last_letter;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            risultato.Text = "";
            cognome.Text = "";
            nome.Text = "";
            nato.Text = "";
            city.Text = "";
            provincia.Text = "";
            MA.Checked = false;
            FE.Checked = false;
        }
    }
}
