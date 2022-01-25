using MarsRovers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Models
{
  public  class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Way Way { get; set; }
        public string CurrentPosition { get { return $"{X} {Y} {Way}"; } }
    }
}
