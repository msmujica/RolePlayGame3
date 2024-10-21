using NUnit.Framework;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Spell))]
public class SpellTEST
{

    [Test]
    public void CrearSpell()
    {
        string nombre = "Bola de Fuego";
        int valorAtaque = 50;
        int valorDefensa = 20;


        Spell boladefuego = new Spell(nombre, valorAtaque,valorDefensa);
        Assert.AreEqual(nombre, boladefuego.Name); 
        Assert.AreEqual(valorAtaque, boladefuego.AttackValue); 
        Assert.AreEqual(valorDefensa, boladefuego.DefenseValue); 
    }
}