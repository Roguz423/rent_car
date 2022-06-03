namespace rent_car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri_ekle_form ekle= new musteri_ekle_form();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri_listele musteri_Listele = new musteri_listele();
            musteri_Listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arac_kayit arac_Kayit = new arac_kayit();
            arac_Kayit.ShowDialog(); 
        }
    }
}