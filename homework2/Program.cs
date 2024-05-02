namespace PlanetariumMass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planetarium pl = new Planetarium();
            pl.X = 1;
            pl.Y = 2;
            pl.Z = 3;
            pl.Mass = 10;

            Planetarium pl2 = new Planetarium();
            pl2.X = 4;
            pl2.Y = 5;
            pl2.Z = 6;
            pl2.Mass = 20;

            double distance = pl.DistanceTo(pl2);
            Console.WriteLine("Distance between two points: " + distance);

            Console.WriteLine((int)Math.Sqrt(1 * 2 + 3 * 4 + 5 * 6));
        }
    }
}
