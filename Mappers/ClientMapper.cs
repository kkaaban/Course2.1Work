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
    public static class ClientMapper
    {
        public static EntityClientBLL ClientPLtoBLL(this EntityClientPL client)
        {
            EntityClientBLL toReturn = new EntityClientBLL(client.PassportID)
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber,
            };
            if (client.Rent != null)
            {
                toReturn.Rent = new EntityClient_sRoomBLL(client.Rent.Room.RoomPLtoBLL(), client.Rent.DateFrom, client.Rent.DateTo);
            }
            return toReturn;
        }
        public static EntityClientPL ClientBLLtoPL(this EntityClientBLL client)
        {
            if (client == null)
            {
                return null;
            }
            EntityClientPL toReturn = new EntityClientPL(client.PassportID)
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber,
            };
            if (client.Rent != null)
            {
                toReturn.Rent = new EntityClients_sRoomPL(client.Rent.Room.RoomBLLtoPL(), client.Rent.DateFrom, client.Rent.DateTo);
            }
            return toReturn;
        }
        public static EntityClientBLL ClientDALtoBLL(this EntityClientDAL client)
        {
            var toReturn = new EntityClientBLL(client.PassportID)
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber,
            };
            if (client.Rent != null)
            {
                toReturn.Rent = new EntityClient_sRoomBLL(client.Rent.Room.RoomDALtoBLL(), client.Rent.DateFrom, client.Rent.DateTo);
            }
            return toReturn;
        }
        public static EntityClientDAL ClientBLLtoDAL(this EntityClientBLL client)
        {
            var toReturn = new EntityClientDAL(client.PassportID)
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber,
            };
            if (client.Rent != null)
            {
                toReturn.Rent = new EntityClient_sRoomDAL(client.Rent.Room.RoomBLLtoDAL(), client.Rent.DateFrom, client.Rent.DateTo);
            }
            return toReturn;
        }
        public static List<EntityClientPL> ListClientBLLtoPL(this List<EntityClientBLL> clients)
        {
            var clientsPL = new List<EntityClientPL>();
            foreach (var client in clients)
            {
                clientsPL.Add(client.ClientBLLtoPL());
            }
            return clientsPL;
        }
    }
}
