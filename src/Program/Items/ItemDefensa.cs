using System;

namespace Ucu.Poo.RoleplayGame.Program.Items;

public abstract class ItemDefensa : IDefensa
{
    private int valordefensa;

    public int ValorDefensa
    {
        get { return valordefensa; }
        set { valordefensa = value; }
    }

    public ItemDefensa(int valorDefensa)
    {
        this.ValorDefensa = valorDefensa;
    }

    // Método para mostrar las estadísticas del ítem
    public void MostrarStats()
    {
        Console.WriteLine($"La defensa de su item es: {this.ValorDefensa}");
    }
}