using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ClientIDNotFoundException : Exception
    {
        public override string Message
        {
            get
            {
                return "ID клієнта не знайдено";
            }
        }
    }
}
