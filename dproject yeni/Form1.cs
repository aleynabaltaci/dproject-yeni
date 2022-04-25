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
            Araba araba = new Araba() { MarkaAdý = txtmarkaadý.Text,ModelAdý=txtModelAdý.Text,KasaTipi=txtKasaTipi.Text,ModelYýlý=Convert.ToInt32(txtModelYýlý.Text),VitesTipi=txtVitesTipi.Text };
            _db.Add(araba);
            _db.SaveChanges();

            List<Araba> arabalistesi=_db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi; // veritabanýyla  datagridviewi birbirine baðlar.
            dataGridView1.Refresh();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dbprojeContext _db = new dbprojeContext();
            List<Araba> arabalistesi = _db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi; // veritabanýyla  datagridviewi birbirine baðlar.
            dataGridView1.Refresh();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dbprojeContext _db = new dbprojeContext();
            int ID=Convert.ToInt32(txtID.Text);
            var seçiliaraba=_db.Arabalar.FirstOrDefault(a=>a.ArabaID==ID);
            if (seçiliaraba!=null)
            {
                _db.Remove(seçiliaraba);
                _db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Araç bulunamadý.");
            }

            List<Araba> arabalistesi = _db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi; // veritabanýyla  datagridviewi birbirine baðlar.
            dataGridView1.Refresh();
            //entity,sqlserver,tools indirdik. PAcket manager kýsmýndan add-migration bir ve update-database yaptýk. eskisini silmek için drop-database çýkan ekrana a.


        }
    }


    
}