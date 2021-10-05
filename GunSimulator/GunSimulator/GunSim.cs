using System;
using System.Collections.Generic;
using System.Text;

namespace GunSimulator
{
    class GunSim
    {
        private int numofbullets;

        public GunSim(int bullets)
        {
            numofbullets = bullets;
            Console.WriteLine("**Let's start shooting**");
        }
        public void PistolCharge()
        {
            if (numofbullets == 15)
            {
                Console.WriteLine("Charger is fulled");
            }
            else if (numofbullets < 15)
            {
                Console.WriteLine("Fill the charger!!!");

                return;
            }
            else
            {
                Console.WriteLine("Charger cannot take more than 15 bullets!!!");
                return;
            }
            Console.WriteLine("Number of bullets:");
            Console.WriteLine(numofbullets);
        }
        public void PistolShut()
        {
            for (int i = 6; i >= 0; i--)//Tutaq ki,6 maqazin var ve her maqazinin gulle tutumu 15-dir.
            {
                if (numofbullets < 15 || numofbullets > 15)
                {
                    return;
                }
                else
                {
                    for (int j = numofbullets; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            Console.WriteLine($"{j}{" bullet left in the charger"}");
                            Console.WriteLine("Pistol need to be recharged:");
                            PistolCharge();
                        }
                    }
                }
            }
            Console.WriteLine("There is no charger left anymore");
            return;
        }
    }
        
} 
