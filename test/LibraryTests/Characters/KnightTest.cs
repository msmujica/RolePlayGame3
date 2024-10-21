using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Characters;

[TestClass]
[TestSubject(typeof(Knight))]
public class KnightTest
{

    [TestMethod]
    public void Knight_Creacion()
    {

        var knight = new Knight("Aragorn", 80, 60, 25, new List<IItem>());
        
        Assert.AreEqual("Aragorn", knight.Name);
        Assert.AreEqual(80, knight.Health);
        Assert.AreEqual(60, knight.AttackValue);
        Assert.AreEqual(25, knight.DefenseValue);
        
    }
}