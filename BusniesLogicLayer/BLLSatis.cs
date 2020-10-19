using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusniesLogicLayer
{
    public class BLLSatis
    {
        public static List<EntitySatis> BLLSatisListesi()
        {
            return DALSatis.SatisListesi();
        }
        public static int BLLSatisEkle(EntitySatis m)
        {
            if (m.Personel != 0 & m.Urun != 0 & m.Musteri != 0 )
            {
                return DALSatis.SatisEkle(m);
            }
            else
            {
                return -1;
            }

        }









    }
}
