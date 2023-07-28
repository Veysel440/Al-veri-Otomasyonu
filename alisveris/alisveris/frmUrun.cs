using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace alisveris
{
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection();
        SqlDataAdapter dad = new SqlDataAdapter();
        DataSet ds = new DataSet();

        void Bagla()
        {
            bag.ConnectionString = "Data Source=.;Initial Catalog=ticari;Integrated Security=SSPI";
            bag.Open();
        }

        void gridDoldur()
        {

            ds.Clear();

            dad = new SqlDataAdapter("Select * from urunler", bag);

            dad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            islem = "yeni";
            bosalt();
            modDuzenleme();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            islem = "düzenle";
            modDuzenleme();
        }

        string islem;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bagla();
            SqlCommand cmd = new SqlCommand();

            if (islem == "yeni")
            {
                cmd = new SqlCommand("insert into urunler (urunAd,urunKod,urunAciklama,urunAlis) values(@ad,@kod,@aciklama,@alis)", bag);
            }
            else if (islem == "düzenle")
            {
                cmd = new SqlCommand("update urunler set urunAd=@ad, urunKod=@kod,urunAciklama=@aciklama,urunAlis=@alis where urunId=@id", bag);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            }
            cmd.Parameters.AddWithValue("@ad", txtKod.Text);
            cmd.Parameters.AddWithValue("@kod", txtAd.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@alis", Convert.ToDouble(txtAlis.Text));
            cmd.ExecuteNonQuery();

            gridDoldur();
            bag.Close();

            modGezinti();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            modGezinti();
            DialogResult secim = MessageBox.Show("Kayıt Silinecek. Emin Misiniz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes)
            {
                Bagla();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("delete from urunler where urunId=@id", bag);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                gridDoldur();
                bag.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            modGezinti();
        }

        void modDuzenleme()
        {
            btnYeni.Enabled = false;
            btnDuzenle.Enabled = false;
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnIptal.Enabled = true;

            txtKod.Enabled = true;
            txtAd.Enabled = true;
            txtAciklama.Enabled = true;
            txtAlis.Enabled = true;
            pictureBox1.Enabled = true;
        }

        void modGezinti()
        {
            btnYeni.Enabled = true;
            btnDuzenle.Enabled = true;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true;
            btnIptal.Enabled = false;

            txtKod.Enabled = false;
            txtAd.Enabled = false;
            txtAciklama.Enabled = false;
            txtAlis.Enabled = false;
            pictureBox1.Enabled = false;
        }

        void bosalt()
        {
            txtKod.Text = "";
            txtAd.Text = "";
            txtAciklama.Text = "";
            txtAlis.Text = "";
            pictureBox1.ImageLocation = "";
        }

        string exeyolu;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //exeyolu1= System.Reflection.Assembly.GetEntryAssembly().Location;
            exeyolu = Application.StartupPath;
            pictureBox1.ImageLocation = exeyolu + "\\res\\" + dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Bagla();

            gridDoldur();
        }

        private void frmUrun_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAna fana = new frmAna();
            fana.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
