using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;

namespace UI
{
    public class usersUI
    {
        static DiampndsDBEntities db = new DiampndsDBEntities();

        public static string exsistNameAndPassword(string enterName,string password)
        {
            string type;
            users u = db.users.Where(x => (x.password == password && x.entringName == enterName)).FirstOrDefault();
            if (u != null)
            {
                if (db.professionales.Where(x => (x.professionalId == u.userId)).FirstOrDefault() != null)
                    type = "professional";
                else
                    type = "trader";
                return type;
            }
            return null;
        }
        public static void addTrader(UsersDTO u)
        {
           users newU= DTO.UsersDTO.convertToDB(u);
            db.users.Add(newU);
        }
        public static void addProfessional(UsersDTO u,ProfessionalesDTO p)
        {
            professionales newp = DTO.ProfessionalesDTO.convertToDB(p);
            users newU = DTO.UsersDTO.convertToDB(u);
            db.users.Add(newU);
            db.professionales.Add(newp);
        }


    }
}
