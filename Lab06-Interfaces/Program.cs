using System;
using Lab06_Interfaces.Classes;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces
{
    public class Program
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

            FishGoldfish Goldfish = new FishGoldfish();
            Goldfish.IsEndangered = false;
            Goldfish.livesInWater = true;
            Goldfish.livesOnLand = false;
            Goldfish.Migrates = false; 

        }

        public static string BirdSound()
        {
            BirdSwallow newSwallow = new BirdSwallow();
            return newSwallow.Sound();
        }

        public static string BirdHabitat()
        {
            BirdTurkey newTurkey = new BirdTurkey();
            return newTurkey.Habitat();
        }

        public static string FishFavFood()
        {
            FishGoldfish newGoldfish = new FishGoldfish();
            return newGoldfish.FavoriteFood();
        }

        public static int ArachnidLegs()
        {
            InsectArachnidManEatingDeathMonster BriansNightmare = new InsectArachnidManEatingDeathMonster();
            return BriansNightmare.NumberOfLegs();
        }

        public static bool SwallowInherit()
        {
            BirdSwallow Swallow = new BirdSwallow();
            Swallow.IsEndangered = true;
            return Swallow.IsEndangered;
        }
    }
}
