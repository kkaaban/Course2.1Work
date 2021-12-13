using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesBLL
{
    public class EntityDeclarationBLL
    {
        public EntityDeclarationBLL(EntityClientBLL client)
        {
            Client = client;
            id = DateTime.Now.Day.ToString() + DateTime.Now.Millisecond;
        }
        string textDeclctation;
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
        public EntityClientBLL Client { get; set; }
        string id;
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
