using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

// Esta es la clase VillainWizard, que hereda de Wizard, como Wizard extiende a MagicCharacter y a su vez MagicCharacter
// extiende a character, VillainDwarf también adquiere todas las características de Character.
// Un mago villano tiene nombre, salud, valores de ataque y defensa, una lista de ítems magicos y una lista de ítems.
public class VillainWizard : Wizard
{
    // El constructor recibe el nombre, salud, ataque, defensa y los ítems.
    public VillainWizard(string name, int health, int attackValue, int defenseValue,
        List<IMagicalItem> magicalItems, List<IItem> normalItems) : base(name, health, attackValue, 
        defenseValue, magicalItems, normalItems)
    {
        // No necesita más código, reutiliza lo de la clase padre.
    }
}