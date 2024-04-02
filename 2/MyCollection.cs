using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class MyCollection<T> where T : IComparable<T>
    {
        Random random = new Random();
        public List<MyClass> list;


        public MyCollection()
        {
            list = new List<MyClass>()
            {
                new (random.Next(0, 1000), (random.Next(0, 1000) * random.NextDouble()).ToString()),
                new (random.Next(0, 1000), (random.Next(0, 1000) * random.NextDouble()).ToString()),
                new (random.Next(0, 1000), (random.Next(0, 1000) * random.NextDouble()).ToString()),
                new (random.Next(0, 1000), (random.Next(0, 1000) * random.NextDouble()).ToString()),
                new (random.Next(0, 1000), (random.Next(0, 1000) * random.NextDouble()).ToString()),
            };
        }

        public void Add()
        {
            list.Add(new(random.Next(0, 1000), (random.Next(0, 1000) * random.NextDouble()).ToString()));
            list.Sort();
            PrintItems();
            
        }

        public void Clear()
        {

            if (list.Count > 0)
            {
                list.Clear();
                Console.WriteLine("---Коллекция очищена------");      
            }
            else 
                PrintItems();
            
        }

        public void PrintItems()
        {
            if (list.Count > 0)
            {
                Console.WriteLine("-ID-----Value-------------");
                foreach (MyClass item in list)
                {

                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("--------------------------");
            }
            else Console.WriteLine("---Список пуст------------");
        }

    }
}
