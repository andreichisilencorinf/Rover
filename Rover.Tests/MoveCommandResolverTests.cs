using MarsMission.Enums;
using MarsMission.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Tests
{
    public class MoveCommandResolverTests
    {
        [Fact]
        public void Resolve_WithValidData_MovesCorrectlyWithOneUnit()
        {
            //Arrange
            var position = new Position(1, 1);
            var facing = Direction.E;
            var resolver = new MoveCommandResolver();
            var expectedPosition = new Position(2, 1);

            //Act
            var result = resolver.Resolve(position, facing);

            //Assert
            Assert.Equal(result.Item1, expectedPosition);
        }
    }
}
