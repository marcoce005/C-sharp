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

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("CIAO");
            var result = MessageBox.Show("ERRORE", "ciao", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);       // bisogna mantenere questa sequenza altrimenti non funziona
            MessageBox.Show(result.ToString());

            var fileContent = string.Empty;             // aprire un file
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            MessageBox.Show("File Content at path: " + filePath);


            // Aprire un file
            using (StreamReader file = new StreamReader(filePath))
            {
                int counter = 0;
                string ln;
                
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                MessageBox.Show("File has lines." + counter.ToString());
            }
        }
    }
}
