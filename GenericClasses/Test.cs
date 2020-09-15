using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericClasses.Models;

namespace GenericClasses
{
    class Test
    {
        static void Main(string[] args)
        {
            //Create new Generic List of Integers and add some items.
            var genericInts = new GenericList<int>(3);
            genericInts.Add(5);
            genericInts.Add(10);
            genericInts.Add(20);
            Console.WriteLine(genericInts);
            //Create new Generic List of Strings and add some items.
            var genericStrings = new GenericList<string>(4);
            genericStrings.Add("aaa");
            genericStrings.Add("bbb");
            genericStrings.Add("ccc");

            //Test Remove method.
            genericInts.Remove(2);
            Console.WriteLine(genericInts);
            genericInts.Remove(1);
            Console.WriteLine(genericInts);

            //Test Exceptions.
            //genericInts.Insert(7878, 1);  //<- uncomment to test IndexOutOfRangeException
            //genericInts.Add(10);          //<- uncomment to test AutoGrow method

            //Test Insert method.
            genericInts.Insert(7878, 0);
            Console.WriteLine(genericInts);

            //Test FindingElement. If return -1, there is no match!
            Console.WriteLine("Have integer 5 at position = {0}", genericInts.FindingElement(5));
            Console.WriteLine("Have integer 7878 at position = {0}", genericInts.FindingElement(7878));
            Console.WriteLine("Have integer 9999 at position = {0}", genericInts.FindingElement(9999));

            Console.WriteLine("Have String \"ccc\" at position = {0}", genericStrings.FindingElement("ccc"));
            Console.WriteLine("Have String \"VVV\" at position = {0}", genericStrings.FindingElement("VVV"));
        }
    }
}
