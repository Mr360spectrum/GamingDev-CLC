using System;

namespace ArraysKE
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 100;
            bool minecraftInList = false;
            //String[] gamesArray = new string[20] {"Minecraft (Java Edition)", "Breath of the Wild", "The Master Chief Collection", "Horizon Zero Dawn", "Beat Saber",
            //    "Super Mario Galaxy 1/2", "Destiny", "RollerCoaster Tycoon 2", "A Hat in Time", "Myst", "Tetris 99", "Super Mario Odyssey", "Mario Kart 7",
            //    "Superhot VR", "Titanfall 2", "Terraria", "Super Smash Bros. Ultimate", "Super Mario World", "Yoshi's Island", "Super Mario Bros. 3"};

            String[,] gamesArray = new string[10, 2];


            gamesArray[0, 0] = "Minecraft (Java Edition)";
            gamesArray[0, 1] = "Mojang";
            gamesArray[1, 0] = "Breath of the Wild";
            gamesArray[1, 1] = "Nintendo";
            gamesArray[2, 0] = "The Master Chief Collection";
            gamesArray[2, 1] = "343 Industries/Bungie";
            gamesArray[3, 0] = "Horizon Zero Dawn";
            gamesArray[3, 1] = "Guerrilla";
            gamesArray[4, 0] = "Beat Saber";
            gamesArray[4, 1] = "Beat Games";
            gamesArray[5, 0] = "Super Mario Galaxy 1/2"; //Both are just too good...
            gamesArray[5, 1] = "Nintendo";
            gamesArray[6, 0] = "Destiny";
            gamesArray[6, 1] = "Bungie";
            gamesArray[7, 0] = "RollerCoaster Tycoon 2";
            gamesArray[7, 1] = "Chris Sawyer";
            gamesArray[8, 0] = "A Hat in Time";
            gamesArray[8, 1] = "Gears for Breakfast";
            gamesArray[9, 0] = "Myst";
            gamesArray[9, 1] = "Cyan";

            for (int i = 0; i < gamesArray.Length; i++) {
                Console.WriteLine(gamesArray[i]);
            }

            foreach (String x in gamesArray)
            {
                int i = 0;
                if (x.Contains("Pokemon"))
                {
                    points -= 10;
                }
                if (x.Equals("Minecraft (Java Edition)"))
                {
                    points += 10;
                    minecraftInList = true;
                }

            }

            if (!minecraftInList)
            {
                points = points -= 20;
            }

            Console.WriteLine("\n" + points);
            Console.ReadKey();
        }
    }
}
