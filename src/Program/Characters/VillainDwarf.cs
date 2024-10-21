using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

// Esta es la clase VillainDwarf, que hereda de Dwarf, como Dwarf extiende a Character,
// VillainDwarf también adquiere todas las características de Character.
// Un enano villano villano tiene nombre, salud, valores de ataque y defensa, y una lista de ítems.
public class VillainDwarf : Dwarf
{
    // El constructor recibe el nombre, salud, ataque, defensa y los ítems.
    public VillainDwarf(string name, int health, int attackValue, int defenseValue, List<IItem> normalItems) 
        : base(name, health, attackValue, defenseValue, normalItems)
    {
        // No necesita más código, reutiliza lo de la clase padre.
    }
}