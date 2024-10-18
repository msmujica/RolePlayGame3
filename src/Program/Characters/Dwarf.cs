using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public class Dwarf : Character
{
    public Dwarf(string name, int health, int attackValue, int defenseValue, List<IItem> normalItems) 
        : base(name, health, attackValue, defenseValue, normalItems)
    {
        
    }
}