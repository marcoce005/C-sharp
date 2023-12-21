using Rubrica.FileWatcherRubrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rubrica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            /*            XmlDocument doc = new XmlDocument();
                        doc.Load("rubrica.xml");

                        XmlNodeList nomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/nome");
                        XmlNodeList cognomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/cognome");
                        XmlNodeList telefoni = doc.DocumentElement.SelectNodes("/rubrica/contatto/numero");

                        rubrica.ColumnCount = 4;
                        rubrica.Columns[0].Name = "ID";
                        rubrica.Columns[1].Name = "Nome";
                        rubrica.Columns[2].Name = "Cognome";
                        rubrica.Columns[3].Name = "Telefono";

                        var cont = 0;
                        foreach (XmlNode node in nomi)
                        {
                            var id = Convert.ToString(cont);
                            string[] riga = new string[] { id, nomi[cont].InnerText, cognomi[cont].InnerText, telefoni[cont].InnerText };
                            rubrica.Rows.Add(riga);
                            cont++;
                        }*/
            FIleWatcher fw = new FIleWatcher();
            fw.CreateFileWatcher("./", rubrica);
            var griglia = new Griglia.Griglia();
            griglia.CreateFirstGrid(rubrica);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("ciao");

                System.IO.File.WriteAllText("test.txt", "ciao sono pippo");
                MessageBox.Show(System.IO.File.ReadAllText("test.txt"));
            } catch(Exception ex)
            {
                MessageBox.Show("Hai rotto tutto!!!");
            }

            
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            new Aggiuni().Show();
        }
    }
}
