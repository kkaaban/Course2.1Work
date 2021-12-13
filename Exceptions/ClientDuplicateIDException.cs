using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ClientDuplicateIDException : Exception
    {
        public override string Message
        {
            get
            {
                return "Спроба додати клієнта в базу даних, проте клієнт з таким паспортом вже є в базі";
            }
        }
    }
}
