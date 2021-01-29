
namespace TractorAdviserExpertSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ehliyet = new System.Windows.Forms.ComboBox();
            this.KullanımAlanı = new System.Windows.Forms.ComboBox();
            this.ABS = new System.Windows.Forms.ComboBox();
            this.ÇekişKontrol = new System.Windows.Forms.ComboBox();
            this.arazi = new System.Windows.Forms.ComboBox();
            this.Bütçe = new System.Windows.Forms.TextBox();
            this.KabinYok = new System.Windows.Forms.CheckBox();
            this.Tente = new System.Windows.Forms.CheckBox();
            this.Kabinli = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sonuç = new System.Windows.Forms.TextBox();
            this.KuralGöster = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ehliyet Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(101, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanım Alanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(101, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bütçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(101, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ABS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(101, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Çift Çeker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(105, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Arazi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(101, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kabin";
            // 
            // Ehliyet
            // 
            this.Ehliyet.FormattingEnabled = true;
            this.Ehliyet.Items.AddRange(new object[] {
            "F",
            "G",
            "B",
            "A",
            "Yok"});
            this.Ehliyet.Location = new System.Drawing.Point(310, 23);
            this.Ehliyet.Name = "Ehliyet";
            this.Ehliyet.Size = new System.Drawing.Size(151, 28);
            this.Ehliyet.TabIndex = 7;
            // 
            // KullanımAlanı
            // 
            this.KullanımAlanı.FormattingEnabled = true;
            this.KullanımAlanı.Items.AddRange(new object[] {
            "Tarla",
            "Bahçe",
            "Çiftlik",
            "Yük Taşıma"});
            this.KullanımAlanı.Location = new System.Drawing.Point(310, 62);
            this.KullanımAlanı.Name = "KullanımAlanı";
            this.KullanımAlanı.Size = new System.Drawing.Size(151, 28);
            this.KullanımAlanı.TabIndex = 8;
            // 
            // ABS
            // 
            this.ABS.FormattingEnabled = true;
            this.ABS.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.ABS.Location = new System.Drawing.Point(310, 140);
            this.ABS.Name = "ABS";
            this.ABS.Size = new System.Drawing.Size(151, 28);
            this.ABS.TabIndex = 9;
            // 
            // ÇekişKontrol
            // 
            this.ÇekişKontrol.FormattingEnabled = true;
            this.ÇekişKontrol.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.ÇekişKontrol.Location = new System.Drawing.Point(310, 183);
            this.ÇekişKontrol.Name = "ÇekişKontrol";
            this.ÇekişKontrol.Size = new System.Drawing.Size(151, 28);
            this.ÇekişKontrol.TabIndex = 10;
            // 
            // arazi
            // 
            this.arazi.FormattingEnabled = true;
            this.arazi.Items.AddRange(new object[] {
            "1000 m2\' den az",
            "1000 - 20 000 m2 arası",
            "20 000 - 50 000 m2 arası",
            "50 000 - 100 000 m2 arası",
            "100 000 m2\' den çok"});
            this.arazi.Location = new System.Drawing.Point(310, 234);
            this.arazi.Name = "arazi";
            this.arazi.Size = new System.Drawing.Size(151, 28);
            this.arazi.TabIndex = 11;
            // 
            // Bütçe
            // 
            this.Bütçe.Location = new System.Drawing.Point(310, 101);
            this.Bütçe.Name = "Bütçe";
            this.Bütçe.Size = new System.Drawing.Size(151, 27);
            this.Bütçe.TabIndex = 12;
            // 
            // KabinYok
            // 
            this.KabinYok.AutoSize = true;
            this.KabinYok.BackColor = System.Drawing.Color.GreenYellow;
            this.KabinYok.Location = new System.Drawing.Point(282, 268);
            this.KabinYok.Name = "KabinYok";
            this.KabinYok.Size = new System.Drawing.Size(96, 24);
            this.KabinYok.TabIndex = 13;
            this.KabinYok.Text = "Kabin Yok";
            this.KabinYok.UseVisualStyleBackColor = false;
            // 
            // Tente
            // 
            this.Tente.AutoSize = true;
            this.Tente.BackColor = System.Drawing.Color.GreenYellow;
            this.Tente.Location = new System.Drawing.Point(421, 265);
            this.Tente.Name = "Tente";
            this.Tente.Size = new System.Drawing.Size(67, 24);
            this.Tente.TabIndex = 14;
            this.Tente.Text = "Tente";
            this.Tente.UseVisualStyleBackColor = false;
            this.Tente.CheckedChanged += new System.EventHandler(this.Tente_CheckedChanged);
            // 
            // Kabinli
            // 
            this.Kabinli.AutoSize = true;
            this.Kabinli.BackColor = System.Drawing.Color.GreenYellow;
            this.Kabinli.Location = new System.Drawing.Point(511, 265);
            this.Kabinli.Name = "Kabinli";
            this.Kabinli.Size = new System.Drawing.Size(94, 24);
            this.Kabinli.TabIndex = 15;
            this.Kabinli.Text = "Kabin Var";
            this.Kabinli.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(511, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Traktör Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sonuç
            // 
            this.sonuç.BackColor = System.Drawing.Color.GreenYellow;
            this.sonuç.Location = new System.Drawing.Point(40, 502);
            this.sonuç.Multiline = true;
            this.sonuç.Name = "sonuç";
            this.sonuç.Size = new System.Drawing.Size(421, 66);
            this.sonuç.TabIndex = 17;
            // 
            // KuralGöster
            // 
            this.KuralGöster.BackColor = System.Drawing.Color.GreenYellow;
            this.KuralGöster.Location = new System.Drawing.Point(691, 502);
            this.KuralGöster.Multiline = true;
            this.KuralGöster.Name = "KuralGöster";
            this.KuralGöster.Size = new System.Drawing.Size(421, 67);
            this.KuralGöster.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(40, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Önerilen Traktör";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(691, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kural";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 593);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KuralGöster);
            this.Controls.Add(this.sonuç);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kabinli);
            this.Controls.Add(this.Tente);
            this.Controls.Add(this.KabinYok);
            this.Controls.Add(this.Bütçe);
            this.Controls.Add(this.arazi);
            this.Controls.Add(this.ÇekişKontrol);
            this.Controls.Add(this.ABS);
            this.Controls.Add(this.KullanımAlanı);
            this.Controls.Add(this.Ehliyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Ehliyet;
        private System.Windows.Forms.ComboBox KullanımAlanı;
        private System.Windows.Forms.ComboBox ABS;
        private System.Windows.Forms.ComboBox ÇekişKontrol;
        private System.Windows.Forms.ComboBox arazi;
        private System.Windows.Forms.TextBox Bütçe;
        private System.Windows.Forms.CheckBox KabinYok;
        private System.Windows.Forms.CheckBox Tente;
        private System.Windows.Forms.CheckBox Kabinli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sonuç;
        private System.Windows.Forms.TextBox KuralGöster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

