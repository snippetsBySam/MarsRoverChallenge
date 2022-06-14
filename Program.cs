// See https://aka.ms/new-console-template for more information
using MarsRoverChallenge;

Console.WriteLine("Hello, World!");
//Request line inputs

Vehicle rover1 = new Vehicle(1, 2, Orientation.N);
rover1.Move("LMLMLMLMM");

Vehicle rover2 = new Vehicle(3, 3, Orientation.E);
rover2.Move("MMRMMRMRRM");
//rover.RotateRight();
//rover.RotateLeft();
