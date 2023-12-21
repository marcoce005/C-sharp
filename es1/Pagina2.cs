using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es1
{
    public partial class Pagina2 : Form
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void Pagina2_Load(object sender, EventArgs e)
        {

        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            string nome;
            nome = (textBox1.Text);
            MessageBox.Show("Il nome è " + nome);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 apri_pag = new Form1();
            apri_pag.Show();
        }
    }
}
