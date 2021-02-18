using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateWinForm.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{FirstName,-20}{LastName,-25}\t{Age,-5}";
        }
        public string ToString(Func<Person,string> format)
        {
            if (format!=null)
            {
                return format(this);
            }
            return string.Empty;
        }
    }
}
