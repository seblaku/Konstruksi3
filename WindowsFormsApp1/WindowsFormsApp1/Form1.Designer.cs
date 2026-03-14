namespace WindowsFormsApp1
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
            this.comboSatuanAwal = new System.Windows.Forms.ComboBox();
            this.comboSatuanAkhir = new System.Windows.Forms.ComboBox();
            this.textNilaiAwal = new System.Windows.Forms.TextBox();
            this.textHasil = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSatuanAwal
            // 
            this.comboSatuanAwal.FormattingEnabled = true;
            this.comboSatuanAwal.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.comboSatuanAwal.Location = new System.Drawing.Point(49, 43);
            this.comboSatuanAwal.Name = "comboSatuanAwal";
            this.comboSatuanAwal.Size = new System.Drawing.Size(121, 24);
            this.comboSatuanAwal.TabIndex = 0;
            // 
            // comboSatuanAkhir
            // 
            this.comboSatuanAkhir.FormattingEnabled = true;
            this.comboSatuanAkhir.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.comboSatuanAkhir.Location = new System.Drawing.Point(49, 131);
            this.comboSatuanAkhir.Name = "comboSatuanAkhir";
            this.comboSatuanAkhir.Size = new System.Drawing.Size(121, 24);
            this.comboSatuanAkhir.TabIndex = 1;
            // 
            // textNilaiAwal
            // 
            this.textNilaiAwal.Location = new System.Drawing.Point(262, 45);
            this.textNilaiAwal.Name = "textNilaiAwal";
            this.textNilaiAwal.Size = new System.Drawing.Size(100, 22);
            this.textNilaiAwal.TabIndex = 2;
            // 
            // textHasil
            // 
            this.textHasil.Location = new System.Drawing.Point(262, 133);
            this.textHasil.Name = "textHasil";
            this.textHasil.ReadOnly = true;
            this.textHasil.Size = new System.Drawing.Size(100, 22);
            this.textHasil.TabIndex = 3;
            this.textHasil.Tag = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(420, 59);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Satuan Awal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Satuan Akhir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nilai Awal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai Akhir";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textHasil);
            this.Controls.Add(this.textNilaiAwal);
            this.Controls.Add(this.comboSatuanAkhir);
            this.Controls.Add(this.comboSatuanAwal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSatuanAwal;
        private System.Windows.Forms.ComboBox comboSatuanAkhir;
        private System.Windows.Forms.TextBox textNilaiAwal;
        private System.Windows.Forms.TextBox textHasil;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

