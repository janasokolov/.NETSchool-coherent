using PlanetariumMass;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void IsZero_Test()
    {
        Planetarium planet = new Planetarium();
        Assert.IsTrue(planet.IsZero());
    }

    [TestMethod]
    public void IsZero_Test_Negative()
    {
        Planetarium planet = new Planetarium();
        planet.X = 1;
        Assert.IsFalse(planet.IsZero());
    }

    [TestMethod]
    public void DistanceTo_Test()
    {
        Planetarium planet1 = new Planetarium();
        planet1.X = 1;
        planet1.Y = 2;
        planet1.Z = 3;
        planet1.Mass = 10;

        Planetarium planet2 = new Planetarium();
        planet2.X = 4;
        planet2.Y = 5;
        planet2.Z = 6;
        planet2.Mass = 20;

        double distance = planet1.DistanceTo(planet2);
        Assert.AreEqual(5.196152422706632, distance);
    }
}