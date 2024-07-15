using MarsMission.Enums;
using MarsMission.Interfaces;

namespace MarsMission.Tests;

public class CommandTokenizerTests
{
    [Fact]
    public void GetCommands_WithValidData_ReturnsCorrectCommands()
    {
        //Arrange
        var commandTokenizer = new CommandTokenizer();
        var expectedCommands = new List<CommandType>
        {
            CommandType.M,
            CommandType.M,
            CommandType.L,
            CommandType.M,
            CommandType.M
        };

        //Act
        var parsedCommands = commandTokenizer.GetCommands("MMLMM");

        //Assert
        Assert.Equal(expectedCommands, parsedCommands);
    }

    [Fact]
    public void GetCommands_WithInvalidData_ReturnsException()
    {
        //Arrange
        var commandTokenizer = new CommandTokenizer();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => commandTokenizer.GetCommands("MKLMM"));
    }
}