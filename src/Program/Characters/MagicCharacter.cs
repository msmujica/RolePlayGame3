using System.Collections.Generic;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

// MagicCharacter es una clase abstracta que hereda de Character. 
// Representa a un personaje que puede usar ítems mágicos, como un mago o hechicero.
public abstract class MagicCharacter : Character
{
    // Lista de ítems mágicos que el personaje puede tener.
    private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

    // Propiedad para acceder o modificar la lista de ítems mágicos.
    public List<IMagicalItem> MagicalItems
    {
        get { return magicalItems; } // Devuelve la lista de ítems mágicos.
        set { magicalItems = value; } // Permite asignar una nueva lista de ítems mágicos.
    }

    // Constructor de MagicCharacter, que además de lo básico (nombre, salud, ataque, defensa, ítems normales),
    // también recibe una lista de ítems mágicos.
    public MagicCharacter(string name, int health, int attackValue, int defenseValue,
        List<IMagicalItem> magicalItems, List<IItem> normalItems)
        : base(name, health, attackValue, defenseValue, normalItems) // Llama al constructor de Character.
    {
        // Asigna la lista de ítems mágicos al personaje.
        this.MagicalItems = magicalItems;
    }
    
    // Sobreescribe el método AttackValuesWithItem() de Character para que considere los ítems mágicos.
    public override int AttackValuesWithItem()
    {
        // Llama al método de la clase base (Character) para sumar los valores de ataque normales.
        int value = base.AttackValuesWithItem(); 
    
        // Luego, recorre la lista de ítems mágicos y suma su valor de ataque si son de tipo IMagicalAttackItem.
        foreach (IMagicalItem item in this.magicalItems)
        {
            if (item is IMagicalAttackItem)
            {
                // Suma el valor de ataque mágico del ítem.
                value += (item as IMagicalAttackItem).AttackValueWithSpell();  
            }
        }

        // Retorna el valor total de ataque (normal + mágico).
        return value;
    }

    // Sobreescribe el método DefenseValueWithItem() para incluir ítems mágicos en la defensa.
    public override int DefenseValueWithItem()
    {
        // Llama al método de la clase base para obtener el valor de defensa normal.
        int value = base.DefenseValueWithItem();
    
        // Luego, recorre los ítems mágicos y suma su valor de defensa si son de tipo IMagicalDefenseItem.
        foreach (IMagicalItem item in this.magicalItems)
        {
            if (item is IMagicalDefenseItem)
            {
                // Suma el valor de defensa mágica del ítem.
                value += (item as IMagicalDefenseItem).DefenseValueWithSpell();
            }
        }

        // Retorna el valor total de defensa (normal + mágico).
        return value;
    }
    
    // Método para agregar un ítem mágico al personaje, siempre que esté vivo.
    public void AddMagicalItem(IMagicalItem item)
    {
        if (this.Alive)
        {
            this.magicalItems.Add(item); // Agrega el ítem mágico a la lista si el personaje está vivo.
        }
    }
    
    // Método para quitar un ítem mágico del personaje, también solo si está vivo.
    public void RemoveMagicalItem(IMagicalItem item)
    {
        if (this.Alive)
        {
            this.magicalItems.Remove(item); // Quita el ítem mágico de la lista si el personaje está vivo.
        }
    }
}
