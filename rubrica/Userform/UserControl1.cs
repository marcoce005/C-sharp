using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Userform
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private class Contatto
        {
            public string Nome;
            public string Cognome;
            public DateTime Nascita;
            public ulong Numero;

           public XElement genera_contatto()
            {
                var Contatto = new XElement("contatto");
                var nome = new XElement("nome");
                nome.Add(Nome);

                var cognome = new XElement("cognome");
                cognome.Add(Cognome);

                Contatto.Add(nome);
                Contatto.Add(cognome);

                return Contatto;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            XDocument xmlFile;
            if (!File.Exists("rubrica.xml"))
            {
                xmlFile = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XComment("File rubrica"));
                xmlFile.Save("rubrica.xml");
            } else
            {
                xmlFile = XDocument.Load("rubrica.xml");
            }
            Contatto contatto = new Contatto();
            xmlFile.Add(contatto.genera_contatto());
        }
    }
}
