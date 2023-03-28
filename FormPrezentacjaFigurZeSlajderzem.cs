using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static OOP_Projekt2_Nester_59112.FiguryGeometryczne;
using static OOP_Projekt2_Nester_59112.FiguryGeometryczne.Elipsa;

using static OOP_Projekt2_Nester_59112.FiguryGeometryczne.Elipsa.FillElipsa;

namespace OOP_Projekt2_Nester_59112
{
    public partial class FormPrezentacjaFigurZeSlajderzem : Form
    {
        // deklaracja poe=wierzchno graficznej
        Graphics Rysownica;

        // deklaracja zmiennej tablicowej TFG: Tablica Figur Geometrycznych
        Punkt[] TFG;

        int IndexTFG; // indeks tablicy TFG

        // deklaracja stałych pomoczniczych
        const int vnMarginesformularza = 20; // odstęp krawedzi formularza od np. krawędzi formularzu 
        const int vnMargines = 10; // odstęp od krawędzi PictureBox

        




        public FormPrezentacjaFigurZeSlajderzem()
        {

            InitializeComponent();

         
            // lokalizacja i zwymiarowanie formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + vnMarginesformularza,
                Screen.PrimaryScreen.Bounds.Y + vnMarginesformularza);

            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.70F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.67F);

            // lokalizacja i zmywarowanie formularza według podanych ustawień
            this.StartPosition = FormStartPosition.Manual;
            // brak aktywności Maks I Min
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            /*// lokalizacja i zmywiarowanie kontrolek na formularzu
            labelN.Location = new Point(Left + vnMarginesformularza, Top + vnMarginesformularza);
            textBoxN.Location = new Point(labelN.Left + vnMarginesformularza, labelN.Top + labelN.Height +vnMarginesformularza);

            buttonStart.Location = new Point(labelN.Left, textBoxN.Top + textBoxN.Height
                + vnMarginesformularza);

            // lokalizacja kontrolkki PictureBox
            vnRysownica.Location = new Point(buttonStart.Left + buttonStart.Width
                + vnMarginesformularza, textBoxN.Top);*/
/*
            vnRysownica.Width = (int)(this.Width * 0.6F);
            vnRysownica.Height = (int)(this.Height * 0.6F);*/

            // ustalenie koloru tła kontrolki PictureBox
            vnRysownica.BackColor = Color.Linen;

            // ustalenie obramowania kontrolki PictureBox
            vnRysownica.BorderStyle = BorderStyle.FixedSingle;

            // utw. mapy bitowej i podpięcie jej do kontrolki PictureBox
            vnRysownica.Image = new Bitmap(vnRysownica.Width, vnRysownica.Height);

            // lokalizacja kontrolki CheckListBox
            /* CheckedListBoxFiguryGeometryczne.Location = new Point(vnRysownica.Left + vnRysownica.Width + vnMarginesformularza,
                 vnRysownica.Top);*/

            //utw egzemplarza powierzechni graficznej 
            Rysownica = Graphics.FromImage(vnRysownica.Image);

        }

        private void FormPrezentacjaFigurZeSlajderzem_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ushort vnN;
            errorProvider1.Dispose();
            if (string.IsNullOrEmpty(textBoxN.Text.Trim()))
            {
                errorProvider1.SetError(textBoxN, "ERROR: Podaj liczbę figur");
                return;
            }
            if (!ushort.TryParse(textBoxN.Text, out vnN))
            {
                errorProvider1.SetError(textBoxN, "ERROR: Wpisano neidozwolony znak");
                return;
            }
            textBoxN.Enabled = false;

            TFG = new Punkt[vnN]; IndexTFG = 0;
            if (CheckedListBoxFiguryGeometryczne.CheckedItems.Count <= 0)
            {
                errorProvider1.SetError(CheckedListBoxFiguryGeometryczne, "Wpisz od 1 i > figur");
                return;
            }
            CheckedListBox.CheckedItemCollection Wybranefigury = CheckedListBoxFiguryGeometryczne.CheckedItems;
            CheckedListBoxFiguryGeometryczne.Enabled = false;
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;
            int X, Y;
            Color KolorLinii;
            Color KolorWypełnienia;
            int GrubośćLinii;
            DashStyle StylLinii;
            int RozmiarPunktu;
            for (int i = 0; i < vnN; i++)
            {

                X = rnd.Next(vnMargines, Xmax - vnMargines);
                Y = rnd.Next(vnMargines, Ymax - vnMargines);
                KolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                KolorWypełnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                switch (rnd.Next(1, 6))
                {
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.DashDot; break;
                    case 3: StylLinii = DashStyle.DashDotDot; break;
                    case 4: StylLinii = DashStyle.Dot; break;
                    case 5: StylLinii = DashStyle.Solid; break;
                }
                GrubośćLinii = rnd.Next(1, 11);
                int WylosowanyIndeksFigury = rnd.Next(Wybranefigury.Count);
                switch (Wybranefigury[WylosowanyIndeksFigury].ToString())
                {
                    case "Punkt":
                        TFG[IndexTFG] = new Punkt(X, Y);
                        RozmiarPunktu = rnd.Next(2, 11);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, vnStylLinii: DashStyle.Solid, GrubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Linia":
                        int Xk = rnd.Next(vnMargines, Xmax - vnMargines);
                        int Yk = rnd.Next(vnMargines, Xmax - vnMargines);
                        TFG[IndexTFG] = new Linia(X, Y, Xk, Yk);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, vnStylLinii: DashStyle.Solid, GrubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Elipsa":
                        int OśDużą = rnd.Next(vnMargines, Xmax / 4 - vnMargines);
                        int OśMała = rnd.Next(vnMargines, Xmax / 4 - vnMargines);
                        TFG[IndexTFG] = new Elipsa(X, Y, OśDużą, OśMała);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, vnStylLinii: DashStyle.Solid, GrubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Okrąg":
                        int Promień = rnd.Next(vnMargines, Ymax / 4);
                        TFG[IndexTFG] = new Okrąg(X, Y, Promień);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, vnStylLinii: DashStyle.Solid, GrubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Kwadrat":
                        int Wysokość = rnd.Next(vnMargines, Xmax / 8 - vnMargines);
                        int Szerokość = rnd.Next(vnMargines, Xmax / 8 - vnMargines);
                        TFG[IndexTFG] = new Kwadrat(50,50,200,200);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, vnStylLinii: DashStyle.Solid, GrubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Rectangle":
                        int Wysokość1 = rnd.Next(vnMargines, Xmax / 8 - vnMargines);
                        int Szerokość1 = rnd.Next(vnMargines, Xmax / 8 - vnMargines);
                        TFG[IndexTFG] = new Kwadrat(X, Y, Wysokość1, Szerokość1);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, vnStylLinii: DashStyle.Solid, GrubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                        /* case "FillEllipsa":
                             int OśDużą1 = rnd.Next(vnMargines, Xmax / 4 - vnMargines);
                             int OśMała1 = rnd.Next(vnMargines, Xmax / 4 - vnMargines);
                             TFG[IndexTFG] = new Elipsa(X, Y, OśDużą1, OśMała1);
                             TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, vnStylLinii: DashStyle.Solid, GrubośćLinii);
                             TFG[IndexTFG].Wykreśl(Rysownica);
                             IndexTFG++;*/

                }
                vnRysownica.Refresh();
                // uaktywnienia przycików
                buttonPrzesunięcie.Enabled = true;
                buttonZmianaAtrybutówGraficznych.Enabled = true;
                button4.Enabled = true;
                buttonWłączenieSlajdera.Enabled = true;
            }
                        /*    default:
                                MessageBox.Show("Nazwa ..." + (string)chlbFiguryGeometryczne.CheckedItems.Count + "ffdfd")*/
                        
                  /*  TFG = new Punkt[10];
                    IndexTFG = 0;

                    // utw egz klasy punkt
                    TFG[IndexTFG] = new Punkt(100, 100); // punkt P

                    //wykrelenie Punktu 
                    TFG[IndexTFG].Wykreśl(Rysownica); // P.wykreśl Rysownica

                    // utw egz linii
                    IndexTFG++;
                    TFG[IndexTFG] = new Linia(200, 200, 400, 300);
                    TFG[IndexTFG].UstalAtrybutyGraficzne(Color.Red, DashStyle.Dash, 3);
                    TFG[IndexTFG].Wykreśl(Rysownica);

                    // wykreślenie elipsy
                    IndexTFG++;
                    TFG[IndexTFG] = new Elipsa(300, 200, 300, 100);
                    TFG[IndexTFG].UstalAtrybutyGraficzne(Color.Blue, DashStyle.Dot, 5);
                    TFG[IndexTFG].Wykreśl(Rysownica);

                    // wykreślenie Okręgu
                    IndexTFG++;
                    TFG[IndexTFG] = new Okrąg(400, 200, 100);
                    TFG[IndexTFG].UstalAtrybutyGraficzne(Color.Green, DashStyle.Solid, 2);
                    TFG[IndexTFG].Wykreśl(Rysownica);

                    vnRysownica.Refresh();

                    buttonStart.Enabled = false;

                    // uaktywnienia przycików
                    buttonPrzesunięcie.Enabled = true;*/



         }

        private void ącegoFormularzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitwyjścieZProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
        }

        private void miętowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.MintCream;
        }

        private void ciemnoSzaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGray;
        }

        private void slateGreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.SlateGray;
        }

        private void ciemnoCzerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkRed;
        }

        private void buttonPowrótDoMenu_Click(object sender, EventArgs e)
        {
           
            // showanie formularzu
            Hide();

            FormMenu form1 = new FormMenu();
            

            form1.Show();
        }

        private void FormPrezentacjaFigurZeSlajderzem_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult Wynik = MessageBox.Show("Czy chczesz zamknić program ?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (Wynik == DialogResult.Yes)
                Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // wymazanie całej powierzhni graficznej
            Rysownica.Clear(vnRysownica.BackColor);

            // wyznaczenie rozmiaru powierzcni graficznej 
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            // slajder indeksu tfg pokazywanej txtBox
            textBoxIndexTFG.Text = timer1.Tag.ToString();


            // wykreślenie figury
            TFG[(int)(timer1.Tag)].PrzesuńDoNowegoXY(vnRysownica, Rysownica, Xmax / 2, Ymax / 2);

            

            vnRysownica.Refresh();

            timer1.Tag = ((int)timer1.Tag + 1) % (TFG.Length - 1);
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWłączenieSlajdera_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(vnRysownica.BackColor);
            timer1.Tag = 0;
            textBoxIndexTFG.Text = 0.ToString();
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;
            TFG[0].PrzesuńDoNowegoXY(vnRysownica, Rysownica, Xmax / 2, Ymax / 2);
            vnRysownica.Refresh();
            if (radioButtonAutomatyczny.Checked)
                timer1.Enabled = true;
            else
            {
                buttonNastępny.Enabled = false;
                buttonPoprzedni.Enabled = false;
                textBoxIndexTFG.Enabled = false;
            }

            buttonNastępny.Enabled = true;
            buttonPoprzedni.Enabled = true;
            radioButtonManualny.Enabled = true;
            radioButtonAutomatyczny.Enabled = true;
            buttonWyłaczenieSlajdera.Enabled = true;


        }

        private void buttonWyłaczenieSlajdera_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonWyłaczenieSlajdera.Enabled = true;

            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            // deklaracje pomocnicze
            int vnx, vny;
            Color vnKolorLinii, vnKolorWypełnienia;
            int vnGrubośćLinii;
            DashStyle vnStylLinii;
            Random rnd = new Random();

            // wylosowanie nowych atrybutów geometrycznych (graficznych) dla wszystkich figur wpisanych w TFG
            for (int vni = 0; vni < TFG.Length; vni++)
            {
                vnKolorLinii = Color.FromArgb(rnd.Next(0, 255),
                                                rnd.Next(0, 255),
                                                rnd.Next(0, 255));

                vnKolorWypełnienia = Color.FromArgb(rnd.Next(0, 255),
                                               rnd.Next(0, 255),
                                               rnd.Next(0, 255));

                vnGrubośćLinii = rnd.Next(1, vnMargines);

                switch (rnd.Next(1, 6))
                {
                    case 0: vnStylLinii = DashStyle.Solid; break;
                    case 1: vnStylLinii = DashStyle.Dash; break;
                    case 2: vnStylLinii = DashStyle.Dot; break;
                    case 3: vnStylLinii = DashStyle.DashDot; break;
                    case 4: vnStylLinii = DashStyle.DashDotDot; break;

                    default: vnStylLinii = DashStyle.Solid; break;

                }

                TFG[vni].UstalAtrybutyGraficzne(vnKolorLinii, vnStylLinii, vnGrubośćLinii);
                TFG[vni].UstalAtrybutyGraficzne(vnKolorWypełnienia);

                // wylosowanie figury 
                vnx = rnd.Next(vnMargines, Xmax - vnMargines);
                vny = rnd.Next(vnMargines, Ymax - vnMargines);

                // przesunięcie figury
                TFG[vni].PrzesuńDoNowegoXY(vnRysownica, Rysownica, vnx, vny);
            }

            //odswieżenie Rysownicy
            vnRysownica.Refresh();

            buttonWyłaczenieSlajdera.Enabled = false;
            buttonNastępny.Enabled = false;
            buttonPoprzedni.Enabled = false;
            textBoxIndexTFG.Enabled = false;
            textBoxIndexTFG.Text = 0.ToString();
            radioButtonAutomatyczny.Checked = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // deklaracja i utw egz generatora liczb losowych
            Random rnd = new Random();

            int vnXp, vnYp;

            Color vnKolorLinii, vnKolorWypełnienia;
            int vnGrubośćLinii;
            DashStyle vnStylLinii;
            int Xmax, Ymax;

            Rysownica.Clear(vnRysownica.BackColor);

            Xmax = vnRysownica.Width;
            Ymax = vnRysownica.Height;

            for (int vni = 0; vni < TFG.Length; vni++)
            {
                vnXp = rnd.Next(vnMargines, Xmax - vnMargines);
                vnYp = rnd.Next(vnMargines, Ymax - vnMargines);
                TFG[vni].PrzesuńDoNowegoXY(vnRysownica, Rysownica, vnXp, vnYp);

            }

            vnRysownica.Refresh();
        }

        private void buttonNastępny_Click(object sender, EventArgs e)
        {
            ushort vnIndeksFigury;

            // pobranie wartości figur
            if(!ushort.TryParse(textBoxIndexTFG.Text, out vnIndeksFigury))
            {
                errorProvider1.SetError(textBoxIndexTFG, "Error: w zapisie wystąpił niedozwolony znak");

                return;
            }

            // sprawdzenie na dozwolona wartość
            if((vnIndeksFigury < 0) || (vnIndeksFigury >= TFG.Length))
            {
                errorProvider1.SetError(textBoxIndexTFG, "Error: przekroczenie indeksow TFG");
                return;
            }

            errorProvider1.Dispose();

            // wyznaczenie rozmiaru powirzchni graf
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;
            
            Rysownica.Clear(vnRysownica.BackColor);


           

            // przesunięcie figury do środka rysownicy i wykreślenie
            TFG[vnIndeksFigury].PrzesuńDoNowegoXY(vnRysownica, Rysownica, Xmax / 2, Ymax / 2);

            vnRysownica.Refresh();

            // ustawienie w kontrolce nowego numeru
            if (vnIndeksFigury < TFG.Length + 1)
            {
                vnIndeksFigury++;

            }

            
            else
            {
                vnIndeksFigury = 0; // co zapewnia cykliczne znacznaia indeksów TFG
                
            }



            
            


            textBoxIndexTFG.Text = vnIndeksFigury.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int vnXp, vnYp;
            Color vnKolorLinii, vnKolorWypełnienia;
            int vnGrubośćLinii;
            DashStyle vnStylLinii;
            int Xmax, Ymax;
            Rysownica.Clear(vnRysownica.BackColor);
            Xmax = vnRysownica.Width;
            Ymax = vnRysownica.Height;
            Rysownica.Clear(vnRysownica.BackColor);
            for (int vni = 0; vni < TFG.Length; vni++)
            {
                vnKolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                vnKolorWypełnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                switch (rnd.Next(1, 5))
                {
                    case 1: vnStylLinii = DashStyle.Dash; break;
                    case 2: vnStylLinii = DashStyle.Dot; break;
                    case 3: vnStylLinii = DashStyle.Solid; break;
                    case 4: vnStylLinii = DashStyle.DashDot; break;
                    case 5: vnStylLinii = DashStyle.DashDotDot; break;
                    default: vnStylLinii = DashStyle.Solid; break;
                }
                vnGrubośćLinii = rnd.Next(1, vnMargines);
                TFG[vni].UstalAtrybutyGraficzne(vnKolorLinii, vnStylLinii, vnGrubośćLinii);
                TFG[vni].UstalAtrybutyGraficzne(vnKolorWypełnienia);
                vnXp = rnd.Next(vnMargines, Xmax - vnMargines);
                vnYp = rnd.Next(vnMargines, Ymax - vnMargines);
                TFG[vni].PrzesuńDoNowegoXY(vnRysownica, Rysownica, vnXp, vnYp);
            }
            vnRysownica.Refresh();
        }

        private void vnRysownica_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrzesunięcie_Click(object sender, EventArgs e)
        {
            // deklaracja zmiennych
            int vnXp, vnYp;

            // deklaracja i utw. generatora liczb losowych
            Random rnd = new Random();

            Rysownica.Clear(vnRysownica.BackColor);

            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            for(int vni = 0; vni < TFG.Length; vni++)
            {
                vnXp = rnd.Next(vnMargines, Xmax - vnMargines);
                vnYp = rnd.Next(vnMargines, Ymax - vnMargines);

                // zmiana połozenia i-tej figury gromr=etrycznej
                TFG[vni].PrzesuńDoNowegoXY(vnRysownica, Rysownica, vnXp, vnYp);


            }

            // odzwieżeni
            vnRysownica.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBoxFiguryGeometryczne_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }

        private void buttonPoprzedni_Click(object sender, EventArgs e)
        {
            ushort vnIndeksFigury;

            // pobranie wartości figur
            if (!ushort.TryParse(textBoxIndexTFG.Text, out vnIndeksFigury))
            {
                errorProvider1.SetError(textBoxIndexTFG, "Error: w zapisie wystąpił niedozwolony znak");

                return;
            }

            // sprawdzenie na dozwolona wartość
            if ((vnIndeksFigury < 0) || (vnIndeksFigury >= TFG.Length))
            {
                errorProvider1.SetError(textBoxIndexTFG, "Error: przekroczenie indeksow TFG");
                return;
            }

            errorProvider1.Dispose();

            // wyznaczenie rozmiaru powirzchni graf
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            Rysownica.Clear(vnRysownica.BackColor);




            // przesunięcie figury do środka rysownicy i wykreślenie
            TFG[vnIndeksFigury].PrzesuńDoNowegoXY(vnRysownica, Rysownica, Xmax / 2, Ymax / 2);

            vnRysownica.Refresh();

            // ustawienie w kontrolce nowego numeru
            if (vnIndeksFigury < TFG.Length - 1)
            {
                vnIndeksFigury--;

            }


            else
            {
                vnIndeksFigury = 0; // co zapewnia cykliczne znacznaia indeksów TFG

            }







            textBoxIndexTFG.Text = vnIndeksFigury.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPrzesunięcie.Enabled = false;
            buttonZmianaAtrybutówGraficznych.Enabled = false;
            button4.Enabled = false;
            buttonWłączenieSlajdera.Enabled = false;
            textBoxN.Enabled = true;
            textBoxN.Text = "";

            // Wyzerowanie Rysownicy
           // vnRysownica.Image = null;

            CheckedListBoxFiguryGeometryczne.Enabled = true;

            // Wyzerowanie Rysownicy
            Graphics Rysownica = Graphics.FromImage(vnRysownica.Image);
            vnRysownica.InitialImage = null;
            Rysownica.Clear(BackColor);
            vnRysownica.Refresh();


            // wyzerowanie elementów CheckedListBox
            for (int i = 0; i < CheckedListBoxFiguryGeometryczne.Items.Count; i++)
            {
                CheckedListBoxFiguryGeometryczne.SetItemChecked(i, false);
            }

            vnRysownica.BackColor = Color.Linen;


        }

        private void zapiszPlikWBitmapieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    vnRysownica.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* // deklaracja i utw egz generatora liczb losowych
            Random rnd = new Random();

            int vnXp, vnYp;

            Color vnKolorLinii, vnKolorWypełnienia;
            int vnGrubośćLinii;
            DashStyle vnStylLinii;
            int Xmax, Ymax;

            for (int vni = 0; vni < TFG.Length; vni++)
            {
                vnKolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                vnKolorWypełnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

                switch (rnd.Next(1, 5))
                {
                    case 1: vnStylLinii = DashStyle.Dash; break;
                    case 2: vnStylLinii = DashStyle.Dot; break;
                    case 3: vnStylLinii = DashStyle.Solid; break;
                    case 4: vnStylLinii = DashStyle.DashDot; break;
                    case 5: vnStylLinii = DashStyle.DashDotDot; break;
                    default: vnStylLinii = DashStyle.Solid; break;
                }
                vnGrubośćLinii = rnd.Next(1, vnMargines);
                TFG[vni].UstalAtrybutyGraficzne(vnKolorLinii, vnStylLinii, vnGrubośćLinii);

            }
            vnRysownica.Refresh();*/
        }

        private void buttonZapiszBitmapeWPliku_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    vnRysownica.Image.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
