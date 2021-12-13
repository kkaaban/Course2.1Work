using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityHotelPL
    {
        public EntityHotelPL(string title, List<EntityRoomPL> rooms)
        {
            Title = title;
            Rooms = rooms;
        }
        public string Title { get; private set; }
        public List<EntityRoomPL> Rooms { get; private set; }
        public List<EntityClientPL> Clients { get; set; } = new List<EntityClientPL>();
        public List<EntityDeclarationPL> Declarations { get; set; } = new List<EntityDeclarationPL>();
    }
}
