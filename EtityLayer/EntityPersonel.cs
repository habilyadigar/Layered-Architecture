using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityPersonel
    {
        private int personelid;
        private string personelad;
        private string personelsoyad;
        private byte personeldepartman;
        private decimal personelmaas;
        private string personelfotograf;
        private string personeldep;

        public int Personelid { get => personelid; set => personelid = value; }
        public string Personelad { get => personelad; set => personelad = value; }
        public string Personelsoyad { get => personelsoyad; set => personelsoyad = value; }
        public byte Personeldepartman { get => personeldepartman; set => personeldepartman = value; }
        public decimal Personelmaas { get => personelmaas; set => personelmaas = value; }
        public string Personelfotograf { get => personelfotograf; set => personelfotograf = value; }
        public string Personeldep { get => personeldep; set => personeldep = value; }
    }
}
