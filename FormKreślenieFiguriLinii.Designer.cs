
namespace OOP_Projekt2_Nester_59112
{
    partial class FormKreślenieFiguriLinii
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonPowrótDoMenu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelPołożeniaMyszy = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConfij = new System.Windows.Forms.Button();
            this.radioButtonLinisaCiągla = new System.Windows.Forms.RadioButton();
            this.radioButtonProstokąt = new System.Windows.Forms.RadioButton();
            this.radioButtonOkrąg = new System.Windows.Forms.RadioButton();
            this.radioButtonLiniaProsta = new System.Windows.Forms.RadioButton();
            this.radioButtonCurve = new System.Windows.Forms.RadioButton();
            this.radioButtonKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.radioButtonDrawClosedCurve = new System.Windows.Forms.RadioButton();
            this.radioButtonKwadrat = new System.Windows.Forms.RadioButton();
            this.radioButtonKoło = new System.Windows.Forms.RadioButton();
            this.radioButtonElipsa = new System.Windows.Forms.RadioButton();
            this.radioButtonPunkt = new System.Windows.Forms.RadioButton();
            this.buttonWłączPokazFigur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonManualny = new System.Windows.Forms.RadioButton();
            this.radioButtonAutomatyczny = new System.Windows.Forms.RadioButton();
            this.buttonWyłączPokazFigur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonNastępny = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPoprzedni = new System.Windows.Forms.Button();
            this.textBoxIndexLFG = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxColorDialog = new System.Windows.Forms.TextBox();
            this.buttonKolorWypełnienia = new System.Windows.Forms.Button();
            this.buttonKolorLinii = new System.Windows.Forms.Button();
            this.buttonZapiszBitmapeWPliku = new System.Windows.Forms.Button();
            this.vnRysownica = new System.Windows.Forms.PictureBox();
            this.buttonPrzesuń = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonResetuj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPowrótDoMenu
            // 
            this.buttonPowrótDoMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonPowrótDoMenu.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPowrótDoMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPowrótDoMenu.Location = new System.Drawing.Point(1171, 28);
            this.buttonPowrótDoMenu.Name = "buttonPowrótDoMenu";
            this.buttonPowrótDoMenu.Size = new System.Drawing.Size(227, 49);
            this.buttonPowrótDoMenu.TabIndex = 7;
            this.buttonPowrótDoMenu.Text = "Powrót do menu";
            this.buttonPowrótDoMenu.UseVisualStyleBackColor = false;
            this.buttonPowrótDoMenu.Click += new System.EventHandler(this.buttonPowrótDoMenu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Location = new System.Drawing.Point(1075, 37);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(74, 33);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelPołożeniaMyszy
            // 
            this.labelPołożeniaMyszy.AutoSize = true;
            this.labelPołożeniaMyszy.BackColor = System.Drawing.Color.Transparent;
            this.labelPołożeniaMyszy.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPołożeniaMyszy.ForeColor = System.Drawing.Color.Beige;
            this.labelPołożeniaMyszy.Location = new System.Drawing.Point(305, 37);
            this.labelPołożeniaMyszy.Name = "labelPołożeniaMyszy";
            this.labelPołożeniaMyszy.Size = new System.Drawing.Size(319, 24);
            this.labelPołożeniaMyszy.TabIndex = 24;
            this.labelPołożeniaMyszy.Text = "Współrżędne (x,y) położenia myszy:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.Transparent;
            this.labelX.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.ForeColor = System.Drawing.Color.Beige;
            this.labelX.Location = new System.Drawing.Point(670, 37);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(27, 24);
            this.labelX.TabIndex = 25;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.Color.Transparent;
            this.labelY.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.ForeColor = System.Drawing.Color.Beige;
            this.labelY.Location = new System.Drawing.Point(724, 37);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(26, 24);
            this.labelY.TabIndex = 26;
            this.labelY.Text = "Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonConfij);
            this.groupBox1.Controls.Add(this.radioButtonLinisaCiągla);
            this.groupBox1.Controls.Add(this.radioButtonProstokąt);
            this.groupBox1.Controls.Add(this.radioButtonOkrąg);
            this.groupBox1.Controls.Add(this.radioButtonLiniaProsta);
            this.groupBox1.Controls.Add(this.radioButtonCurve);
            this.groupBox1.Controls.Add(this.radioButtonKrzywaBeziera);
            this.groupBox1.Controls.Add(this.radioButtonDrawClosedCurve);
            this.groupBox1.Controls.Add(this.radioButtonKwadrat);
            this.groupBox1.Controls.Add(this.radioButtonKoło);
            this.groupBox1.Controls.Add(this.radioButtonElipsa);
            this.groupBox1.Controls.Add(this.radioButtonPunkt);
            this.groupBox1.ForeColor = System.Drawing.Color.Beige;
            this.groupBox1.Location = new System.Drawing.Point(1046, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 274);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz figurę lub linię";
            // 
            // buttonConfij
            // 
            this.buttonConfij.ForeColor = System.Drawing.Color.Black;
            this.buttonConfij.Location = new System.Drawing.Point(204, 173);
            this.buttonConfij.Name = "buttonConfij";
            this.buttonConfij.Size = new System.Drawing.Size(110, 28);
            this.buttonConfij.TabIndex = 19;
            this.buttonConfij.Text = "Confij figurę";
            this.buttonConfij.UseVisualStyleBackColor = true;
            this.buttonConfij.Click += new System.EventHandler(this.buttonConfij_Click);
            // 
            // radioButtonLinisaCiągla
            // 
            this.radioButtonLinisaCiągla.AutoSize = true;
            this.radioButtonLinisaCiągla.Location = new System.Drawing.Point(204, 114);
            this.radioButtonLinisaCiągla.Name = "radioButtonLinisaCiągla";
            this.radioButtonLinisaCiągla.Size = new System.Drawing.Size(100, 21);
            this.radioButtonLinisaCiągla.TabIndex = 17;
            this.radioButtonLinisaCiągla.TabStop = true;
            this.radioButtonLinisaCiągla.Text = "Linia ciągla";
            this.radioButtonLinisaCiągla.UseVisualStyleBackColor = true;
            // 
            // radioButtonProstokąt
            // 
            this.radioButtonProstokąt.AutoSize = true;
            this.radioButtonProstokąt.Location = new System.Drawing.Point(204, 86);
            this.radioButtonProstokąt.Name = "radioButtonProstokąt";
            this.radioButtonProstokąt.Size = new System.Drawing.Size(89, 21);
            this.radioButtonProstokąt.TabIndex = 12;
            this.radioButtonProstokąt.TabStop = true;
            this.radioButtonProstokąt.Text = "Prostokąt";
            this.radioButtonProstokąt.UseVisualStyleBackColor = true;
            this.radioButtonProstokąt.CheckedChanged += new System.EventHandler(this.radioButtonProstokąt_CheckedChanged);
            // 
            // radioButtonOkrąg
            // 
            this.radioButtonOkrąg.AutoSize = true;
            this.radioButtonOkrąg.Location = new System.Drawing.Point(204, 58);
            this.radioButtonOkrąg.Name = "radioButtonOkrąg";
            this.radioButtonOkrąg.Size = new System.Drawing.Size(68, 21);
            this.radioButtonOkrąg.TabIndex = 11;
            this.radioButtonOkrąg.TabStop = true;
            this.radioButtonOkrąg.Text = "Okrąg";
            this.radioButtonOkrąg.UseVisualStyleBackColor = true;
            // 
            // radioButtonLiniaProsta
            // 
            this.radioButtonLiniaProsta.AutoSize = true;
            this.radioButtonLiniaProsta.Location = new System.Drawing.Point(204, 31);
            this.radioButtonLiniaProsta.Name = "radioButtonLiniaProsta";
            this.radioButtonLiniaProsta.Size = new System.Drawing.Size(103, 21);
            this.radioButtonLiniaProsta.TabIndex = 10;
            this.radioButtonLiniaProsta.TabStop = true;
            this.radioButtonLiniaProsta.Text = "Linia prosta";
            this.radioButtonLiniaProsta.UseVisualStyleBackColor = true;
            this.radioButtonLiniaProsta.CheckedChanged += new System.EventHandler(this.radioButtonLiniaProsta_CheckedChanged);
            // 
            // radioButtonCurve
            // 
            this.radioButtonCurve.AutoSize = true;
            this.radioButtonCurve.Location = new System.Drawing.Point(7, 177);
            this.radioButtonCurve.Name = "radioButtonCurve";
            this.radioButtonCurve.Size = new System.Drawing.Size(66, 21);
            this.radioButtonCurve.TabIndex = 9;
            this.radioButtonCurve.TabStop = true;
            this.radioButtonCurve.Text = "Curve";
            this.radioButtonCurve.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrzywaBeziera
            // 
            this.radioButtonKrzywaBeziera.AutoSize = true;
            this.radioButtonKrzywaBeziera.Location = new System.Drawing.Point(6, 141);
            this.radioButtonKrzywaBeziera.Name = "radioButtonKrzywaBeziera";
            this.radioButtonKrzywaBeziera.Size = new System.Drawing.Size(126, 21);
            this.radioButtonKrzywaBeziera.TabIndex = 5;
            this.radioButtonKrzywaBeziera.TabStop = true;
            this.radioButtonKrzywaBeziera.Text = "Krzywa Beziera";
            this.radioButtonKrzywaBeziera.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrawClosedCurve
            // 
            this.radioButtonDrawClosedCurve.AutoSize = true;
            this.radioButtonDrawClosedCurve.Location = new System.Drawing.Point(204, 141);
            this.radioButtonDrawClosedCurve.Name = "radioButtonDrawClosedCurve";
            this.radioButtonDrawClosedCurve.Size = new System.Drawing.Size(141, 21);
            this.radioButtonDrawClosedCurve.TabIndex = 4;
            this.radioButtonDrawClosedCurve.TabStop = true;
            this.radioButtonDrawClosedCurve.Text = "DrawClosedCurve";
            this.radioButtonDrawClosedCurve.UseVisualStyleBackColor = true;
            this.radioButtonDrawClosedCurve.CheckedChanged += new System.EventHandler(this.radioButtonDrawClosedCurve_CheckedChanged);
            // 
            // radioButtonKwadrat
            // 
            this.radioButtonKwadrat.AutoSize = true;
            this.radioButtonKwadrat.Location = new System.Drawing.Point(7, 113);
            this.radioButtonKwadrat.Name = "radioButtonKwadrat";
            this.radioButtonKwadrat.Size = new System.Drawing.Size(80, 21);
            this.radioButtonKwadrat.TabIndex = 3;
            this.radioButtonKwadrat.TabStop = true;
            this.radioButtonKwadrat.Text = "Kwadrat";
            this.radioButtonKwadrat.UseVisualStyleBackColor = true;
            // 
            // radioButtonKoło
            // 
            this.radioButtonKoło.AutoSize = true;
            this.radioButtonKoło.Location = new System.Drawing.Point(7, 86);
            this.radioButtonKoło.Name = "radioButtonKoło";
            this.radioButtonKoło.Size = new System.Drawing.Size(57, 21);
            this.radioButtonKoło.TabIndex = 2;
            this.radioButtonKoło.TabStop = true;
            this.radioButtonKoło.Text = "Koło";
            this.radioButtonKoło.UseVisualStyleBackColor = true;
            // 
            // radioButtonElipsa
            // 
            this.radioButtonElipsa.AutoSize = true;
            this.radioButtonElipsa.Location = new System.Drawing.Point(7, 58);
            this.radioButtonElipsa.Name = "radioButtonElipsa";
            this.radioButtonElipsa.Size = new System.Drawing.Size(67, 21);
            this.radioButtonElipsa.TabIndex = 1;
            this.radioButtonElipsa.TabStop = true;
            this.radioButtonElipsa.Text = "Elipsa";
            this.radioButtonElipsa.UseVisualStyleBackColor = true;
            this.radioButtonElipsa.CheckedChanged += new System.EventHandler(this.radioButtonElipsa_CheckedChanged);
            // 
            // radioButtonPunkt
            // 
            this.radioButtonPunkt.AutoSize = true;
            this.radioButtonPunkt.Location = new System.Drawing.Point(7, 31);
            this.radioButtonPunkt.Name = "radioButtonPunkt";
            this.radioButtonPunkt.Size = new System.Drawing.Size(65, 21);
            this.radioButtonPunkt.TabIndex = 0;
            this.radioButtonPunkt.TabStop = true;
            this.radioButtonPunkt.Text = "Punkt";
            this.radioButtonPunkt.UseVisualStyleBackColor = true;
            // 
            // buttonWłączPokazFigur
            // 
            this.buttonWłączPokazFigur.Location = new System.Drawing.Point(258, 485);
            this.buttonWłączPokazFigur.Name = "buttonWłączPokazFigur";
            this.buttonWłączPokazFigur.Size = new System.Drawing.Size(160, 39);
            this.buttonWłączPokazFigur.TabIndex = 28;
            this.buttonWłączPokazFigur.Text = "Włącz pokaz figur";
            this.buttonWłączPokazFigur.UseVisualStyleBackColor = true;
            this.buttonWłączPokazFigur.Click += new System.EventHandler(this.buttonWłączPokazFigur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButtonManualny);
            this.groupBox2.Controls.Add(this.radioButtonAutomatyczny);
            this.groupBox2.ForeColor = System.Drawing.Color.Beige;
            this.groupBox2.Location = new System.Drawing.Point(134, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 78);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pokaz figur";
            // 
            // radioButtonManualny
            // 
            this.radioButtonManualny.AutoSize = true;
            this.radioButtonManualny.Enabled = false;
            this.radioButtonManualny.ForeColor = System.Drawing.Color.Beige;
            this.radioButtonManualny.Location = new System.Drawing.Point(191, 38);
            this.radioButtonManualny.Name = "radioButtonManualny";
            this.radioButtonManualny.Size = new System.Drawing.Size(90, 21);
            this.radioButtonManualny.TabIndex = 1;
            this.radioButtonManualny.TabStop = true;
            this.radioButtonManualny.Text = "Manualny";
            this.radioButtonManualny.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutomatyczny
            // 
            this.radioButtonAutomatyczny.AutoSize = true;
            this.radioButtonAutomatyczny.Enabled = false;
            this.radioButtonAutomatyczny.ForeColor = System.Drawing.Color.Beige;
            this.radioButtonAutomatyczny.Location = new System.Drawing.Point(50, 38);
            this.radioButtonAutomatyczny.Name = "radioButtonAutomatyczny";
            this.radioButtonAutomatyczny.Size = new System.Drawing.Size(117, 21);
            this.radioButtonAutomatyczny.TabIndex = 0;
            this.radioButtonAutomatyczny.TabStop = true;
            this.radioButtonAutomatyczny.Text = "Automatyczny";
            this.radioButtonAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // buttonWyłączPokazFigur
            // 
            this.buttonWyłączPokazFigur.Enabled = false;
            this.buttonWyłączPokazFigur.Location = new System.Drawing.Point(426, 486);
            this.buttonWyłączPokazFigur.Name = "buttonWyłączPokazFigur";
            this.buttonWyłączPokazFigur.Size = new System.Drawing.Size(160, 39);
            this.buttonWyłączPokazFigur.TabIndex = 30;
            this.buttonWyłączPokazFigur.Text = "Wyłącz pokaz figur";
            this.buttonWyłączPokazFigur.UseVisualStyleBackColor = true;
            this.buttonWyłączPokazFigur.Click += new System.EventHandler(this.buttonWyłączPokazFigur_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonNastępny);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonPoprzedni);
            this.groupBox3.Controls.Add(this.textBoxIndexLFG);
            this.groupBox3.Location = new System.Drawing.Point(478, 531);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 78);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // buttonNastępny
            // 
            this.buttonNastępny.Enabled = false;
            this.buttonNastępny.Location = new System.Drawing.Point(251, 22);
            this.buttonNastępny.Name = "buttonNastępny";
            this.buttonNastępny.Size = new System.Drawing.Size(116, 37);
            this.buttonNastępny.TabIndex = 13;
            this.buttonNastępny.Text = "Następny";
            this.buttonNastępny.UseVisualStyleBackColor = true;
            this.buttonNastępny.Click += new System.EventHandler(this.buttonNastępny_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(145, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numer figury";
            // 
            // buttonPoprzedni
            // 
            this.buttonPoprzedni.Enabled = false;
            this.buttonPoprzedni.Location = new System.Drawing.Point(23, 22);
            this.buttonPoprzedni.Name = "buttonPoprzedni";
            this.buttonPoprzedni.Size = new System.Drawing.Size(116, 37);
            this.buttonPoprzedni.TabIndex = 12;
            this.buttonPoprzedni.Text = "Poprzedni";
            this.buttonPoprzedni.UseVisualStyleBackColor = true;
            this.buttonPoprzedni.Click += new System.EventHandler(this.buttonPoprzedni_Click);
            // 
            // textBoxIndexLFG
            // 
            this.textBoxIndexLFG.Enabled = false;
            this.textBoxIndexLFG.Location = new System.Drawing.Point(145, 37);
            this.textBoxIndexLFG.Name = "textBoxIndexLFG";
            this.textBoxIndexLFG.Size = new System.Drawing.Size(100, 22);
            this.textBoxIndexLFG.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.trackBar1);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBoxColorDialog);
            this.groupBox5.Controls.Add(this.buttonKolorWypełnienia);
            this.groupBox5.Controls.Add(this.buttonKolorLinii);
            this.groupBox5.ForeColor = System.Drawing.Color.Beige;
            this.groupBox5.Location = new System.Drawing.Point(1011, 436);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(404, 154);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Atrybuty Graficzne";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(260, 49);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(121, 56);
            this.trackBar1.TabIndex = 38;
            this.trackBar1.UseWaitCursor = true;
            this.trackBar1.Value = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBoxColorDialog
            // 
            this.textBoxColorDialog.Location = new System.Drawing.Point(139, 39);
            this.textBoxColorDialog.Name = "textBoxColorDialog";
            this.textBoxColorDialog.Size = new System.Drawing.Size(100, 22);
            this.textBoxColorDialog.TabIndex = 2;
            // 
            // buttonKolorWypełnienia
            // 
            this.buttonKolorWypełnienia.BackColor = System.Drawing.Color.Transparent;
            this.buttonKolorWypełnienia.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKolorWypełnienia.Location = new System.Drawing.Point(18, 85);
            this.buttonKolorWypełnienia.Name = "buttonKolorWypełnienia";
            this.buttonKolorWypełnienia.Size = new System.Drawing.Size(115, 44);
            this.buttonKolorWypełnienia.TabIndex = 1;
            this.buttonKolorWypełnienia.Text = "Kolor Wypełnienia";
            this.buttonKolorWypełnienia.UseVisualStyleBackColor = false;
            this.buttonKolorWypełnienia.Click += new System.EventHandler(this.buttonKolorWypełnienia_Click);
            // 
            // buttonKolorLinii
            // 
            this.buttonKolorLinii.BackColor = System.Drawing.Color.Transparent;
            this.buttonKolorLinii.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKolorLinii.Location = new System.Drawing.Point(18, 30);
            this.buttonKolorLinii.Name = "buttonKolorLinii";
            this.buttonKolorLinii.Size = new System.Drawing.Size(115, 40);
            this.buttonKolorLinii.TabIndex = 0;
            this.buttonKolorLinii.Text = "Kolor linii";
            this.buttonKolorLinii.UseVisualStyleBackColor = false;
            this.buttonKolorLinii.Click += new System.EventHandler(this.buttonKolorLinii_Click);
            // 
            // buttonZapiszBitmapeWPliku
            // 
            this.buttonZapiszBitmapeWPliku.Location = new System.Drawing.Point(92, 486);
            this.buttonZapiszBitmapeWPliku.Name = "buttonZapiszBitmapeWPliku";
            this.buttonZapiszBitmapeWPliku.Size = new System.Drawing.Size(160, 39);
            this.buttonZapiszBitmapeWPliku.TabIndex = 34;
            this.buttonZapiszBitmapeWPliku.Text = "Zapisz Bitmape w pliku";
            this.buttonZapiszBitmapeWPliku.UseVisualStyleBackColor = true;
            this.buttonZapiszBitmapeWPliku.Click += new System.EventHandler(this.buttonZapiszBitmapeWPliku_Click);
            // 
            // vnRysownica
            // 
            this.vnRysownica.Location = new System.Drawing.Point(70, 70);
            this.vnRysownica.Name = "vnRysownica";
            this.vnRysownica.Size = new System.Drawing.Size(867, 400);
            this.vnRysownica.TabIndex = 36;
            this.vnRysownica.TabStop = false;
            this.vnRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vnRysownica_MouseDown);
            this.vnRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vnRysownica_MouseMove);
            this.vnRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vnRysownica_MouseUp);
            // 
            // buttonPrzesuń
            // 
            this.buttonPrzesuń.Location = new System.Drawing.Point(595, 486);
            this.buttonPrzesuń.Name = "buttonPrzesuń";
            this.buttonPrzesuń.Size = new System.Drawing.Size(160, 39);
            this.buttonPrzesuń.TabIndex = 37;
            this.buttonPrzesuń.Text = "Przesuń figury";
            this.buttonPrzesuń.UseVisualStyleBackColor = true;
            this.buttonPrzesuń.Click += new System.EventHandler(this.buttonPrzesuń_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonResetuj
            // 
            this.buttonResetuj.Location = new System.Drawing.Point(761, 485);
            this.buttonResetuj.Name = "buttonResetuj";
            this.buttonResetuj.Size = new System.Drawing.Size(160, 39);
            this.buttonResetuj.TabIndex = 38;
            this.buttonResetuj.Text = "Resetuj";
            this.buttonResetuj.UseVisualStyleBackColor = true;
            this.buttonResetuj.Click += new System.EventHandler(this.buttonResetuj_Click);
            // 
            // FormKreślenieFiguriLinii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_Projekt2_Nester_59112.Properties.Resources.background0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1451, 612);
            this.Controls.Add(this.buttonResetuj);
            this.Controls.Add(this.buttonPrzesuń);
            this.Controls.Add(this.vnRysownica);
            this.Controls.Add(this.buttonZapiszBitmapeWPliku);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonWyłączPokazFigur);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonWłączPokazFigur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelPołożeniaMyszy);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPowrótDoMenu);
            this.Name = "FormKreślenieFiguriLinii";
            this.Load += new System.EventHandler(this.FormKreślenieFiguriLinii_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPowrótDoMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelPołożeniaMyszy;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLinisaCiągla;
        private System.Windows.Forms.RadioButton radioButtonProstokąt;
        private System.Windows.Forms.RadioButton radioButtonOkrąg;
        private System.Windows.Forms.RadioButton radioButtonLiniaProsta;
        private System.Windows.Forms.RadioButton radioButtonCurve;
        private System.Windows.Forms.RadioButton radioButtonKrzywaBeziera;
        private System.Windows.Forms.RadioButton radioButtonDrawClosedCurve;
        private System.Windows.Forms.RadioButton radioButtonKwadrat;
        private System.Windows.Forms.RadioButton radioButtonKoło;
        private System.Windows.Forms.RadioButton radioButtonElipsa;
        private System.Windows.Forms.RadioButton radioButtonPunkt;
        private System.Windows.Forms.Button buttonWłączPokazFigur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonManualny;
        private System.Windows.Forms.RadioButton radioButtonAutomatyczny;
        private System.Windows.Forms.Button buttonWyłączPokazFigur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonNastępny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPoprzedni;
        private System.Windows.Forms.TextBox textBoxIndexLFG;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonKolorWypełnienia;
        private System.Windows.Forms.Button buttonKolorLinii;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxColorDialog;
        private System.Windows.Forms.Button buttonZapiszBitmapeWPliku;
        private System.Windows.Forms.PictureBox vnRysownica;
        private System.Windows.Forms.Button buttonPrzesuń;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonConfij;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonResetuj;
    }
}