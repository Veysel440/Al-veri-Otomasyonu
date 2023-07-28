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
    public partial class frmAlisVeris : Form
    {
        public frmAlisVeris()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection();
        SqlDataAdapter dadMus = new SqlDataAdapter();
        SqlDataAdapter dadSip = new SqlDataAdapter();
        SqlDataAdapter dadSipDet = new SqlDataAdapter();
        SqlDataAdapter dadUrun = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();

        void Bagla()
        {
            bag.ConnectionString = "Data Source=.;Initial Catalog=ticari;Integrated Security=SSPI;MultipleActiveResultSets=True";
            bag.Open();
        }

        void gridDoldur()
        {

            ds1.Clear();
            dadMus = new SqlDataAdapter("Select musAd,musSoyad,musTel,musFoto,musId from musteri", bag);
            dadMus.Fill(ds1);
            dataGridView4.DataSource = ds1.Tables[0];
            bag.Close();
        }

        string exeyolu;
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmusId.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            txtAd.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            txtSoyad.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            txtTelefon.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            //exeyolu1= System.Reflection.Assembly.GetEntryAssembly().Location;
            exeyolu = Application.StartupPath;
            pictureBox1.ImageLocation = exeyolu + "\\res\\" + dataGridView4.CurrentRow.Cells[3].Value.ToString();
        }

        private void frmAlisVeris_Load(object sender, EventArgs e)
        {
            Bagla();
            gridDoldur();
        }

        private void frmAlisVeris_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAna fana = new frmAna();
            fana.Show();
        }

        private void txtmusId_TextChanged(object sender, EventArgs e)
        {
            if (txtmusId.Text != "")
             {
                ds2.Clear();
                if (bag.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                int mid = Convert.ToInt32(txtmusId.Text); //Müşteri ID textboxtan alınıyor
                dadSip = new SqlDataAdapter("Select sipTarih,sipOdeme,musId,sipId from siparis where musId=" + mid + "", bag);
                dadSip.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];
                bag.Close();
            }

            if (dataGridView1.RowCount > 1)
            {
                txtsipId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                ds3.Clear();
                txtsipId.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsipId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtsipId_TextChanged(object sender, EventArgs e)
        {
            if (txtsipId.Text != "")
            {
                ds3.Clear();
                if (bag.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                int sid = Convert.ToInt32(txtsipId.Text); //Sipariş ID datagrid den alınıyor
                dadSipDet = new SqlDataAdapter("Select urunId,urunFiyat from sipDetay where sipId=" + sid + "", bag);
                dadSipDet.Fill(ds3);
                dataGridView2.DataSource = ds3.Tables[0];
                bag.Close();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if ((dateTimePicker1.Text != "") && (cbOdeme.Text != ""))
            {
                if (bag.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insert into siparis (sipTarih,sipOdeme,musId) values(@tarih,@odeme,@musid)", bag);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@odeme", cbOdeme.Text);
                cmd.Parameters.AddWithValue("@musid", txtmusId.Text);
                cmd.ExecuteNonQuery();
                bag.Close();
                txtmusId_TextChanged(sender, e);
            }
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if(bag.State == ConnectionState.Closed)
            {
                Bagla();
            }
            ds4.Clear();
            if (txtUrunAra.Text != "")
            {
                dadUrun = new SqlDataAdapter("select urunKod,urunAd,urunAciklama,urunId from urunler where urunKod like '%" + txtUrunAra.Text + "%'", bag);
            }
            else
            {
                dadUrun = new SqlDataAdapter("select urunKod,urunAd,urunAciklama,urunId from urunler", bag);
            }
            dadUrun.Fill(ds4);
            dataGridView3.DataSource = ds4.Tables[0];
            bag.Close();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrun.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            txtKod.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtAciklama.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            txtUrunId.Text= dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void tbnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtSatisFiyati.Text != "")
            {
                if (bag.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                ds4.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insert into sipDetay (sipId,urunId,urunFiyat) values(@sipid,@urunid,@urunfiyat)", bag);
                cmd.Parameters.AddWithValue("@sipid", txtsipId.Text);
                cmd.Parameters.AddWithValue("@urunid", Convert.ToInt32(txtUrunId.Text));
                cmd.Parameters.AddWithValue("@urunfiyat", Convert.ToDouble(txtSatisFiyati.Text));
                cmd.ExecuteNonQuery();
                bag.Close();
            }
            txtsipId_TextChanged(sender,e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void frmAlisVeris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnYeni_Click(sender,e);
            }
        }
    }
}
