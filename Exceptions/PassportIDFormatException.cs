using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class PassportIDFormatException : Exception
    {
        public override string Message
        {
            get
            {
                return "Неправильний формат вхідної строки паспорта. Строка повинна бути типу: 9 цифр або 2 латинські літери і 6 цифр";
            }
        }
    }
}
