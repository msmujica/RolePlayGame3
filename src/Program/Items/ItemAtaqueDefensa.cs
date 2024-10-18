using System;

namespace Ucu.Poo.RoleplayGame.Program.Items;

public abstract class ItemAtaqueDefensa : IDefensa, IAtaque
{
    
    private int valorataque;

    public int ValorAtaque
    {
        get { return valorataque; }
        set { valorataque = value; }
    }
    private int valordefensa;

    public int ValorDefensa
    {
        get { return valordefensa; }
        set { valordefensa = value; }
    }

    public ItemAtaqueDefensa(int valorAtaque, int valorDefensa)
    {
        this.ValorAtaque = valorAtaque;
        this.ValorDefensa = valorDefensa;
    }

    public void MostrarStats()
    {
        Console.WriteLine($"El ataque de su item es: {this.ValorAtaque}" +
                          $"La defensa de su item es: {this.ValorDefensa}");
    }
}