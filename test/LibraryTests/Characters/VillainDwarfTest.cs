using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Characters;

[TestClass]
[TestSubject(typeof(VillainDwarf))]
public class VillainDwarfTest
{

    [TestMethod]
    public void VillianDwarf_Creacion()
    {

        var villianDwarf = new VillainDwarf("Fabrizio", 80, 60, 25, new List<IItem>());
        
        Assert.AreEqual("Fabrizio", villianDwarf.Name);
        Assert.AreEqual(80, villianDwarf.Health);
        Assert.AreEqual(60, villianDwarf.AttackValue);
        Assert.AreEqual(25, villianDwarf.DefenseValue);
        
    }
}