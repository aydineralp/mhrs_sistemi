namespace MBYS
{
    partial class HastaListele
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
            this.HastaListeleBtn2 = new System.Windows.Forms.Button();
            this.DataGridViewListele1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListele1)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaListeleBtn2
            // 
            this.HastaListeleBtn2.Location = new System.Drawing.Point(28, 32);
            this.HastaListeleBtn2.Name = "HastaListeleBtn2";
            this.HastaListeleBtn2.Size = new System.Drawing.Size(109, 38);
            this.HastaListeleBtn2.TabIndex = 0;
            this.HastaListeleBtn2.Text = "LİSTELE";
            this.HastaListeleBtn2.UseVisualStyleBackColor = true;
            this.HastaListeleBtn2.Click += new System.EventHandler(this.HastaListeleBtn2_Click);
            // 
            // DataGridViewListele1
            // 
            this.DataGridViewListele1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewListele1.Location = new System.Drawing.Point(28, 105);
            this.DataGridViewListele1.Name = "DataGridViewListele1";
            this.DataGridViewListele1.RowHeadersWidth = 51;
            this.DataGridViewListele1.RowTemplate.Height = 29;
            this.DataGridViewListele1.Size = new System.Drawing.Size(726, 208);
            this.DataGridViewListele1.TabIndex = 1;
            // 
            // HastaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewListele1);
            this.Controls.Add(this.HastaListeleBtn2);
            this.Name = "HastaListele";
            this.Text = "HastaListele";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListele1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button HastaListeleBtn2;
        private DataGridView DataGridViewListele1;
    }
}