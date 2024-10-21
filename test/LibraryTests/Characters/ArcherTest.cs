using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Characters;

[TestClass]
[TestSubject(typeof(Archer))]
public class ArcherTest
{

    [TestMethod]
    public void Archer_Creacion()
    {
        var archer = new Archer("Legolas", 80, 60, 25, new List<IItem>());

        Assert.AreEqual("Legolas", archer.Name);
        Assert.AreEqual(80, archer.Health);
        Assert.AreEqual(60, archer.AttackValue);
        Assert.AreEqual(25, archer.DefenseValue);
        
    }
}