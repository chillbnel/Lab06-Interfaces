using System;
using Lab06_Interfaces.Classes;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BirdSwallow Swallow = new BirdSwallow();
            Swallow.IsEndangered = true;
            Swallow.livesInWater = false;
            Swallow.livesOnLand = true;
            Swallow.Migrates = true;

            BirdTurkey Turkey = new BirdTurkey();
            Turkey.livesInWater = false;
            Turkey.livesOnLand = true;
            Turkey.Migrates = true;
            Turkey.IsEndangered = false;
            Turkey.IsBrianScaredofIt = true;

            FishGobidine Gobidine = new FishGobidine();
            Gobidine.IsBrianScaredofIt = false;
            Gobidine.IsEndangered = true;
            Gobidine.livesInWater = true;
            Gobidine.livesOnLand = false;
            Gobidine.Migrates = false;

        }
    }
}
