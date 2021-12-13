using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityClientPL
    {
        public EntityClientPL(string passportID)
        {
            PassportID = passportID;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public EntityClients_sRoomPL Rent { get; set; }
        public string PassportID { get; set; }
        public string ID
        {
            get
            {
                if (PassportID.Length==9)
                    return PassportID;
                if (PassportID.Length==8)
                    return PassportID.Remove(0, 2);
                throw new Exception();
            }
        }
    }
}
