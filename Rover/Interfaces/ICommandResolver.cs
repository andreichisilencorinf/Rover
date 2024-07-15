using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMission.Enums;

namespace MarsMission.Interfaces
{
    internal interface ICommandResolver
    {
        public CommandType SupportedCommand { get;}
        Tuple<Position, Direction> Resolve(Position position, Direction facing);
    }

    internal class LeftCommandResolver : ICommandResolver
    {
        public CommandType SupportedCommand => CommandType.L;

        public Tuple<Position, Direction> Resolve(Position position, Direction facing)
        {
            switch (facing)
            {
                case Direction.N:
                    facing = Direction.W;
                    break;
                case Direction.S:
                    facing = Direction.E;
                    break;
                case Direction.E:
                    facing = Direction.N;
                    break;
                case Direction.W:
                    facing = Direction.S;
                    break;
            }
            return Tuple.Create(position, facing);
        }
    }

    internal class RightCommandResolver : ICommandResolver
    {
        public CommandType SupportedCommand => CommandType.R;

        public Tuple<Position, Direction> Resolve(Position position, Direction facing)
        {
            switch (facing)
            {
                case Direction.N:
                    facing = Direction.E;
                    break;
                case Direction.S:
                    facing = Direction.W;
                    break;
                case Direction.E:
                    facing = Direction.S;
                    break;
                case Direction.W:
                    facing = Direction.N;
                    break;
            }

            return Tuple.Create(position, facing);
        }
    }

    internal class MoveCommandResolver : ICommandResolver
    {
        public CommandType SupportedCommand => CommandType.M;

        public Tuple<Position, Direction> Resolve(Position position, Direction facing)
        {
            switch (facing)
            {
                case Direction.N:
                    position.Y++;
                    break;
                case Direction.S:
                    position.Y--;
                    break;
                case Direction.E:
                    position.X++;
                    break;
                case Direction.W:
                    position.X--;
                    break;
            }

            return Tuple.Create(position, facing);
        }
    }
}
