using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DTO
{
     public class ProfessionalesDTO
    {
        public int professionalId { get; set; }
        public Nullable<int> statusId { get; set; }
        public Nullable<int> price { get; set; }

        static DiampndsDBEntities db = new DiampndsDBEntities();
        public static ProfessionalesDTO convertToDTO(professionales pr)
        {
            return new ProfessionalesDTO()
            {
                professionalId =pr.professionalId,
                statusId = pr.statusId,
                price = pr.price
            };
        }
        public static List<ProfessionalesDTO> convertToListDTO(List<professionales> lpr)
        {
            var v = from x in lpr
                    select new ProfessionalesDTO()
                    {
                        professionalId = x.professionalId,
                        statusId =x.statusId,
                        price = x.price
                    };
            return v.ToList();
        }
        public static  professionales convertToDB(ProfessionalesDTO pr)
        {
            return new professionales()
            {
                professionalId =pr.professionalId,
                statusId = pr.statusId,
                price = pr.price
            };
        }
    }
}
