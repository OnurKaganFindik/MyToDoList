using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Data
{
   public class Not: IComparable
    {
        public Not()
        {

        }
        public Not(string metin)
        {
            Metin = metin;
        }
        public string Metin { get; set; }
        public DateTime Zaman { get; set; } = DateTime.Now;
        public bool YildizliMi { get; set; }
        public int CompareTo(object diger)
        {
            Not digerNot = (Not)diger;
            return -Zaman.CompareTo(digerNot.Zaman);
        }
        public override string ToString()
        {
            string yildiz=YildizliMi? "★" : "☆";
            string tarih = Zaman.Date == DateTime.Now.Date ? Zaman.ToString("HH:mm") : Zaman.ToString("dd.MM.yyyy HH:mm");

            return $"{yildiz} [{tarih}] {Metin}";
        }
    }
}
