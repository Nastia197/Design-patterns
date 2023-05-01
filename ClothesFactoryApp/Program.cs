using System;
using ClothesFactoryApp.Factories;

namespace ClothesFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a type of clothe you want:");
            string type = Console.ReadLine();
            if (type=="Elegant")
            {
                Client client = new Client(new ElegantClothesFactory()); 
                client.DescribeYourClothes();
                Console.WriteLine($"Choose from: {client.DescribeYourClothes()} \n");
            }
            if(type == "Casual")
            {
                Client client = new Client(new CasualClothesFactory());
                client.DescribeYourClothes();
                Console.WriteLine($"Choose from: {client.DescribeYourClothes()} \n");
            }


            Console.ReadKey();

        }
    }
}
