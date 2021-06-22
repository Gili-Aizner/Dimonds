using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Models;
namespace DTO
{
    public class areaDTO
    {
        public int id { get; set; }
        public string area { get; set; }

        public static areaDTO convertToDTO(areas a)
        {
            return new areaDTO()
            {
                id = a.id,
                area = a.area
            };
        }
        public static List<areaDTO> convertToList( List<areas> a)
        {
            var s = from x in a
                    select new areaDTO()
                    {
                        id = x.id,
                        area = x.area
                    };
            return s.ToList();
        }

        public static areas convertToDB(areaDTO a)
        {
            return new areas()
            {
                id = a.id,
                area = a.area
            };
        }
    }
}
