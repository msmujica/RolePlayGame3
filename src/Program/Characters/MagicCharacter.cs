using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public abstract class MagicCharacter : Character
{
    private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

    public List<IMagicalItem> MagicalItems
    {
        get { return magicalItems; }
        set { magicalItems = value; }
    }

    public MagicCharacter(string name, int health, int attackValue, int defenseValue,
        List<IMagicalItem> magicalItems, List<IItem> normalItems)
        : base(name, health, attackValue, defenseValue, normalItems)
    {
        this.MagicalItems = magicalItems;
    }
    
    public override int AttackValuesWithItem()
    {
        int value = base.AttackValuesWithItem(); 
    
        foreach (IMagicalItem item in this.magicalItems)
        {
            if (item is IMagicalAttackItem)
            {
                value += (item as IMagicalAttackItem).AttackValueWithSpell();  
            }
        }

        return value;
    }

// Método DefenseValueWithItem en MagicCharacter
    public override int DefenseValueWithItem()
    {
        int value = base.DefenseValueWithItem();
    
        foreach (IMagicalItem item in this.magicalItems)
        {
            if (item is IMagicalDefenseItem)
            {
                value += (item as IMagicalDefenseItem).DefenseValueWithSpell();
            }
        }

        return value;
    }
    
    public void AddMagicalItem(IMagicalItem item)
    {
        if (this.Alive)
        {
            this.magicalItems.Add(item);   
        }
    }
    
    public void RemoveMagicalItem(IMagicalItem item)
    {
        if (this.Alive)
        {
            this.magicalItems.Remove(item);   
        }
    }
}