using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class HotelDuplicateNameException : Exception
    {
        public override string Message
        {
            get
            {
                return "Готель з такою назвою вже існує";
            }
        }
    }
}
