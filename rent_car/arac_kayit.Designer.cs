namespace rent_car
{
    partial class arac_kayit
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
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.combo_marka = new System.Windows.Forms.ComboBox();
            this.combo_seri = new System.Windows.Forms.ComboBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_renk = new System.Windows.Forms.TextBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.combo_yakit = new System.Windows.Forms.ComboBox();
            this.txt_kira_ucret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_resim_ekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(125, 34);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(162, 27);
            this.txt_plaka.TabIndex = 0;
            // 
            // combo_marka
            // 
            this.combo_marka.FormattingEnabled = true;
            this.combo_marka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.combo_marka.Location = new System.Drawing.Point(125, 71);
            this.combo_marka.Name = "combo_marka";
            this.combo_marka.Size = new System.Drawing.Size(162, 28);
            this.combo_marka.TabIndex = 1;
            this.combo_marka.SelectedIndexChanged += new System.EventHandler(this.combo_marka_SelectedIndexChanged);
            // 
            // combo_seri
            // 
            this.combo_seri.FormattingEnabled = true;
            this.combo_seri.Location = new System.Drawing.Point(125, 108);
            this.combo_seri.Name = "combo_seri";
            this.combo_seri.Size = new System.Drawing.Size(162, 28);
            this.combo_seri.TabIndex = 2;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(125, 145);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(162, 27);
            this.txt_model.TabIndex = 3;
            // 
            // txt_renk
            // 
            this.txt_renk.Location = new System.Drawing.Point(125, 182);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(162, 27);
            this.txt_renk.TabIndex = 4;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(125, 219);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(162, 27);
            this.txt_km.TabIndex = 5;
            // 
            // combo_yakit
            // 
            this.combo_yakit.FormattingEnabled = true;
            this.combo_yakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin + LPG"});
            this.combo_yakit.Location = new System.Drawing.Point(125, 256);
            this.combo_yakit.Name = "combo_yakit";
            this.combo_yakit.Size = new System.Drawing.Size(162, 28);
            this.combo_yakit.TabIndex = 6;
            // 
            // txt_kira_ucret
            // 
            this.txt_kira_ucret.Location = new System.Drawing.Point(125, 293);
            this.txt_kira_ucret.Name = "txt_kira_ucret";
            this.txt_kira_ucret.Size = new System.Drawing.Size(162, 27);
            this.txt_kira_ucret.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kira Ücreti";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(49, 344);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(103, 47);
            this.btn_kayit.TabIndex = 17;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(184, 344);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(103, 47);
            this.btn_iptal.TabIndex = 18;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_resim_ekle
            // 
            this.btn_resim_ekle.Location = new System.Drawing.Point(381, 279);
            this.btn_resim_ekle.Name = "btn_resim_ekle";
            this.btn_resim_ekle.Size = new System.Drawing.Size(132, 41);
            this.btn_resim_ekle.TabIndex = 19;
            this.btn_resim_ekle.Text = "Resim Ekle";
            this.btn_resim_ekle.UseVisualStyleBackColor = true;
            this.btn_resim_ekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // arac_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btn_resim_ekle);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kayit);
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
            this.Name = "arac_kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_plaka;
        private ComboBox combo_marka;
        private ComboBox combo_seri;
        private TextBox txt_model;
        private TextBox txt_renk;
        private TextBox txt_km;
        private ComboBox combo_yakit;
        private TextBox txt_kira_ucret;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btn_kayit;
        private Button btn_iptal;
        private Button btn_resim_ekle;
        private OpenFileDialog openFileDialog1;
    }
}