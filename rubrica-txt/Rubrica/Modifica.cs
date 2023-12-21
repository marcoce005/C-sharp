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

namespace Rubrica
{
    public partial class Modifica : Form
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
        public Modifica(string path)
        {
            InitializeComponent();
            filePath = path;
        }

        private void indietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerca_Click(object sender, EventArgs e)
        {
            string text;
            using (var sw = new StreamReader("./rubrica.txt", Encoding.UTF8))
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
                info = i.Split('~');
                contatti.Add(new Contatto(info[0], info[1], Convert.ToUInt64(info[2]), info[3], info[4], info[5]));
            }

            foreach (var x in contatti)
            {
                if (x.nome == nameSearch.Text && x.cognome == surnameSearch.Text)
                {
                    name.Text = x.nome;
                    surname.Text = x.cognome;
                    phone.Text = Convert.ToString(x.numero);
                    email.Text = x.email;
                    nascita.Text = x.nascita;
                    indirizzo.Text = x.indirizzo;
                }
            }
        }

        private void invio_Click(object sender, EventArgs e)
        {
            try
            {
                Contatto contatto;

                string nome = name.Text;    // Riempiamo gli attrbuti
                string cognome = surname.Text;
                string num = phone.Text;
                string mail = email.Text;
                string nato = nascita.Text;
                string casa = indirizzo.Text;

                var result_nome = Regex.IsMatch(nome, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
                var result_cognome = Regex.IsMatch(cognome, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
                var result_mail = Regex.IsMatch(mail, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                Regex result_casa = new Regex("^(\\d{1,3}) [a-zA-Z0-9\\s]+(\\,)? [a-zA-Z]+(\\,)? [A-Z]{2} [0-9]{5}$");
                Regex num_regex = new Regex("^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$");

                MessageBox.Show(casa);
                if (!result_nome || nome == "")
                {
                    MessageBox.Show("ERRORE nome non valido");
                    return;
                }
                else if (!result_cognome || cognome == "")
                {
                    MessageBox.Show("ERRORE cognome non valido");
                    return;
                }
                else if (!num_regex.IsMatch(num))
                {
                    MessageBox.Show("ERRORE telefono invalido");
                    return;
                }
                else if (!result_mail)
                {
                    MessageBox.Show("ERRORE email non valida");
                    return;
                }

                else if (!result_casa.IsMatch(casa))
                {
                    MessageBox.Show("ERRORE indirizzo invalido\nDeve essere così:\nnumero civico via, città, provincia CAP");
                    return;
                }
                else
                {
                    contatto = new Contatto(nome, cognome, Convert.ToUInt64(num), mail, nato, casa);
                }

                /*if (!File.Exists("rubrica.txt"))
                {
                    using (StreamWriter sw = File.CreateText("./rubrica.txt"))
                    {
                        sw.WriteLine(contatto.Nome + "~" + contatto.Cognome + "~" + contatto.Numero + "~" + contatto.Email + "~" + contatto.Nascita + "~" + contatto.Indirizzo);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText("./rubrica.txt"))
                    {
                        sw.WriteLine(contatto.Nome + "~" + contatto.Cognome + "~" + contatto.Numero + "~" + contatto.Email + "~" + contatto.Nascita + "~" + contatto.Indirizzo);
                    }
                }

                MessageBox.Show("Utente salvato correttamente");*/
                this.Close();
            }
            catch
            {
                MessageBox.Show("Errore 104");
            }
        }
    }
}
