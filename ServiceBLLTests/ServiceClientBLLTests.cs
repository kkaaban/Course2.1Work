using EntitiesBLL;
using Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceBLL;
using ServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;

namespace ServiceBLL.Tests
{
    [TestClass()]
    public class ServiceClientBLLTests
    {
        string path = @"D:\test\ServiceBLLTests\Temp";
        [TestMethod()]
        [ExpectedException(typeof(ClientIDNotFoundException))]
        public void GetClientById_should_return_Exception_when_ClientID_NoExist()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceClient = new ServiceClientBLL(pathHotel);

            // act
            serviceClient.GetClientById("id");

            // assert is handled by ExpectedException
        }

        [TestMethod()]
        public void GetInfoById_should_return_null_when_ClientID_NoExist()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceClient = new ServiceClientBLL(pathHotel);

            // act
            string expected = serviceClient.GetInfoById("id");

            // assert
            Assert.IsNull(expected);
        }

        [TestMethod()]
        public void GetInfoById_should_return_stringInfo_whithoutRentInfo_when_ClientIDExist()
        {
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            hotel.Clients.Add(new EntityClientBLL("000000001")
            {
                FirstName = "Дмитро",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceClient = new ServiceClientBLL(pathHotel);
            string info = $"ID: {hotel.Clients[0].ID}\n" +
                    $"Ім`я: {hotel.Clients[0].FirstName}\n" +
                    $"Прізвище: {hotel.Clients[0].LastName}\n" +
                    $"Паспорт: {hotel.Clients[0].PassportID}\n" +
                    $"Телефон: {hotel.Clients[0].PhoneNumber}\n";
            // act
            string expected = serviceClient.GetInfoById("000000001");

            // assert
            Assert.AreEqual(info, expected);
        }

        [TestMethod()]
        public void ToRent_should_add_valueTo_clientRent_when_ClientIdExist()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            hotel.Clients.Add(new EntityClientBLL("000000001")
            {
                FirstName = "Дмитро",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            var room = new EntityRoomBLL("room number");
            DateTime from = DateTime.Parse("12.12.2022");
            DateTime to = DateTime.Parse("14.12.2022");
            var clientsRoom = new EntityClient_sRoomBLL(room, from, to);
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceClient = new ServiceClientBLL(pathHotel);
            var serviceHotelDAL = new ServiceHotelDAL(pathHotel);

            // act
            serviceClient.ToRent(hotel.Clients[0].ID, room, from, to);
            var expected = serviceHotelDAL.GetHotel().HotelDALtoBLL().Clients[0].Rent;

            // assert
            Assert.IsTrue(clientsRoom.Room.RoomNumber == expected.Room.RoomNumber &&
                clientsRoom.Room.Price == expected.Room.Price &&
                clientsRoom.DateFrom == expected.DateFrom &&
                clientsRoom.DateTo == expected.DateTo);
        }

        [TestMethod()]
        public void RemoveRent_should_install_null_in_clientRent()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            hotel.Clients.Add(new EntityClientBLL("000000000")
            {
                FirstName = "Дмитро",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            hotel.Clients[0].Rent = new EntityClient_sRoomBLL(new EntityRoomBLL("roomNum"), DateTime.Now, DateTime.Now);
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceClient = new ServiceClientBLL(pathHotel);

            // act
            serviceClient.RemoveRent("000000000");

            // assert
            Assert.IsNull(serviceClient.GetClientById("000000000").Rent);
        }

        [TestMethod()]
        public void GetListByFirstName_should_return_listFromFirstName()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            #region Add Clients
            hotel.Clients.Add(new EntityClientBLL("000000000")
            {
                FirstName = "Дмитро",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            hotel.Clients.Add(new EntityClientBLL("000000000")
            {
                FirstName = "Дмитро",
                LastName = "Мазепа",
                PhoneNumber = "+380999092131"
            });
            hotel.Clients.Add(new EntityClientBLL("000000000")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            });
            #endregion
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceClient = new ServiceClientBLL(pathHotel);

            // act
            var expected = serviceClient.GetListByFirstName("Дмитро");

            // assert
            Assert.AreEqual(expected.Count, 2);
        }
    }
}