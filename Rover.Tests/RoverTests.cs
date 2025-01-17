using MarsMission.Enums;

namespace MarsMission.Tests
{
    public class RoverTests
    {
        [Fact]
        public void Move_WithValidData_ChangesPosition()
        {
            //Arrange
            Rover rover = new Rover(0, 0, Direction.N);
            var destination = new Rover(0, 1, Direction.N);

            //Act
            rover.Move("LMLMLMLMM");

            //Assert
            Assert.Equal(destination.Position.X, rover.Position.X);
            Assert.Equal(destination.Position.Y, rover.Position.Y);
            Assert.Equal(destination.Facing, rover.Facing);
        }

        [Fact]
        public void ToString_WithValidData_DisplaysCorrectlyThePosition()
        {
            //Arrange
            Rover rover = new Rover(3, 2, Direction.W);

            //Act
            var result = rover.ToString();

            //Assert
            Assert.Equal("Position: (3, 2), Facing: W", result);
        }
    }
}