using System;

namespace Ucu.Poo.RoleplayGame.Program.Items;

public abstract class ItemAtaque : IAtaque
{
    private int valorataque;

    // Constructor que inicializa el valor de ataque
    public int ValorAtaque
    {
        get { return valorataque; }
        set { valorataque = value; }
    }

    public ItemAtaque(int valorAtaque)
    {
        this.ValorAtaque = valorAtaque;
    }

    // Método para mostrar las estadísticas del ítem
    public void MostrarStats()
    {
        Console.WriteLine($"El ataque de su item es: {this.ValorAtaque}");
    }
}