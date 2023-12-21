using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qalc
{
    public partial class Qalc : Form
    {
        class value
        {
            public string n1 { get; set; }
            public string n2 { get; set; }
            public string tmp { get; set; }
            public char operatore { get; set; }

            public value() { n1 = ""; n2 = ""; tmp = ""; }
            
            public void del() { try { tmp = tmp.Substring(0, tmp.Length - 1); } catch { tmp = "0"; } }
            public void change_operator(char x) { operatore = x; n1 = tmp; tmp = ""; }
            public void change_digit(char n) { tmp += n.ToString(); }

            public void calc()
            {
                n2 = tmp;
                switch (operatore)
                {
                    case '+':
                        tmp = (Convert.ToDouble(n1) + Convert.ToDouble(n2)).ToString();
                        tmp = Math.Round(Convert.ToDouble(tmp), 11 - tmp.Split(',')[0].Length + 1).ToString(); break;
                    case '-':
                        tmp = (Convert.ToDouble(n1) - Convert.ToDouble(n2)).ToString();
                        tmp = Math.Round(Convert.ToDouble(tmp), 11 - tmp.Split(',')[0].Length + 1).ToString(); break;
                    case '*':
                        tmp = (Convert.ToDouble(n1) * Convert.ToDouble(n2)).ToString();
                        tmp = Math.Round(Convert.ToDouble(tmp), 11 - tmp.Split(',')[0].Length + 1).ToString(); break;
                    case '/':
                        tmp = (Convert.ToDouble(n1) / Convert.ToDouble(n2)).ToString();
                        tmp = Math.Round(Convert.ToDouble(tmp), 11 - tmp.Split(',')[0].Length + 1).ToString(); break;
                }
            }
        }
        value valori = new value();

        private void render_init() { valori.n1 = valori.n2 = valori.tmp = ""; schermo.Text = "0";  }
        private void render() { schermo.Text = valori.tmp; }

        public Qalc()
        {
            InitializeComponent();
            render_init();
        }

        private void delete_Click(object sender, EventArgs e) { render_init(); }
        private void del_Click(object sender, EventArgs e) { valori.del(); render(); }
        private void diviso_Click(object sender, EventArgs e) { valori.change_operator('/'); }
        private void per_Click(object sender, EventArgs e) { valori.change_operator('*'); }
        private void meno_Click(object sender, EventArgs e) { valori.change_operator('-'); }
        private void piu_Click(object sender, EventArgs e) { valori.change_operator('+'); }
        private void sette_Click(object sender, EventArgs e) { valori.change_digit('7'); render(); }
        private void otto_Click(object sender, EventArgs e) { valori.change_digit('8'); render(); }
        private void nove_Click(object sender, EventArgs e) { valori.change_digit('9'); render(); }
        private void sei_Click(object sender, EventArgs e) { valori.change_digit('6'); render(); }
        private void cinque_Click(object sender, EventArgs e) { valori.change_digit('5'); render(); }
        private void quattro_Click(object sender, EventArgs e) { valori.change_digit('4'); render(); }
        private void uno_Click(object sender, EventArgs e) { valori.change_digit('1'); render(); }
        private void due_Click(object sender, EventArgs e) { valori.change_digit('2'); render(); }
        private void tre_Click(object sender, EventArgs e) { valori.change_digit('3'); render(); }
        private void zero_Click(object sender, EventArgs e) { valori.change_digit('0'); render(); }
        private void virgola_Click(object sender, EventArgs e) { valori.change_digit(','); render(); }
        private void uguale_Click(object sender, EventArgs e) { valori.calc(); render(); }
    }
}
