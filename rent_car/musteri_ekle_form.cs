using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_car
{
    public partial class musteri_ekle_form : Form
    {

        arac_kiralama Arac_kiralama = new arac_kiralama();

        public musteri_ekle_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into musteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txt_tc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txt_ad_soyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            komut2.Parameters.AddWithValue("@adres", txt_adres.Text);
            komut2.Parameters.AddWithValue("@email", txt_email.Text);
            Arac_kiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void musteri_ekle_form_Load(object sender, EventArgs e)
        {

        }
    }
}
