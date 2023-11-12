
namespace Skaistumkopsana_08_11_2023_EB_LL
{
    partial class Form3
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
            this.nakama3 = new System.Windows.Forms.Button();
            this.iepriekseja2 = new System.Windows.Forms.Button();
            this.PakalpVeidi = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IzveleBTN = new System.Windows.Forms.Button();
            this.kaste1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nakama3
            // 
            this.nakama3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nakama3.Location = new System.Drawing.Point(612, 383);
            this.nakama3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nakama3.Name = "nakama3";
            this.nakama3.Size = new System.Drawing.Size(175, 54);
            this.nakama3.TabIndex = 3;
            this.nakama3.Text = "Nākamā lappuse";
            this.nakama3.UseVisualStyleBackColor = true;
            this.nakama3.Click += new System.EventHandler(this.nakama3_Click);
            // 
            // iepriekseja2
            // 
            this.iepriekseja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.iepriekseja2.Location = new System.Drawing.Point(12, 383);
            this.iepriekseja2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iepriekseja2.Name = "iepriekseja2";
            this.iepriekseja2.Size = new System.Drawing.Size(189, 54);
            this.iepriekseja2.TabIndex = 4;
            this.iepriekseja2.Text = "Iepriekšējā lappuse";
            this.iepriekseja2.UseVisualStyleBackColor = true;
            this.iepriekseja2.Click += new System.EventHandler(this.iepriekseja2_Click);
            // 
            // PakalpVeidi
            // 
            this.PakalpVeidi.FormattingEnabled = true;
            this.PakalpVeidi.Items.AddRange(new object[] {
            "Matu_veidošana",
            "Matu_krāsošana",
            "Manikīrs",
            "Pedikīrs"});
            this.PakalpVeidi.Location = new System.Drawing.Point(288, 252);
            this.PakalpVeidi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PakalpVeidi.Name = "PakalpVeidi";
            this.PakalpVeidi.Size = new System.Drawing.Size(220, 24);
            this.PakalpVeidi.TabIndex = 5;
            this.PakalpVeidi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(772, 186);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IzveleBTN
            // 
            this.IzveleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.IzveleBTN.Location = new System.Drawing.Point(312, 336);
            this.IzveleBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IzveleBTN.Name = "IzveleBTN";
            this.IzveleBTN.Size = new System.Drawing.Size(171, 59);
            this.IzveleBTN.TabIndex = 8;
            this.IzveleBTN.Text = "Izvēlēties";
            this.IzveleBTN.UseVisualStyleBackColor = true;
            this.IzveleBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaste1
            // 
            this.kaste1.Location = new System.Drawing.Point(288, 286);
            this.kaste1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kaste1.Name = "kaste1";
            this.kaste1.Size = new System.Drawing.Size(220, 22);
            this.kaste1.TabIndex = 9;
            this.kaste1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pakalpojuma veids";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Izvēlētā pakalpojuma ID";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kaste1);
            this.Controls.Add(this.IzveleBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PakalpVeidi);
            this.Controls.Add(this.iepriekseja2);
            this.Controls.Add(this.nakama3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nakama3;
        private System.Windows.Forms.Button iepriekseja2;
        private System.Windows.Forms.ComboBox PakalpVeidi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button IzveleBTN;
        private System.Windows.Forms.TextBox kaste1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}