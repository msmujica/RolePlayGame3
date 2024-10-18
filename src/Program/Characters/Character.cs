using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public abstract class Character
{
    private string name;
    private int health;
    private int attackValue;
    private int defenseValue;
    private int exp;
    private bool alive;
    private List<IItem> items = new List<IItem>();

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int AttackValue
    {
        get { return attackValue; }
        set { attackValue = value; }
    }

    public int DefenseValue
    {
        get { return defenseValue; }
        set { defenseValue = value; }
    }

    public int EXP
    {
        get { return exp; }
        set { exp = value; }
    }

    public bool Alive
    {
        get { return alive; }
        set { alive = value; }
    }

    public List<IItem> Items
    {
        get { return items; }
        set { items = value; }
    }

    public Character(string name, int health, int attackValue, int defenseValue, List<IItem> items)
    {
        this.Name = name;
        this.Health = health;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
        this.EXP = 2;
        this.Alive = true;
        this.Items = items;
    }

    public virtual int AttackValuesWithItem()
    {
        int value = this.AttackValue;
        foreach (IItem item in this.Items)
        {
            if (item is IAtaque)
            {
                value += (item as IAtaque).ValorAtaque;
            }
        }
        return value;
    }
    
    public virtual int DefenseValueWithItem() 
    {
            int value = this.DefenseValue;
            foreach (IItem item in this.Items)
            {
                if (item is IDefensa)
                {
                    value += (item as IDefensa).ValorDefensa;
                }
            }
            return value;
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValueWithItem() < power)
        {
            this.Health -= power - this.DefenseValueWithItem();
            if (this.Health <= 0)
            {
                this.Alive = false;
                Console.WriteLine($"{this.Name} ha muerto.");
            }
        }
        else
        {
            Console.WriteLine("Ataque nulo;");
        }
    }

    public void Cure()
    {
        if ((this.Health + 20) > 100)
        {
            this.Health = 100;
        }
        else
        {
            this.Health += 20;
        }
    }

    public void AddItem(IItem item)
    {
        if (this.Alive)
        {
            this.items.Add(item);   
        }
    }

    public void RemoveItem(IItem item)
    {
        if (this.Alive)
        {
            this.items.Remove(item);   
        }
    }

    public void agregarEXP(int value)
    {
        this.EXP += value;
    }
}