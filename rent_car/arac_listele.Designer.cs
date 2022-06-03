namespace rent_car
{
    partial class arac_listele
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
            this.combo_araclar = new System.Windows.Forms.ComboBox();
            this.btn_resim_ekle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kira_ucret = new System.Windows.Forms.TextBox();
            this.combo_yakit = new System.Windows.Forms.ComboBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_renk = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.combo_seri = new System.Windows.Forms.ComboBox();
            this.combo_marka = new System.Windows.Forms.ComboBox();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(512, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // combo_araclar
            // 
            this.combo_araclar.FormattingEnabled = true;
            this.combo_araclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.combo_araclar.Location = new System.Drawing.Point(912, 12);
            this.combo_araclar.Name = "combo_araclar";
            this.combo_araclar.Size = new System.Drawing.Size(151, 28);
            this.combo_araclar.TabIndex = 1;
            // 
            // btn_resim_ekle
            // 
            this.btn_resim_ekle.Location = new System.Drawing.Point(369, 293);
            this.btn_resim_ekle.Name = "btn_resim_ekle";
            this.btn_resim_ekle.Size = new System.Drawing.Size(132, 41);
            this.btn_resim_ekle.TabIndex = 39;
            this.btn_resim_ekle.Text = "Resim Ekle";
            this.btn_resim_ekle.UseVisualStyleBackColor = true;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(172, 358);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(103, 47);
            this.btn_iptal.TabIndex = 38;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(37, 358);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(103, 47);
            this.btn_guncelle.TabIndex = 37;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(328, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 224);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Plaka";
            // 
            // txt_kira_ucret
            // 
            this.txt_kira_ucret.Location = new System.Drawing.Point(113, 307);
            this.txt_kira_ucret.Name = "txt_kira_ucret";
            this.txt_kira_ucret.Size = new System.Drawing.Size(162, 27);
            this.txt_kira_ucret.TabIndex = 27;
            // 
            // combo_yakit
            // 
            this.combo_yakit.FormattingEnabled = true;
            this.combo_yakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin + LPG"});
            this.combo_yakit.Location = new System.Drawing.Point(113, 270);
            this.combo_yakit.Name = "combo_yakit";
            this.combo_yakit.Size = new System.Drawing.Size(162, 28);
            this.combo_yakit.TabIndex = 26;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(113, 233);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(162, 27);
            this.txt_km.TabIndex = 25;
            // 
            // txt_renk
            // 
            this.txt_renk.Location = new System.Drawing.Point(113, 196);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(162, 27);
            this.txt_renk.TabIndex = 24;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(113, 159);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(162, 27);
            this.txt_model.TabIndex = 23;
            // 
            // combo_seri
            // 
            this.combo_seri.FormattingEnabled = true;
            this.combo_seri.Location = new System.Drawing.Point(113, 122);
            this.combo_seri.Name = "combo_seri";
            this.combo_seri.Size = new System.Drawing.Size(162, 28);
            this.combo_seri.TabIndex = 22;
            // 
            // combo_marka
            // 
            this.combo_marka.FormattingEnabled = true;
            this.combo_marka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.combo_marka.Location = new System.Drawing.Point(113, 85);
            this.combo_marka.Name = "combo_marka";
            this.combo_marka.Size = new System.Drawing.Size(162, 28);
            this.combo_marka.TabIndex = 21;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(113, 48);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(162, 27);
            this.txt_plaka.TabIndex = 20;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(960, 358);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(103, 47);
            this.btn_sil.TabIndex = 40;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(551, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 163);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // arac_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1075, 516);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_resim_ekle);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kira_ucret);
            this.Controls.Add(this.combo_yakit);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.txt_renk);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.combo_seri);
            this.Controls.Add(this.combo_marka);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.combo_araclar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "arac_listele";
            this.Text = "Araç Listeleme";
            this.Load += new System.EventHandler(this.arac_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox combo_araclar;
        private Button btn_resim_ekle;
        private Button btn_iptal;
        private Button btn_guncelle;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_kira_ucret;
        private ComboBox combo_yakit;
        private TextBox txt_km;
        private TextBox txt_renk;
        private TextBox txt_model;
        private ComboBox combo_seri;
        private ComboBox combo_marka;
        private TextBox txt_plaka;
        private Button btn_sil;
        private PictureBox pictureBox2;
    }
}