using Foxbit.Domain.Entities;
using Foxbit.Domain.Enums;

namespace Foxbit.Tests
{
    public class RoverTest
    {
        [Fact]
        public void TestSnarioRotate90left()
        {
            Rover rover = new Rover(1, 2, Directions.NORTH);

            rover.SpinLeft();

            Assert.Equal(Directions.WEST, rover.Direction);
        }

        [Fact]
        public void TestSnarioRotate90Right()
        {
            Rover rover = new Rover(1, 2, Directions.NORTH);

            rover.SpinRight();

            Assert.Equal(Directions.EAST, rover.Direction);
        }


        [Fact]
        public void TestSnarioInSameDirection()
        {
            Rover rover = new Rover(1, 2, Directions.NORTH);

            rover.MoveInSameDirection();

            Assert.Equal(3, rover.PositionY);
        }

        [Fact]
        public void TestScanrioMMRMMRMRRM()
        {
            Rover rover = new Rover(3, 3, Directions.EAST);

            rover.Move("MMRMMRMRRM");

            Assert.Equal("5 1 EAST", $"{rover.PositionX} {rover.PositionY} {rover.Direction}");
        }


        [Fact]
        public void TestScanrioLMLMLMLMM()
        {
            Rover rover = new Rover(1, 2, Directions.NORTH);

            rover.Move("LMLMLMLMM");

            Assert.Equal("1 3 NORTH", $"{rover.PositionX} {rover.PositionY} {rover.Direction}");
        }

    }
}