namespace MBYS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HastaKayitBtn1 = new System.Windows.Forms.Button();
            this.HastaListeleBtn1 = new System.Windows.Forms.Button();
            this.İlacEkleBtn1 = new System.Windows.Forms.Button();
            this.MuayeneDefteriBtn1 = new System.Windows.Forms.Button();
            this.RecetelerBtn1 = new System.Windows.Forms.Button();
            this.HastaİlacTakip1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HastaKayitBtn1
            // 
            this.HastaKayitBtn1.BackColor = System.Drawing.Color.AliceBlue;
            this.HastaKayitBtn1.Location = new System.Drawing.Point(74, 93);
            this.HastaKayitBtn1.Name = "HastaKayitBtn1";
            this.HastaKayitBtn1.Size = new System.Drawing.Size(113, 29);
            this.HastaKayitBtn1.TabIndex = 0;
            this.HastaKayitBtn1.Text = "Hasta Kayıt";
            this.HastaKayitBtn1.UseVisualStyleBackColor = false;
            this.HastaKayitBtn1.Click += new System.EventHandler(this.HastaKayitBtn1_Click);
            // 
            // HastaListeleBtn1
            // 
            this.HastaListeleBtn1.BackColor = System.Drawing.Color.AliceBlue;
            this.HastaListeleBtn1.Location = new System.Drawing.Point(74, 165);
            this.HastaListeleBtn1.Name = "HastaListeleBtn1";
            this.HastaListeleBtn1.Size = new System.Drawing.Size(113, 33);
            this.HastaListeleBtn1.TabIndex = 1;
            this.HastaListeleBtn1.Text = "Hasta Listele";
            this.HastaListeleBtn1.UseVisualStyleBackColor = false;
            this.HastaListeleBtn1.Click += new System.EventHandler(this.HastaListeleBtn1_Click);
            // 
            // İlacEkleBtn1
            // 
            this.İlacEkleBtn1.BackColor = System.Drawing.Color.AliceBlue;
            this.İlacEkleBtn1.Location = new System.Drawing.Point(283, 91);
            this.İlacEkleBtn1.Name = "İlacEkleBtn1";
            this.İlacEkleBtn1.Size = new System.Drawing.Size(107, 33);
            this.İlacEkleBtn1.TabIndex = 2;
            this.İlacEkleBtn1.Text = "İlaç Ekle";
            this.İlacEkleBtn1.UseVisualStyleBackColor = false;
            this.İlacEkleBtn1.Click += new System.EventHandler(this.İlacEkleBtn1_Click);
            // 
            // MuayeneDefteriBtn1
            // 
            this.MuayeneDefteriBtn1.BackColor = System.Drawing.Color.AliceBlue;
            this.MuayeneDefteriBtn1.Location = new System.Drawing.Point(488, 93);
            this.MuayeneDefteriBtn1.Name = "MuayeneDefteriBtn1";
            this.MuayeneDefteriBtn1.Size = new System.Drawing.Size(131, 33);
            this.MuayeneDefteriBtn1.TabIndex = 3;
            this.MuayeneDefteriBtn1.Text = "Muayene Defteri";
            this.MuayeneDefteriBtn1.UseVisualStyleBackColor = false;
            this.MuayeneDefteriBtn1.Click += new System.EventHandler(this.MuayeneDefteriBtn1_Click);
            // 
            // RecetelerBtn1
            // 
            this.RecetelerBtn1.BackColor = System.Drawing.Color.AliceBlue;
            this.RecetelerBtn1.Location = new System.Drawing.Point(283, 166);
            this.RecetelerBtn1.Name = "RecetelerBtn1";
            this.RecetelerBtn1.Size = new System.Drawing.Size(107, 32);
            this.RecetelerBtn1.TabIndex = 4;
            this.RecetelerBtn1.Text = "Reçeteler";
            this.RecetelerBtn1.UseVisualStyleBackColor = false;
            this.RecetelerBtn1.Click += new System.EventHandler(this.RecetelerBtn1_Click);
            // 
            // HastaİlacTakip1
            // 
            this.HastaİlacTakip1.Location = new System.Drawing.Point(488, 168);
            this.HastaİlacTakip1.Name = "HastaİlacTakip1";
            this.HastaİlacTakip1.Size = new System.Drawing.Size(131, 32);
            this.HastaİlacTakip1.TabIndex = 5;
            this.HastaİlacTakip1.Text = "Hasta İlaç Takip";
            this.HastaİlacTakip1.UseVisualStyleBackColor = true;
            this.HastaİlacTakip1.Click += new System.EventHandler(this.HastaİlacTakip1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(74, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hasta Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HastaİlacTakip1);
            this.Controls.Add(this.RecetelerBtn1);
            this.Controls.Add(this.MuayeneDefteriBtn1);
            this.Controls.Add(this.İlacEkleBtn1);
            this.Controls.Add(this.HastaListeleBtn1);
            this.Controls.Add(this.HastaKayitBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button HastaKayitBtn1;
        private Button HastaListeleBtn1;
        private Button İlacEkleBtn1;
        private Button MuayeneDefteriBtn1;
        private Button RecetelerBtn1;
        private Button HastaİlacTakip1;
        private Button button1;
    }
}