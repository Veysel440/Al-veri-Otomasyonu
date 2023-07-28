namespace alisveris
{
    partial class frmUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAlis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(476, 536);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 66);
            this.button10.TabIndex = 23;
            this.button10.Text = "ÇIKIŞ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(244, 536);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 66);
            this.button8.TabIndex = 21;
            this.button8.Text = "Sonraki";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(128, 536);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 66);
            this.button7.TabIndex = 20;
            this.button7.Text = "Önceki";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(360, 536);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 66);
            this.button9.TabIndex = 22;
            this.button9.Text = "Son Kayıt";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(421, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAlis);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 186);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alış Fiyatı";
            // 
            // txtAlis
            // 
            this.txtAlis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlis.Enabled = false;
            this.txtAlis.Location = new System.Drawing.Point(87, 127);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(130, 20);
            this.txtAlis.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAciklama.Enabled = false;
            this.txtAciklama.Location = new System.Drawing.Point(87, 91);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(130, 20);
            this.txtAciklama.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün";
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(87, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(130, 20);
            this.txtAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kodu";
            // 
            // txtKod
            // 
            this.txtKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKod.Enabled = false;
            this.txtKod.Location = new System.Drawing.Point(87, 55);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(130, 20);
            this.txtKod.TabIndex = 0;
            // 
            // btnIptal
            // 
            this.btnIptal.Enabled = false;
            this.btnIptal.Location = new System.Drawing.Point(476, 203);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(116, 66);
            this.btnIptal.TabIndex = 16;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(360, 203);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 66);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunId,
            this.urunAd,
            this.urunKod,
            this.urunAciklama,
            this.urunAlis});
            this.dataGridView1.Location = new System.Drawing.Point(11, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 259);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 536);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 66);
            this.button6.TabIndex = 17;
            this.button6.Text = "İlk Kayıt";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(244, 203);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 66);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(128, 203);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(116, 66);
            this.btnDuzenle.TabIndex = 13;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(12, 203);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(116, 66);
            this.btnYeni.TabIndex = 12;
            this.btnYeni.Text = "Yeni Kayıt";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // urunId
            // 
            this.urunId.DataPropertyName = "urunId";
            this.urunId.HeaderText = "Ürün Numarası";
            this.urunId.Name = "urunId";
            this.urunId.ReadOnly = true;
            // 
            // urunAd
            // 
            this.urunAd.DataPropertyName = "urunAd";
            this.urunAd.HeaderText = "Ürün Adı";
            this.urunAd.Name = "urunAd";
            this.urunAd.ReadOnly = true;
            // 
            // urunKod
            // 
            this.urunKod.DataPropertyName = "urunKod";
            this.urunKod.HeaderText = "Ürün Kod";
            this.urunKod.Name = "urunKod";
            this.urunKod.ReadOnly = true;
            // 
            // urunAciklama
            // 
            this.urunAciklama.DataPropertyName = "urunAciklama";
            this.urunAciklama.HeaderText = "Açıklama Bilgisi";
            this.urunAciklama.Name = "urunAciklama";
            this.urunAciklama.ReadOnly = true;
            // 
            // urunAlis
            // 
            this.urunAlis.DataPropertyName = "urunAlis";
            this.urunAlis.HeaderText = "Alış Fiyatı";
            this.urunAlis.Name = "urunAlis";
            this.urunAlis.ReadOnly = true;
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 610);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeni);
            this.Name = "frmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrun_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAlis;
    }
}