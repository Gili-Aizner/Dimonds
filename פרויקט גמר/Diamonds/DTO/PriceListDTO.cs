using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DTO
{
    public class PriceListDTO
    {
        public int pricrId { get; set; }
        public Nullable<int> cleanLevelId { get; set; }
        public Nullable<int> colorId { get; set; }
        public Nullable<int> shapeId { get; set; }
        public Nullable<double> minCT { get; set; }
        public Nullable<double> maxCT { get; set; }
        public Nullable<int> price { get; set; }

        public static PriceListDTO convertToDTO(priceList p)
        {
            return new PriceListDTO()
            {
                pricrId = p.pricrId,
                cleanLevelId = p.cleanLevelId,
                colorId = p.colorId,
                shapeId = p.shapeId,
                minCT = p.minCT,
                maxCT = p.maxCT,
                price = p.price
            };
        }
        public static List<PriceListDTO> convertToListDTO(List<PriceListDTO> pl)
        {
            var v = from x in pl
                    select new PriceListDTO()
                    {
                        pricrId = x.pricrId,
                        cleanLevelId = x.cleanLevelId,
                        colorId = x.colorId,
                        shapeId = x.shapeId,
                        minCT = x.minCT,
                        maxCT = x.maxCT,
                        price = x.price
                    };
            return pl.ToList();
        }
        public static priceList convertToDB(PriceListDTO p)
        {
            return new priceList()
            {
                pricrId = p.pricrId,
                cleanLevelId = p.cleanLevelId,
                colorId = p.colorId,
                shapeId = p.shapeId,
                minCT = p.minCT,
                maxCT = p.maxCT,
                price = p.price
            };
        }
    }
}
