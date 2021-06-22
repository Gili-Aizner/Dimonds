using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace UI
{
    public class professionalesUI
    {
        static DiampndsDBEntities db = new DiampndsDBEntities();
       public static float getPriceOfProfessional(int professionalId)
        {
           float priceOfProfessional=db.professionales.Where(x => x.professionalId == professionalId)
                .Select(y => y.price.Value).FirstOrDefault();

            return priceOfProfessional;

        }

    }
}
