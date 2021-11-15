using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework10Duel
{
    class Duelist
    {
        private string name;
        private double shootingaccuracy;
        private bool isAlive;
        private Random rnd;

        //constructors
        public Duelist() {
            //Create one Random class object for use with this Duelist
            rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        }
        public Duelist(string s, double acc, bool b)
        {
            name = s;
            shootingaccuracy = acc;
            isAlive = b;
        
            //Create one Random class object for use with this Duelist
            rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        }

        public string Name { get => name; set => name = value; }
        public double ShootingAccuracy { get => shootingaccuracy; set => shootingaccuracy = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }

        public void ShootAtTarget(Duelist target) 
        {
            // Console.WriteLine("--------------");
            // Console.WriteLine("this: " + this.name + " target: " + target.name + " " + target.IsAlive.ToString());

            //Get a random number, and check if it is less than the shooter's shooting accuracy 
            //If the new random number is <= the shooting accuracy, then the target is hit; if not, the target is not hit!
            //Random rnd2 = new Random(); // ((int)DateTime.Now.Ticks & 0x0000FFFF);

            double dRand = rnd.NextDouble();
            //Console.WriteLine(dRand.ToString());

            bool Hit_result = (dRand <= shootingaccuracy) ? true: false;
            // Console.WriteLine("this " + this.Name + " " + this.shootingaccuracy.ToString() + " " + this.isAlive.ToString() + " " + dRand.ToString());

            //If the target is hit, set the target's status to dead
            if (Hit_result == true)
                if (target.IsAlive) target.IsAlive = false;

            //Console.WriteLine("*******Target's changed status = " + target.IsAlive.ToString());
            //Console.WriteLine();

        }

    }
}
