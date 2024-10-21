using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Characters;

[TestClass]
[TestSubject(typeof(VillainArcher))]
public class VillainArcherTest
{

    [TestMethod]
    public void VillianArcher_Creacion()
    {

        var villianArcher = new VillainArcher("Salogel", 80, 60, 25, new List<IItem>());
        
        Assert.AreEqual("Salogel", villianArcher.Name);
        Assert.AreEqual(80, villianArcher.Health);
        Assert.AreEqual(60, villianArcher.AttackValue);
        Assert.AreEqual(25, villianArcher.DefenseValue);
        
    }
}
