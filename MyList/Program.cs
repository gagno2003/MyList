using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MList<int> arr = new MList<int>();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);
            arr.Add(9);


            arr.RemoveRange(1, 3);

            for (int i = 0; i < arr.Count(); i++)
            {
                Console.WriteLine(arr.GetElement(i));
            }


            Console.Read();
        }
    }
}
