using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDAL
{
    [DataContract]
    public class EntityHotelDAL : BaseEntityDAL
    {
        public EntityHotelDAL(string title, List<EntityRoomDAL> rooms)
        {
            Title = title;
            Rooms = rooms;
        }
        [DataMember]
        public string Title { get; private set; }
        [DataMember]
        public List<EntityRoomDAL> Rooms { get; private set; }
        [DataMember]
        public List<EntityClientDAL> Clients { get; set; } = new List<EntityClientDAL>();
        [DataMember]
        public List<EntityDeclarationDAL> Declarations { get; set; }
    }
}
