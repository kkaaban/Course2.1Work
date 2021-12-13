using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ProperNameFormatException : Exception
    {
        public ProperNameFormatException()
        {

        }
        public ProperNameFormatException(string source)
        {
            Source = source;
        }
        public override string Message
        {
            get
            {
                return "Неправильний формат вхідної строки. Строки ім'я та прізвище не повинні мати інших символів, крім як символів кириллиці";
            }
        }
        public override string Source { get; set; }
    }
}
