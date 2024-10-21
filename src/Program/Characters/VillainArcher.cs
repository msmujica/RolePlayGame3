using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

// Esta es la clase VillainArcher, que hereda de Archer, como Archer extiende a Character,
// VillainArcher también adquiere todas las características de Character.
// Un arquero villano tiene nombre, salud, valores de ataque y defensa, y una lista de ítems.
public class VillainArcher : Archer
{
    // El constructor recibe el nombre, salud, ataque, defensa y los ítems.
    public VillainArcher(string name, int health, int attackValue, int defenseValue, List<IItem> normalItems) 
        : base(name, health, attackValue, defenseValue, normalItems)
    {
        // No necesita más código, reutiliza lo de la clase padre.
    }
}