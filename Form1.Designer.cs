
namespace OOP_Projekt2_Nester_59112
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWieloformularzowyPrezenterFigurGeometrycznych = new System.Windows.Forms.Label();
            this.buttonKreślenieFigurLinii = new System.Windows.Forms.Button();
            this.buttonPrFigurZeSl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Sienna;
            this.buttonExit.Location = new System.Drawing.Point(997, 25);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(74, 33);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelWieloformularzowyPrezenterFigurGeometrycznych
            // 
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.AutoSize = true;
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.BackColor = System.Drawing.Color.Transparent;
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.ForeColor = System.Drawing.Color.Sienna;
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.Location = new System.Drawing.Point(302, 172);
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.Name = "labelWieloformularzowyPrezenterFigurGeometrycznych";
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.Size = new System.Drawing.Size(476, 68);
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.TabIndex = 16;
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.Text = "Wieloformularzowy prezenter figur\r\ngeometrycznych";
            this.labelWieloformularzowyPrezenterFigurGeometrycznych.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKreślenieFigurLinii
            // 
            this.buttonKreślenieFigurLinii.BackColor = System.Drawing.Color.Transparent;
            this.buttonKreślenieFigurLinii.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKreślenieFigurLinii.ForeColor = System.Drawing.Color.Sienna;
            this.buttonKreślenieFigurLinii.Location = new System.Drawing.Point(378, 385);
            this.buttonKreślenieFigurLinii.Name = "buttonKreślenieFigurLinii";
            this.buttonKreślenieFigurLinii.Size = new System.Drawing.Size(321, 65);
            this.buttonKreślenieFigurLinii.TabIndex = 15;
            this.buttonKreślenieFigurLinii.Text = "Kreślenie figur i linii\r\n";
            this.buttonKreślenieFigurLinii.UseVisualStyleBackColor = false;
            this.buttonKreślenieFigurLinii.Click += new System.EventHandler(this.buttonKreślenieFigurLinii_Click);
            // 
            // buttonPrFigurZeSl
            // 
            this.buttonPrFigurZeSl.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrFigurZeSl.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrFigurZeSl.ForeColor = System.Drawing.Color.Sienna;
            this.buttonPrFigurZeSl.Location = new System.Drawing.Point(378, 300);
            this.buttonPrFigurZeSl.Name = "buttonPrFigurZeSl";
            this.buttonPrFigurZeSl.Size = new System.Drawing.Size(321, 65);
            this.buttonPrFigurZeSl.TabIndex = 14;
            this.buttonPrFigurZeSl.Text = "Prezentacja figur ze slajderzem";
            this.buttonPrFigurZeSl.UseVisualStyleBackColor = false;
            this.buttonPrFigurZeSl.Click += new System.EventHandler(this.buttonMacierze_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_Projekt2_Nester_59112.Properties.Resources.background0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 607);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelWieloformularzowyPrezenterFigurGeometrycznych);
            this.Controls.Add(this.buttonKreślenieFigurLinii);
            this.Controls.Add(this.buttonPrFigurZeSl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWieloformularzowyPrezenterFigurGeometrycznych;
        private System.Windows.Forms.Button buttonKreślenieFigurLinii;
        private System.Windows.Forms.Button buttonPrFigurZeSl;
    }
}

