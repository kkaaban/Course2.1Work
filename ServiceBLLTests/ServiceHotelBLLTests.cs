using ServiceBLL;
using EntitiesBLL;
using Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System;

namespace ServiceBLL.Tests
{
    [TestClass()]
    public class ServiceHotelBLLTests
    {
        string path = @"D:\test\ServiceBLLTests\Temp";
        [TestMethod()]
        [ExpectedException(typeof(HotelDuplicateNameException))]
        public void Create_should_return_Exception_when_hotelExistInFolder()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            var service = new ServiceHotelBLL(path + "\\" + hotel.Title + ".json");
            service.Save(hotel);
            var service2 = new ServiceHotelBLL(path);

            // act
            service2.Create(hotel);

            // assert is handled by ExpectedException
        }

        [TestMethod()]
        public void Create_should_createHotelFile_when_hotelExistInFolder()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            File.Delete(pathHotel);
            var service = new ServiceHotelBLL(path);

            // act
            service.Create(hotel);

            // assert
            Assert.IsTrue(File.Exists(pathHotel));
        }

        [TestMethod()]
        public void GetTitle_should_return_Ukraine_when_hotelUkraineInFolder()
        {
            // arrange
            string hotelTitle = "Ukraine";
            var hotel = new EntityHotelBLL(hotelTitle, new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);

            // act 
            string expected = service.GetTitle();

            // assert
            Assert.AreEqual(expected, hotelTitle);
        }

        [TestMethod()]
        public void GetTitle_should_return_null_when_hotelUkraineNotInFolder()
        {
            // arrange
            string hotelTitle = "Ukraine";
            var hotel = new EntityHotelBLL(hotelTitle, new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            File.Delete(pathHotel);

            // act
            string expected = service.GetTitle();

            // assert
            Assert.AreEqual(expected, null);
        }

        [TestMethod()]
        public void Delete_should_delete_file()
        {
            // arrange
            string hotelTitle = "Ukraine";
            var hotel = new EntityHotelBLL(hotelTitle, new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);

            // act
            service.Delete();

            // assert
            Assert.IsFalse(File.Exists(pathHotel));
        }

        [TestMethod()]
        public void GetInfoTest()
        {
            // arrange
            DateTime now = DateTime.Now;
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            string text = $"Готель: {hotel.Title}\n" +
                $"Місць: 0\n" +
                $"Вільних: 0\n" +
                $"Проживають: 0\n" +
                $"Бронюють: 0\n" +
                $"Клієнтів: 0";

            // act
            string expected = service.GetInfo(now);

            // assert
            Assert.AreEqual(text, expected);
        }
    }
}