
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
            this.SuspendLayout();
            // 
            // nakama3
            // 
            this.nakama3.Location = new System.Drawing.Point(638, 403);
            this.nakama3.Name = "nakama3";
            this.nakama3.Size = new System.Drawing.Size(150, 35);
            this.nakama3.TabIndex = 3;
            this.nakama3.Text = "Nākamā lappuse";
            this.nakama3.UseVisualStyleBackColor = true;
            // 
            // iepriekseja2
            // 
            this.iepriekseja2.Location = new System.Drawing.Point(12, 403);
            this.iepriekseja2.Name = "iepriekseja2";
            this.iepriekseja2.Size = new System.Drawing.Size(150, 35);
            this.iepriekseja2.TabIndex = 4;
            this.iepriekseja2.Text = "Iepriekšējā lappuse";
            this.iepriekseja2.UseVisualStyleBackColor = true;
            this.iepriekseja2.Click += new System.EventHandler(this.iepriekseja2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iepriekseja2);
            this.Controls.Add(this.nakama3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nakama3;
        private System.Windows.Forms.Button iepriekseja2;
    }
}