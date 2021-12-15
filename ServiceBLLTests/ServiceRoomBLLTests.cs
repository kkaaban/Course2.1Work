using EntitiesBLL;
using Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBLL.Tests
{
    [TestClass()]
    public class ServiceRoomBLLTests
    {
        string path = @"D:\test\ServiceBLLTests\Temp";

        [TestMethod()]
        public void GetPriceRent_should_return_2000_when_roomPrice1000_rent_dateFrom1212_dateTo1412()
        {
            // arrange
            var room = new EntityRoomBLL("room number");
            var service = new ServiceRoomBLL("path not required");
            room.Price = 1000;
            DateTime from = DateTime.Parse("12.12.2021");
            DateTime to = DateTime.Parse("14.12.2021");
            decimal price = 2000;

            // act
            decimal expected = service.GetPriceRent(room, from, to);

            // assert
            Assert.AreEqual(price, expected);
        }

        [TestMethod()]
        [ExpectedException(typeof(RoomNumberNotFoundException))]
        public void GetInfoByNumber_should_return_Exception_when_notFoundRoomNumber()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            hotel.Rooms.Add(new EntityRoomBLL("room number"));
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            DateTime now = DateTime.Now;
            var serviceRoom = new ServiceRoomBLL(pathHotel);

            // act
            serviceRoom.GetInfoByNumber(now, "room number №2");

            // assert is handled by ExpectedException
        }

        [TestMethod()]
        public void RoomNumber_should_return_true_when_Exist_RoomNumber()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string roomNumber = "room number";
            hotel.Rooms.Add(new EntityRoomBLL(roomNumber));
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceRoom = new ServiceRoomBLL(pathHotel);

            // act
            bool expected = serviceRoom.RoomNumberExist(roomNumber);

            // assert
            Assert.IsTrue(expected);
        }

        [TestMethod()]
        public void GetRoomFree_should_return_ListFreeRoom()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            hotel.Clients = new List<EntityClientBLL>();
            hotel.Rooms = new List<EntityRoomBLL>();
            hotel.Rooms.Add(new EntityRoomBLL("1"));
            hotel.Rooms.Add(new EntityRoomBLL("2"));
            #region Create Clients
            hotel.Clients.Add(new EntityClientBLL("000000001")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            hotel.Clients.Add(new EntityClientBLL("000000002")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131",
                Rent = new EntityClient_sRoomBLL(hotel.Rooms[1], DateTime.Parse("12.02.1970"), DateTime.Parse("13.02.1970"))
            });
            #endregion
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceRoom = new ServiceRoomBLL(pathHotel);

            // act
            var expected = serviceRoom.GetRoomFree(DateTime.Now);

            // assert
            Assert.IsTrue(expected.Count == 2);
        }

        [TestMethod()]
        public void GetInfoFree_should_return_InfoFreeRooms()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            hotel.Clients = new List<EntityClientBLL>();
            hotel.Rooms = new List<EntityRoomBLL>();
            hotel.Rooms.Add(new EntityRoomBLL("1"));
            hotel.Rooms.Add(new EntityRoomBLL("2"));
            #region Create Clients
            hotel.Clients.Add(new EntityClientBLL("000000001")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            hotel.Clients.Add(new EntityClientBLL("000000002")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131",
                Rent = new EntityClient_sRoomBLL(hotel.Rooms[1], DateTime.Parse("12.02.1970"), DateTime.Parse("13.02.1970"))
            });
            #endregion
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceRoom = new ServiceRoomBLL(pathHotel);
            string info = $"Номер: 1\n" +
                       $"Ціна: 0\n" +
                       $"Статус: вільно\n\n";
            info += $"Номер: 2\n" +
                       $"Ціна: 0\n" +
                       $"Статус: вільно\n\n";

            // act
            string expected = serviceRoom.GetInfoFree(DateTime.Now);

            // assert
            Assert.AreEqual(expected, info);
        }

        [TestMethod()]
        public void GetInfo_should_return_stringInfoAllRooms()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            hotel.Clients = new List<EntityClientBLL>();
            hotel.Rooms = new List<EntityRoomBLL>();
            hotel.Rooms.Add(new EntityRoomBLL("1"));
            hotel.Rooms.Add(new EntityRoomBLL("2"));
            #region Create Clients
            hotel.Clients.Add(new EntityClientBLL("000000001")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            hotel.Clients.Add(new EntityClientBLL("000000002")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131",
                Rent = new EntityClient_sRoomBLL(hotel.Rooms[1], DateTime.Parse("12.02.1970"), DateTime.Parse("13.02.1970"))
            });
            #endregion
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceRoom = new ServiceRoomBLL(pathHotel);
            string info = $"Номер: 1\n" +
                       $"Ціна: 0\n" +
                       $"Статус: вільно\n\n";
            info += $"Номер: 2\n" +
                       $"Ціна: 0\n" +
                       $"Статус: вільно\n\n";

            // act
            string expected = serviceRoom.GetInfo(DateTime.Now);

            // assert
            Assert.AreEqual(expected, info);
        }
    }
}