using EntitiesBLL;
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

            // act
            serviceDeclaration.CreateFile(id, path);
        }
    }
}