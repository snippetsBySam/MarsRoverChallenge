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

        }

        public void RotateRight()
        {
            Console.WriteLine($"Heading Before {Heading.ToString()}");
        }
    }
}
