using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;

namespace UI
{
    public class diamondsStatusUI
    {
        static DiampndsDBEntities db =new DiampndsDBEntities();
        public static DiamondStatusDTO getDiamondOfEndingStatus(int professionalId, string diamondName, DateTime date)
        {
            int diamondId= UI.DiamondsUI.getIdByName(diamondName);
            List<diamondStatus> ds = db.diamondStatus.Where(x => (x.diamondId == diamondId && x.professionalId == professionalId)).ToList();
            diamondStatus ds1=ds.Where(x => x.endDate == null).FirstOrDefault();
            ds1.endDate = date;
            DiamondStatusDTO dsDTO=DiamondStatusDTO.convertToDTO(ds1);
            ds1.price = (UI.professionalesUI.getPriceOfProfessional(professionalId))*;

            return dsDTO;
        }
    }
}
