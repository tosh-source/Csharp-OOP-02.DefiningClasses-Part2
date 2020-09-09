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
            var genericList = new GenericList<int>(3);
            genericList.Add(5);
            genericList.Add(10);
            genericList.Add(20);
            Console.WriteLine(genericList);

            genericList.Remove(1);
            Console.WriteLine(genericList);

            genericList.Insert(7878, 1);
            Console.WriteLine(genericList);
        }
    }
}
