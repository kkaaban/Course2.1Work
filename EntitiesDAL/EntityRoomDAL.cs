using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDAL
{
    [DataContract]
    public class EntityRoomDAL : BaseEntityDAL
    {
        public EntityRoomDAL(string roomNumber)
        {
            RoomNumber = roomNumber;
        }
        [DataMember]
        public string RoomNumber { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
}
