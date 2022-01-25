using MarsRovers.Enums;
using MarsRovers.Managers;
using MarsRovers.Models;
using System;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Console.ReadLine()?.Split(' ');
            var plateau = new Plateau() { X = 0, Y = 0, X1 = int.Parse(p[0]), Y1 = int.Parse(p[1]) };
            var roverManager = new RoverManager(plateau);

            var r1Location = Console.ReadLine()?.Split(' ');
            var r1Steps = Console.ReadLine()?.ToUpper();
            var r1 = new Rover() { X = int.Parse(r1Location[0]), Y = int.Parse(r1Location[1]), Way = Enum.Parse<Way>(r1Location[2]) };

            var r2Location = Console.ReadLine()?.Split(' ');
            var r2Steps = Console.ReadLine()?.ToUpper();
            var r2 = new Rover() { X = int.Parse(r2Location[0]), Y = int.Parse(r2Location[1]), Way = Enum.Parse<Way>(r2Location[2]) };

            roverManager.Go(r1, r1Steps);
            Console.WriteLine(r1.CurrentPosition);

            roverManager.Go(r2, r2Steps);
            Console.WriteLine(r2.CurrentPosition);
        }
    }
}
