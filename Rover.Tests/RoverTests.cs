namespace Rover.Tests
{
    public class RoverTests
    {
        [Fact]
        public void Move_WithValidData_ChangesPosition()
        {
            //Arrange
            MarsMission.Rover rover = new MarsMission.Rover(0, 0, 'N');
            var destination = new MarsMission.Rover(0, 1, 'N');

            //Act
            rover.Move("LMLMLMLMM");

            //Assert
            Assert.Equal(destination.X, rover.X);
            Assert.Equal(destination.Y, rover.Y);
            Assert.Equal(destination.Direction, rover.Direction);
        }
    }
}