namespace Parking
{
    partial class Pocetna
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
            this.btn_stanje = new System.Windows.Forms.Button();
            this.btn_promet = new System.Windows.Forms.Button();
            this.btn_garaze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_stanje
            // 
            this.btn_stanje.Location = new System.Drawing.Point(12, 58);
            this.btn_stanje.Name = "btn_stanje";
            this.btn_stanje.Size = new System.Drawing.Size(75, 23);
            this.btn_stanje.TabIndex = 0;
            this.btn_stanje.Text = "Stanje";
            this.btn_stanje.UseVisualStyleBackColor = true;
            this.btn_stanje.Click += new System.EventHandler(this.btn_stanje_Click);
            // 
            // btn_promet
            // 
            this.btn_promet.Location = new System.Drawing.Point(93, 58);
            this.btn_promet.Name = "btn_promet";
            this.btn_promet.Size = new System.Drawing.Size(75, 23);
            this.btn_promet.TabIndex = 1;
            this.btn_promet.Text = "Promet";
            this.btn_promet.UseVisualStyleBackColor = true;
            this.btn_promet.Click += new System.EventHandler(this.btn_promet_Click);
            // 
            // btn_garaze
            // 
            this.btn_garaze.Location = new System.Drawing.Point(174, 58);
            this.btn_garaze.Name = "btn_garaze";
            this.btn_garaze.Size = new System.Drawing.Size(75, 23);
            this.btn_garaze.TabIndex = 2;
            this.btn_garaze.Text = "Garaze";
            this.btn_garaze.UseVisualStyleBackColor = true;
            this.btn_garaze.Click += new System.EventHandler(this.btn_garaze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dobrodosli";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_garaze);
            this.Controls.Add(this.btn_promet);
            this.Controls.Add(this.btn_stanje);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stanje;
        private System.Windows.Forms.Button btn_promet;
        private System.Windows.Forms.Button btn_garaze;
        private System.Windows.Forms.Label label1;
    }
}

