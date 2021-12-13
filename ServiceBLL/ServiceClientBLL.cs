using EntitiesBLL;
using Exceptions;
using Mappers;
using ServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBLL
{
    public class ServiceClientBLL
    {
        public ServiceClientBLL(string path)
        {
            this.path = path;
        }
        string path;
        public void Add(EntityClientBLL client)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            try
            {
                GetClientById(client.ID);
            }
            catch (ClientIDNotFoundException)
            {
                hotel.Clients.Add(client);
                service.Save(hotel.HotelBLLtoDAL());
                return;
            }
            catch(Exception)
            {
                throw;
            }
            throw new ClientDuplicateIDException();
        }
        public string GetInfo()
        {
            string info = "";
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            foreach (var client in hotel.Clients)
            {
                info += $"ID: {client.ID}\n" +
                    $"Ім`я: {client.FirstName}\n" +
                    $"Прізвище: {client.LastName}\n" +
                    $"Паспорт: {client.PassportID}\n" +
                    $"Телефон: {client.PhoneNumber}\n\n";
            }
            return info;
        }
        public List<EntityClientBLL> GetListClient()
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            return hotel.Clients;
        }
        public void DeleteById(string id)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            for (int i = 0; i < hotel.Clients.Count; i++)
            {
                if (hotel.Clients[i].ID == id)
                {
                    hotel.Clients.Remove(hotel.Clients[i]);
                }
            }
            service.Save(hotel.HotelBLLtoDAL());
        }
        public EntityClientBLL GetClientById(string id)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            for (int i = 0; i < hotel.Clients.Count; i++)
            {
                if (hotel.Clients[i].ID == id)
                {
                    return hotel.Clients[i];
                }
            }
            throw new ClientIDNotFoundException();
        }
        public void UpdateById(string id, EntityClientBLL client)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            for (int i = 0; i < hotel.Clients.Count; i++)
            {
                if (hotel.Clients[i].ID == id)
                {
                    hotel.Clients[i] = client;
                }
            }
            service.Save(hotel.HotelBLLtoDAL());
        }
        public string GetInfoById(string id)
        {
            string info;
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            for (int i = 0; i < hotel.Clients.Count; i++)
            {
                if (hotel.Clients[i].ID == id)
                {
                    info = $"ID: {hotel.Clients[i].ID}\n" +
                    $"Ім`я: {hotel.Clients[i].FirstName}\n" +
                    $"Прізвище: {hotel.Clients[i].LastName}\n" +
                    $"Паспорт: {hotel.Clients[i].PassportID}\n" +
                    $"Телефон: {hotel.Clients[i].PhoneNumber}\n";
                    if (hotel.Clients[i].Rent !=null)
                    {
                        info += $"Номер: {hotel.Clients[i].Rent.Room.RoomNumber} з " +
                            $"{hotel.Clients[i].Rent.DateFrom.ToShortDateString()} " +
                            $"до {hotel.Clients[i].Rent.DateTo.ToShortDateString()}";
                    }
                    return info;
                }
            }
            return null;
        }
        public void ToRent(string id, EntityRoomBLL room, DateTime from, DateTime to)
        {
            var client = GetClientById(id);
            client.Rent = new EntityClient_sRoomBLL(room, from, to);
            UpdateById(id, client);
            var service = new ServiceDeclarationBLL(path);
            service.Add(client);
        }
        public void RemoveRent(string id)
        {
            var client = GetClientById(id);
            client.Rent = null;
            UpdateById(id, client);
        }
        public List<EntityClientBLL> GetListByFirstName(string firstName)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var clients = hotel.Clients;
            var clientsSorted = new List<EntityClientBLL>();
            foreach (var client in clients)
            {
                if (client.FirstName == firstName)
                {
                    clientsSorted.Add(client);
                }
            }
            return clientsSorted;
        }
        public List<EntityClientBLL> GetListByLastName(string lastName)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var clients = hotel.Clients;
            var clientsSorted = new List<EntityClientBLL>();
            foreach (var client in clients)
            {
                if (client.LastName == lastName)
                {
                    clientsSorted.Add(client);
                }
            }
            return clientsSorted;
        }
    }
}
