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
    {
        string nombre = "Grimorio";
        List<Spell> hechizos = new List<Spell>
        {
            new Spell("Bola de fuego", 50, 20),
            new Spell("Escudo", 0, 30)
        };

        SpellsBook grimorio = new SpellsBook(nombre, hechizos);

        Assert.AreEqual(nombre, grimorio.Name);
        Assert.AreEqual(hechizos, grimorio.Spells);
    }

    [TestMethod]
    public void AgregaryRemoverHechizo()
    {
        SpellsBook grimorio = new SpellsBook("Grimorio", new List<Spell>());
        Spell boladefuego = new Spell("Bola de fuego", 50, 20);
        grimorio.AddSpell(boladefuego);
        CollectionAssert.Contains(grimorio.Spells,boladefuego);
        grimorio.RemoveSpell(boladefuego);
        Assert.IsFalse(grimorio.Spells.Contains(boladefuego));
    }

    [TestMethod]
    public void ValorAtaqueDefensa()
    {
        Spell boladefuego = new Spell("Bola de fuego", 50, 20);
        Spell escudo = new Spell("Escudo", 0, 30);
        
        SpellsBook grimorio = new SpellsBook("Grimorio", new List<Spell>{boladefuego,escudo});

        int AtaqueEsperado = 50;
        Assert.AreEqual(AtaqueEsperado, grimorio.AttackValueWithSpell());

        int DefensaEsperada = 50;
        Assert.AreEqual(DefensaEsperada, grimorio.AttackValueWithSpell());

    }
}