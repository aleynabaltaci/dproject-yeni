namespace dproject_yeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dbprojeContext _db = new dbprojeContext();
            Araba araba = new Araba() { MarkaAd� = txtmarkaad�.Text,ModelAd�=txtModelAd�.Text,KasaTipi=txtKasaTipi.Text,ModelY�l�=Convert.ToInt32(txtModelY�l�.Text),VitesTipi=txtVitesTipi.Text };
            _db.Add(araba);
            _db.SaveChanges();

            List<Araba> arabalistesi=_db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi; // veritaban�yla  datagridviewi birbirine ba�lar.
            dataGridView1.Refresh();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dbprojeContext _db = new dbprojeContext();
            List<Araba> arabalistesi = _db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi; // veritaban�yla  datagridviewi birbirine ba�lar.
            dataGridView1.Refresh();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dbprojeContext _db = new dbprojeContext();
            int ID=Convert.ToInt32(txtID.Text);
            var se�iliaraba=_db.Arabalar.FirstOrDefault(a=>a.ArabaID==ID);
            if (se�iliaraba!=null)
            {
                _db.Remove(se�iliaraba);
                _db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ara� bulunamad�.");
            }

            List<Araba> arabalistesi = _db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi; // veritaban�yla  datagridviewi birbirine ba�lar.
            dataGridView1.Refresh();
            //entity,sqlserver,tools indirdik. PAcket manager k�sm�ndan add-migration bir ve update-database yapt�k. eskisini silmek i�in drop-database ��kan ekrana a.


        }
    }


    
}