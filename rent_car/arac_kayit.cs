using System.Data.SqlClient;

namespace rent_car
{
    public partial class arac_kayit : Form
    {
        arac_kiralama arackira = new arac_kiralama();
        public arac_kayit()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                combo_seri.Items.Clear();
                if (combo_marka.SelectedIndex == 0)
                {
                    combo_seri.Items.Add("Astra");
                    combo_seri.Items.Add("Vectra");
                    combo_seri.Items.Add("Corsa");

                }
                else if (combo_marka.SelectedIndex == 1)
                {
                    combo_seri.Items.Add("Clio");
                    combo_seri.Items.Add("Megane");
                }
                else if (combo_marka.SelectedIndex == 2)
                {
                    combo_seri.Items.Add("Linea");
                    combo_seri.Items.Add("Egea");

                }
                else if (combo_marka.SelectedIndex == 3)
                {
                    combo_seri.Items.Add("Fiesta");
                    combo_seri.Items.Add("Focus");

                }
            }
            catch
            {
                throw;
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            string cumle = "insert into arac(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txt_plaka.Text);
            komut2.Parameters.AddWithValue("@marka", combo_marka.Text);
            komut2.Parameters.AddWithValue("@seri", combo_seri.Text);
            komut2.Parameters.AddWithValue("@yil", txt_model.Text);
            komut2.Parameters.AddWithValue("@renk", txt_renk.Text);
            komut2.Parameters.AddWithValue("@km", txt_km.Text);
            komut2.Parameters.AddWithValue("@yakit", combo_yakit.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", txt_kira_ucret.Text);
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");

            arackira.ekle_sil_guncelle(komut2, cumle);
            combo_seri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }
    }
}
