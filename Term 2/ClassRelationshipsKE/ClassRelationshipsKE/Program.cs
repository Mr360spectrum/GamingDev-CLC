using System;

namespace Game
{
    public class Weapon
    {
        protected double damage;
        protected double range;
        protected double rateOfFire;
        protected int accuracy;
        public String model;

        public double getRateOfFire()
        {
            return this.rateOfFire;
        }

        public void setRateOfFire(double rof)
        {
            if (this.model.Equals("gun"))
            {
                this.rateOfFire = rof;
            }
        }

        public int getAccuracy()
        {
            return this.accuracy;
        }

        public void setAccuracy(int acu)
        {
            if (this.model.Equals("gun"))
            {
                this.accuracy = acu;
            }
        }
    }

    public class Clip
    {
        private int currentAmmo;
        private int ammoCap;

        public void setCurrentAmmo(int ammo)
        {
            this.currentAmmo += ammo;
        }
    }

    public class Knife : Weapon
    {
        public Knife()
        {
            Console.WriteLine("Used default constructor");
        }

        public Knife(double rof, int acu)
        {
            setRateOfFire(rof);
            setAccuracy(acu);
        }
        public Knife(double rof, int acu, string model, double damage, double range)
        {
            setRateOfFire(rof);
            setAccuracy(acu);
        }
    }

    public class Gun : Weapon
    {
        Clip clip = new Clip();
        private int ammoCap;
        private int currentCap;

        public Gun()
        {
            this.damage = 50;
            this.range = 100;
        }

        public void pullTrigger(Player target)
        {
            clip.setCurrentAmmo(-1);
            target.takeDamage();
        }

        public void setTarget(Player target)
        {
            this.target = target;
        }
    }

    class Player
    {
        Gun handgun = new Gun();
        int health = 100;
        public Player target = new Player();

        public void shoot()
        {
            handgun.pullTrigger(this.target);
        }

        public void takeDamage()
        {
            this.health--;
        }


    }

    public class PlayGame
    {
        public PlayGame()
        {
            Gun handgun = new Gun();
            Knife knife1 = new Knife();
            Knife knife2 = new Knife(25.5, 55);
            Knife knife3 = new Knife(50, 25, "k bar", 100.5, 25.0);
        }
        public static void Main(String[] args)
        {
            new PlayGame();
        }
    }

}
