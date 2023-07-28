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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
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

            dad = new SqlDataAdapter("Select * from musteri", bag);

            dad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Bagla();

            gridDoldur();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        void bosalt()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            pictureBox1.ImageLocation = "";
        }

        string exeyolu;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //exeyolu1= System.Reflection.Assembly.GetEntryAssembly().Location;
            exeyolu = Application.StartupPath;
            pictureBox1.ImageLocation=exeyolu+"\\res\\"+ dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        void modDuzenleme()
        {
            btnYeni.Enabled = false;
            btnDuzenle.Enabled = false;
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnIptal.Enabled = true;

            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtTelefon.Enabled = true;
            pictureBox1.Enabled = true;
        }

        void modGezinti()
        {
            btnYeni.Enabled = true;
            btnDuzenle.Enabled = true;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true;
            btnIptal.Enabled = false;

            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtTelefon.Enabled = false;
            pictureBox1.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            modGezinti();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            islem = "düzenle";
            modDuzenleme();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            islem = "yeni";
            bosalt();
            modDuzenleme();
        }
        string islem;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bagla();
            SqlCommand cmd = new SqlCommand();

            if (islem == "yeni")
            {
                cmd = new SqlCommand("insert into musteri (musAd,MusSoyad,musTel,musFoto) values(@ad,@soyad,@telefon,@foto)", bag);
            }
            else if (islem == "düzenle")
            {
                cmd = new SqlCommand("update musteri set musAd=@ad, musSoyad=@soyad,musTel=@telefon,musFoto=@foto where musId=@id", bag);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            }
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@foto", openFileDialog1.SafeFileName);
            cmd.ExecuteNonQuery();

            gridDoldur();
            bag.Close();

            modGezinti();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            modGezinti();
            DialogResult secim = MessageBox.Show("Kayıt Silinecek. Emin Misiniz?", "UYARI!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (secim==DialogResult.Yes) {
                Bagla();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("delete from musteri where musId=@id", bag);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                gridDoldur();
                bag.Close();
            }
        }

        private void frmMusteri_FormClosed(object sender, FormClosedEventArgs e)
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
