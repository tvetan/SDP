using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            HashTable<int, int> hashTable = new HashTable<int, int>(24);

            for (int i = 0; i < 5000000; i++)
            {
                hashTable.Set(i, i + 1);
            }

            Console.WriteLine(hashTable.Get(235));


            //Dictionary<int, int> dictionary = new Dictionary<int, int>(24);

            //for (int i = 0; i < 25000000; i++)
            //{
            //    dictionary.Add(i, i + 1);
            //}

            //Console.WriteLine(dictionary[235]);
        }
    }
}
