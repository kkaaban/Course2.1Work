using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityClients_sRoomPL
    {
        public EntityClients_sRoomPL(EntityRoomPL room, DateTime from, DateTime to)
        {
            Room = room;
            DateFrom = from;
            DateTo = to;
        }
        public EntityRoomPL Room { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
