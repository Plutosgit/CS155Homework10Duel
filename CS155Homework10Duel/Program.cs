using System;

namespace CS155Homework10Duel
{
    class Program
    {
        const int NUM_DUELS = 10000;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Homework10 Duel!");

            int bWinner = 0;
            int Winner1,Winner2,Winner3;
            double d1, d2, d3;
            string s1, s2, s3;

            Duelist Aaron = new Duelist("Aaron", 0.3333, true);
            Duelist Bob = new Duelist("Bob", 0.50, true);
            Duelist Charlie = new Duelist("Charlie", 0.995, true);

            //Init count
            Winner1 = 0;
            Winner2 = 0;
            Winner3 = 0;

            for (int i = 0; i < NUM_DUELS; i++)
            {

                //Reset
                bWinner = 0;
                Aaron.IsAlive = true;
                Bob.IsAlive = true;
                Charlie.IsAlive = true;
                
                do
                {
                    //Aaron, Bob, Charlie get to shoot in that order..
                    if (Aaron.IsAlive)
                    {
                        if (Charlie.IsAlive)
                            Aaron.ShootAtTarget(Charlie);
                        else if (Bob.IsAlive)
                            Aaron.ShootAtTarget(Bob);
                        else
                            bWinner = 1;
                    }

                    if (Bob.IsAlive)
                    {
                        if (Charlie.IsAlive)
                            Bob.ShootAtTarget(Charlie);
                        else if (Aaron.IsAlive)
                            Bob.ShootAtTarget(Aaron);
                        else
                            bWinner = 2;
                    }

                    if (Charlie.IsAlive)
                    {
                        if (Bob.IsAlive)
                            Charlie.ShootAtTarget(Bob);
                        else if (Aaron.IsAlive)
                            Charlie.ShootAtTarget(Aaron);
                        else
                            bWinner = 3;
                    }
                } while (bWinner == 0);

                //Console.Write("The winner is: ");
                //Console.WriteLine(bWinner);
                if (bWinner == 1) Winner1++;
                if (bWinner == 2) Winner2++;
                if (bWinner == 3) Winner3++;

            }
            Console.WriteLine("Report Out");
            Console.WriteLine("----------");
            Console.WriteLine("Number of duels: " + NUM_DUELS.ToString());

            d1 = (double)Winner1 / NUM_DUELS * 100.0;
            d2 = (double)Winner2 / NUM_DUELS * 100.0;
            d3 = (double)Winner3 / NUM_DUELS * 100.0;

            s1 = d1.ToString("#0.0");
            s2 = d2.ToString("#0.0");
            s3 = d3.ToString("#0.0");

            Console.WriteLine("Winning Probability: Aaron = " + s1 + "%" + "    Bob = " + s2 + "%" + "    Charlie = " + s3 + "%");
            
            Console.WriteLine();
            
            //**************************************************************************************

            Console.WriteLine("****************");
            Console.WriteLine("Now, Aaron misses his first shoot..");

            //Reset count
            Winner1 = 0;
            Winner2 = 0;
            Winner3 = 0;

            for (int i = 0; i < NUM_DUELS; i++)
            {

                //Reset
                bWinner = 0;
                Aaron.IsAlive = true;
                Bob.IsAlive = true;
                Charlie.IsAlive = true;

                do
                {
                    //Aaron, Bob, Charlie get to shoot in that order..
                    if (Aaron.IsAlive)
                    {
                        if (i != 0) //Aaron misses first time intentionally
                        { 
                            if (Charlie.IsAlive)
                                Aaron.ShootAtTarget(Charlie);
                            else if (Bob.IsAlive)
                                Aaron.ShootAtTarget(Bob);
                            else
                                bWinner = 1;
                        }
                    }

                    if (Bob.IsAlive)
                    {
                        if (Charlie.IsAlive)
                            Bob.ShootAtTarget(Charlie);
                        else if (Aaron.IsAlive)
                            Bob.ShootAtTarget(Aaron);
                        else
                            bWinner = 2;
                    }

                    if (Charlie.IsAlive)
                    {
                        if (Bob.IsAlive)
                            Charlie.ShootAtTarget(Bob);
                        else if (Aaron.IsAlive)
                            Charlie.ShootAtTarget(Aaron);
                        else
                            bWinner = 3;
                    }
                } while (bWinner == 0);

                //Console.Write("The winner is: ");
                //Console.WriteLine(bWinner);
                if (bWinner == 1) Winner1++;
                if (bWinner == 2) Winner2++;
                if (bWinner == 3) Winner3++;

            }
            Console.WriteLine("Report Out");
            Console.WriteLine("----------");
            Console.WriteLine("Number of duels: " + NUM_DUELS.ToString());

            d1 = (double)Winner1 / NUM_DUELS * 100.0;
            d2 = (double)Winner2 / NUM_DUELS * 100.0;
            d3 = (double)Winner3 / NUM_DUELS * 100.0;

            s1 = d1.ToString("#0.0");
            s2 = d2.ToString("#0.0");
            s3 = d3.ToString("#0.0");

            Console.WriteLine("Winning Probability (Aaron miss first time): Aaron = " + s1 + "%" + "    Bob = " + s2 + "%" + "    Charlie = " + s3 + "%");

            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
