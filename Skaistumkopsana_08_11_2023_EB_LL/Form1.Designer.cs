namespace Skaistumkopsana_08_11_2023_EB_LL
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vards = new System.Windows.Forms.TextBox();
            this.KONEKCIJA = new System.Windows.Forms.Button();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uzvards = new System.Windows.Forms.TextBox();
            this.numurs = new System.Windows.Forms.TextBox();
            this.pers_kods = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(752, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // vards
            // 
            this.vards.Location = new System.Drawing.Point(916, 103);
            this.vards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vards.Name = "vards";
            this.vards.Size = new System.Drawing.Size(121, 22);
            this.vards.TabIndex = 1;
            // 
            // KONEKCIJA
            // 
            this.KONEKCIJA.Location = new System.Drawing.Point(276, 13);
            this.KONEKCIJA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KONEKCIJA.Name = "KONEKCIJA";
            this.KONEKCIJA.Size = new System.Drawing.Size(227, 71);
            this.KONEKCIJA.TabIndex = 3;
            this.KONEKCIJA.Text = "Konekcija ar datubāzi";
            this.KONEKCIJA.UseVisualStyleBackColor = true;
            this.KONEKCIJA.Click += new System.EventHandler(this.KONEKCIJA_Click);
            // 
            // InsertBTN
            // 
            this.InsertBTN.Location = new System.Drawing.Point(804, 234);
            this.InsertBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(233, 60);
            this.InsertBTN.TabIndex = 4;
            this.InsertBTN.Text = "Pievienot datus datubāzei";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uzvards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numurs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pers_kods";
            // 
            // uzvards
            // 
            this.uzvards.Location = new System.Drawing.Point(916, 132);
            this.uzvards.Name = "uzvards";
            this.uzvards.Size = new System.Drawing.Size(121, 22);
            this.uzvards.TabIndex = 9;
            // 
            // numurs
            // 
            this.numurs.Location = new System.Drawing.Point(916, 160);
            this.numurs.Name = "numurs";
            this.numurs.Size = new System.Drawing.Size(121, 22);
            this.numurs.TabIndex = 10;
            // 
            // pers_kods
            // 
            this.pers_kods.Location = new System.Drawing.Point(916, 188);
            this.pers_kods.Name = "pers_kods";
            this.pers_kods.Size = new System.Drawing.Size(121, 22);
            this.pers_kods.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(838, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lūdzu ievadiet savus datus!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 327);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pers_kods);
            this.Controls.Add(this.numurs);
            this.Controls.Add(this.uzvards);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.KONEKCIJA);
            this.Controls.Add(this.vards);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox vards;
        private System.Windows.Forms.Button KONEKCIJA;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uzvards;
        private System.Windows.Forms.TextBox numurs;
        private System.Windows.Forms.TextBox pers_kods;
        private System.Windows.Forms.Label label5;
    }
}

