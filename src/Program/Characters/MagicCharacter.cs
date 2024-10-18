using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public abstract class MagicCharacter : Character
{
    private List<IMagicalItem> magicalItems;

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
    
    // Sobrescribimos el método AttackValueWithItem para agregar ítems mágicos
    public override int AttackValuesWithItem()
    {
        int value = base.AttackValuesWithItem(); 
        
        foreach (IMagicalItem item in this.magicalItems)
        {
            if (item is IMagicalAttackItem)
            {
                value += (item as IMagicalAttackItem).AttackValue;
            }
        }

        return value;
    }

    // Sobrescribimos el método DefenseValueWithItem para agregar ítems mágicos
    public override int DefenseValueWithItem()
    {
        int value = this.AttackValue;
        
        foreach (IItem item in this.Items)
        {
            if (item is IAttackItem)
            {
                value += (item as IAttackItem).AttackValue;
            }
        }

        foreach (IMagicalItem item in this.magicalItems)
        {
            if (item is IMagicalDefenseItem)
            {
                value += (item as IMagicalDefenseItem).DefenseValue;
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