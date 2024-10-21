using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Characters;

[TestClass]
[TestSubject(typeof(VillainKnight))]
public class VillainKnightTest
{

    [TestMethod]
    public void VillianKnight_Creacion()
    {

        var villianKnight = new VillainKnight("Joel", 80, 60, 25, new List<IItem>());
        
        Assert.AreEqual("Joel", villianKnight.Name);//Verifica
        Assert.AreEqual(80, villianKnight.Health); // Verifica que su vida sea 80
        Assert.AreEqual(60, villianKnight.AttackValue);// Verifica
        Assert.AreEqual(25, villianKnight.DefenseValue);// Verifica
        
    }
}