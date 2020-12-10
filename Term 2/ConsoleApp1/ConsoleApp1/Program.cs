using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class People
    {
        private String skinColor;
        private String eyeColor;
        private String hairColor;
        private double hairLength;
        private double height;
        private double weight;
        private int age;
        private String name;

        public People()
        {
            Console.WriteLine("Skin color: ");
            skinColor = Console.ReadLine();
            Console.WriteLine("Eye color: ");
            eyeColor = Console.ReadLine();
            Console.WriteLine("Hair color: ");
            hairColor = Console.ReadLine();
            Console.WriteLine("Hair length: ");
            hairLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Weight: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Age: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
        }

        public void setEyeColor(String color)
        {
            String password = "up up down down left right left right b a start";
            Console.WriteLine("Enter the password: ");
            String input = Console.ReadLine();
            if (password == input)
            {
                this.eyeColor = color;
            }
        }

        public String getEyeColor()
        {
            return this.eyeColor;
        }

        public String introduce()
        {
            String message = "Hello! My name is " + this.name;
            message += ".\nI have " + this.skinColor + " skin.";
            message += "\nMy eyes are " + this.eyeColor + ".";
            message += "\nMy hair is " + this.hairColor + ".";
            message += "\nMy hair is " + this.hairLength.ToString() + " inches long.";
            message += "\nI am " + this.height.ToString() + " feet tall.";
            message += "\nI weigh " + this.weight.ToString() + " pounds.";
            message += "\nI am " + this.age.ToString() + " years old.";
            return message;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People me = new People();
            People you = new People();

            Console.WriteLine(me.introduce());
            Console.WriteLine(you.introduce());

            Console.ReadKey();
        }
    }
}
