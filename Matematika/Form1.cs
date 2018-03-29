using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Matematika
{
    
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        
        MatematickaOperace matOp = MatematickaOperace.Scitani;

        public void Spravne()
        {
            lblSpravne.Text = Vysledek.Spravne().ToString();

            pbObrazek.Load("happy.png");
            pbObrazek.SizeMode = PictureBoxSizeMode.StretchImage;

            rtbVysledky.SelectionColor = Color.Green;
            rtbVysledky.AppendText($"{tbPrvniCislo.Text} {lblZnamenko.Text} {tbDruheCislo.Text} = {tbVysledek.Text}\n");
        }

        public void Spatne()
        {
            lblSpatne.Text = Vysledek.Spatne().ToString();

            //timer1.Start();
            pbObrazek.Load("sad.jpg");
            pbObrazek.SizeMode = PictureBoxSizeMode.StretchImage;
            //timer1.Tick += Timer1_Tick;
            //timer1.Stop();

            
                        
            rtbVysledky.SelectionColor = Color.Red;
            rtbVysledky.AppendText($"{tbPrvniCislo.Text} {lblZnamenko.Text} {tbDruheCislo.Text} = {tbVysledek.Text}\n");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pbObrazek.Load("sad.jpg");
            pbObrazek.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void KontrolaCheckboxu()
        {
            if (chlbMatematickaOperace.GetItemChecked(1) == false) //odcitani
            {
                cbZapornyVysledek.Enabled = false;
            }
            else
            {
                cbZapornyVysledek.Enabled = true;
            }

            if (chlbMatematickaOperace.GetItemChecked(3) == true) //deleni
            {
                cbDeleniCeleCislo.Enabled = true;
            }
            else
            {
                cbDeleniCeleCislo.Enabled = false;
            }
        }

        public void GenerujVstupniHodnoty()
        {
            
            List<string> matOpList = new List<string>();
            int maxHodnota = Convert.ToInt16(nudMaxHodnota.Value) + 1;

            var checkedItems = chlbMatematickaOperace.CheckedItems;
            if (checkedItems.Contains("Sčítání"))
            {
                matOpList.Add("Sčítání");
            }

            if (checkedItems.Contains("Odčítání"))
            {
                matOpList.Add("Odčítání");
            }

            if (checkedItems.Contains("Násobení"))
            {
                matOpList.Add("Násobení");
            }

            if (checkedItems.Contains("Dělení"))
            {
                matOpList.Add("Dělení");
            }

            if (matOpList.Count == 0)
            {
                MessageBox.Show("Nebyla zvolena žádná matematická operace!");
            }

            else
            {
                int nahodnyIndexListu = GenerujNahodneCislo.Generuj(matOpList.Count);
                string nahodneZvolenaOperace = matOpList[nahodnyIndexListu];

                switch (nahodneZvolenaOperace)
                {
                    case "Sčítání":
                        lblZnamenko.Text = "+";
                        matOp = MatematickaOperace.Scitani;
                        break;
                    case "Odčítání":
                        lblZnamenko.Text = "-";
                        matOp = MatematickaOperace.Odecitani;
                        break;
                    case "Násobení":
                        lblZnamenko.Text = "*";
                        matOp = MatematickaOperace.Nasobeni;
                        break;
                    case "Dělení":
                        lblZnamenko.Text = "/";
                        matOp = MatematickaOperace.Deleni;
                        break;

                    default:
                        lblZnamenko.Text = "+";
                        matOp = MatematickaOperace.Scitani;
                        break;

                }

                float docasneCisloPrvni = GenerujNahodneCislo.Generuj(maxHodnota);
                float docasneCisloDruhe = GenerujNahodneCislo.Generuj(maxHodnota);
                
                if (matOp == MatematickaOperace.Deleni)
                {

                    while (docasneCisloDruhe == 0)
                    {
                        docasneCisloDruhe = GenerujNahodneCislo.Generuj(maxHodnota);
                    }

                    tbDruheCislo.Text = docasneCisloDruhe.ToString();
                }
                else
                {
                    tbDruheCislo.Text = GenerujNahodneCislo.Generuj(maxHodnota).ToString();
                }

                if (matOp == MatematickaOperace.Deleni && cbDeleniCeleCislo.Checked == true)
                {
                    docasneCisloPrvni = docasneCisloDruhe * GenerujNahodneCislo.Generuj(maxHodnota);
                    tbPrvniCislo.Text = docasneCisloPrvni.ToString();
                }
                else
                {
                    tbPrvniCislo.Text = GenerujNahodneCislo.Generuj(maxHodnota).ToString();
                }
                if (matOp == MatematickaOperace.Odecitani && cbZapornyVysledek.Checked == false) //pridat checkbox na zaporne vysledek
                {

                    docasneCisloPrvni = GenerujNahodneCislo.Generuj(maxHodnota);
                    docasneCisloDruhe = GenerujNahodneCislo.Generuj(maxHodnota);

                    while (docasneCisloPrvni < docasneCisloDruhe)
                    {
                        docasneCisloPrvni = GenerujNahodneCislo.Generuj(maxHodnota);
                        docasneCisloDruhe = GenerujNahodneCislo.Generuj(maxHodnota);
                    }

                    tbPrvniCislo.Text = docasneCisloPrvni.ToString();
                    tbDruheCislo.Text = docasneCisloDruhe.ToString();
                }
            }

            
                                  

        }

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            stopwatch.Start();
                        
            chlbMatematickaOperace.SetItemChecked(0, true);
            chlbMatematickaOperace.SetItemChecked(1, true);

            KontrolaCheckboxu();

            GenerujVstupniHodnoty();

        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            GenerujVstupniHodnoty();
        }

        

        private void btnSpocitej_Click(object sender, EventArgs e)
        {
                        
            float vysledekResult = 0;
            if (!float.TryParse(tbVysledek.Text,out vysledekResult))
            {
                //zprava
                MessageBox.Show("Chybí výsledek!");
                         
                              
            }
                        
            else if ((float.Parse(tbPrvniCislo.Text) + float.Parse(tbDruheCislo.Text)) == vysledekResult && (lblZnamenko.Text == "+"))
            {

                Spravne();

            }
            else if ((float.Parse(tbPrvniCislo.Text) - float.Parse(tbDruheCislo.Text)) == vysledekResult && (lblZnamenko.Text == "-"))
            {
                Spravne();
            }
            else if ((float.Parse(tbPrvniCislo.Text) * float.Parse(tbDruheCislo.Text)) == vysledekResult && (lblZnamenko.Text == "*"))
            {
                Spravne();
            }
            else if (lblZnamenko.Text == "/")
            {

                if ((float.Parse(tbPrvniCislo.Text) / float.Parse(tbDruheCislo.Text) == vysledekResult))
                {
                    Spravne();
                }
                else
                {
                    Spatne();
                }
                
            }
            else
            {
                Spatne();
            }
                        
            tbVysledek.Text = "";
            GenerujVstupniHodnoty();

            



        }
               
        

        private void tbVysledek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSpocitej_Click(sender, e);
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {

            lblPocitadlo.Text = $"{stopwatch.Elapsed.Minutes:00}:{stopwatch.Elapsed.Seconds:00}";
        }

        private void rtbVysledky_TextChanged(object sender, EventArgs e)
        {
            rtbVysledky.ScrollToCaret();
        }

        private void nudMaxHodnota_ValueChanged(object sender, EventArgs e)
        {
            GenerujVstupniHodnoty();
        }

        private void chlbMatematickaOperace_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerujVstupniHodnoty();

            KontrolaCheckboxu();
            
        }

        private void cbDeleniCeleCislo_CheckedChanged(object sender, EventArgs e)
        {
            GenerujVstupniHodnoty();
        }

        private void cbZapornyVysledek_CheckedChanged(object sender, EventArgs e)
        {
            GenerujVstupniHodnoty();
        }
    }
}
