using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateWinForm.Models
{
    public class People
    {
        public static IList<Person> GetPeople()
        {
            List<Person> p = new List<Person>()
            {
                new Person(){FirstName = "Kenan",LastName="Kurda",Age=40,StartDate=new DateTime(2000,10,26)},
                new Person(){FirstName = "Dirk",LastName="Dirk",Age=12,StartDate=new DateTime(2000,5,9)},
                new Person(){FirstName = "Jan",LastName="Jan",Age=50,StartDate=new DateTime(2000,1,1)},
                new Person(){FirstName = "Bert",LastName="Van herrewegen",Age=9,StartDate=new DateTime(2000,5,30)},
                new Person(){FirstName = "Ruben",LastName="Spillebeen",Age=22,StartDate=new DateTime(2020,9,26)},
            };
            return p;
        }
    }
}
