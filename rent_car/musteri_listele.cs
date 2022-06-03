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
    public partial class musteri_listele : Form
    {
        arac_kiralama arackiralama = new arac_kiralama();
        public musteri_listele()
        {
            InitializeComponent();
        }

        private void musteri_listele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
        public void YenileListele()
        {

            string cumle = "select * from musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAIL";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string cumle = "select * from musteri where tc like '%"+textBox1.Text+"%' ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update musteri set adsoyad= @adsoyad,telefon= @telefon, adres= @adres, email= @email where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txt_tc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txt_ad_soyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            komut2.Parameters.AddWithValue("@adres", txt_adres.Text);
            komut2.Parameters.AddWithValue("@email", txt_email.Text);
            arackiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt_tc.Text = satir.Cells[0].Value.ToString();
            txt_ad_soyad.Text = satir.Cells[1].Value.ToString();
            txt_telefon.Text = satir.Cells[2].Value.ToString();
            txt_adres.Text = satir.Cells[3].Value.ToString();
            txt_email.Text = satir.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cumle = "delete from musteri where tc= '" + satır.Cells["tc"].Value.ToString()+ "' ";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(komut2, cumle);
            
            YenileListele();
        }
    }
}
