using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Models;
namespace DTO
{
    public class colleaguesDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phon { get; set; }
        public Nullable<int> areaId { get; set; }
        public Nullable<int> fieldId { get; set; }
        public Nullable<int> numHours { get; set; }
        public static colleaguesDTO convertToDTO(newColleagues c)
        {
            return new colleaguesDTO()
            {
                id = c.id,
                name = c.name,
                password = c.password,
                address = c.address,
                phon = c.phon,
                areaId = c.areaId,
                fieldId = c.fieldId,
                numHours = c.numHours

            };
        }

        public static List<colleaguesDTO> convertToList(List<newColleagues> c)
        {
            var s = from x in c
                    select new colleaguesDTO
                    {
                        id = x.id,
                        name = x.name,
                        password = x.password,
                        address = x.address,
                        phon = x.phon,
                        areaId = x.areaId,
                        fieldId = x.fieldId,
                        numHours = x.numHours
                    };
            return s.ToList();
        }
        public static newColleagues convertToDB(colleaguesDTO c)
        {
            return new newColleagues()
            {
                id = c.id,
                name = c.name,
                password = c.password,
                address = c.address,
                phon = c.phon,
                areaId = c.areaId,
                fieldId = c.fieldId,
                numHours = c.numHours
            };
        }
     

    }
}
