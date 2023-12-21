using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenotazioni
{
    public partial class Form1 : Form
    {
        public class info
        {
            public string data { get; set; }
            public string ora { get; set; }
            public info(string d, string o)
            {
                data = d;
                ora = o;
            }
        }

        string filePath = "";
        bool newFile;
        public Form1()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            data.MinDate = today;
            var day = (int)today.DayOfWeek;
            data.MaxDate = today.AddDays((7 - day - 1) + 7);
        }

        private void get_path()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "./";
                openFileDialog.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = openFileDialog.FileName;
                openFileDialog.Dispose();
            }
        }

        private List<info> take_hours()
        {
            string text;
            if (filePath == "")
            {
                using (StreamWriter sw = File.CreateText("./prenotazioni.txt"))
                {
                    sw.WriteLine();
                }
                newFile = true;
                filePath = "./prenotazioni.txt";
            }

            using (var sw = new StreamReader(filePath, Encoding.UTF8))
            {
                text = sw.ReadToEnd();
            }
            string[] prenotazioni = text.Split('\n'), line;
            List<info> infos = new List<info>();
            foreach (var x in prenotazioni)
            {
                if (x == "")
                    break;
                line = x.Split(';');
                try
                {
                    infos.Add(new info((line[2].Split(' '))[0], (line[2].Split(' '))[1]));
                } catch { break; }   
            }
            return infos;
        }

        private bool control(string giorno)
        {
            List<info> infos = take_hours();
            if (infos.Count == 0)
                return true;
            foreach (var x in infos)
            {
                string tmp = x.data + " " + x.ora.Remove(x.ora.Length - 1, 1);
                if (tmp == giorno)
                    return false;
            }   
            return true;
        }

        private void add_file(string text)
        {
            if (newFile)
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(text);
                }
                newFile = false;
            }
            else
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(text);
                }
        }

        private void clean_all(string orario)
        {
            if (orario == null)
            {
                MessageBox.Show("Campi non validi controllare!!!");
                return;
            }
            else if (orario.Length == 3 || orario.Length == 4)
                MessageBox.Show("Grazie di aver scelto il nostro sevizio\nLa tua prenotazione è stata confermata per:\n" + data.Value.ToString("D") + " " + orario + "0");
            else
                MessageBox.Show("Grazie di aver scelto il nostro sevizio\nLa tua prenotazione è stata confermata per:\n" + data.Value.ToString("D") + " " + orario);
            cognome.Text = "";
            telefono.Text = "";
            data.Text = "";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string surname = cognome.Text;
            string num = telefono.Text;
            var result_cognome = Regex.IsMatch(surname, "^[A-Za-zÀ-ÖØ-öø-ÿ ']+$");
            Regex num_regex = new Regex("^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$");
            if (!num_regex.IsMatch(num) || num == "" && !result_cognome || surname == "")
            {
                clean_all(null);
                return;
            }

            get_path();
            var ora = data.Value.Hour;
            var min = data.Value.Minute;
            if (min > 30)
            {
                ora++;
                min = 00;
            } else if (min > 15)
                min = 30;
            else
                min = 00;

            if (ora < 8 || (ora == 8 && min == 0) || ora > 19 || (ora == 19 && min == 30) || data.Value.ToString("D").Split()[0] == "domenica" || data.Value.ToString("D").Split()[0] == "lunedì")
                MessageBox.Show("barbiere chiuso");
            else
            {
                if (control(data.Value.Day.ToString() + "/" + data.Value.Month.ToString() + " " + ora + ":" + min))
                {
                    add_file(cognome.Text + ';' + telefono.Text + ';' + (data.Value.Day.ToString() + "/" + data.Value.Month.ToString() + " " + ora + ":" + min));
                    clean_all(ora.ToString() + ':' + min.ToString());
                }
                else
                {
                    MessageBox.Show("Orario già occupato");
                    data.Text = "";
                }
            }
        }
    }
}
