namespace Parking
{
    partial class Promet
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_garaza = new System.Windows.Forms.ComboBox();
            this.txt_tablica = new System.Windows.Forms.TextBox();
            this.cmb_ui = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_sati = new System.Windows.Forms.TextBox();
            this.txt_minuti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_err = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(28, 20);
            this.txt_id.TabIndex = 0;
            // 
            // cmb_garaza
            // 
            this.cmb_garaza.FormattingEnabled = true;
            this.cmb_garaza.Location = new System.Drawing.Point(326, 32);
            this.cmb_garaza.Name = "cmb_garaza";
            this.cmb_garaza.Size = new System.Drawing.Size(121, 21);
            this.cmb_garaza.TabIndex = 1;
            // 
            // txt_tablica
            // 
            this.txt_tablica.Location = new System.Drawing.Point(453, 32);
            this.txt_tablica.Name = "txt_tablica";
            this.txt_tablica.Size = new System.Drawing.Size(100, 20);
            this.txt_tablica.TabIndex = 2;
            // 
            // cmb_ui
            // 
            this.cmb_ui.FormattingEnabled = true;
            this.cmb_ui.Items.AddRange(new object[] {
            "Ulaz",
            "Izlaz"});
            this.cmb_ui.Location = new System.Drawing.Point(559, 31);
            this.cmb_ui.Name = "cmb_ui";
            this.cmb_ui.Size = new System.Drawing.Size(121, 21);
            this.cmb_ui.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txt_sati
            // 
            this.txt_sati.Location = new System.Drawing.Point(252, 32);
            this.txt_sati.Name = "txt_sati";
            this.txt_sati.Size = new System.Drawing.Size(31, 20);
            this.txt_sati.TabIndex = 5;
            // 
            // txt_minuti
            // 
            this.txt_minuti.Location = new System.Drawing.Point(289, 32);
            this.txt_minuti.Name = "txt_minuti";
            this.txt_minuti.Size = new System.Drawing.Size(31, 20);
            this.txt_minuti.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vreme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Garaza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tablice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ulaz/Izlaz";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(686, 29);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 13;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 293);
            this.dataGridView1.TabIndex = 14;
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Location = new System.Drawing.Point(16, 368);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(0, 13);
            this.lbl_err.TabIndex = 15;
            // 
            // Promet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 385);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_minuti);
            this.Controls.Add(this.txt_sati);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_ui);
            this.Controls.Add(this.txt_tablica);
            this.Controls.Add(this.cmb_garaza);
            this.Controls.Add(this.txt_id);
            this.Name = "Promet";
            this.Text = "Promet";
            this.Load += new System.EventHandler(this.Promet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cmb_garaza;
        private System.Windows.Forms.TextBox txt_tablica;
        private System.Windows.Forms.ComboBox cmb_ui;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_sati;
        private System.Windows.Forms.TextBox txt_minuti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_err;
    }
}