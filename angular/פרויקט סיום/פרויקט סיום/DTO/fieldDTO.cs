using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Models;

namespace DTO
{
    class fieldDTO
    {
        public int id { get; set; }
        public string fieldName { get; set; }
        public string discribe { get; set; }

        public static fieldDTO convertToDTO(fields f)
        {
            return new fieldDTO()
            {
                id = f.id,
                fieldName = f.fieldName,
                discribe = f.discribe
            };
        }
        
        public static List<fieldDTO> convertToList(List<fields> f)
        {
            var s = from x in f
                    select new fieldDTO()
                    {
                        id = x.id,
                        fieldName = x.fieldName,
                        discribe = x.discribe
                    };
            return s.ToList();
        }

        public static fields convertToDB(fieldDTO f)
        {
            return new fields()
            {
                id = f.id,
                fieldName = f.fieldName,
                discribe = f.discribe
            };
        }
    }


   
}
