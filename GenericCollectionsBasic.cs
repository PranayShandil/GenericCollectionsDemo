using System;
using System.Collections.Generic;

namespace GenericCollectionsDemo
{
    class GenericCollectionsBasic
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);
            li.Add(50);
            li.Add(60);

            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();

            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
