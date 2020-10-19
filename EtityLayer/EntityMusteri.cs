using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityMusteri
   {
        private int musteriid;
        private string musteriad;
        private string musterisoyad;

        public int Musteriid { get => musteriid; set => musteriid = value; }
        public string Musteriad { get => musteriad; set => musteriad = value; }
        public string Musterisoyad { get => musterisoyad; set => musterisoyad = value; }
   }
}
