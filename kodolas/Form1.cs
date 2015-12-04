using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kodolas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMegnyit_Click(object sender, EventArgs e)
        {
            // Ez tartalmazza majd a fájl nevét elérési útvonallal
            string path = string.Empty;

            // Megnyitás eredménye "Megnyitás" v. "Mégsem"
            DialogResult eredmeny = ofdMegnyit.ShowDialog();
            
            // listbox tartalmának törlése
            lbSzoveg.Items.Clear();
            if (eredmeny == DialogResult.OK)
            {
                path = ofdMegnyit.FileName;
                //MessageBox.Show(path);
                // File beolvasása listbox-ba
                FileStream file = new FileStream(path, FileMode.Open);
                StreamReader fileBe = new StreamReader(file);

                // Beolvasunk amíg el nem érjük a file végét
                while (!fileBe.EndOfStream)
                {
                    lbSzoveg.Items.Add( fileBe.ReadLine() );
                }


                // Fájl bezárása már nem kell! fordított sorrend
                fileBe.Close();
                file.Close();

                // Kódolás gomb engedélyezése
                btnKodolas.Enabled = true;

            }
            else{
                MessageBox.Show("Nem választottál semmit!");
            }
            
        }

        private void ofdMegnyit_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnKodolas_Click(object sender, EventArgs e)
        {
            string sor = string.Empty;
           
            for (int i = 0; i < lbSzoveg.Items.Count; i++)
            {
                string ujsor = string.Empty;
                sor = lbSzoveg.Items[i].ToString();
                for (int j = 0; j < sor.Length;  j++)
                {
                    int ch = (int)sor[j];
                    ch = ch ^ 100;
                    ujsor += (char) ch;
                }
                lbKodolt.Items.Add(ujsor);
            }

            if (lbKodolt.Items.Count > 0) {
                btnKiiras.Enabled = true;    
            }
        }

        private void btnKiiras_Click(object sender, EventArgs e)
        {
            DialogResult result = sfdKiiras.ShowDialog();
            string path = string.Empty;

            if (result == DialogResult.OK) {
                FileStream file = new FileStream(sfdKiiras.FileName, FileMode.Create);
                StreamWriter fileKi = new StreamWriter(file);

                for (int i = 0; i < lbKodolt.Items.Count; i++)
                {
                    fileKi.WriteLine(lbKodolt.Items[i]);
                }

                fileKi.Close();
                file.Close();
            }
        }
    }
}
