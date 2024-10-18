using System;

namespace Ucu.Poo.RoleplayGame.Program.Items;

public abstract class ItemAtaque : IItem
{
    private int valorataque;

    public int ValorAtaque
    {
        get { return valorataque; }
        set { valorataque = value; }
    }

    public ItemAtaque(int valorAtaque)
    {
        this.ValorAtaque = valorAtaque;
    }

    public void MostrarStats()
    {
        Console.WriteLine($"El ataque de su item es: {this.ValorAtaque}");
    }
}