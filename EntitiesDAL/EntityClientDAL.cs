using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDAL
{
    [DataContract]
    public class EntityClientDAL : BaseEntityDAL
    {
        public EntityClientDAL(string passportID)
        {
            PassportID = passportID;
        }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public EntityClient_sRoomDAL Rent { get; set; }
        [DataMember]
        public string PassportID { get; set; }
        public string ID
        {
            get
            {
                if (PassportID.Length == 9)
                    return PassportID;
                if (PassportID.Length == 8)
                    return PassportID.Remove(0, 2);
                throw new Exception();
            }
        }
    }
}
