using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// dodanie nowych przestrzeni nazw dla grafiky 2d
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OOP_Projekt2_Nester_59112
{
    class FiguryGeometryczne
    {
        public class Punkt // klasa Punkt
        { // deklaracja klasy bazowej
            const int vnDomyslnyRozmiarPunktu = 20;
            protected int vnX;
            protected int vnY;
            protected int vnGrubośćLinii; // grubośc punktu
            protected Color vnKolor;
            protected bool vnWidoczny; // true - jest widoczny, false - nie jest

            // deklaracja zmiennych wspólnych dla klas potomnych
            protected Color vnKolorTła;
            protected DashStyle vnStylLinii;


            // deklaracja konstruktora
            public Punkt(int vnx, int vny)
            {
                // inicjowanie atrybutów klasy Punkt na podstawie wartości parametrów aktualnego konstruktora
                vnX = vnx; vnY = vny;
                // inicjowanie atrybutów klasy Punkt na podstawie wartości domyślnych pryjętych przez projektanta programu

                vnKolor = Color.Black;
                vnKolorTła = Color.White;
                vnStylLinii = DashStyle.Solid;
                vnGrubośćLinii = vnDomyslnyRozmiarPunktu;
                vnWidoczny = false;
            }

            public Punkt(int vnx, int vny, Color vnKolor) : this(vnx, vny)
            {
                /*this(vnx, vny) - przekazanie parametrów do zadeklarowanogo juz konstruktora
                    dwuargomentowego w tej samej klasie: Punkt*/
                // inicjowanie atrybutów klasy Punkt na podstawie wartości parametrów aktualnego konstruktora
                this.vnKolor = vnKolor; // wpisanie do pola ekzemplarza klasy Punkt wartości trzeciego parametru tego konstruktora

            }

            public Punkt(int vnx, int vny, Color vnKolor, int vnRozmiarpunktu) : this(vnx, vny, vnKolor)
            {
                /*this(vnx, vny, vnkolor) - przekazanie parametrów do zadeklarowanogo juz konstruktora
                    trójargomentowego w tej samej klasie: Punkt*/
                // inicjowanie atrybutów klasy Punkt na podstawie wartości parametrów aktualnego konstruktora
                vnGrubośćLinii = vnRozmiarpunktu;
            }

            public Punkt(int vnX, int vnY, Color vnKolor, DashStyle vnStylLinii, int vnRozmiarPunktu) : this(vnX, vnY, vnKolor)
            {
                // inicjowanie atrybutów klasy Punkt na podstawie wartości parametrów aktualnego konstruktora
                this.vnStylLinii = vnStylLinii;
                vnGrubośćLinii = vnRozmiarPunktu;
            }

            public virtual void UstawXY(int X, int Y)//UaktualnijXY
            {
                this.vnX = X;
                this.vnY = Y;
            }



            // przeciążenie metody UaktyalnijXY, dla innego sposobu przekazywania parametrów

            public void UaktyalnijXY(Point NowaLokalizacja)  //mb Point
            {
                vnX = NowaLokalizacja.X;
                vnX = NowaLokalizacja.Y;
            }

            public void UstalAtrybutyGraficzne(Color vnKolorLinii, DashStyle vnStylLinii, int vnGrubośćLinii)
            {
                vnKolor = vnKolorLinii;
                this.vnStylLinii = vnStylLinii;
                this.vnGrubośćLinii = vnGrubośćLinii;
            }

            // przeciążenie metody UstalSAtrybytuGraficzn
            public void UstalAtrybutyGraficzne(Color vnKolorTła)
            {
                this.vnKolorTła = vnKolorTła;
            }


            protected void UstalStylLinii(DashStyle vnStylLinii)
            {
                this.vnStylLinii = vnStylLinii;
            }


            // metody wirtualne
            public virtual void Wykreśl(Graphics Rysownica)
            {
                // wykreślenie punktu jako wypełnionego okręgu
                SolidBrush Pędzel = new SolidBrush(vnKolor);
                Rysownica.FillEllipse(Pędzel, vnX - vnGrubośćLinii / 2, vnY - vnGrubośćLinii / 2, vnGrubośćLinii, vnGrubośćLinii);
                vnWidoczny = true; // ustawienie stanu widoczny
                Pędzel.Dispose();
            }

            public virtual void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (this.vnWidoczny)
                { /*gdy punkt jest widoczny, wynazujemy go wykreślając wypełniony okrąg(elips)
                   w kolor tła powierzchni*/

                    SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor);
                    Rysownica.FillEllipse(Pędzel, vnX - vnGrubośćLinii / 2, vnY - vnGrubośćLinii / 2, vnGrubośćLinii, vnGrubośćLinii);
                    vnWidoczny = false; // ustawienie stanu widoczny
                    Pędzel.Dispose();

                }
            }

            public virtual void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, Point NowaLokalizacja)
            {
                UaktyalnijXY(NowaLokalizacja);
                Wykreśl(Rysownica);
            }

            // przeciążenie metody PrzesunDoNowegoXY, dla innego sposobu przekazywania parametrów

            public virtual void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, int vnx, int vny)
            {
                UstawXY(vnx, vny);
                Wykreśl(Rysownica);
            }




        }

        public class Linia : Punkt
        {
            // deklaracja dla przechowania współrzędnych końca linii
            int vnXk, vnYk; // deklaracka prywatnę, klasa linia nie będzie klasa bazową dla innych klas potomnych

            public Linia(int vnXp, int vnYp, int vnXk, int vnYk) : base(vnXp, vnYp)
            { // przekazanie elementów dwuargumentowego do klasy bazowej, do klasy punkt
                this.vnXk = vnXk;
                this.vnYk = vnYk;
            }

            public Linia(int vnXp, int vnYp, int vnXk, int vnYk, Color vnKolorLinii, DashStyle vnStylLinii, int vnGrubośćLinii) : base(vnXp, vnYp, vnKolorLinii, vnStylLinii, vnGrubośćLinii)
            { // przekazanie elementów pięćargumentowego do klasy bazowej, do klasy punkt
                this.vnXk = vnXk;
                this.vnYk = vnYk;
            }

            public override void Wykreśl(Graphics Rysownica)
            {

                Pen Pióro = new Pen(vnKolor, this.vnGrubośćLinii);
                Pióro.DashStyle = vnStylLinii;
                Rysownica.DrawLine(Pióro, vnX, vnY, vnXk, vnYk);
                vnWidoczny = true;
                Pióro.Dispose();
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (vnWidoczny)
                {
                    Pen Pióro = new Pen(Kontrolka.BackColor, this.vnGrubośćLinii);
                    Pióro.DashStyle = vnStylLinii;
                    Rysownica.DrawLine(Pióro, vnX, vnY, vnXk, vnYk);
                    vnWidoczny = false;
                    Pióro.Dispose();
                }
            }
            public override void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, int vnx, int vny)
            {
                int vndx, vndy;
                if (vnx > vnX)
                    vndx = vnx - vnX;
                else
                    vndx = vnX - vnx;
                if (vny > vnY)
                    vndy = vny - vnY;
                else
                    vndy = vnY - vny;
                vnX = vnx;
                vnY = vny;
                vnXk = (vnXk + vndx) % Kontrolka.Width;
                vnYk = (vnYk + vndy) % Kontrolka.Height;
                Wykreśl(Rysownica);

            }

        } // od klasy Linia


        public class LiniaCiągla : Punkt
        {


            List<Point> ListaPunktów = new List<Point>();
            // deklaracja dla przechowania współrzędnych końca linii

            public LiniaCiągla(Point PoczątekLinii) : base(PoczątekLinii.X, PoczątekLinii.Y)
            {
                ListaPunktów.Add(PoczątekLinii);
            }

            public LiniaCiągla(Point PoczątekLinii, Color vnKolor, DashStyle vnStylLinii, int vnGrubośćLinii) : base(PoczątekLinii.X, PoczątekLinii.Y,
                vnKolor, vnStylLinii, vnGrubośćLinii)
            {
                ListaPunktów.Add(PoczątekLinii);
            }

            public void DodajNowyPunktKreślonejLinii(Point NowyPunkt)
            {
                ListaPunktów.Add(NowyPunkt);
            }

            public override void UstawXY(int x, int y)
            {
                if (ListaPunktów.Count < 1)
                    return;

                int PrxyrostX = ListaPunktów[0].X - x;
                int PrxyrostY = ListaPunktów[0].Y - y;

                for (int vni = 0; vni < ListaPunktów.Count; vni++)
                    ListaPunktów[vni] = new Point(ListaPunktów[vni].X - PrxyrostX, ListaPunktów[vni].Y - PrxyrostY);
            }

            public override void Wykreśl(Graphics Rysownica)
            {

                Point[] TablicaPunktów = new Point[ListaPunktów.Count];

                for (int vni = 0; vni < ListaPunktów.Count; vni++)
                    TablicaPunktów[vni] = ListaPunktów[vni];

                Pen Pióro = new Pen(vnKolor, this.vnGrubośćLinii);
                Pióro.DashStyle = vnStylLinii;
                Rysownica.DrawLines(Pióro, TablicaPunktów);




            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                Point[] TablicaPunktów = new Point[ListaPunktów.Count];

                for (int vni = 0; vni < ListaPunktów.Count; vni++)
                    TablicaPunktów[vni] = ListaPunktów[vni];

                Pen PióroGumka = new Pen(Kontrolka.BackColor, vnGrubośćLinii);
                PióroGumka.DashStyle = vnStylLinii;
                Rysownica.DrawLines(PióroGumka, TablicaPunktów);


            }


        } // od klasy Linia


        public class Elipsa : Punkt
        {
            protected int vnOśDuża, vnOśMała; // oś duża i oś mała elipsy /*deklaracje chronione, gdyż klasa Elipsa jest klasą bazową
                                              // dla klasy Okrąg */
            public Elipsa(int vnx, int vny, int vnOśDuża, int vnOśMała) : base(vnx, vny)
            {
                this.vnOśDuża = vnOśDuża;
                this.vnOśMała = vnOśMała;
            }
            public Elipsa(int vnx, int vny, int vnOśDuża, int vnOśMała, Color vnKolorLinii, DashStyle vnStylLinii, int vnGrubośćLinii) : base(vnx, vny, vnKolorLinii, vnStylLinii, vnGrubośćLinii)
            {
                this.vnOśDuża = vnOśDuża;
                this.vnOśMała = vnOśMała;
            }
            public override void Wykreśl(Graphics Rysownica)
            {
                Pen Pióro = new Pen(vnKolor, this.vnGrubośćLinii);
                Pióro.DashStyle = vnStylLinii;
                Rysownica.DrawEllipse(Pióro, vnX - vnOśDuża / 2, vnY - vnOśMała / 2, vnOśDuża, vnOśMała);
                vnWidoczny = true;
                Pióro.Dispose();
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (this.vnWidoczny)
                {
                    Pen Pióro = new Pen(Kontrolka.BackColor, this.vnGrubośćLinii);
                    Pióro.DashStyle = vnStylLinii;
                    Rysownica.DrawEllipse(Pióro, vnX - vnOśDuża / 2, vnY - vnOśMała / 2, vnOśDuża, vnOśMała);
                    vnWidoczny = false;
                    Pióro.Dispose();




                } // od Klasy Elipsa

            }

            // class Prostokąt : Punkt { } // od klasy Prostokąt

            public class Okrąg : Elipsa
            {
                protected int vnPromień; /* deklaracje chronione, gdyż okrąg może być klasą bazową dla innych klas potomnych (takich jak
                                          * łuk okręngu czy koła), czyli dla innych figur geometrycznych */

                public Okrąg(int vnx, int vny, int vnPromień) : base(vnx, vny, 2 * vnPromień, 2 * vnPromień)
                {
                    this.vnPromień = vnPromień;
                }

                public Okrąg(int vnx, int vny, int vnPromień, Color vnKolorLinii, DashStyle vnStylLinii, int vnGrubośćLinii) : base(vnx, vny, 2 * vnPromień, 2 * vnPromień, vnKolorLinii, vnStylLinii, vnGrubośćLinii)
                {
                    this.vnPromień = vnPromień;
                }
                public override void Wykreśl(Graphics Rysownica)
                {
                    Pen Pióro = new Pen(vnKolor, this.vnGrubośćLinii);
                    Pióro.DashStyle = vnStylLinii;
                    Rysownica.DrawEllipse(Pióro, vnX - vnPromień, vnY - vnPromień, 2 * vnPromień, 2 * vnPromień);
                    vnWidoczny = true;
                    Pióro.Dispose();
                }
                public override void Wymaż(Control Kontrolka, Graphics Rysownica)
                {
                    if (this.vnWidoczny)
                    {
                        Pen Pióro = new Pen(Kontrolka.BackColor, this.vnGrubośćLinii);
                        Pióro.DashStyle = this.vnStylLinii;
                        Rysownica.DrawEllipse(Pióro, vnX - vnPromień, vnY - vnPromień, 2 * vnPromień, 2 * vnPromień);
                        vnWidoczny = false;
                        Pióro.Dispose();
                    }
                } // od klasy Okrąg




            }

            public class FillElipsa : Punkt
            {
                protected int vnOśDuża, vnOśMała; // oś duża i oś mała elipsy /*deklaracje chronione, gdyż klasa Elipsa jest klasą bazową
                                                  // dla klasy Okrąg */
                public FillElipsa(int vnx, int vny, int vnOśDuża, int vnOśMała) : base(vnx, vny)
                {
                    this.vnOśDuża = vnOśDuża;
                    this.vnOśMała = vnOśMała;
                }
                public FillElipsa(int vnx, int vny, int vnOśDuża, int vnOśMała, Color vnKolorLinii, DashStyle vnStylLinii, int vnGrubośćLinii) : base(vnx, vny, vnKolorLinii, vnStylLinii, vnGrubośćLinii)
                {
                    this.vnOśDuża = vnOśDuża;
                    this.vnOśMała = vnOśMała;
                }
                public override void Wykreśl(Graphics Rysownica)
                {
                    // wykreślenie punktu jako wypełnionego okręgu
                    SolidBrush Pędzel = new SolidBrush(vnKolor);
                    Rysownica.FillEllipse(Pędzel, vnX - vnGrubośćLinii / 2, vnY - vnGrubośćLinii / 2, vnGrubośćLinii, vnGrubośćLinii);
                    vnWidoczny = true; // ustawienie stanu widoczny
                    Pędzel.Dispose();
                }
                public override void Wymaż(Control Kontrolka, Graphics Rysownica)
                {
                    if (this.vnWidoczny)
                    {
                        SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor);
                        Rysownica.FillEllipse(Pędzel, vnX - vnGrubośćLinii / 2, vnY - vnGrubośćLinii / 2, vnGrubośćLinii, vnGrubośćLinii);
                        vnWidoczny = false; // ustawienie stanu widoczny
                        Pędzel.Dispose();




                    } // od Klasy Elipsa

                }

                public class KrzywaBeziera : Punkt
                {
                    public List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();

                    int PromieńPunktuKontrolnego = 4;
                    public ushort LiczbaPunktówKontrolnych
                    {
                        get;
                        set;
                    }

                    Font FontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);

                    public KrzywaBeziera(Graphics Rysownica, Pen Pióro, Point XYPunktu) : base(XYPunktu.X, XYPunktu.Y, Pióro.Color, Pióro.DashStyle, (int)Pióro.Width)
                    {
                        PunktyKontrolneKrzywejBeziera.Add(XYPunktu);

                        using (SolidBrush Pędzel = new SolidBrush(Pióro.Color))
                        {
                            Rysownica.FillEllipse(Pędzel, XYPunktu.X - PromieńPunktuKontrolnego, XYPunktu.Y - PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                            Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel, PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                        }
                    }

                    public void DodajNowyPunktKontrolonych(Point XYPunktu, Graphics Rysownica)
                    {
                        PunktyKontrolneKrzywejBeziera.Add(XYPunktu);

                        using (SolidBrush Pędzel = new SolidBrush(Color.Red))
                        {
                            Rysownica.FillEllipse(Pędzel, XYPunktu.X - PromieńPunktuKontrolnego, XYPunktu.Y - PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                            Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel, PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                        }

                        if (PunktyKontrolneKrzywejBeziera.Count == 4)
                            Wykreśl(Rysownica);

                    }

                    public override void Wykreśl(Graphics Rysownica)
                    {
                        using (Pen Pióro = new Pen(vnKolor, vnGrubośćLinii))
                        {
                            Pióro.DashStyle = vnStylLinii;
                            Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];

                            for (ushort vni = 0; vni < PunktyKontrolneKrzywejBeziera.Count; vni++)
                            {
                                PunktyKontrolne[vni] = new Point(PunktyKontrolneKrzywejBeziera[vni].X, PunktyKontrolneKrzywejBeziera[vni].Y);
                            }

                            Rysownica.DrawBezier(Pióro, PunktyKontrolne[0], PunktyKontrolne[1], PunktyKontrolne[2], PunktyKontrolne[3]);

                            vnWidoczny = true;
                        }
                    }

                    public override void Wymaż(Control Kontrolka, Graphics Rysownica)
                    {
                        if (vnWidoczny)
                        {
                            using (Pen Pióro = new Pen(Kontrolka.BackColor, vnGrubośćLinii))
                            {
                                Pióro.DashStyle = vnStylLinii;
                                Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];

                                for (ushort vni = 0; vni < PunktyKontrolneKrzywejBeziera.Count; vni++)
                                {
                                    PunktyKontrolne[vni] = new Point(PunktyKontrolneKrzywejBeziera[vni].X, PunktyKontrolneKrzywejBeziera[vni].Y);
                                }

                                Rysownica.DrawBezier(Pióro, PunktyKontrolneKrzywejBeziera[0], PunktyKontrolneKrzywejBeziera[1], PunktyKontrolneKrzywejBeziera[2], PunktyKontrolneKrzywejBeziera[3]);
                            }


                            vnWidoczny = false; // ustawienie stanu widoczny

                        } // od Klasy Elipsa


                    }

                    public override void UstawXY(int X, int Y)
                    {
                        int PrzyrostX = PunktyKontrolneKrzywejBeziera[0].X - X;
                        int PrzyrostY = PunktyKontrolneKrzywejBeziera[0].Y - Y;

                        for (ushort vni = 0; vni < PunktyKontrolneKrzywejBeziera.Count; vni++)
                        {
                            PunktyKontrolneKrzywejBeziera[vni] = new Point(PunktyKontrolneKrzywejBeziera[vni].X - PrzyrostX, PunktyKontrolneKrzywejBeziera[vni].Y - PrzyrostY);
                        }
                    }

                }

                public class Kwadrat : Punkt
                {
                    protected int vnWysokość, vnSzerokość; // oś duża i oś mała elipsy /*deklaracje chronione, gdyż klasa Elipsa jest klasą bazową
                                                           // dla klasy Okrąg */
                    public Kwadrat(int vnx, int vny, int vnWysokość, int vnSzerokość) : base(vnx, vny)
                    {
                        this.vnWysokość = vnWysokość;
                        this.vnSzerokość = vnSzerokość;
                    }
                    public Kwadrat(int vnx, int vny, int vnOśDuża, int vnOśMała, Color vnKolorLinii, DashStyle vnStylLinii, int vnGrubośćLinii) 
                        : base(vnx, vny, vnKolorLinii, vnStylLinii, vnGrubośćLinii)
                    {
                        this.vnWysokość = vnWysokość;
                        this.vnSzerokość = vnSzerokość;
                    }
                    public override void Wykreśl(Graphics Rysownica)
                    {
                        Pen Pióro = new Pen(vnKolor, this.vnGrubośćLinii);
                        Pióro.DashStyle = vnStylLinii;
                        Rysownica.DrawRectangle(Pióro, vnX, vnY, vnWysokość, vnSzerokość);
                        vnWidoczny = true;
                        Pióro.Dispose();
                    }
                    public override void Wymaż(Control Kontrolka, Graphics Rysownica)
                    {
                        if (this.vnWidoczny)
                        {
                            Pen Pióro = new Pen(Kontrolka.BackColor, this.vnGrubośćLinii);
                            Pióro.DashStyle = vnStylLinii;
                            Rysownica.DrawRectangle(Pióro, vnX, vnY, vnWysokość, vnSzerokość);
                            vnWidoczny = false;
                            Pióro.Dispose();

                        } // od Klasy Elipsa

                    }
                }

                public class ClosedCurve : Punkt
                {
                    public List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();

                    int PromieńPunktuKontrolnego = 2;
                    public ushort LiczbaPunktówKontrolnych
                    {
                        get;
                        set;
                    }

                    Font FontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);

                    public ClosedCurve(Graphics Rysownica, Pen Pióro, Point XYPunktu) : base(XYPunktu.X, XYPunktu.Y, Pióro.Color, Pióro.DashStyle, (int)Pióro.Width)
                    {
                        PunktyKontrolneKrzywejBeziera.Add(XYPunktu);

                        using (SolidBrush Pędzel = new SolidBrush(Pióro.Color))
                        {
                            Rysownica.FillEllipse(Pędzel, XYPunktu.X - PromieńPunktuKontrolnego, XYPunktu.Y - PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                            Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel, PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                        }
                    }

                    public void DodajNowyPunktKontrolonych(Point XYPunktu, Graphics Rysownica)
                    {
                        PunktyKontrolneKrzywejBeziera.Add(XYPunktu);

                        using (SolidBrush Pędzel = new SolidBrush(Color.Red))
                        {
                            Rysownica.FillEllipse(Pędzel, XYPunktu.X - PromieńPunktuKontrolnego, XYPunktu.Y - PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                            Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel, PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                        }

                        if (PunktyKontrolneKrzywejBeziera.Count == 4)
                            Wykreśl(Rysownica);

                    }

                    public override void Wykreśl(Graphics Rysownica)
                    {
                        using (Pen Pióro = new Pen(vnKolor, vnGrubośćLinii))
                        {
                            Pióro.DashStyle = vnStylLinii;
                            Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];

                            for (ushort vni = 0; vni < PunktyKontrolneKrzywejBeziera.Count; vni++)
                            {
                                PunktyKontrolne[vni] = new Point(PunktyKontrolneKrzywejBeziera[vni].X, PunktyKontrolneKrzywejBeziera[vni].Y);
                            }

                            Rysownica.DrawClosedCurve(Pióro, PunktyKontrolne);

                            vnWidoczny = true;
                        }
                    }

                    public class Curve : Punkt
                    {
                        public List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();

                        int PromieńPunktuKontrolnego = 2;
                        public ushort LiczbaPunktówKontrolnych
                        {
                            get;
                            set;
                        }

                        Font FontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);

                        public Curve(Graphics Rysownica, Pen Pióro, Point XYPunktu) : base(XYPunktu.X, XYPunktu.Y, Pióro.Color, Pióro.DashStyle, (int)Pióro.Width)
                        {
                            PunktyKontrolneKrzywejBeziera.Add(XYPunktu);

                            using (SolidBrush Pędzel = new SolidBrush(Pióro.Color))
                            {
                                Rysownica.FillEllipse(Pędzel, XYPunktu.X - PromieńPunktuKontrolnego, XYPunktu.Y - PromieńPunktuKontrolnego,
                                    2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                                Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel,
                                    PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                            }
                        }

                        public void DodajNowyPunktKontrolonych(Point XYPunktu, Graphics Rysownica)
                        {
                            PunktyKontrolneKrzywejBeziera.Add(XYPunktu);

                            using (SolidBrush Pędzel = new SolidBrush(Color.Red))
                            {
                                Rysownica.FillEllipse(Pędzel, XYPunktu.X - PromieńPunktuKontrolnego, XYPunktu.Y - PromieńPunktuKontrolnego, 2
                                    * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                                Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel
                                    , PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                            }

                            if (PunktyKontrolneKrzywejBeziera.Count == 4)
                                Wykreśl(Rysownica);

                        }

                        public override void Wykreśl(Graphics Rysownica)
                        {
                            using (Pen Pióro = new Pen(vnKolor, vnGrubośćLinii))
                            {
                                Pióro.DashStyle = vnStylLinii;
                                Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];

                                for (ushort vni = 0; vni < PunktyKontrolneKrzywejBeziera.Count; vni++)
                                {
                                    PunktyKontrolne[vni] = new Point(PunktyKontrolneKrzywejBeziera[vni].X, PunktyKontrolneKrzywejBeziera[vni].Y);
                                }

                                Rysownica.DrawCurve(Pióro, PunktyKontrolne);

                                vnWidoczny = true;
                            }
                        }


                        public class Rectangle : Punkt
                        {
                            protected int vnWysokość, vnSzerokość; // oś duża i oś mała elipsy /*deklaracje chronione, gdyż klasa Elipsa jest klasą bazową
                                                                   // dla klasy Okrąg */
                            public Rectangle(int vnx, int vny, int vnWysokość, int vnSzerokość) : base(vnx, vny)
                            {
                                this.vnWysokość = vnWysokość;
                                this.vnSzerokość = vnSzerokość;
                            }
                            public Rectangle(int vnx, int vny, int vnOśDuża, int vnOśMała, Color vnKolorLinii, DashStyle vnStylLinii, int vnGrubośćLinii) : 
                                base(vnx, vny, vnKolorLinii, vnStylLinii, vnGrubośćLinii)
                            {
                                this.vnWysokość = vnWysokość;
                                this.vnSzerokość = vnSzerokość;
                            }
                            public override void Wykreśl(Graphics Rysownica)
                            {
                                Pen Pióro = new Pen(vnKolor, this.vnGrubośćLinii);
                                Pióro.DashStyle = vnStylLinii;
                                Rysownica.DrawRectangle(Pióro, vnX, vnY, vnWysokość, vnSzerokość);
                                vnWidoczny = true;
                                Pióro.Dispose();
                            }
                            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
                            {
                                if (this.vnWidoczny)
                                {
                                    Pen Pióro = new Pen(Kontrolka.BackColor, this.vnGrubośćLinii);
                                    Pióro.DashStyle = vnStylLinii;
                                    Rysownica.DrawRectangle(Pióro, vnX, vnY, vnWysokość, vnSzerokość);
                                    vnWidoczny = false;
                                    Pióro.Dispose();




                                } // od Klasy Elipsa

                            }
                        }
                    }
                }
            }
        }
    }
}

