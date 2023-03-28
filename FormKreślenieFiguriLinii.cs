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
using static OOP_Projekt2_Nester_59112.FiguryGeometryczne.Elipsa.FillElipsa.ClosedCurve;

namespace OOP_Projekt2_Nester_59112
{
    public partial class FormKreślenieFiguriLinii : Form
    {

        // deklaracja poe=wierzchno graficznej
        Graphics Rysownica;

        // deklaracja zmiennej tablicowej TFG: Tablica Figur Geometrycznych
        Punkt[] TFG;

        int IndexTFG; // indeks tablicy TFG

        // deklaracja stałych pomoczniczych
        const int vnMarginesformularza = 20; // odstęp krawedzi formularza od np. krawędzi formularzu 
        const int vnMargines = 10; // odstęp od krawędzi PictureBox

        Graphics RysownicaTymczasowa;

        Point Punkt;

        Pen Pióro;

        SolidBrush Pędzel;

        Pen PióroTymczasowe;


        List<Punkt> LFG = new List<Punkt>();

        public FormKreślenieFiguriLinii()
        {
            InitializeComponent();


            // lokalizacja i zwymiarowanie formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + vnMarginesformularza,
                Screen.PrimaryScreen.Bounds.Y + vnMarginesformularza);

            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.73F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.65F);

            // lokalizacja i zmywarowanie formularza według podanych ustawień
            this.StartPosition = FormStartPosition.Manual;
            // brak aktywności Maks I Min
            this.MaximizeBox = false;
            this.MinimizeBox = false; // ustalenie koloru tła kontrolki PictureBox
            vnRysownica.BackColor = Color.Linen;

            // ustalenie obramowania kontrolki PictureBox
            vnRysownica.BorderStyle = BorderStyle.FixedSingle;

            // utw. mapy bitowej i podpięcie jej do kontrolki PictureBox
            vnRysownica.Image = new Bitmap(vnRysownica.Width, vnRysownica.Height);


            Rysownica = Graphics.FromImage(vnRysownica.Image);

            RysownicaTymczasowa = vnRysownica.CreateGraphics();
            // lokalizacja kontrolki CheckListBox

            // utw egz Pióra
            Punkt = Point.Empty;
            Pióro = new Pen(Color.Black, 1F);
            Pióro.DashStyle = DashStyle.Solid;
            Pióro.StartCap = LineCap.Round;
            Pióro.EndCap = LineCap.Round;

            // utw piora tymczasowego
            PióroTymczasowe = new Pen(System.Drawing.Color.Black, 4);



            // utw Pędzla
            Pędzel = new SolidBrush(Color.White);


            //utw egzemplarza powierzechni graficznej 
            Rysownica = Graphics.FromImage(vnRysownica.Image);

            RysownicaTymczasowa = vnRysownica.CreateGraphics();
        }

        private void FormKreślenieFiguriLinii_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult Wynik = MessageBox.Show("Czy chczesz zamknić program ?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (Wynik == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonPowrótDoMenu_Click(object sender, EventArgs e)
        {

            // showanie formularzu
            Hide();

            FormMenu form1 = new FormMenu();


            form1.Show();
        }

        private void buttonWłączPokazFigur_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(vnRysownica.BackColor);
            timer1.Tag = 0;
            textBoxIndexLFG.Text = 0.ToString();
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;
            LFG[0].PrzesuńDoNowegoXY(vnRysownica, Rysownica, Xmax / 2, Ymax / 2);
            vnRysownica.Refresh();
            if (radioButtonAutomatyczny.Checked)
                timer1.Enabled = true;
            else
            {
                buttonNastępny.Enabled = false;
                buttonPoprzedni.Enabled = false;
                textBoxIndexLFG.Enabled = false;
            }

            buttonNastępny.Enabled = true;
            buttonPoprzedni.Enabled = true;
            radioButtonManualny.Enabled = true;
            radioButtonAutomatyczny.Enabled = true;
            buttonWyłączPokazFigur.Enabled = true;
        }

        private void vnRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            // wypisanie współrzędnych X i Y położenia myszy
            labelX.Text = e.Location.X.ToString();
            labelY.Text = e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                Punkt = e.Location;

                if (radioButtonLinisaCiągla.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    //LFG.Add(new LiniaCiągla(Punkt));

                    Pióro.Color = textBoxColorDialog.BackColor;
                    //  Pióro.DashStyle = WybranyStylLinii(comboBox1.SelectedIndex);
                    Pióro.Width = trackBar1.Value;

                    LFG.Add(new LiniaCiągla(Punkt, Pióro.Color, Pióro.DashStyle, (int)Pióro.Width));


                }

            }



        }

        private static DashStyle WybranyStylLinii(int i)
        {
            switch (i)
            {
                case (0): return DashStyle.Solid;
                case (1): return DashStyle.Dash;
                case (2): return DashStyle.Dot;
                case (3): return DashStyle.DashDot;
                case (4): return DashStyle.DashDotDot;
                default: return DashStyle.Solid;
            }



        }

        private void vnRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            // wypisanie współrzędnych X i Y położenia myszy
            labelX.Text = e.Location.X.ToString();
            labelY.Text = e.Location.Y.ToString();

            // deklaracja zmiennych pomocniczych i wyznaczenie parametów prostokąta, którym będzie wykreślona eom figura
            int lewyGórnyNarożnikX = (Punkt.X < e.Location.X) ? e.Location.X : Punkt.X;
            int lewyGórnyNarożnikY = (Punkt.Y < e.Location.Y) ? e.Location.Y : Punkt.Y;
            int Szerokość = Math.Abs(Punkt.X - e.Location.X);
            int Wysokość = Math.Abs(Punkt.Y - e.Location.Y);

            // rozpoznanie czy zdarzenie MouseUp dotyczy lewgo prycisku myszy
            if (e.Button == MouseButtons.Left)
            {
                //rozpoznanie figury geom i jej wykreślenie



                if (radioButtonLiniaProsta.Checked)
                    RysownicaTymczasowa.DrawLine(PióroTymczasowe, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);

                if (radioButtonOkrąg.Checked)
                    RysownicaTymczasowa.DrawEllipse(PióroTymczasowe, new System.Drawing.Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));


                if (radioButtonElipsa.Checked)
                    RysownicaTymczasowa.DrawEllipse(PióroTymczasowe, new System.Drawing.Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość)); 

/*                if (radioButtonFillElipsa.Checked)
                    RysownicaTymczasowa.DrawEllipse(PióroTymczasowe, new System.Drawing.Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość*));*/

                if (radioButtonProstokąt.Checked)
                    RysownicaTymczasowa.DrawRectangle(PióroTymczasowe, new System.Drawing.Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));

                if (radioButtonKwadrat.Checked)
                    RysownicaTymczasowa.DrawRectangle(PióroTymczasowe, new System.Drawing.Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));

                if (radioButtonLinisaCiągla.Checked)
                {
                    ((LiniaCiągla)LFG[LFG.Count - 1]).DodajNowyPunktKreślonejLinii(e.Location);
                    Rysownica.DrawLine(Pióro, Punkt, e.Location);
                    Punkt = e.Location;

                }


                if (radioButtonKoło.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new Okrąg(lewyGórnyNarożnikX - Szerokość, lewyGórnyNarożnikY - Wysokość, Wysokość));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.Wheat, DashStyle.Solid, 5);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }


                vnRysownica.Refresh();


            }


        }

        private void vnRysownica_MouseUp(object sender, MouseEventArgs e)
        {


            // wypisanie współrzędnych X i Y położenia myszy
            labelX.Text = e.Location.X.ToString();
            labelY.Text = e.Location.Y.ToString();

            // deklaracja zmiennych pomocniczych i wyznaczenie parametów prostokąta, którym będzie wykreślona eom figura
            int lewyGórnyNarożnikX = (Punkt.X < e.Location.X) ? e.Location.X : Punkt.X;
            int lewyGórnyNarożnikY = (Punkt.Y < e.Location.Y) ? e.Location.Y : Punkt.Y;
            int Szerokość = Math.Abs(Punkt.X - e.Location.X);
            int Wysokość = Math.Abs(Punkt.Y - e.Location.Y);


            // rozpoznanie czy zdarzenie MouseUp dotyczy lewgo prycisku myszy
            if (e.Button == MouseButtons.Left)
            {
                //rozpoznanie figury geom i jej wykreślenie
                if (radioButtonPunkt.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new FiguryGeometryczne.Punkt(Punkt.X, Punkt.Y));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.Red, DashStyle.Solid, 5);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }


                if (radioButtonLiniaProsta.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new Linia(Punkt.X, Punkt.Y, e.Location.X, e.Location.Y));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.Green, DashStyle.Dash, 5);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }


                if (radioButtonElipsa.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new Elipsa(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.BlueViolet, DashStyle.Dash, 4);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }

               /* if (radioButtonFillElipsa.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new FillElipsa(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.Violet, DashStyle.Solid, 4);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }*/

                if (radioButtonOkrąg.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new Okrąg(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Wysokość));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.DodgerBlue, DashStyle.Solid, 5);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }

                if (radioButtonProstokąt.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new Kwadrat(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.Blue, DashStyle.Solid, 5);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }

                if (radioButtonKwadrat.Checked)
                {
                    // utw egz i dodanie jego referencji do LFG
                    LFG.Add(new Kwadrat(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Wysokość, Wysokość));

                    // ust atrybutów geom i grF
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Color.DarkSlateGray, DashStyle.Solid, 5);


                    // wykr Punktu
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }

                if (e.Button == MouseButtons.Left)
                {
                    Punkt = e.Location;
                    if (radioButtonLinisaCiągla.Checked)
                    {
                        ((LiniaCiągla)LFG[LFG.Count - 1]).DodajNowyPunktKreślonejLinii(e.Location);

                        Rysownica.DrawLine(Pióro, Punkt, e.Location);

                    }

                }

                if (radioButtonKrzywaBeziera.Checked)
                {
                    if (groupBox1.Enabled)
                    {

                        LFG.Add(new KrzywaBeziera(Rysownica, Pióro, Punkt));

                        groupBox1.Enabled = false;
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych = 0;

                    }

                    else
                    {
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).DodajNowyPunktKontrolonych(e.Location, Rysownica);
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych++;


                        if (((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych == 3)
                        {
                            groupBox1.Enabled = true;
                            LFG[LFG.Count - 1].Wykreśl(Rysownica);
                        }

                    }

                }

                if (radioButtonDrawClosedCurve.Checked)
                {
                    if (groupBox1.Enabled)
                    {

                        LFG.Add(new ClosedCurve(Rysownica, Pióro, Punkt));

                        groupBox1.Enabled = false;
                        ((ClosedCurve)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych = 0;

                    }

                   

                    else
                    {
                        ((ClosedCurve)LFG[LFG.Count - 1]).DodajNowyPunktKontrolonych(e.Location, Rysownica);
                        ((ClosedCurve)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych++;


                        if (((ClosedCurve)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych == 3)
                        {
                            groupBox1.Enabled = true;
                            LFG[LFG.Count - 1].Wykreśl(Rysownica);
                        }

                    }

                }


                if (radioButtonCurve.Checked)
                {
                    if (groupBox1.Enabled)
                    {

                        LFG.Add(new Curve(Rysownica, Pióro, Punkt));

                        groupBox1.Enabled = false;
                        ((Curve)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych = 0;

                    }



                    else
                    {
                        ((Curve)LFG[LFG.Count - 1]).DodajNowyPunktKontrolonych(e.Location, Rysownica);
                        ((Curve)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych++;


                        if (((Curve)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych == 3)
                        {
                            groupBox1.Enabled = true;
                            LFG[LFG.Count - 1].Wykreśl(Rysownica);
                        }

                    }

                }

                vnRysownica.Refresh();
            }
        }

        private void buttonKolorWypełnienia_Click(object sender, EventArgs e)
        {
            ColorDialog KolorDialog = new ColorDialog();
            KolorDialog.Color = Pióro.Color;

            if (KolorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.BackColor = KolorDialog.Color;
                vnRysownica.BackColor = KolorDialog.Color;

            }
            KolorDialog.Dispose();

            vnRysownica.BackColor = textBox2.BackColor;
            vnRysownica.Refresh();
        }

        private void vnRysownica_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonLiniaProsta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog KolorDialog = new ColorDialog();
            KolorDialog.Color = Pióro.Color;

            if (KolorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxColorDialog.BackColor = KolorDialog.Color;
                Pióro.Color = KolorDialog.Color;
            }
            KolorDialog.Dispose();
        }

        private void radioButtonElipsa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonProstokąt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrzesuń_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(vnRysownica.BackColor);

            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            int X, Y;

            Random rnd = new Random();

            for (int vni = 0; vni < LFG.Count; vni++)
            {
                X = rnd.Next(vnMargines, Xmax - vnMargines);
                Y = rnd.Next(vnMargines, Ymax - vnMargines);

                // zmiana połozenia i-tej figury gromr=etrycznej
                LFG[vni].PrzesuńDoNowegoXY(vnRysownica, Rysownica, X, Y);

                /*  LFG[vni].UaktyalnijXY(X, Y);
                  LFG[vni].Wykreśl(Rysownica);*/

            }

            vnRysownica.Refresh();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // wymazanie całej powierzhni graficznej
            Rysownica.Clear(vnRysownica.BackColor);

            // wyznaczenie rozmiaru powierzcni graficznej 
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            // slajder indeksu tfg pokazywanej txtBox
            textBoxIndexLFG.Text = timer1.Tag.ToString();


            // wykreślenie figury
            LFG[(int)(timer1.Tag)].PrzesuńDoNowegoXY(vnRysownica, Rysownica, Xmax / 2, Ymax / 2);



            vnRysownica.Refresh();

            timer1.Tag = ((int)timer1.Tag + 1) % (LFG.Count - 1);
        }

        private void buttonConfij_Click(object sender, EventArgs e)
        {
            if (LFG.Count <= 0)
            {
                errorProvider1.SetError(buttonConfij, "ERROR: Lista figur geometrycznych pusta, CONFIJ nie może być zrealizowana");
                return;
            }

            LFG.RemoveAt(LFG.Count - 1);
            Rysownica.Clear(vnRysownica.BackColor);

            for (int vni = 0; vni < LFG.Count; vni++)
            {

                // zmiana połozenia i-tej figury gromr=etrycznej
                //LFG[vni].PrzesuńDoNowegoXY(vnRysownica, Rysownica, X, Y);

                //LFG[vni].UaktyalnijXY(X, Y);
                LFG[vni].Wykreśl(Rysownica);

            }

            vnRysownica.Refresh();

        }

        private void buttonNastępny_Click(object sender, EventArgs e)
        {
            ushort vnIndeksFigury;

            // pobranie wartości figur
            if (!ushort.TryParse(textBoxIndexLFG.Text, out vnIndeksFigury))
            {
                errorProvider1.SetError(textBoxIndexLFG, "Error: w zapisie wystąpił niedozwolony znak");

                return;
            }

            // sprawdzenie na dozwolona wartość
            if ((vnIndeksFigury < 0) || (vnIndeksFigury >= LFG.Count))
            {
                errorProvider1.SetError(textBoxIndexLFG, "Error: przekroczenie indeksow LFG");
                return;
            }

            errorProvider1.Dispose();

            // wyznaczenie rozmiaru powirzchni graf
            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            Rysownica.Clear(vnRysownica.BackColor);




            // przesunięcie figury do środka rysownicy i wykreślenie
            LFG[vnIndeksFigury].PrzesuńDoNowegoXY(vnRysownica, Rysownica, Xmax / 2, Ymax / 2);

            vnRysownica.Refresh();

            // ustawienie w kontrolce nowego numeru
            if (vnIndeksFigury < LFG.Count + 1)
            {
                vnIndeksFigury++;

            }


            else
            {
                vnIndeksFigury = 0; // co zapewnia cykliczne znacznaia indeksów TFG

            }







            textBoxIndexLFG.Text = vnIndeksFigury.ToString();
        }

        private void buttonPoprzedni_Click(object sender, EventArgs e)
        {
            ushort vnIndeksFigury;

            // pobranie wartości figur
            if (!ushort.TryParse(textBoxIndexLFG.Text, out vnIndeksFigury))
            {
                errorProvider1.SetError(textBoxIndexLFG, "Error: w zapisie wystąpił niedozwolony znak");

                return;
            }

            // sprawdzenie na dozwolona wartość
            if ((vnIndeksFigury < 0) || (vnIndeksFigury >= TFG.Length))
            {
                errorProvider1.SetError(textBoxIndexLFG, "Error: przekroczenie indeksow TFG");
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







            textBoxIndexLFG.Text = vnIndeksFigury.ToString();
        }

        private void buttonWyłączPokazFigur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonWyłączPokazFigur.Enabled = true;

            int Xmax = vnRysownica.Width;
            int Ymax = vnRysownica.Height;

            // deklaracje pomocnicze
            int vnx, vny;
            Color vnKolorLinii, vnKolorWypełnienia;
            int vnGrubośćLinii;
            DashStyle vnStylLinii;
            Random rnd = new Random();

            // wylosowanie nowych atrybutów geometrycznych (graficznych) dla wszystkich figur wpisanych w TFG
            for (int vni = 0; vni < LFG.Count; vni++)
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

                LFG[vni].UstalAtrybutyGraficzne(vnKolorLinii, vnStylLinii, vnGrubośćLinii);
                LFG[vni].UstalAtrybutyGraficzne(vnKolorWypełnienia);

                // wylosowanie figury 
                vnx = rnd.Next(vnMargines, Xmax - vnMargines);
                vny = rnd.Next(vnMargines, Ymax - vnMargines);

                // przesunięcie figury
                LFG[vni].PrzesuńDoNowegoXY(vnRysownica, Rysownica, vnx, vny);
            }

            //odswieżenie Rysownicy
            vnRysownica.Refresh();

            buttonWyłączPokazFigur.Enabled = false;
            buttonNastępny.Enabled = false;
            buttonPoprzedni.Enabled = false;
            textBoxIndexLFG.Enabled = false;
            textBoxIndexLFG.Text = 0.ToString();
            radioButtonAutomatyczny.Checked = true;

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

        private void buttonZapiszBitmapeZPliku_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonResetuj_Click(object sender, EventArgs e)
        {
            vnRysownica.BackColor = Color.Linen;

            // Wyzerowanie Rysownicy
            // vnRysownica.Image = null;



            // Wyzerowanie Rysownicy
            Graphics Rysownica = Graphics.FromImage(vnRysownica.Image);
            vnRysownica.InitialImage = null;
            Rysownica.Clear(BackColor);
            vnRysownica.Refresh();

            groupBox1.Enabled = true;


        }

        private void radioButtonDrawClosedCurve_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
