using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusniesLogicLayer
{
    public class BLLMusteri
    {
        public static List<EntityMusteri> BLLMusteriListesi()
        {

            return DALMusteri.MusteriListesi();
        }
        public static int BLLMusteriEkle(EntityMusteri m)
        {
            if (m.Musteriad != "" && m.Musterisoyad !="" & m.Musteriad.Length <= 50 & m.Musterisoyad.Length <= 50)
            {
                return DALMusteri.MusteriEkle(m);
            }
            else
            {
                return -1;
            }

        }
        public static bool BLLMusteriSil(int par)
        {
            if (par != null)
            {
                return DALMusteri.MusteriSil(par);
            }
            return false;
        }
        public static List<EntityMusteri> BLLMusteriGetir(int p)
        {

            return DALMusteri.MusteriGetir(p);
        }
        public static bool BLLMusteriGuncelle(EntityMusteri p)
        {
            if (p.Musteriad !="" & p.Musterisoyad != "")
            {
                return DALMusteri.MusteriGuncelle(p);
            }                        
            return false;           
        }


    }
}
