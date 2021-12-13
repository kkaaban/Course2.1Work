using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesBLL
{
    public class EntityHotelBLL
    {
        public EntityHotelBLL(string title, List<EntityRoomBLL> rooms)
        {
            Title = title;
            Rooms = rooms;
        }
        public string Title { get; private set; }
        public List<EntityRoomBLL> Rooms { get; set; }
        public List<EntityClientBLL> Clients { get; set; } = new List<EntityClientBLL>();
        public List<EntityDeclarationBLL> Declarations { get; set; } = new List<EntityDeclarationBLL>();
    }
}
