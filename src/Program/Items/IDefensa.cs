namespace Ucu.Poo.RoleplayGame.Program.Items;

public interface IDefensa : IItem
{
    // Propiedad que devuelve el valor de ataque del item
    int ValorDefensa { get; }
    // Método para mostrar las estadísticas del item
    void MostrarStats();
}