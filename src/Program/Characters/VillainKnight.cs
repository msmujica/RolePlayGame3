using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

// Esta es la clase VillainKnight, que hereda de Knight, como Knight extiende a Character,
// VillainKnight también adquiere todas las características de Character.
// Un caballero villano tiene nombre, salud, valores de ataque y defensa, y una lista de ítems.
public class VillainKnight : Knight
{
    // El constructor recibe el nombre, salud, ataque, defensa y los ítems.
    public VillainKnight(string name, int health, int attackValue, int defenseValue, List<IItem> normalItems) 
        : base(name, health, attackValue, defenseValue, normalItems)
    {
        // No necesita más código, reutiliza lo de la clase padre.
    }
}