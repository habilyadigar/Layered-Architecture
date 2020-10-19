using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace BusniesLogicLayer
{
    public class BLLUrun
    {
        public static List<EntityUrun> BLLUrunListesi()
        {
            return DALUrun.UrunListesi();
        }
        public static int BLLUrunEkle(EntityUrun m)
        {
            if (m.Urunad != "" && m.Urunfiyat != 0 & m.Urunadet != 0 )
            {
                return DALUrun.UrunEkle(m);
            }
            else
            {
                return -1;
            }

        }

    }
}
