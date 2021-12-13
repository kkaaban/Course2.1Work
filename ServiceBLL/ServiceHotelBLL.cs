using EntitiesBLL;
using Exceptions;
using Mappers;
using ServiceDAL;
using System;
using System.IO;

namespace ServiceBLL
{
    public class ServiceHotelBLL
    {
        public ServiceHotelBLL(string path)
        {
            this.path = path;
        }
        string path;
        public void Create(EntityHotelBLL hotel)
        {
            string createPath = $"{path}\\{hotel.Title}.json";
            if (File.Exists(createPath))
            {
                throw new HotelDuplicateNameException();
            }
            path = createPath;
            Save(hotel);
        }
        public void Save(EntityHotelBLL hotel) => new ServiceHotelDAL(path).Save(hotel.HotelBLLtoDAL());
        public string GetTitle()
        {
            try
            {
                var service = new ServiceHotelDAL(path);
                var hotel = service.GetHotel().HotelDALtoBLL();
                return hotel.Title;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void Delete() => new ServiceHotelDAL(path).Delete();
        public string GetInfo(DateTime now)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var serviceRoom = new ServiceRoomBLL(path);
            string text = $"Готель: {hotel.Title}\n" +
                $"Місць: {hotel.Rooms.Count}\n" +
                $"Вільних: {serviceRoom.GetRoomFree(now).Count}\n" +
                $"Проживають: {serviceRoom.GetRoomSettle(now).Count}\n" +
                $"Бронюють: {serviceRoom.GetRoomBooking(now).Count}\n" +
                $"Клієнтів: {hotel.Clients.Count}";
            return text;
        }
    }
}
