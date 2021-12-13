using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityDeclarationPL
    {
        public EntityDeclarationPL(EntityClientPL client)
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
        public EntityClientPL Client { get; set; }
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
