namespace Ucu.Poo.RoleplayGame.Program.Items;

public interface IMagicalDefenseItem : IMagicalItem
{
    // Método que devuelve el valor de defensa usando un hechizo
    int DefenseValueWithSpell();
}