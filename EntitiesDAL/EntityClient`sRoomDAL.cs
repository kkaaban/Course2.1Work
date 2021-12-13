using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDAL
{
    [DataContract]
    public class EntityClient_sRoomDAL : BaseEntityDAL
    {
        public EntityClient_sRoomDAL(EntityRoomDAL room, DateTime from, DateTime to)
        {
            Room = room;
            DateFrom = from;
            DateTo = to;
        }
        [DataMember]
        public EntityRoomDAL Room { get; set; }
        [DataMember]
        public DateTime DateFrom { get; set; }
        [DataMember]
        public DateTime DateTo { get; set; }
    }
}
