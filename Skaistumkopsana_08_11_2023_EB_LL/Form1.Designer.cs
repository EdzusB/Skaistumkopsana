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
            this.vardsTXBX = new System.Windows.Forms.TextBox();
            this.KONEKCIJA = new System.Windows.Forms.Button();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(275, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // vardsTXBX
            // 
            this.vardsTXBX.Location = new System.Drawing.Point(109, 212);
            this.vardsTXBX.Name = "vardsTXBX";
            this.vardsTXBX.Size = new System.Drawing.Size(193, 20);
            this.vardsTXBX.TabIndex = 1;
            // 
            // KONEKCIJA
            // 
            this.KONEKCIJA.Location = new System.Drawing.Point(115, 68);
            this.KONEKCIJA.Name = "KONEKCIJA";
            this.KONEKCIJA.Size = new System.Drawing.Size(170, 58);
            this.KONEKCIJA.TabIndex = 3;
            this.KONEKCIJA.Text = "Konekcija";
            this.KONEKCIJA.UseVisualStyleBackColor = true;
            this.KONEKCIJA.Click += new System.EventHandler(this.KONEKCIJA_Click);
            // 
            // InsertBTN
            // 
            this.InsertBTN.Location = new System.Drawing.Point(117, 139);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(168, 49);
            this.InsertBTN.TabIndex = 4;
            this.InsertBTN.Text = "Ievietot";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vards";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.KONEKCIJA);
            this.Controls.Add(this.vardsTXBX);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox vardsTXBX;
        private System.Windows.Forms.Button KONEKCIJA;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Label label1;
    }
}

