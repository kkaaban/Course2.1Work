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
    public class ServiceRoomBLL
    {
        public ServiceRoomBLL(string path)
        {
            this.path = path;
        }
        string path;
        public EntityRoomBLL GetRoomByNumber(string roomNumber)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            foreach (var room in hotel.Rooms)
            {
                if (room.RoomNumber==roomNumber)
                {
                    return room;
                }
            }
            throw new RoomNumberNotFoundException();
        }
        public bool RoomNumberExist(string roomNumber)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            foreach (var room in hotel.Rooms)
            {
                if (room.RoomNumber == roomNumber)
                {
                    return true;
                }
            }
            return false;
        }
        public List<EntityRoomBLL> GetRoomFree(DateTime now)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var rooms = new List<EntityRoomBLL>();
            foreach (var room in hotel.Rooms)
            {
                bool check = true;
                foreach (var client in hotel.Clients)
                {
                    if (client.Rent == null)
                        continue;
                    if (client.Rent.Room.RoomNumber == room.RoomNumber)
                        check = false;
                }
                if (check)
                    rooms.Add(room);
            }
            foreach (var client in hotel.Clients)
            {
                if (client.Rent == null)
                    continue;
                if (client.Rent.DateFrom < now &&
                    client.Rent.DateTo < now)
                    rooms.Add(client.Rent.Room);
            }
            return rooms;
        }
        public List<EntityRoomBLL> GetRoomSettle (DateTime now)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var rooms = new List<EntityRoomBLL>();
            foreach (var client in hotel.Clients)
            {
                if (client.Rent == null)
                    continue;
                if (client.Rent.DateFrom <= now &&
                    client.Rent.DateTo >= now)
                    rooms.Add(client.Rent.Room);
            }
            return rooms;
        }
        public List<EntityRoomBLL> GetRoomBooking (DateTime now)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var rooms = new List<EntityRoomBLL>();
            foreach (var client in hotel.Clients)
            {
                if (client.Rent == null)
                    continue;
                if (now < client.Rent.DateFrom &&
                now < client.Rent.DateTo)
                    rooms.Add(client.Rent.Room);
            }
            return rooms;
        }
        public string GetInfo(DateTime now)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var rooms = hotel.Rooms;
            string info = "";
            foreach (var room in rooms)
            {
                bool check = true;
                foreach (var client in hotel.Clients)
                {
                    if (client.Rent == null)
                        continue;
                    if (client.Rent.Room.RoomNumber==room.RoomNumber)
                    {
                        check = false;
                        if (client.Rent.DateFrom <= now &&
                         client.Rent.DateTo >= now)
                        {
                            info += $"Номер: {room.RoomNumber}\n" +
                                $"Ціна: {room.Price}\n" +
                                $"Статус: зайнято\n" +
                                $"З {client.Rent.DateFrom.ToShortDateString()}\n" +
                                $"До {client.Rent.DateTo.ToShortDateString()}\n" +
                                $"Клієнт: {client.FirstName} {client.LastName}\n" +
                                $"ID клієнта: {client.ID}\n\n";
                        }
                        if (now < client.Rent.DateFrom &&
                        now < client.Rent.DateTo)
                        {
                            info += $"Номер: {room.RoomNumber}\n" +
                                $"Ціна: {room.Price}\n" +
                                $"Статус: бронь\n" +
                                $"З {client.Rent.DateFrom.ToShortDateString()}\n" +
                                $"До {client.Rent.DateTo.ToShortDateString()}\n" +
                                $"Клієнт: {client.FirstName} {client.LastName}\n" +
                                $"ID клієнта: {client.ID}\n\n";
                        }
                    }
                }
                if (check)
                {
                    info += $"Номер: {room.RoomNumber}\n" +
                        $"Ціна: {room.Price}\n" +
                        $"Статус: вільно\n\n";
                }
            }
            return info;
        }
        public string GetInfoFree(DateTime now)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            string info = "";
            var rooms = new List<EntityRoomBLL>();
            foreach (var room in hotel.Rooms)
            {
                bool check = true;
                foreach (var client in hotel.Clients)
                {
                    if (client.Rent == null)
                        continue;
                    if (client.Rent.Room.RoomNumber == room.RoomNumber)
                        check = false;
                }
                if (check)
                {
                    info += $"Номер: {room.RoomNumber}\n" +
                       $"Ціна: {room.Price}\n" +
                       $"Статус: вільно\n\n";
                }
            }
            foreach (var client in hotel.Clients)
            {
                if (client.Rent == null)
                    continue;
                if (client.Rent.DateFrom < now &&
                    client.Rent.DateTo < now)
                {
                    info += $"Номер: {client.Rent.Room.RoomNumber}\n" +
                       $"Ціна: {client.Rent.Room.Price}\n" +
                       $"Статус: вільно\n\n";
                }
            }
            return info;
        }
        public string GetInfoSettle(DateTime now)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            string info = "";
            foreach (var client in hotel.Clients)
            {
                if (client.Rent == null)
                    continue;
                if (client.Rent.DateFrom <= now &&
                    client.Rent.DateTo >= now)
                {
                    info += $"Номер: {client.Rent.Room.RoomNumber}\n" +
                        $"Ціна: {client.Rent.Room.Price}\n" +
                        $"Статус: зайнято\n" +
                        $"З {client.Rent.DateFrom.ToShortDateString()}\n" +
                        $"До {client.Rent.DateTo.ToShortDateString()}\n" +
                        $"Клієнт: {client.FirstName} {client.LastName}\n" +
                        $"ID клієнта: {client.ID}\n\n";
                }
            }
            return info;
        }
        public string GetInfoBooking(DateTime now)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            string info = "";
            foreach (var client in hotel.Clients)
            {
                if (client.Rent == null)
                    continue;
                if (now < client.Rent.DateFrom &&
                now < client.Rent.DateTo)
                {
                    info += $"Номер: {client.Rent.Room.RoomNumber}\n" +
                        $"Ціна: {client.Rent.Room.Price}\n" +
                        $"Статус: зайнято\n" +
                        $"З {client.Rent.DateFrom.ToShortDateString()}\n" +
                        $"До {client.Rent.DateTo.ToShortDateString()}\n" +
                        $"Клієнт: {client.FirstName} {client.LastName}\n" +
                        $"ID клієнта: {client.ID}\n\n";
                }
            }
            return info;

        }
        public string GetInfoByNumber(DateTime now, string roomNumber)
        {
            now = DateTime.Parse(now.ToShortDateString());
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var room = GetRoomByNumber(roomNumber);
            string info = "";
            bool check = true;
            foreach (var client in hotel.Clients)
            {
                if (client.Rent == null)
                    continue;
                if (client.Rent.Room.RoomNumber == room.RoomNumber)
                {
                    check = false;
                    if (client.Rent.DateFrom <= now &&
                        client.Rent.DateTo >= now)
                    {
                        info += $"Номер: {room.RoomNumber}\n" +
                            $"Ціна: {room.Price}\n" +
                            $"Статус: зайнято\n" +
                            $"З {client.Rent.DateFrom.ToShortDateString()}\n" +
                            $"До {client.Rent.DateTo.ToShortDateString()}\n" +
                            $"Клієнт: {client.FirstName} {client.LastName}\n" +
                            $"ID клієнта: {client.ID}\n\n";
                    }
                    if (now < client.Rent.DateFrom &&
                    now < client.Rent.DateTo)
                    {
                        info += $"Номер: {room.RoomNumber}\n" +
                            $"Ціна: {room.Price}\n" +
                            $"Статус: бронь\n" +
                            $"З {client.Rent.DateFrom}\n" +
                            $"До {client.Rent.DateTo}\n" +
                            $"Клієнт: {client.FirstName} {client.LastName}\n" +
                            $"ID клієнта: {client.ID}\n\n";
                    }
                }
            }
            if (check)
            {
                info += $"Номер: {room.RoomNumber}\n" +
                    $"Ціна: {room.Price}\n" +
                    $"Статус: вільно\n\n";
            }
            return info;
        }
        public decimal GetPriceRent(EntityRoomBLL room, DateTime from, DateTime to)
        {
            var days = (to - from).TotalDays;
            return room.Price * (decimal)days;
        }
    }
}
