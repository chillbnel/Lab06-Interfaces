using System;
using Xunit;
using static Lab06_Interfaces.Program;
using Lab06_Interfaces.Classes;
using Lab06_Interfaces;

namespace Lab06Test
{
    public class UnitTest1
    {
        [Fact]
        public void BirdCanMakeSound()
        {
            Assert.Equal("wok wok", BirdSound());
        }

        [Fact]
        public void BirdHasHabitat()
        {
            Assert.Equal("nests", BirdHabitat());
        }

        [Fact]
        public void FishHasFavFood()
        {
            Assert.Equal("worms on a hook", FishFavFood());
        }

        [Fact]
        public void ScaryAF()
        {
            Assert.Equal(16, ArachnidLegs());
        }

    }
}
