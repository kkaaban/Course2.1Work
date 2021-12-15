using EntitiesBLL;
using Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceBLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBLL.Tests
{
    [TestClass()]
    public class ServiceDeclarationBLLTests
    {
        string path = @"D:\test\ServiceBLLTests\Temp";
        [TestMethod()]
        public void CreateFile_should_createFileDeclaration_ByID()
        {
            // arrange
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var client = new EntityClientBLL("000000000")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            };
            hotel.Declarations = new List<EntityDeclarationBLL>();
            hotel.Declarations.Add(new EntityDeclarationBLL(client));
            string id = hotel.Declarations[0].ID;
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceDeclaration = new ServiceDeclarationBLL(pathHotel);
            File.Delete(path + "\\filename");

            // act
            serviceDeclaration.CreateFile(id, path + "\\filename");

            // assert
            Assert.IsTrue(File.Exists(path + "\\filename"));
        }

        [TestMethod()]
        public void Delete_should_delete_declaration_fromDeclrationsHotel_byId()
        {
            // arrange 
            var hotel = new EntityHotelBLL("Title", new List<EntityRoomBLL>());
            string pathHotel = path + "\\" + hotel.Title + ".json";
            var client = new EntityClientBLL("000000000")
            {
                FirstName = "Іван",
                LastName = "Крутов",
                PhoneNumber = "+380999092131"
            };
            hotel.Declarations = new List<EntityDeclarationBLL>();
            hotel.Declarations.Add(new EntityDeclarationBLL(client));
            string id = hotel.Declarations[0].ID;
            var service = new ServiceHotelBLL(pathHotel);
            service.Save(hotel);
            var serviceDeclaration = new ServiceDeclarationBLL(pathHotel);

            // act
            serviceDeclaration.Delete(id);

            // assert
            Assert.AreEqual(new ServiceDAL.ServiceHotelDAL(pathHotel).GetHotel().HotelDALtoBLL().Declarations.Count, 0);
        }
    }
}