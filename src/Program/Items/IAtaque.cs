namespace Ucu.Poo.RoleplayGame.Program.Items;

public interface IAtaque : IItem
{
    int ValorAtaque { get; }
    void MostrarStats();
}