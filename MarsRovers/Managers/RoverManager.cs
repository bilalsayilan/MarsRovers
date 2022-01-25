using MarsRovers.Enums;
using MarsRovers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Managers
{
    public class RoverManager
    {
        public RoverManager(Plateau plateau)
        {
            Plateau = plateau;
        }
        public Plateau Plateau { get; set; }

        public void Go(Rover rover, string steps)
        {
            foreach (var step in steps)
            {
                switch (step)
                {
                    case 'M':
                        Move(rover);
                        break;
                    case 'L':
                        SpinLeft(rover);
                        break;
                    case 'R':
                        SpinRight(rover);
                        break;
                }
            }

        }

        private void SpinRight(Rover rover)
        {
            rover.Way = (Way)(((int)rover.Way + 1) % 4);
        }

        private void SpinLeft(Rover rover)
        {
            rover.Way = (Way)(rover.Way == 0 ? 3 : ((int)rover.Way - 1));
        }

        private void Move(Rover rover)
        {
            switch (rover.Way)
            {
                case Way.N:
                    rover.Y = rover.Y < Plateau.Y1 ? rover.Y + 1 : Plateau.Y1;
                    break;
                case Way.E:
                    rover.X = rover.X < Plateau.X1 ? rover.X + 1 : Plateau.X1;
                    break;
                case Way.S:
                    rover.Y = rover.Y > Plateau.Y ? rover.Y - 1 : Plateau.Y;

                    break;
                case Way.W:
                    rover.X = rover.X > Plateau.X ? rover.X - 1 : Plateau.X;
                    break;
                default:
                    break;
            }
        }

    }
}
