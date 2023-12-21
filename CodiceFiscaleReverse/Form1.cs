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

namespace CodiceFiscaleReverse
{
    public partial class CodFisReverse : Form
    {
        class dati
        {
            public string cognome3 { get; set; }
            public string nome3 { get; set; }
            public string anno2 { get; set; }
            public string mese1 { get; set; }
            public string giorno2 { get; set; }
            public string catasto4 { get; set; }
            public string sesso { get; set; }

            public dati(string cod)
            {
                cognome3 = cod.Substring(0, 3);
                nome3 = cod.Substring(3, 3);
                anno2 = cod.Substring(6, 2);
                mese1 = mese(Convert.ToChar(cod.Substring(8, 1)));
                giorno2 = giorno(cod.Substring(9, 2));
                catasto4 = catasto(cod.Substring(11, 4));
            }

            public string catasto(string cod)
            {
                string text;
                try
                {
                    using (var sw = new StreamReader("./cod_catasto.txt", Encoding.UTF8))
                        text = sw.ReadToEnd();

                    string[] line = text.Split('\n');
                    foreach (var x in line)
                        if (x.Split(';')[0] == cod)
                            return x.Split(';')[1];
                }
                catch
                {
                  return "Codici del catasto non rilevato!!!";
                }
                return "Errore";
            }

            public string giorno(string gg)
            {
                if (Convert.ToInt16(gg) >= 40 && Convert.ToInt16(gg) <= 71)
                {
                    sesso = "Femmina";
                    return (Convert.ToInt16(gg) - 40).ToString();
                }
                else if (Convert.ToInt16(gg) <= 31)
                {
                    sesso = "Maschio";
                    return gg;
                }
                else
                    return "Giorno della data di nascita non valido";
            }

            public string mese(char x)
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
                    if (m.Value == x)
                        return m.Key;
                return "Mese non valido!!!";
            } 
        }

        public CodFisReverse()
        {
            InitializeComponent();
        }

        private void calcola_Click(object sender, EventArgs e)
        {
            if (codice.Text.Length != 16)
            {
                MessageBox.Show("Codice errato!!!");
                return;
            }
            try
            {
                dati persona = new dati(codice.Text.ToUpper());
                cognome.Text = persona.cognome3;
                nome.Text = persona.nome3;
                sesso.Text = persona.sesso;
                data.Text = persona.giorno2 + "/" + persona.mese1 + "/" + persona.anno2;
                comune.Text = persona.catasto4;
            }
            catch
            {
                MessageBox.Show("Codice errato!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codice.Text = "";
            cognome.Text = "";
            nome.Text = "";
            comune.Text = "";
            sesso.Text = "";
            data.Text = "";
        }
    }
}
