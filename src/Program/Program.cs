using System;
using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program;

class Program
{
    static void Main(string[] args)
    {
        Dwarf gimli = new Dwarf("Gimli", 100, 30, 20, new List<IItem> { new Espada(15), new Armadura(10) });
        Wizard gandalf = new Wizard("Gandalf", 80, 25, 15, new List<IMagicalItem> { new SpellsBook("Grimorio", new List<Spell> { new Spell("Fuego", 20, 5) }) }, new List<IItem> { new Baston(10, 5) });

        List<Character> heroes = new List<Character> { gimli, gandalf };

        // Crear enemigos
        VillainDwarf enemyGimli = new VillainDwarf("Evil Gimli", 80, 25, 15, new List<IItem> { new Hacha(20), new Casco(5) });
        VillainWizard enemyGandalf = new VillainWizard("Evil Gandalf", 60, 20, 10, new List<IMagicalItem> { new SpellsBook("Dark Magic", new List<Spell> { new Spell("Sombra", 15, 3) }) }, new List<IItem> { new Baston(10, 5) });

        List<Character> enemies = new List<Character> { enemyGimli, enemyGandalf };

        // Crear un encuentro
        Encuentro encounter = new Encuentro(heroes, enemies);

        // Ejecutar el encuentro
        encounter.doEncounter();
    }
}
