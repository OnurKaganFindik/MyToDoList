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
    public partial class Duzenle : Form
    {
        private readonly Not _not;

        public Duzenle(Not not)
        {
            _not = not;
            InitializeComponent();
            NotuYaz();
        }
        private void NotuYaz()
        {
            txtYapilan.Text = _not.Metin;
            dtpZaman.Value = _not.Zaman;
        }

    }
}
