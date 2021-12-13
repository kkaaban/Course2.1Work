using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class RoomNumberNotFoundException : Exception
    {
        public override string Message
        {
            get
            {
                return "Номер не знайден";
            }
        }
    }
}
