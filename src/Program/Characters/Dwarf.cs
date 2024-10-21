using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

// Esta es la clase Dwarf, que hereda de Character.
// Un enano tiene nombre, salud, valores de ataque y defensa, y una lista de ítems.
public class Dwarf : Character
{
    // El constructor recibe el nombre, salud, ataque, defensa y los ítems.
    public Dwarf(string name, int health, int attackValue, int defenseValue, List<IItem> normalItems) 
        : base(name, health, attackValue, defenseValue, normalItems)
    {
        // No necesita más código, reutiliza lo de la clase padre.
    }
}
