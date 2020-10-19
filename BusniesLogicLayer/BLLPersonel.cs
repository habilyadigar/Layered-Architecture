using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusniesLogicLayer
{
   public class BLLPersonel
    {
        public static List<EntityPersonel> BLLPErsonelListesi()
        {

            return DALPersonel.PersonelListesi();
        }
        public static int BLLPersonelEkle(EntityPersonel m)
        {
            if (m.Personelad != "" && m.Personelsoyad != "" & m.Personeldepartman != 0)
            {
                return DALPersonel.PersonelEkle(m);
            }
            else
            {
                return -1;
            }

        }


    }
}
