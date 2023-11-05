
namespace Skaistumkopsana_08_11_2023_EB_LL
{
    partial class Form2
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
            this.pakalpojumi = new System.Windows.Forms.Button();
            this.iepriekseja1 = new System.Windows.Forms.Button();
            this.nakama2 = new System.Windows.Forms.Button();
            this.pakalpojumi_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pakalpojumi_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pakalpojumi
            // 
            this.pakalpojumi.Location = new System.Drawing.Point(270, 12);
            this.pakalpojumi.Name = "pakalpojumi";
            this.pakalpojumi.Size = new System.Drawing.Size(219, 60);
            this.pakalpojumi.TabIndex = 0;
            this.pakalpojumi.Text = "Pieejamie pakalpojumi";
            this.pakalpojumi.UseVisualStyleBackColor = true;
            this.pakalpojumi.Click += new System.EventHandler(this.button1_Click);
            // 
            // iepriekseja1
            // 
            this.iepriekseja1.Location = new System.Drawing.Point(12, 403);
            this.iepriekseja1.Name = "iepriekseja1";
            this.iepriekseja1.Size = new System.Drawing.Size(150, 35);
            this.iepriekseja1.TabIndex = 1;
            this.iepriekseja1.Text = "Iepriekšējā lappuse";
            this.iepriekseja1.UseVisualStyleBackColor = true;
            this.iepriekseja1.Click += new System.EventHandler(this.iepriekseja1_Click);
            // 
            // nakama2
            // 
            this.nakama2.Location = new System.Drawing.Point(638, 403);
            this.nakama2.Name = "nakama2";
            this.nakama2.Size = new System.Drawing.Size(150, 35);
            this.nakama2.TabIndex = 2;
            this.nakama2.Text = "Nākamā lappuse";
            this.nakama2.UseVisualStyleBackColor = true;
            this.nakama2.Click += new System.EventHandler(this.nakama2_Click);
            // 
            // pakalpojumi_grid
            // 
            this.pakalpojumi_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pakalpojumi_grid.Location = new System.Drawing.Point(12, 78);
            this.pakalpojumi_grid.Name = "pakalpojumi_grid";
            this.pakalpojumi_grid.RowHeadersWidth = 51;
            this.pakalpojumi_grid.RowTemplate.Height = 24;
            this.pakalpojumi_grid.Size = new System.Drawing.Size(776, 291);
            this.pakalpojumi_grid.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pakalpojumi_grid);
            this.Controls.Add(this.nakama2);
            this.Controls.Add(this.iepriekseja1);
            this.Controls.Add(this.pakalpojumi);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pakalpojumi_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pakalpojumi;
        private System.Windows.Forms.Button iepriekseja1;
        private System.Windows.Forms.Button nakama2;
        private System.Windows.Forms.DataGridView pakalpojumi_grid;
    }
}