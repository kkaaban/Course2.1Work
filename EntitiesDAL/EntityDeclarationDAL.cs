using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDAL
{
    [DataContract]
    public class EntityDeclarationDAL : BaseEntityDAL
    {
        string textDeclctation;
        [DataMember]
        public string TextDeclaration
        {
            get
            {
                return textDeclctation;
            }
            set
            {
                textDeclctation = value;
            }
        }
        [DataMember]
        public EntityClientDAL Client { get; set; }
        string id;
        [DataMember]
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
