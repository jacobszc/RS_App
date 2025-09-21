using System;

namespace myApp
{
    class Chance
    {
        public double Lvl;
        public double Points;

        
        public Chance()
        {
            Lvl = 0;
            Points = 0;
        }

        public double PurpleChance()
        {
            double scaledRaidLevel = 0;
            const double LowScalar = 310;
            const double HighScalar = 430;

            Console.Write("Enter your total raid points: ");
            string line = Console.ReadLine();
            Points = double.Parse(line);
            Console.WriteLine("points: " + Points + Environment.NewLine);

            Console.Write("Enter your Raid lvl: ");
            line = Console.ReadLine();
            Lvl = double.Parse(line);
            Console.WriteLine("lvl: " + Lvl);

            double percentChance = 0;

            if (Lvl < 310)
            {
                return LowScalar;  // dont forget to fix this
            }

            if (Lvl >= 310 && Lvl < 430)
            {
                scaledRaidLevel = LowScalar + ((Lvl - 310) / 3);
                double purpleChance = 10500 - (20 * scaledRaidLevel);
                percentChance = Points / purpleChance;
                Console.WriteLine("you raid level was: " + Lvl + Environment.NewLine +
                                  "you earned: " + Points + " points." + Environment.NewLine +
                                  "your scaled raid level is:" + scaledRaidLevel + Environment.NewLine +
                                  "this means you have a 1% chance at a purple for every " + purpleChance +
                                  " points earned " + Environment.NewLine +
                                  "your chance at a purple is: " + percentChance + "%");
            }

            if (Lvl >= 430)
            {
                scaledRaidLevel = 310 + ((430 + ((Lvl - 430) / 2) - 310) / 3);
                double purpleChance = 10500 - (20 * scaledRaidLevel);
                percentChance = Points / purpleChance;
                Console.WriteLine("you raid level was: " + Lvl + Environment.NewLine +
                                  "you earned: " + Points + " points." + Environment.NewLine +
                                  "your scaled raid level is:" + scaledRaidLevel + Environment.NewLine +
                                  "this means you have a 1% chance at a purple for every " + purpleChance +
                                  " points earned " + Environment.NewLine +
                                  "your chance at a purple is: " + percentChance + "%");
            }

            return percentChance; 
        }
    }
}
