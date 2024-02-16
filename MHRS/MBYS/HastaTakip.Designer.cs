namespace MBYS
{
    partial class HastaTakip
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HastaListeleBtn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListeleBtn5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(296, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlaç İsmi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // HastaListeleBtn2
            // 
            this.HastaListeleBtn2.Location = new System.Drawing.Point(250, 103);
            this.HastaListeleBtn2.Name = "HastaListeleBtn2";
            this.HastaListeleBtn2.Size = new System.Drawing.Size(248, 46);
            this.HastaListeleBtn2.TabIndex = 2;
            this.HastaListeleBtn2.Text = "İLACA SAHİP HASTALARI LİSTELE";
            this.HastaListeleBtn2.UseVisualStyleBackColor = true;
            this.HastaListeleBtn2.Click += new System.EventHandler(this.HastaListeleBtn2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(405, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // ListeleBtn5
            // 
            this.ListeleBtn5.Location = new System.Drawing.Point(67, 212);
            this.ListeleBtn5.Name = "ListeleBtn5";
            this.ListeleBtn5.Size = new System.Drawing.Size(97, 36);
            this.ListeleBtn5.TabIndex = 4;
            this.ListeleBtn5.Text = "LİSTELE";
            this.ListeleBtn5.UseVisualStyleBackColor = true;
            this.ListeleBtn5.Click += new System.EventHandler(this.ListeleBtn5_Click);
            // 
            // HastaTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListeleBtn5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HastaListeleBtn2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "HastaTakip";
            this.Text = "HastaTakip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button HastaListeleBtn2;
        private DataGridView dataGridView1;
        private Button ListeleBtn5;
    }
}