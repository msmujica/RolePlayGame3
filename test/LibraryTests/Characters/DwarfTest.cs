using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Characters;

[TestClass]
[TestSubject(typeof(Dwarf))]
public class DwarfTest
{

    [TestMethod]
    public void Dwarf_Creacion()
    {

        var dwarf = new Dwarf("Ariel", 80, 60, 25, new List<IItem>());
        
        Assert.AreEqual("Ariel", dwarf.Name);
        Assert.AreEqual(80, dwarf.Health);
        Assert.AreEqual(60, dwarf.AttackValue);
        Assert.AreEqual(25, dwarf.DefenseValue);
        
    }
}