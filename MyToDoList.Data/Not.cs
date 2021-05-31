using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Data
{
   public class Not
    {
        public string Metin { get; set; }
        public DateTime Zaman { get; set; } = DateTime.Now;
        public bool YildizliMi { get; set; }
        public override string ToString()
        {
            return $"{Metin} ({Zaman:HH:mm})";
        }
    }
}
