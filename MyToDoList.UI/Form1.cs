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
        Not not1;
        List<Not> notlar;
        public Form1()
        {
            notlar = new List<Not>();
            InitializeComponent();
            
        }

        private void Listele()
        {
            lstNotlar.DataSource = null;
            lstNotlar.DataSource = notlar;
        }

        public string NotuOku()
        {
            return txtNot.Text;
        }

       

        //private void Sirala()
        //{
        //    notlar.Sort();
        //}

       

       

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Not not = new Not();
            not.Metin = NotuOku();
            notlar.Add(not);
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            new Duzenle((Not)lstNotlar.SelectedItem).ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            notlar.Remove((Not)lstNotlar.SelectedItem);
            Listele();
        }

        private void lstNotlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                notlar.Remove((Not)lstNotlar.SelectedItem);
                Listele();
            }

        }

        private void txtNot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Not not = new Not();
                not.Metin = NotuOku();
                notlar.Add(not);
                Listele();
            }
        }
    }
}


