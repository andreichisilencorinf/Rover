namespace MarsMission.Tests
{
    public class RoverTests
    {
        [Fact]
        public void Move_WithValidData_ChangesPosition()
        {
            //Arrange
            Rover rover = new Rover(0, 0, 'N');
            var destination = new Rover(0, 1, 'N');

            //Act
            rover.Move("LMLMLMLMM");

            //Assert
            Assert.Equal(destination.X, rover.X);
            Assert.Equal(destination.Y, rover.Y);
            Assert.Equal(destination.Direction, rover.Direction);
        }
    }
}