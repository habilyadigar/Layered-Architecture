using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySatis
    {
        private int satisid;
        private int urun;
        private int personel;
        private decimal fiyat;
        private int musteri;
        private string musteriad;
        private string musterisoyad;
        private string urunad;
        private string personelad;
        private string personelsoyad;

        public int Satisid { get => satisid; set => satisid = value; }
        public int Urun { get => urun; set => urun = value; }
        public int Personel { get => personel; set => personel = value; }
        public decimal Fiyat { get => fiyat; set => fiyat = value; }
        public int Musteri { get => musteri; set => musteri = value; }
        public string Musteriad { get => musteriad; set => musteriad = value; }
        public string Musterisoyad { get => musterisoyad; set => musterisoyad = value; }
        public string Urunad { get => urunad; set => urunad = value; }
        public string Personelad { get => personelad; set => personelad = value; }
        public string Personelsoyad { get => personelsoyad; set => personelsoyad = value; }
    }
}
