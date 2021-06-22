using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DTO
{
   public class DiamondsDTO
    {
        public int diamondId { get; set; }
        public string diamondName { get; set; }
        public Nullable<int> cleanLevelId { get; set; }
        public  string cleanLevelName { get; set; }
        public Nullable<int> colorId { get; set; }
        public string colorName { get; set; }
        public Nullable<int> shapeId { get; set; }
        public string shapeName { get; set; }
        public Nullable<double> CT { get; set; }
        public static DiamondsDTO convertToDTO(Diamonds d)
        {
            return new DiamondsDTO()
            {
                diamondId = d.diamondId,
                diamondName = d.diamondName,
                cleanLevelId = d.cleanLevelId,
                cleanLevelName = (d.cleanLevels != null) ? d.cleanLevels.cleanLevel : "",
                colorId = d.colorId,
                colorName = (d.colors != null) ? d.colors.color : "",
                shapeId=d.shapeId,
                shapeName=(d.shapes !=null)?d.shapes.shape : "",
                CT=d.CT
            };
        }
        public static List<DiamondsDTO> convertToListDTO(List<Diamonds> ld)
        {
            var v = from x in ld
                    select new DiamondsDTO()
                    {
                        diamondId = x.diamondId,
                        diamondName = x.diamondName,
                        cleanLevelName = (x.cleanLevels != null) ? x.cleanLevels.cleanLevel : "",
                        colorId = x.colorId,
                        colorName = (x.colors != null) ? x.colors.color : "",
                        shapeId = x.shapeId,
                        shapeName = (x.shapes != null) ?x.shapes.shape : "",
                        CT = x.CT

                    };
            return v.ToList();
        }
        public static Diamonds convertToDB(DiamondsDTO d)
        {
            return new Diamonds()
            {
                diamondId = d.diamondId,
                diamondName = d.diamondName,
                cleanLevelId = d.cleanLevelId,
                colorId = d.colorId,
                shapeId = d.shapeId,
                CT = d.CT

            };
        }


    }

}
