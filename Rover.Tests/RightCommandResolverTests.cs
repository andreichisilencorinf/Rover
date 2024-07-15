using MarsMission.Enums;
using MarsMission.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Tests
{
    public class RightCommandResolverTests
    {
        [Fact]
        public void Resolve_WithValidData_MovesCorrectlyToTheRight()
        {
            //Arrange
            var position = new Position(1, 1);
            var facing = Direction.N;
            var resolver = new RightCommandResolver();
            var expectedFacing = Direction.E;

            //Act
            var result = resolver.Resolve(position, facing);

            //Assert
            Assert.Equal(result.Item2, expectedFacing);
        }
    }
}
