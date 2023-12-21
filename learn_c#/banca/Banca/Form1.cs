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

namespace Banca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || psw.Text == "")
            {
                MessageBox.Show("Errore");
                return;
            }
            else
            {
                string text;
                using (var sw = new StreamReader("./db.txt", Encoding.UTF8))
                    text = sw.ReadToEnd();

                int cont = 0;
                foreach (string line in text.Split('\n'))
                {
                    if (line.Split(';')[0] == email.Text && line.Split(';')[1] == psw.Text)
                        new Home(text, cont).Show();
                    cont++;
                }
                    
            }
        }
    }
}
