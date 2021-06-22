using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Models;
using DTO;
namespace UI
{
    public class Class1
    {
       static  timeBankDBEntities db = new timeBankDBEntities();
        static List<newColleagues> l = db.newColleagues.ToList();

       public static  List<colleaguesDTO> getcolleagues()
        {
            return DTO.colleaguesDTO.convertToList(l).ToList();
        }

        public static bool isExist(string password, string name)
        {
            var x = db.newColleagues
                .Where(m => m.password == password && m.name == name).FirstOrDefault();
            if (x != null)
              return  true;
            else
              return false;
                    
        }

        //public static addColleagues(newColleagues c)
        //{
        //    db.newColleagues.Add(c);
        //    db.SaveChanges();
        //}




    }
}
