using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DTO
{
     public class DiamondStatusDTO
    {
        public int diamondStatusId { get; set; }
        public Nullable<int> statusId { get; set; }
        public Nullable<int> diamondId { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<int> professionalId { get; set; }
        public Nullable<int> price { get; set; }

        public static DiamondStatusDTO convertToDTO(diamondStatus ds)
        {
            return new DiamondStatusDTO()
            {
                diamondStatusId = ds.diamondStatusId,
                statusId = ds.statusId,
                diamondId = ds.diamondId,
                startDate = ds.startDate,
                endDate = ds.endDate,
                professionalId = ds.professionalId,
                price = ds.price
            };
        }
        public static List<DiamondStatusDTO> convertToListDTO(List<diamondStatus> lds)
        {
            var v = from x in lds
                    select new DiamondStatusDTO()
                    {
                        diamondStatusId = x.diamondStatusId,
                        statusId = x.statusId,
                        diamondId = x.diamondId,
                        startDate = x.startDate,
                        endDate = x.endDate,
                        professionalId = x.professionalId,
                        price = x.price
                    };
            return v.ToList();
        }
        public static diamondStatus convertToDB(DiamondStatusDTO ds)
        {
            return new diamondStatus()
            {
                diamondStatusId = ds.diamondStatusId,
                statusId = ds.statusId,
                diamondId = ds.diamondId,
                startDate = ds.startDate,
                endDate = ds.endDate,
                professionalId = ds.professionalId,
                price = ds.price
            };
        }
    }
}
