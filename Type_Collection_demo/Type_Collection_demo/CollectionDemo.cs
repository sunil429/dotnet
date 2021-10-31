using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Type_Collection_demo
{
    class CollectionDemo
    {
        static void Main(string[] args)
        {
            #region Nullable Type

            //int i = null;
            Nullable<int> x = null;
            x = 100;
            x = null;

            //datatype?  ---------- nullable type
            int? y = null;
            #endregion

            // #region Generic Collection classes
            // List<string> countryList = new List<string>();

            // List<int> numbers = new List<int>();
            // numbers.Add(100);

            // List<Person> personlList = new List<Person>();
            // personlList.Add(new Person() { FirstName = "Sunil", LastName = "Pillai" });
            // Console.WriteLine(personlList[0].FirstName);
            // #endregion

            //  #region System.Collections.classes

            //  ArrayList countryList = new ArrayList();
            // countryList.Add("India");
            // countryList.Add("USA");
            // countryList.Insert(1, "France");

            // for(int i = 0; i < countryList.Count; i++)
            //{
            //    Console.WriteLine(countryList[i]);
            // }
            //Person person = new Person() { FirstName = "Sunil", LastName = "Pillai" };
            //Console.WriteLine(person.FirstName + "" + person.LastName);
            // Console.WriteLine("---------------------------\n");
            //countryList.Add(person);

            //Console.WriteLine(((Person)countryList[3]).FirstName);
            // Console.WriteLine("---------------------------\n");

            // #endregion
            //int[] numberArray = new int[3];
            // numberArray[0] = 454;
            // numberArray[1] = 44754;
            // numberArray[2] = 23;

            //for(int i = 0; i < numberArray.Length; i++)
            // {
            //Console.WriteLine(numberArray[i]);
            // }

        }
    }
}
