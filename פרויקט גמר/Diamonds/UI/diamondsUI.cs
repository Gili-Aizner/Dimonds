using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;

namespace UI
{
    public class DiamondsUI
    {
        static DiampndsDBEntities db = new DiampndsDBEntities();
       public static int getIdByName(string name)
        {
            int id = db.Diamonds.Where(x => x.diamondName == name)
                      .Select(y => y.diamondId).FirstOrDefault();
            return id;
        }

    }
}
