using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Projekt2_Nester_59112
{
    public partial class FormMenu : Form
    {



        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult Wynik = MessageBox.Show("Czy chczesz zamknić program ?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (Wynik == DialogResult.Yes)
                Application.Exit();
        
        }

        private void buttonMacierze_Click(object sender, EventArgs e)
        {
            // showanie form Menu
            Hide();
            // Otwarcie innego okna Prezentacja figur ze slajderzem
            FormMenu form1 = new FormMenu();
            FormPrezentacjaFigurZeSlajderzem form2 = new FormPrezentacjaFigurZeSlajderzem();


            form2.Show();
            form1.Close();





        }

        private void buttonKreślenieFigurLinii_Click(object sender, EventArgs e)
        {
            // showanie form Menu
            Hide();
            // Otwarcie innego okna Prezentacja figur ze slajderzem
            FormMenu form1 = new FormMenu();
            FormKreślenieFiguriLinii form2 = new FormKreślenieFiguriLinii();

            form2.Show();
            form1.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
