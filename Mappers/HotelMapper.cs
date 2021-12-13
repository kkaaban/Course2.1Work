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
    public static class HotelMapper
    {
        public static EntityHotelBLL HotelPLtoBLL(this EntityHotelPL hotel)
        {
            var rooms = new List<EntityRoomBLL>();
            foreach (var room in hotel.Rooms)
            {
                rooms.Add(new EntityRoomBLL(room.RoomNumber) { Price = room.Price});
            }
            var clients = new List<EntityClientBLL>();
            foreach (var client in hotel.Clients)
            {
                clients.Add(client.ClientPLtoBLL());
            }
            var declarations = new List<EntityDeclarationBLL>();
            foreach (var declaration in hotel.Declarations)
            {
                declarations.Add(declaration.DeclarationPLtoBLL());
            }
            return new EntityHotelBLL(hotel.Title, rooms) { Clients = clients, Declarations = declarations };
        }
        public static EntityHotelDAL HotelBLLtoDAL(this EntityHotelBLL hotel)
        {
            var rooms = new List<EntityRoomDAL>();
            foreach (var room in hotel.Rooms)
            {
                rooms.Add(new EntityRoomDAL(room.RoomNumber) { Price = room.Price });
            }
            var clients = new List<EntityClientDAL>();
            foreach (var client in hotel.Clients)
            {
                clients.Add(client.ClientBLLtoDAL());
            }
            var declarations = new List<EntityDeclarationDAL>();
            foreach (var declaration in hotel.Declarations)
            {
                declarations.Add(declaration.DeclarationBLLtoDAL());
            }
            return new EntityHotelDAL(hotel.Title, rooms) { Clients = clients, Declarations = declarations };
        }
        public static EntityHotelBLL HotelDALtoBLL(this EntityHotelDAL hotel)
        {
            var rooms = new List<EntityRoomBLL>();
            foreach (var room in hotel.Rooms)
            {
                rooms.Add(new EntityRoomBLL(room.RoomNumber) { Price = room.Price });
            }
            var clients = new List<EntityClientBLL>();
            foreach (var client in hotel.Clients)
            {
                clients.Add(client.ClientDALtoBLL());
            }
            var declarations = new List<EntityDeclarationBLL>();
            foreach (var declaration in hotel.Declarations)
            {
                declarations.Add(declaration.DeclarationDALtoBLL());
            }
            return new EntityHotelBLL(hotel.Title, rooms) { Clients = clients, Declarations = declarations};
        }
    }
}
