namespace Ucu.Poo.RoleplayGame.Program.Items;

public interface IDefensa : IItem
{
    int ValorDefensa { get; }
    void MostrarStats();
}