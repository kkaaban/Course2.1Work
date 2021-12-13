using Entities;
using EntitiesBLL;
using EntitiesDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public static class RoomMapper
    {
        public static EntityRoomBLL RoomPLtoBLL(this EntityRoomPL room)
        {
            return new EntityRoomBLL(room.RoomNumber)
            {
                Price = room.Price
            };
        }
        public static EntityRoomPL RoomBLLtoPL(this EntityRoomBLL room)
        {
            return new EntityRoomPL(room.RoomNumber)
            {
                Price = room.Price
            };
        }
        public static EntityRoomBLL RoomDALtoBLL(this EntityRoomDAL room)
        {
            return new EntityRoomBLL(room.RoomNumber)
            {
                Price = room.Price
            };
        }

        public static EntityRoomDAL RoomBLLtoDAL(this EntityRoomBLL room)
        {
            return new EntityRoomDAL(room.RoomNumber)
            {
                Price = room.Price
            };
        }
    }
}
