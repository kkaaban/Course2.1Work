using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntitiesBLL
{
    public class EntityClientBLL
    {
        public EntityClientBLL(string passportID)
        {
            PassportID = passportID;
        }
        string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                string pattern = @"\p{IsCyrillic}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ProperNameFormatException();
                }
                firstName = value;
            }
        }
        string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                string pattern = @"\p{IsCyrillic}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ProperNameFormatException();
                }
                lastName = value;
            }
        }
        string passportID;
        public string PassportID
        {
            get
            {
                return passportID;
            }
            set
            {
                string pattern = "^[0-9]{9}$|^[A-Z]{2}[0-9]{6}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new PassportIDFormatException();
                }
                passportID = value;
            }
        }
        public string ID
        {
            get
            {
                if (PassportID.Length == 9)
                    return PassportID;
                if (PassportID.Length == 8)
                    return PassportID.Remove(0, 2);
                throw new PassportIDFormatException();
            }
        }
        string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public EntityClient_sRoomBLL Rent { get; set; }
    }
}
