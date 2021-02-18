using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateWinForm.Models
{
    public class Formatter
    {
        public static string Default(Person input)
        {
            return input.ToString();
        }
        public static string LastNameToUpper(Person input)
        {
            return input.LastName.ToUpper();
        }
        public static string FirstNameToUpper(Person input)
        {
            return input.FirstName.ToUpper();
        }
        public static string FullNameToUpper(Person input)
        {
            return $"{input.FirstName.ToUpper(),-30}{input.LastName.ToUpper(),-30}";
        }
    }
}
