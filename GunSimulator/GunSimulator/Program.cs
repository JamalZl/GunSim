using System;

namespace GunSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            GunSim gs = new GunSim(15);
            gs.PistolCharge();
            gs.PistolShut(); 
            //gs.PistolCharge();

        }   
    }
}
