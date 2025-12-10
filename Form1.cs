using System;
using System.Linq;
using System.Windows.Forms;

namespace mlTranslator
{
    public partial class Form1 : Form
    {
        private CeviriServisi _ceviriServisi;

        public Form1()
        {
            InitializeComponent();
            _ceviriServisi = new CeviriServisi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dilleri ekle (API'nin kabul ettiği kodlar: tr, en, de, fr, es, it, ru)
            cmbKaynak.Items.Add(new Dil("Türkçe", "tr"));
            cmbKaynak.Items.Add(new Dil("İngilizce", "en"));
            cmbKaynak.Items.Add(new Dil("Almanca", "de"));
            cmbKaynak.Items.Add(new Dil("Fransızca", "fr"));
            cmbKaynak.Items.Add(new Dil("İtalyanca", "it"));
            cmbKaynak.Items.Add(new Dil("İspanyolca", "es"));
            cmbKaynak.Items.Add(new Dil("Rusça", "ru"));

            // Kaynak dillerin aynısını hedef dile kopyala
            cmbHedef.Items.AddRange(cmbKaynak.Items.Cast<object>().ToArray());

            // Varsayılan seçimler
            cmbKaynak.SelectedIndex = 0; // Türkçe
            cmbHedef.SelectedIndex = 1;  // İngilizce
        }

        private async void btnCevir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiris.Text))
            {
                MessageBox.Show("Lütfen çevrilecek bir metin giriniz.");
                return;
            }

            // Seçilen dilleri al
            Dil kaynak = (Dil)cmbKaynak.SelectedItem;
            Dil hedef = (Dil)cmbHedef.SelectedItem;

            try
            {
                // Görsel geri bildirim
                btnCevir.Text = "Çevriliyor...";
                btnCevir.Enabled = false;

                // Servisi çağır
                string sonuc = await _ceviriServisi.Cevir(txtGiris.Text, kaynak.Kod, hedef.Kod);

                txtSonuc.Text = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // İşlem bitince butonu eski haline getir
                btnCevir.Text = "ÇEVİR";
                btnCevir.Enabled = true;
            }
        }
    }

    // ComboBox için yardımcı sınıf
    public class Dil
    {
        public string Ad { get; set; }
        public string Kod { get; set; }

        public Dil(string ad, string kod)
        {
            Ad = ad;
            Kod = kod;
        }

        public override string ToString()
        {
            return Ad;
        }
    }
}