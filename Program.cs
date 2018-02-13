using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            //var cars = new List<string>();

            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Mercedes";
            //var car4 = "Ferrari";
            //var car5 = "Opel";
            //var car6 = "Saab";

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(cars[index]);
            //}
            //Console.ReadLine();

            //var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Ople", "Saab" };

            //for (int index = 0; index <cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}

            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 26 },
                new Human(){Name = "Jasper", Age = 25 },
                new Human(){Name = "Tom", Age = 24 },
                new Human(){Name = "Jakob", Age = 23 },
                new Human(){Name = "Andris", Age = 22 },
            };

            var human1 = new Human();
            human1.Name = "Priit";
            human1.Age = 25;
            humans1.Add(human1);

            var human2 = new Human();
            Console.WriteLine("Sisestage nimi");
            human2.Name = Console.ReadLine();
            Console.WriteLine("Sisestage oma vanus");
            human2.Name = Console.ReadLine();

            foreach (var item in humans1)
            {
            Console.WriteLine(item.Name + " " + item.Age);
            }
            while(true)
            {
                var human3 = new Human();
                Console.WriteLine("Sisestage nimi?");
                human3.Name = Console.ReadLine();
                Console.WriteLine("Sisestage vanus?");
                human3.Age = Int32.Parse(Console.ReadLine());
                humans1.Add(human3);

                foreach (var item in humans1)
                {
                    Console.WriteLine(item.Name + " " + item.Age);
                }

            }
        }
    }
}
