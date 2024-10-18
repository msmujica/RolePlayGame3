using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public class Wizard : MagicCharacter
{

    public Wizard(string name, int health, int attackValue, int defenseValue,
        List<IMagicalItem> magicalItems, List<IItem> normalItems) : base(name, health, attackValue, 
        defenseValue, magicalItems, normalItems)
    {
        
    }
    
}