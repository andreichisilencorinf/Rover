using System;

namespace MarsMission
{
    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Direction { get; private set; }

        public Rover(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void Move(string commands)
        {
            foreach (char command in commands)
            {
                if (command == 'L')
                {
                    TurnLeft();
                }
                else if (command == 'R')
                {
                    TurnRight();
                }
                else if (command == 'M')
                {
                    MoveForward();
                }
            }
        }

        private void TurnLeft()
        {
            if (Direction == 'N') Direction = 'W';
            else if (Direction == 'W') Direction = 'S';
            else if (Direction == 'S') Direction = 'E';
            else if (Direction == 'E') Direction = 'N';
        }

        private void TurnRight()
        {
            if (Direction == 'N') Direction = 'E';
            else if (Direction == 'E') Direction = 'S';
            else if (Direction == 'S') Direction = 'W';
            else if (Direction == 'W') Direction = 'N';
        }

        private void MoveForward()
        {
            if (Direction == 'N') Y += 1;
            else if (Direction == 'E') X += 1;
            else if (Direction == 'S') Y -= 1;
            else if (Direction == 'W') X -= 1;
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Rover Position: {X}, {Y}, {Direction}");
        }
    }
}