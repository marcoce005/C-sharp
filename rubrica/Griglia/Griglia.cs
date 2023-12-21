using System;
using System.Windows.Forms;
using System.Xml;
using System.Threading;

namespace Rubrica.Griglia
{
    public class Griglia
    {
        public void CreateGrid(DataGridView dg)
        {
            XmlDocument doc = new XmlDocument();
            Thread.Sleep(1000);
            doc.Load("rubrica.xml");
            XmlNodeList nomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/nome");
            XmlNodeList cognome = doc.DocumentElement.SelectNodes("/rubrica/contatto/cognome");
            XmlNodeList numeri = doc.DocumentElement.SelectNodes("/rubrica/contatto/numero");
            dg.Invoke(new Action(() => { dg.Rows.Clear(); }));
            dg.ColumnCount = 4;
            dg.Columns[0].Name = "ID";
            dg.Columns[1].Name = "Nome";
            dg.Columns[2].Name = "Cognome";
            dg.Columns[3].Name = "Numero";
            for (int i = 0; i < nomi.Count; i++)
            {
                string[] row = new string[] { i.ToString(), nomi[i].InnerText, cognome[i].InnerText, numeri[i].InnerText };
                dg.Invoke(new Action(() => dg.Rows.Add(row)));
            }
        }

        public void CreateFirstGrid(DataGridView dg)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("rubrica.xml");
            XmlNodeList nomi = doc.DocumentElement.SelectNodes("/rubrica/contatto/nome");
            XmlNodeList cognome = doc.DocumentElement.SelectNodes("/rubrica/contatto/cognome");
            XmlNodeList numeri = doc.DocumentElement.SelectNodes("/rubrica/contatto/numero");
            dg.ColumnCount = 4;
            dg.Columns[0].Name = "ID";
            dg.Columns[1].Name = "Nome";
            dg.Columns[2].Name = "Cognome";
            dg.Columns[3].Name = "Numero";
            for (int i = 0; i < nomi.Count; i++)
            {
                string[] row = new string[] { i.ToString(), nomi[i].InnerText, cognome[i].InnerText, numeri[i].InnerText };
                dg.Rows.Add(row);
            }
        }
    }
}