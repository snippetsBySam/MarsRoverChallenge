using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge
{
    public enum Orientation
    {
        N = 0,
        E = 1,
        S = 2,
        W = 3
    }
    public class Vehicle
    {
        private int XPosition;
        private int YPosition;
        private Orientation Heading;

        public Vehicle(int xPosition, int yPosition, Orientation heading)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            Heading = heading;
        }

        public void Move(string instructions)
        {
            foreach (char instruction in instructions)
            {
                switch (instruction)
                {
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                }
            }
            Console.WriteLine($"{XPosition} {YPosition} {Heading.ToString()}");
        }

        public void MoveForward()
        {
            switch (Heading)
            {
                case Orientation.N:
                    YPosition++;
                    break;
                case Orientation.E:
                    XPosition++;
                    break;
                case Orientation.S:
                    YPosition--;
                    break;
                case Orientation.W:
                    XPosition--;
                    break;
            }
        }

        public void RotateLeft()
        {
            if (Heading == Orientation.N)
            {
                Heading = Orientation.W;
            }
            else
            {
                Heading--;
            }
        }

        public void RotateRight()
        {
            if (Heading == Orientation.W)
            {
                Heading = Orientation.N;
            }
            else
            {
                Heading++;
            }
        }
    }
}
