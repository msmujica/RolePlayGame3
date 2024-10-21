namespace Ucu.Poo.RoleplayGame.Program.Items;

public interface IAtaque : IItem
{
    // Propiedad que devuelve el valor de ataque del item
    int ValorAtaque { get; }
    // Método para mostrar las estadísticas del item
    void MostrarStats();
}