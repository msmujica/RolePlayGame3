using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Encounter;

[TestClass]
[TestSubject(typeof(Encuentro))]
public class EncuentroTest
{

    [TestMethod]
    public void crearEncuentroTest()
    {
        //Se crea un personaje heroe para el encuentro
        Dwarf gimli = new Dwarf("Gimli", 1, 30, 20, new List<IItem> { new Espada(15), new Armadura(10) });
        
        List<Character> heroes = new List<Character> { gimli };

        // Se crean enemigos
        VillainDwarf enemyGimli = new VillainDwarf("Evil Gimli", 80, 25, 15, new List<IItem> { new Hacha(20), new Casco(5) });
        VillainWizard enemyGandalf = new VillainWizard("Evil Gandalf", 60, 20, 10, new List<IMagicalItem> { new SpellsBook("Dark Magic", new List<Spell> { new Spell("Sombra", 15, 3) }) }, new List<IItem> { new Baston(10, 5) });

        List<Character> enemies = new List<Character> { enemyGimli, enemyGandalf };
        // Se crea el encuentro
        Encuentro encounter = new Encuentro(heroes, enemies);
        
        Assert.AreEqual(encounter.Heroes.Count, 1);
        Assert.AreEqual(encounter.Enemigos.Count, 2);
    }
    
    //En este Test se realzan el Test de EnemigoVivo, Heroe Vivo, DoEncounter y ademas Atacar Heroe y Enemigo
    [TestMethod]
    public void EncuentroYEnemigoVivosTest()
    {
        //Se crea un personaje heroe para el encuentro
        Dwarf gimli = new Dwarf("Gimli", 1, 30, 20, new List<IItem> { new Espada(15), new Armadura(10) });
        
        List<Character> heroes = new List<Character> { gimli };

        // Se crean enemigos
        VillainDwarf enemyGimli = new VillainDwarf("Evil Gimli", 80, 25, 15, new List<IItem> { new Hacha(20), new Casco(5) });
        VillainWizard enemyGandalf = new VillainWizard("Evil Gandalf", 60, 20, 10, new List<IMagicalItem> { new SpellsBook("Dark Magic", new List<Spell> { new Spell("Sombra", 15, 3) }) }, new List<IItem> { new Baston(10, 5) });

        List<Character> enemies = new List<Character> { enemyGimli, enemyGandalf };
        
        //Se crea el encuentro
        Encuentro encounter = new Encuentro(heroes, enemies);
        
        encounter.doEncounter();
        
        Assert.AreEqual(encounter.HeroesVivos(), false);//Verifica si hay heroes vivos
        Assert.AreEqual(encounter.EnemigosVivo(), true);//Verifica si hay enemigos vivos
        }

    [TestMethod]
    public void CurarTest()
    {
        //Se crea un personaje heroe para el encuentro
        Dwarf gimli = new Dwarf("Gimli", 1, 30, 20, new List<IItem> { new Espada(15), new Armadura(10) });
        
        List<Character> heroes = new List<Character> { gimli };

        // Se crean enemigos
        VillainDwarf enemyGimli = new VillainDwarf("Evil Gimli", 80, 25, 15, new List<IItem> { new Hacha(20), new Casco(5) });
        VillainWizard enemyGandalf = new VillainWizard("Evil Gandalf", 60, 20, 10, new List<IMagicalItem> { new SpellsBook("Dark Magic", new List<Spell> { new Spell("Sombra", 15, 3) }) }, new List<IItem> { new Baston(10, 5) });

        List<Character> enemies = new List<Character> { enemyGimli, enemyGandalf };

        //Se crea el encuentro
        Encuentro encounter = new Encuentro(heroes, enemies);
        
        //Ejecuta el metodo para curar heroes
        encounter.CurarHeroe();

        Assert.AreEqual(gimli.Health, 1);//Verifica que la salud del heroe no se ha incrementado
    }
}