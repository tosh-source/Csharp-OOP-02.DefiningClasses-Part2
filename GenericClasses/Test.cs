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
            var genericList = new GenericList<int>(3);
            genericList.Add(5);
            genericList.Add(10);
            genericList.Add(20);
            Console.WriteLine(genericList);

            //Test Remove method.
            genericList.Remove(2);
            Console.WriteLine(genericList);
            genericList.Remove(1);
            Console.WriteLine(genericList);

            //Test Exceptions.
            //genericList.Insert(7878, 1);  //<- uncomment to test IndexOutOfRangeException
            //genericList.Add(10);

            //Test Insert method.
            genericList.Insert(7878, 0);
            Console.WriteLine(genericList);
        }
    }
}
