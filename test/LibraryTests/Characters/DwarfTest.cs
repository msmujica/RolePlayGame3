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
        //Se crea instancia con nombre, vida, daño, defensa y lista de items
        var dwarf = new Dwarf("Ariel", 80, 60, 25, new List<IItem>());
        
        Assert.AreEqual("Ariel", dwarf.Name);//Verifica que ese sea su nombre
        Assert.AreEqual(80, dwarf.Health);// Verifica que su vida sea 80
        Assert.AreEqual(60, dwarf.AttackValue);// Verifica que su ataque sea 60
        Assert.AreEqual(25, dwarf.DefenseValue);// Verifica que su defensa sea 25
        
    }
}