using Business.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description+"fiyatı: "+car.DailyPrice);
            }
            Console.ReadLine();
        }
    }
}
