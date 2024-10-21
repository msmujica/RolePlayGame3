using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Spell))]
public class SpellTEST
{
    //Con este metodo se verifica la correcta creacion de un hechizo
    [TestMethod]
    public void CrearSpell()
    {   //Se define el nombre del hechizo
        string nombre = "Bola de Fuego";
        //Se define como entero su valor de ataque
        int valorAtaque = 50;
        //Se define como entero el valor de defensa que tiene
        int valorDefensa = 20;
        
        //Se crea una nueva instancia de Spell con el nombre definido, Valor de ataque y valor de defensa
        Spell boladefuego = new Spell(nombre, valorAtaque,valorDefensa);
        //Se verifica que el nombre del hechizo sea igual al previsto
        Assert.AreEqual(nombre, boladefuego.Name); 
        Assert.AreEqual(valorAtaque, boladefuego.AttackValue); 
        Assert.AreEqual(valorDefensa, boladefuego.DefenseValue); 
    }
}