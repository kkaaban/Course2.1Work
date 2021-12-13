using EntitiesDAL;
using JSONProvider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDAL
{
    public class ServiceHotelDAL
    {
        public ServiceHotelDAL(string path)
        {
            this.path = path;
        }
        string path;
        public void Save(EntityHotelDAL hotel)=> Provider.Serialize(hotel, path);
        public EntityHotelDAL GetHotel()=> Provider.Deserialize<EntityHotelDAL>(path);
        public void Delete() => File.Delete(path);
    }
}
