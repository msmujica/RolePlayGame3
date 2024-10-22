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
        //Se crea instancia con nombre, vida, daño, defensa y lista de items
        var archer = new Archer("Legolas", 80, 60, 25, new List<IItem>());

        Assert.AreEqual("Legolas", archer.Name);//Verifica que ese sea su nombre
        Assert.AreEqual(80, archer.Health);// Verifica que su vida sea 80
        Assert.AreEqual(60, archer.AttackValue);// Verifica que su ataque sea 60
        Assert.AreEqual(25, archer.DefenseValue);// Verifica que su defensa sea 25
    }
}