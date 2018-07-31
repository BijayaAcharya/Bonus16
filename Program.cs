using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();

            // Console.WriteLine("How many cars you are entering. Print 1-3!");
            // int input = int.Parse(Console.ReadLine());

            

            while (true)
            {

                Car temp = new Car();

                Console.WriteLine(" Enter Car Make!");
                temp.Make = Console.ReadLine();

                Console.WriteLine("Enter Car model!");
                temp.Model = Console.ReadLine();

                Console.WriteLine(" Enter Car Year!");
                temp.Year = int.Parse(Console.ReadLine());

                Console.WriteLine(" Enter Car price!");
                temp.Price = double.Parse(Console.ReadLine());

                cars.Add(temp);

                Console.WriteLine("Do you want to continue? y/n");
                string choice = (Console.ReadLine());
                if (choice.ToLower() == "n")
                {
                    break;
                }
            }
            Console.WriteLine("\tMake\tModel\tYear\tPrice"); // writing tabbed line for the display table

            Console.WriteLine("\t*******\t*******\t*******\t*******"); // writing tabbed astrisks

            foreach (Car c in cars)
            {
                   

            Console.WriteLine($"\t{c.Make}\t{c.Model}\t{c.Year}\t{c.Price}");

            }





            


            
        }
    }
}
