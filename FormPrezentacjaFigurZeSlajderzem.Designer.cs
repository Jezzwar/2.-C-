
namespace OOP_Projekt2_Nester_59112
{
    partial class FormPrezentacjaFigurZeSlajderzem
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
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.CheckedListBoxFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.buttonPowrótDoMenu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ącegoFormularzuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitwyjścieZProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszPlikWBitmapieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResetuj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIndexTFG = new System.Windows.Forms.TextBox();
            this.buttonPoprzedni = new System.Windows.Forms.Button();
            this.buttonNastępny = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonManualny = new System.Windows.Forms.RadioButton();
            this.radioButtonAutomatyczny = new System.Windows.Forms.RadioButton();
            this.buttonPrzesunięcie = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonZmianaAtrybutówGraficznych = new System.Windows.Forms.Button();
            this.buttonWłączenieSlajdera = new System.Windows.Forms.Button();
            this.buttonWyłaczenieSlajdera = new System.Windows.Forms.Button();
            this.vnRysownica = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonZapiszBitmapeWPliku = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vnRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.Transparent;
            this.labelN.ForeColor = System.Drawing.Color.Beige;
            this.labelN.Location = new System.Drawing.Point(38, 57);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(191, 17);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Liczbe figur Geometrycznych";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(43, 77);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(186, 22);
            this.textBoxN.TabIndex = 1;
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(41, 123);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(186, 51);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start\r\n(wykreśl figury)";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // CheckedListBoxFiguryGeometryczne
            // 
            this.CheckedListBoxFiguryGeometryczne.BackColor = System.Drawing.Color.Ivory;
            this.CheckedListBoxFiguryGeometryczne.ForeColor = System.Drawing.Color.Black;
            this.CheckedListBoxFiguryGeometryczne.FormattingEnabled = true;
            this.CheckedListBoxFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Kwadrat",
            "Rectangle"});
            this.CheckedListBoxFiguryGeometryczne.Location = new System.Drawing.Point(1155, 239);
            this.CheckedListBoxFiguryGeometryczne.Name = "CheckedListBoxFiguryGeometryczne";
            this.CheckedListBoxFiguryGeometryczne.Size = new System.Drawing.Size(227, 225);
            this.CheckedListBoxFiguryGeometryczne.TabIndex = 3;
            this.CheckedListBoxFiguryGeometryczne.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxFiguryGeometryczne_SelectedIndexChanged);
            // 
            // buttonPowrótDoMenu
            // 
            this.buttonPowrótDoMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonPowrótDoMenu.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPowrótDoMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPowrótDoMenu.Location = new System.Drawing.Point(1155, 106);
            this.buttonPowrótDoMenu.Name = "buttonPowrótDoMenu";
            this.buttonPowrótDoMenu.Size = new System.Drawing.Size(227, 49);
            this.buttonPowrótDoMenu.TabIndex = 4;
            this.buttonPowrótDoMenu.Text = "Powrót do menu";
            this.buttonPowrótDoMenu.UseVisualStyleBackColor = false;
            this.buttonPowrótDoMenu.Click += new System.EventHandler(this.buttonPowrótDoMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1451, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ącegoFormularzuToolStripMenuItem,
            this.exitwyjścieZProgramuToolStripMenuItem,
            this.zapiszPlikWBitmapieToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // ącegoFormularzuToolStripMenuItem
            // 
            this.ącegoFormularzuToolStripMenuItem.Name = "ącegoFormularzuToolStripMenuItem";
            this.ącegoFormularzuToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.ącegoFormularzuToolStripMenuItem.Text = "Zamknięcie bieżącego formularzu";
            this.ącegoFormularzuToolStripMenuItem.Click += new System.EventHandler(this.ącegoFormularzuToolStripMenuItem_Click);
            // 
            // exitwyjścieZProgramuToolStripMenuItem
            // 
            this.exitwyjścieZProgramuToolStripMenuItem.Name = "exitwyjścieZProgramuToolStripMenuItem";
            this.exitwyjścieZProgramuToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.exitwyjścieZProgramuToolStripMenuItem.Text = "&Exit (wyjście z programu)";
            this.exitwyjścieZProgramuToolStripMenuItem.Click += new System.EventHandler(this.exitwyjścieZProgramuToolStripMenuItem_Click);
            // 
            // zapiszPlikWBitmapieToolStripMenuItem
            // 
            this.zapiszPlikWBitmapieToolStripMenuItem.Name = "zapiszPlikWBitmapieToolStripMenuItem";
            this.zapiszPlikWBitmapieToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.zapiszPlikWBitmapieToolStripMenuItem.Text = "&Zapisz plik w bitmapie(png)";
            this.zapiszPlikWBitmapieToolStripMenuItem.Click += new System.EventHandler(this.zapiszPlikWBitmapieToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(1152, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zaznacz figury geometryczne,\r\nktorę mają być losowane i\r\nwyświetlane na plansze g" +
    "raficznej";
            // 
            // buttonResetuj
            // 
            this.buttonResetuj.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetuj.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetuj.Location = new System.Drawing.Point(1155, 499);
            this.buttonResetuj.Name = "buttonResetuj";
            this.buttonResetuj.Size = new System.Drawing.Size(227, 49);
            this.buttonResetuj.TabIndex = 8;
            this.buttonResetuj.Text = "Resetuj";
            this.buttonResetuj.UseVisualStyleBackColor = false;
            this.buttonResetuj.Click += new System.EventHandler(this.button1_Click);
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
            // textBoxIndexTFG
            // 
            this.textBoxIndexTFG.Enabled = false;
            this.textBoxIndexTFG.Location = new System.Drawing.Point(145, 37);
            this.textBoxIndexTFG.Name = "textBoxIndexTFG";
            this.textBoxIndexTFG.Size = new System.Drawing.Size(100, 22);
            this.textBoxIndexTFG.TabIndex = 11;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonNastępny);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonPoprzedni);
            this.groupBox1.Controls.Add(this.textBoxIndexTFG);
            this.groupBox1.Location = new System.Drawing.Point(716, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButtonManualny);
            this.groupBox2.Controls.Add(this.radioButtonAutomatyczny);
            this.groupBox2.ForeColor = System.Drawing.Color.Beige;
            this.groupBox2.Location = new System.Drawing.Point(305, 559);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 78);
            this.groupBox2.TabIndex = 15;
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
            // buttonPrzesunięcie
            // 
            this.buttonPrzesunięcie.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrzesunięcie.Enabled = false;
            this.buttonPrzesunięcie.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrzesunięcie.Location = new System.Drawing.Point(43, 187);
            this.buttonPrzesunięcie.Name = "buttonPrzesunięcie";
            this.buttonPrzesunięcie.Size = new System.Drawing.Size(186, 51);
            this.buttonPrzesunięcie.TabIndex = 16;
            this.buttonPrzesunięcie.Text = "Przesunięcie do nowego miejsca";
            this.buttonPrzesunięcie.UseVisualStyleBackColor = false;
            this.buttonPrzesunięcie.Click += new System.EventHandler(this.buttonPrzesunięcie_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(41, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 96);
            this.button4.TabIndex = 17;
            this.button4.Text = "Wylosuj nowe położenie\r\noraz atrybuty graficzne figur\r\ngeometrycznych";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonZmianaAtrybutówGraficznych
            // 
            this.buttonZmianaAtrybutówGraficznych.BackColor = System.Drawing.Color.Transparent;
            this.buttonZmianaAtrybutówGraficznych.Enabled = false;
            this.buttonZmianaAtrybutówGraficznych.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZmianaAtrybutówGraficznych.Location = new System.Drawing.Point(43, 370);
            this.buttonZmianaAtrybutówGraficznych.Name = "buttonZmianaAtrybutówGraficznych";
            this.buttonZmianaAtrybutówGraficznych.Size = new System.Drawing.Size(186, 73);
            this.buttonZmianaAtrybutówGraficznych.TabIndex = 18;
            this.buttonZmianaAtrybutówGraficznych.Text = "Zmiana atrybutów graficznych figur geometrycznych";
            this.buttonZmianaAtrybutówGraficznych.UseVisualStyleBackColor = false;
            this.buttonZmianaAtrybutówGraficznych.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonWłączenieSlajdera
            // 
            this.buttonWłączenieSlajdera.BackColor = System.Drawing.Color.Transparent;
            this.buttonWłączenieSlajdera.Enabled = false;
            this.buttonWłączenieSlajdera.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWłączenieSlajdera.Location = new System.Drawing.Point(41, 472);
            this.buttonWłączenieSlajdera.Name = "buttonWłączenieSlajdera";
            this.buttonWłączenieSlajdera.Size = new System.Drawing.Size(186, 51);
            this.buttonWłączenieSlajdera.TabIndex = 20;
            this.buttonWłączenieSlajdera.Text = "Włączenie slajdera figur geometrycznych";
            this.buttonWłączenieSlajdera.UseVisualStyleBackColor = false;
            this.buttonWłączenieSlajdera.Click += new System.EventHandler(this.buttonWłączenieSlajdera_Click);
            // 
            // buttonWyłaczenieSlajdera
            // 
            this.buttonWyłaczenieSlajdera.BackColor = System.Drawing.Color.Transparent;
            this.buttonWyłaczenieSlajdera.Enabled = false;
            this.buttonWyłaczenieSlajdera.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWyłaczenieSlajdera.Location = new System.Drawing.Point(43, 542);
            this.buttonWyłaczenieSlajdera.Name = "buttonWyłaczenieSlajdera";
            this.buttonWyłaczenieSlajdera.Size = new System.Drawing.Size(186, 51);
            this.buttonWyłaczenieSlajdera.TabIndex = 21;
            this.buttonWyłaczenieSlajdera.Text = "Wyłączenie slajdera figur geometrycznych";
            this.buttonWyłaczenieSlajdera.UseVisualStyleBackColor = false;
            this.buttonWyłaczenieSlajdera.Click += new System.EventHandler(this.buttonWyłaczenieSlajdera_Click);
            // 
            // vnRysownica
            // 
            this.vnRysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vnRysownica.Location = new System.Drawing.Point(261, 123);
            this.vnRysownica.Name = "vnRysownica";
            this.vnRysownica.Size = new System.Drawing.Size(867, 400);
            this.vnRysownica.TabIndex = 5;
            this.vnRysownica.TabStop = false;
            this.vnRysownica.Click += new System.EventHandler(this.vnRysownica_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Location = new System.Drawing.Point(1308, 49);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(74, 33);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonZapiszBitmapeWPliku
            // 
            this.buttonZapiszBitmapeWPliku.Location = new System.Drawing.Point(1155, 554);
            this.buttonZapiszBitmapeWPliku.Name = "buttonZapiszBitmapeWPliku";
            this.buttonZapiszBitmapeWPliku.Size = new System.Drawing.Size(227, 49);
            this.buttonZapiszBitmapeWPliku.TabIndex = 35;
            this.buttonZapiszBitmapeWPliku.Text = "Zapisz Bitmape w pliku";
            this.buttonZapiszBitmapeWPliku.UseVisualStyleBackColor = true;
            this.buttonZapiszBitmapeWPliku.Click += new System.EventHandler(this.buttonZapiszBitmapeWPliku_Click);
            // 
            // FormPrezentacjaFigurZeSlajderzem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::OOP_Projekt2_Nester_59112.Properties.Resources.background0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1451, 660);
            this.Controls.Add(this.buttonZapiszBitmapeWPliku);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWyłaczenieSlajdera);
            this.Controls.Add(this.buttonWłączenieSlajdera);
            this.Controls.Add(this.buttonZmianaAtrybutówGraficznych);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPrzesunięcie);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonResetuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vnRysownica);
            this.Controls.Add(this.buttonPowrótDoMenu);
            this.Controls.Add(this.CheckedListBoxFiguryGeometryczne);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrezentacjaFigurZeSlajderzem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrezentacjaFigurZeSlajderzem_FormClosed);
            this.Load += new System.EventHandler(this.FormPrezentacjaFigurZeSlajderzem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vnRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckedListBox CheckedListBoxFiguryGeometryczne;
        private System.Windows.Forms.Button buttonPowrótDoMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ącegoFormularzuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitwyjścieZProgramuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResetuj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIndexTFG;
        private System.Windows.Forms.Button buttonPoprzedni;
        private System.Windows.Forms.Button buttonNastępny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonManualny;
        private System.Windows.Forms.RadioButton radioButtonAutomatyczny;
        private System.Windows.Forms.Button buttonPrzesunięcie;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonZmianaAtrybutówGraficznych;
        private System.Windows.Forms.Button buttonWłączenieSlajdera;
        private System.Windows.Forms.Button buttonWyłaczenieSlajdera;
        private System.Windows.Forms.PictureBox vnRysownica;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem zapiszPlikWBitmapieToolStripMenuItem;
        private System.Windows.Forms.Button buttonZapiszBitmapeWPliku;
    }
}