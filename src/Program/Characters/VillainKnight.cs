using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public class VillainKnight : Knight
{
    public VillainKnight(string name, int health, int attackValue, int defenseValue, List<IItem> normalItems) 
        : base(name, health, attackValue, defenseValue, normalItems)
    {
        
    }
}