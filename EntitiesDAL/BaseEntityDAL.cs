using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDAL
{
    [DataContract]
    public abstract class BaseEntityDAL
    {
        public BaseEntityDAL()
        {
            dateCreate = DateTime.Now;
        }
        [DataMember]
        DateTime dateCreate;
        public DateTime DateCreate
        {
            get
            {
                return dateCreate;
            }
        }
    }
}
