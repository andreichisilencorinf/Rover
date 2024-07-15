using System;
using System.ComponentModel;
using MarsMission.Enums;
using MarsMission.Interfaces;

namespace MarsMission
{
    public class Rover
    {
        public Position Position { get; private set; }
        public Direction Facing { get; private set; }
        private readonly ICommandTokenizer _commandTokenizer;
        private readonly IEnumerable<ICommandResolver> _commandResolvers;
        public Rover(int x, int y, Direction facing)
        {
            Position = new Position(x, y);
            Facing = facing;
            _commandTokenizer = new CommandTokenizer();
            _commandResolvers = new List<ICommandResolver>
            {
                new LeftCommandResolver(),
                new RightCommandResolver(),
                new MoveCommandResolver()
            };
        }

        public void Move(string commands)
        {
            var parsedCommands = _commandTokenizer.GetCommands(commands);
            foreach (var command in parsedCommands)
            {
                var commandResolver = _commandResolvers.FirstOrDefault(cr => cr.SupportedCommand == command);
                if (commandResolver is null)
                {
                    throw new InvalidEnumArgumentException($"Invalid command for {nameof(Rover)}.command: {command}");
                }

                var newLocation = commandResolver.Resolve(Position, Facing);
                Position = newLocation.Item1;
                Facing = newLocation.Item2;
            }
        }

        public override string ToString()
        {
            return $"Position: ({Position.X}, {Position.Y}), Facing: {Facing}";
        }
    }
}