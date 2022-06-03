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
    public partial class arac_listele : Form
    {
        arac_kiralama arackira = new arac_kiralama();
        public arac_listele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt_plaka.Text = satir.Cells["plaka"].Value.ToString();
           combo_marka.Text = satir.Cells["marka"].Value.ToString();
            combo_seri.Text = satir.Cells["seri"].Value.ToString();
            txt_renk.Text = satir.Cells["renk"].Value.ToString();
            txt_km.Text = satir.Cells["km"].Value.ToString();
            txt_kira_ucret.Text = satir.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation = satir.Cells["resim"].Value.ToString();
            combo_yakit.Text = satir.Cells["yakit"].Value.ToString();
        }

        private void arac_listele_Load(object sender, EventArgs e)
        {
            Yenile_Araclar_Listesi();
        }

        private void Yenile_Araclar_Listesi()
        {
            string cumle = "select * from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            arackira.listele(adtr2, cumle);
        }
    }
}
