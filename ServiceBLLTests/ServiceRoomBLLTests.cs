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
    }
}