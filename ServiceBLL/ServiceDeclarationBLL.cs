using EntitiesBLL;
using Mappers;
using ServiceDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBLL
{
    public class ServiceDeclarationBLL
    {
        public ServiceDeclarationBLL(string path)
        {
            this.path = path;
        }
        string path;
        public void Add(EntityClientBLL client)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var declaration = new EntityDeclarationBLL(client);
            declaration.TextDeclaration = ToFormText(client);
            hotel.Declarations.Add(declaration);
            service.Save(hotel.HotelBLLtoDAL());
        }
        public string ToFormText(EntityClientBLL client)
        {
            return $"Анкета\n" +
                $"1. Ім'я {client.FirstName}\n" +
                $"2. Прізвище {client.LastName}\n" +
                $"3. Паспорт {client.PassportID}\n" +
                $"4. Мета приїзду ______________\n" +
                $"5. Номер № {client.Rent.Room.RoomNumber}\n" +
                $"6. Прибув {client.Rent.DateFrom.ToShortDateString()}\n" +
                $"7. Вибув {client.Rent.DateTo.ToShortDateString()}\n" +
                $"8. З пам'яткою щодо правил пожежної безпеки ознайомлено\n" +
                $"підпис _________\n" +
                $"підпс відповідальної особи _______\n" +
                $"{DateTime.Now.ToShortDateString()}";
        }
        public EntityDeclarationBLL GetDeclarationById(string id)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            foreach (var declaration in hotel.Declarations)
            {
                if (id.ToString()==declaration.ID)
                    return declaration;
            }
            throw new Exception("не найден ид деклр");
        }
        public void CreateFile(string id, string _path)
        {
            var declaration = GetDeclarationById(id);
            var service = new ServiceDeclarationDAL(path);
            service.CreateFile(declaration.DeclarationBLLtoDAL(), _path);
        }
        public void Delete(string id)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var declaration = GetDeclarationById(id);
            for (int i = 0; i < hotel.Declarations.Count; i++)
            {
                if (hotel.Declarations[i].ID == declaration.ID)
                {
                    hotel.Declarations.RemoveAt(i);
                }
            }
            service.Save(hotel.HotelBLLtoDAL());
        }
        public string GetInfo(EntityDeclarationBLL declaration)
        {
            return $"ID заявки: {declaration.ID}\n" +
                $"Клієнт {declaration.Client.FirstName} {declaration.Client.LastName}\n" +
                $"ID клієнта: {declaration.Client.ID}\n" +
                $"Номер {declaration.Client.Rent.Room.RoomNumber}\n" +
                $"З {declaration.Client.Rent.DateFrom.ToShortDateString()}\n" +
                $"До {declaration.Client.Rent.DateTo.ToShortDateString()}\n\n";
        }
        public List<EntityDeclarationBLL> GetListFromTo(DateTime from, DateTime to)
        {
            var service = new ServiceHotelDAL(path);
            var hotel = service.GetHotel().HotelDALtoBLL();
            var list = new List<EntityDeclarationBLL>();
            foreach (var declaration in hotel.Declarations)
            {
                if (declaration.Client.Rent.DateFrom>=from 
                    && declaration.Client.Rent.DateFrom<=to)
                {
                    list.Add(declaration);
                }
            }
            return list;
        }
    }
}
