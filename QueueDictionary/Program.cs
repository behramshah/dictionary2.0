using System;
using System.Collections.Generic;

namespace example_dictionary
{
    class Program
    {
        public static Dictionary<int, object> countries = new Dictionary<int, object>();
        static void Main(string[] args)
        {
            Console.WriteLine("To Add country into dictionary type 1, to remove type 2, to finish type 3");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    DictionaryAdd();
                    break;
                case 2:
                    DictionaryRemove();
                    break;
                case 3: break;
                default:
                    Console.WriteLine("Choose from menu");
                    break;

            }





        }
        static object CreateO()
        {
            Console.WriteLine("Insert Country Name");
            string Name = Console.ReadLine();
            Country GOV = new Country(Name);
            return GOV;
        }
        static void DictionaryAdd()
        {

            Console.WriteLine("Insert the key of value you add");
            try
            {
                int counter = Convert.ToInt32(Console.ReadLine());
                countries.Add(counter, CreateO());
            }
            catch { Console.WriteLine("incorrect key"); }

            foreach (Country g in countries.Values)
            {
                Console.WriteLine(g.GetInfo());
            }



        }
        static void DictionaryRemove()
        {
            Console.WriteLine("Insert the key of value you need to remove");
            try { int counter = Convert.ToInt32(Console.ReadLine()); countries.Remove(counter); }
            catch { Console.WriteLine("Key not found"); }
        }



    }
    public class Country
    {
        public string name { get; set; }
        public Country(string n) { name = n; }


        public string GetInfo()
        {
            Console.WriteLine($"Country: {name}");
            return name;
        }

    }
}
