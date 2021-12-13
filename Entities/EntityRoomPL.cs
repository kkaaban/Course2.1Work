using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityRoomPL
    {
        public EntityRoomPL(string roomNumber)
        {
            RoomNumber = roomNumber;
        }
        public string RoomNumber { get; set; }
        public decimal Price { get; set; }
    }
}
