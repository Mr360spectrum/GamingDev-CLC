using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarKE
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCar car1 = new MyCar();
            MyCar car2 = new MyCar();
            Console.WriteLine(car1.color);
            Console.WriteLine(car2.color);
            car1.drive();
            Console.ReadKey();
        }
    }

    class MyCar
    {
        public String color;
        private String make;
        private String model;
        private int year;
        private double mileage;
        private double price;
        Engine engine = new Engine();

        public MyCar()
        {
            Console.WriteLine("What is the color?");
            color = Console.ReadLine();

            Console.WriteLine("What is the make?");
            make = Console.ReadLine();

            Console.WriteLine("What is the model?");
            model = Console.ReadLine();

            Console.WriteLine("what is the year?");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the mileage?");
            mileage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the price?");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void drive()
        {
            if (engine.pistons == 8)
            {
                Console.WriteLine("I'm going 20 MPH over the speed limit!");
            }
            else
            {
                Console.WriteLine("I'm in me mum's car, vroom vroom");
            }
        }
    }

    class Engine
    {
        private String style;
        public int pistons;

        public Engine()
        {
            style = "V";
            pistons = 8;
        }
    }
}
