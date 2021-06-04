using MyToDoList.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyToDoList.UI
{
    public partial class Form1 : Form
    {
        private List<Not> _notlar;
        private BindingList<Not> _blNotlar;
        public Form1()
        {
            VerileriOku();
            InitializeComponent();
            Listele();
        }
        private void VerileriOku()
        {
            _notlar = new List<Not>();
            _blNotlar = new BindingList<Not>(_notlar);
        }
        private void Listele()
        {
            lstNotlar.DataSource = _blNotlar;
        }
        public string NotuOku()
        {
            return txtNot.Text;
        }
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            var icerik = txtNot.Text;
            if (icerik == "")
            {
                MessageBox.Show("Lütfen bir mesaj giriniz");
                return;
            }
            _blNotlar.Add(new Not(icerik));
            txtNot.Clear();
        }
        private void lstNotlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                SeciliyiSil();
            }
        }
        private void SeciliyiSil()
        {
            DialogResult dr = MessageBox.Show("Seçili mesajı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Not not = (Not)lstNotlar.SelectedItem;
                _notlar.Remove(not);
            }
        }
        private void txtNot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEkle.PerformClick();
            }
        }
        private void lstNotlar_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lstNotlar.IndexFromPoint(e.Location);
            if (index > -1 && e.Button == MouseButtons.Right)
            {
                lstNotlar.SelectedIndex = index;
                Not not = (Not)lstNotlar.Items[index];
                tsmiFavori.Text = not.YildizliMi ? "Yıldızlılardan Kaldır" : "Favorilere Ekle";
                cmsNotlar.Show(Cursor.Position);
            }
        }
        private void lstNotlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indeks = lstNotlar.IndexFromPoint(e.Location);
            if (indeks > -1 && e.Button == MouseButtons.Left)
            {
                SeciliyiDuzenle();
            }
        }
        private void SeciliyiDuzenle()
        {
            if (lstNotlar.SelectedIndex > -1)
            {
                Not not = (Not)lstNotlar.SelectedItem;
                new Duzenle(not).ShowDialog();
                Listele();
            }
        }
    }
}


