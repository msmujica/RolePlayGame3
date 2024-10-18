namespace Ucu.Poo.RoleplayGame.Program.Items;

public class Spell
{
    private string name;
    private int attackValue;
    private int defenseValue;

    public string Name
    {
        get { return name; }
        set { name = value; }
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

    public Spell(string name, int attackValue, int defenseValue)
    {
        this.Name = name;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }
}