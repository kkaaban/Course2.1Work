using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesBLL
{
    public class EntityClient_sRoomBLL
    {
        public EntityClient_sRoomBLL(EntityRoomBLL room, DateTime from, DateTime to)
        {
            Room = room;
            DateFrom = from;
            DateTo = to;
        }
        public EntityRoomBLL Room { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
