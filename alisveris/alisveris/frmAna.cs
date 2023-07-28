using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alisveris
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteri fur = new frmMusteri();
            fur.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUrun fmust = new frmUrun();
            fmust.Show();
            this.Hide();
        }

        private void frmAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAlisVeris fav = new frmAlisVeris();
            fav.Show();
            this.Hide();
        }
    }
}
