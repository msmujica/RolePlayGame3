using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public class Wizard : MagicCharacter
{
    // Esta es la clase Wizard, que hereda de MagicCharacter, como MagicCharacter extiende a Character,
    // Wizard también adquiere todas las características de Character.
    // Un mago villano tiene nombre, salud, valores de ataque y defensa, una lista de ítems magicos y una lista de ítems.

    // El constructor recibe el nombre, salud, ataque, defensa y los ítems.
    public Wizard(string name, int health, int attackValue, int defenseValue,
        List<IMagicalItem> magicalItems, List<IItem> normalItems) : base(name, health, attackValue, 
        defenseValue, magicalItems, normalItems)
    {
        // No necesita más código, reutiliza lo de la clase padre.
    }
}