using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(SpellsBook))]
public class SpellsBookTEST
{

    [TestMethod]
    public void CrearLibro()
    {   //Se crea variable Grimorio
        string nombre = "Grimorio";
        //Se crea una lista que incluye dos hechizos 
        List<Spell> hechizos = new List<Spell>
        {
            new Spell("Bola de fuego", 50, 20),
            new Spell("Escudo", 0, 30)
        };
        //Se crea el grimorio usando el nombre y la lista de hechizos
        SpellsBook grimorio = new SpellsBook(nombre, hechizos);
        //Se verifica que el nombre del grimorio sea el esperado: "Grimorio"
        Assert.AreEqual(nombre, grimorio.Name);
        //Se verifica que los hechizos del grimorio coincidan con la lista proporcionada"
        Assert.AreEqual(hechizos, grimorio.Spells);
    }

    [TestMethod]
    public void AgregaryRemoverHechizo()
    {   //Se inicializa un grimorio
        SpellsBook grimorio = new SpellsBook("Grimorio", new List<Spell>());
        //Se inicializa un nuevo hechizo
        Spell boladefuego = new Spell("Bola de fuego", 50, 20);
        //Se añade el hechizo al grimorio
        grimorio.AddSpell(boladefuego);
        //Se verifica que el grimorio contenga el hechizo previsto
        CollectionAssert.Contains(grimorio.Spells,boladefuego);
        //Se remueve el hechizo del grimorio
        grimorio.RemoveSpell(boladefuego);
        //Se verifica que el grimorio ya no contiene el hechizo eliminado previamente
        Assert.IsFalse(grimorio.Spells.Contains(boladefuego));
    }

    [TestMethod]
    public void ValorAtaqueDefensa()
    {   //Se crea un hechizo con nombre, valor de ataque y valor de defensa
        Spell boladefuego = new Spell("Bola de fuego", 50, 20);
        //Se crea un escudo unicamente con valor de defensa
        Spell escudo = new Spell("Escudo", 0, 30);
        //Se crea un grimorio con el hechizo y el escudo
        SpellsBook grimorio = new SpellsBook("Grimorio", new List<Spell>{boladefuego,escudo});
        //Se setea un ataque esperado por parte del hechizo
        int AtaqueEsperado = 50;
        //Se verifica que el valor de ataque calculado por el grimorio coincida con el valor esperado
        Assert.AreEqual(AtaqueEsperado, grimorio.AttackValueWithSpell());
        //Esta vez se setea un valor de defensa esperado por parte del escudo
        int DefensaEsperada = 50;
        //Se verifica que el valor de la defensa del grimorio coincida con la defensa esperada
        Assert.AreEqual(DefensaEsperada, grimorio.AttackValueWithSpell());

    }
}