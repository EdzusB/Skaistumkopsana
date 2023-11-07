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
            this.Klients = new System.Windows.Forms.DataGridView();
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
            this.nakama1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Klients)).BeginInit();
            this.SuspendLayout();
            // 
            // Klients
            // 
            this.Klients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Klients.Location = new System.Drawing.Point(10, 75);
            this.Klients.Name = "Klients";
            this.Klients.RowHeadersWidth = 51;
            this.Klients.Size = new System.Drawing.Size(564, 220);
            this.Klients.TabIndex = 0;
            // 
            // vards
            // 
            this.vards.Location = new System.Drawing.Point(687, 84);
            this.vards.Name = "vards";
            this.vards.Size = new System.Drawing.Size(92, 20);
            this.vards.TabIndex = 1;
            // 
            // KONEKCIJA
            // 
            this.KONEKCIJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KONEKCIJA.Location = new System.Drawing.Point(207, 11);
            this.KONEKCIJA.Name = "KONEKCIJA";
            this.KONEKCIJA.Size = new System.Drawing.Size(170, 58);
            this.KONEKCIJA.TabIndex = 3;
            this.KONEKCIJA.Text = "Konekcija ar datubāzi";
            this.KONEKCIJA.UseVisualStyleBackColor = true;
            this.KONEKCIJA.Click += new System.EventHandler(this.KONEKCIJA_Click);
            // 
            // InsertBTN
            // 
            this.InsertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.InsertBTN.Location = new System.Drawing.Point(603, 190);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(175, 49);
            this.InsertBTN.TabIndex = 4;
            this.InsertBTN.Text = "Pievienot datus datubāzei";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(601, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(601, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uzvards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(601, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numurs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(601, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pers_kods";
            // 
            // uzvards
            // 
            this.uzvards.Location = new System.Drawing.Point(687, 107);
            this.uzvards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uzvards.Name = "uzvards";
            this.uzvards.Size = new System.Drawing.Size(92, 20);
            this.uzvards.TabIndex = 9;
            // 
            // numurs
            // 
            this.numurs.Location = new System.Drawing.Point(687, 130);
            this.numurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numurs.Name = "numurs";
            this.numurs.Size = new System.Drawing.Size(92, 20);
            this.numurs.TabIndex = 10;
            // 
            // pers_kods
            // 
            this.pers_kods.Location = new System.Drawing.Point(687, 153);
            this.pers_kods.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pers_kods.Name = "pers_kods";
            this.pers_kods.Size = new System.Drawing.Size(92, 20);
            this.pers_kods.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(606, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lūdzu ievadiet savus datus!";
            // 
            // nakama1
            // 
            this.nakama1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nakama1.Location = new System.Drawing.Point(673, 244);
            this.nakama1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nakama1.Name = "nakama1";
            this.nakama1.Size = new System.Drawing.Size(119, 52);
            this.nakama1.TabIndex = 13;
            this.nakama1.Text = "Nākamā lappuse";
            this.nakama1.UseVisualStyleBackColor = true;
            this.nakama1.Click += new System.EventHandler(this.nakama1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.nakama1);
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
            this.Controls.Add(this.Klients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Klients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Klients;
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
        private System.Windows.Forms.Button nakama1;
    }
}

