using System;
using System.ComponentModel;
using MarsMission.Enums;
using MarsMission.Interfaces;

namespace MarsMission
{
    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }
        private readonly ICommandTokenizer _commandTokenizer;

        public Rover(int x, int y, Direction facing)
        {
            X = x;
            Y = y;
            Facing = facing;
            _commandTokenizer = new CommandTokenizer();
        }

        public void Move(string commands)
        {
            var parsedCommands = _commandTokenizer.GetCommands(commands);
            foreach (var command in parsedCommands)
            {
                switch (command)
                {
                    case CommandType.L:
                        TurnLeft();
                        break;
                    case CommandType.R:
                        TurnRight();
                        break;
                    case CommandType.M:
                        MoveForward();
                        break;
                    default:
                        throw new InvalidEnumArgumentException(
                            $"Invalid command for {nameof(Rover)}.command: {command}");
                }
            }
        }

        private void TurnLeft()
        {
            switch (Facing)
            {
                case Direction.N:
                    Facing = Direction.W;
                    break;
                case Direction.S:
                    Facing = Direction.E;
                    break;
                case Direction.E:
                    Facing = Direction.N;
                    break;
                case Direction.W:
                    Facing = Direction.S;
                    break;
            }
        }

        private void TurnRight()
        {
            switch (Facing)
            {
                case Direction.N:
                    Facing = Direction.E;
                    break;
                case Direction.S:
                    Facing = Direction.W;
                    break;
                case Direction.E:
                    Facing = Direction.S;
                    break;
                case Direction.W:
                    Facing = Direction.N;
                    break;
            }
        }

        private void MoveForward()
        {
            switch (Facing)
            {
                case Direction.N:
                    Y++;
                    break;
                case Direction.S:
                    Y--;
                    break;
                case Direction.E:
                    X++;
                    break;
                case Direction.W:
                    X--;
                    break;
            }
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Rover Position: {X}, {Y}, {Facing}");
        }
    }
}