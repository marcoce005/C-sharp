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

namespace Banca
{
    public partial class Home : Form
    {
        class utente
        {
            public string email { get; set; }
            public string password { get; set; }
            public double cash { get; set; }

            public utente(string e, string p, double c)
            {
                email = e; password = p; cash = c; 
            }

            public void change_soldi(Label label) {label.Text = cash.ToString();}
        }

        List<utente> ciro = new List<utente>();
        int ciro_id;

        public Home(string text, int tipo)
        {
            InitializeComponent();
            foreach (string line in text.Split('\n'))
                ciro.Add(new utente(line.Split(';')[0], line.Split(';')[1], Convert.ToDouble(line.Split(';')[2])));

            ciro[tipo].change_soldi(soldi);
            ciro_id = tipo;
        }

        private void invio_Click(object sender, EventArgs e)
        {
            if (bonifico.Text == "" || !Regex.IsMatch(bonifico.Text, "[0-9]"))
            {
                MessageBox.Show("Errore");
                return;
            }
            else
            {
                ciro[ciro_id].cash -= Convert.ToDouble(bonifico.Text);
                ciro[ciro_id].change_soldi(soldi);
                bonifico.Text = "";
            }
        }

        private void deposita_Click(object sender, EventArgs e)
        {
            if (deposito.Text == "" && !Regex.IsMatch(deposito.Text, "[0-9]"))
            {
                MessageBox.Show("Errore");
                return;
            }
            else
            {
                ciro[ciro_id].cash += Convert.ToDouble(deposito.Text);
                ciro[ciro_id].change_soldi(soldi);
                deposito.Text = "";
            }
        }
    }
}
