using NUnit.Framework;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests;

public class SpecificCharacterTests
{
    public void Archer_Creacion()
    {
        var archer = new Archer("Legolas", 80, 60, 25, new List<IItem>());

        Assert.AreEqual("Legolas", archer.Name);
        Assert.AreEqual(80, archer.Health);
        Assert.AreEqual(60, archer.AttackValue);
        Assert.AreEqual(25, archer.DefenseValue);
        
    }


    public void VillianArcher_Creacion()
    {

        var villianArcher = new VillainArcher("Salogel", 80, 60, 25, new List<IItem>());
        
        Assert.AreEqual("Salogel", villianArcher.Name);
        Assert.AreEqual(80, villianArcher.Health);
        Assert.AreEqual(60, villianArcher.AttackValue);
        Assert.AreEqual(25, villianArcher.DefenseValue);
        
    }
}