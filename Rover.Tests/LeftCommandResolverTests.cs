using MarsMission.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMission.Enums;

namespace MarsMission.Tests
{
    public class LeftCommandResolverTests
    {
        [Fact]
        public void Resolve_WithValidData_MovesCorrectlyToTheLeft()
        {
            //Arrange
            var position = new Position(1, 1);
            var facing = Direction.N;
            var resolver = new LeftCommandResolver();
            var expectedFacing = Direction.W;

            //Act
            var result = resolver.Resolve(position, facing);

            //Assert
            Assert.Equal(result.Item2, expectedFacing);
        }
    }
}
