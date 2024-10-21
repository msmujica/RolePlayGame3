using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame.Program.Items;

public class SpellsBook : IMagicalAttackItem, IMagicalDefenseItem
{
    private string name;
    private List<Spell> spells = new List<Spell>();

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Spell> Spells
    {
        get { return spells; }
        set { spells = value; }
    }
    
    public SpellsBook(string name, List<Spell> speels)
    {
        this.Name = name;
        this.Spells = speels;
    }
    
    // Calcula el valor total de ataque sumando el ataque de cada hechizo
    public int AttackValueWithSpell()
    {
 
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        
    }
    
    // Calcula el valor total de defensa sumando la defensa de cada hechizo
    public int DefenseValueWithSpell()
    {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        
    }
    
    // Método para agregar un nuevo hechizo al libro
    public void AddSpell(Spell spell)
    {
        this.spells.Add(spell);
    }

    // Método para eliminar un hechizo del libro
    public void RemoveSpell(Spell spell)
    {
        this.spells.Remove(spell);
    }
}