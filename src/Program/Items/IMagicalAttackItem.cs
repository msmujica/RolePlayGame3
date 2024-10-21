namespace Ucu.Poo.RoleplayGame.Program.Items;

public interface IMagicalAttackItem : IMagicalItem
{
    // Método que devuelve el valor de ataque usando un hechizo
    int AttackValueWithSpell();
}