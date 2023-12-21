using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Spesa
{
    public partial class Login : Form
    {
        class utente
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string address { get; set; }

            public utente(string n, string c, string i)
            {
                name = n;
                surname = c;
                address = i;
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            var result_nome = Regex.IsMatch(nome.Text, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
            var result_cognome = Regex.IsMatch(cognome.Text, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
            var result_casa = Regex.IsMatch(indirizzo.Text, "^(\\d{1,3}) [a-zA-Z0-9\\s]+(\\,)? [a-zA-Z]+(\\,)? [A-Z]{2} [0-9]{5}$");

            if (!result_nome || nome.Text == "")
            {
                MessageBox.Show("ERRORE nome non valido");
                return;
            }
            else if (!result_cognome || cognome.Text == "")
            {
                MessageBox.Show("ERRORE cognome non valido");
                return;
            }
            else if (!result_casa || indirizzo.Text == "")
            {
                MessageBox.Show("ERRORE indirizzo invalido\nDevono essere inseriti i seguenti parametri nel seguente ordine:\nnumero civico via città provincia CAP");
                return;
            }
            else
            {
                utente persona = new utente(nome.Text, cognome.Text, indirizzo.Text);
                new Lista(persona.name, persona.surname, persona.address).Show();
            }
        }
    }
}
