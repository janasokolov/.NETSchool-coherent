using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetariumMass
{
    public class Planetarium
    {
        private int[] coordinates = new int[3];
        private double _mass;
        public int X
        {
            get { return coordinates[0]; }
            set { coordinates[0] = value; }
        }

        public int Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }

        public int Z
        {
            get { return coordinates[2]; }
            set { coordinates[2] = value; }
        }
        public double Mass
        {
            get { return _mass; }
            set { _mass = Math.Max(value,0); }
        }

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0;
        }

        public double DistanceTo(Planetarium otherPoint)
        {
            int xDiff = X - otherPoint.X;
            int yDiff = Y - otherPoint.Y;
            int zDiff = Z - otherPoint.Z;

            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
        }

        
    }
}
