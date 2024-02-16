namespace MBYS
{
    partial class HastaArama
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
            this.label1 = new System.Windows.Forms.Label();
            this.AraBtn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListeleBtn7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(191, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak Hastanın Adı:";
            // 
            // AraBtn1
            // 
            this.AraBtn1.Location = new System.Drawing.Point(359, 112);
            this.AraBtn1.Name = "AraBtn1";
            this.AraBtn1.Size = new System.Drawing.Size(94, 29);
            this.AraBtn1.TabIndex = 1;
            this.AraBtn1.Text = "ARA";
            this.AraBtn1.UseVisualStyleBackColor = true;
            this.AraBtn1.Click += new System.EventHandler(this.AraBtn1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 27);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // ListeleBtn7
            // 
            this.ListeleBtn7.Location = new System.Drawing.Point(111, 224);
            this.ListeleBtn7.Name = "ListeleBtn7";
            this.ListeleBtn7.Size = new System.Drawing.Size(94, 29);
            this.ListeleBtn7.TabIndex = 4;
            this.ListeleBtn7.Text = "LİSTELE";
            this.ListeleBtn7.UseVisualStyleBackColor = true;
            this.ListeleBtn7.Click += new System.EventHandler(this.ListeleBtn7_Click);
            // 
            // HastaArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListeleBtn7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AraBtn1);
            this.Controls.Add(this.label1);
            this.Name = "HastaArama";
            this.Text = "HastaArama";
            this.Load += new System.EventHandler(this.HastaArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button AraBtn1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button ListeleBtn7;
    }
}