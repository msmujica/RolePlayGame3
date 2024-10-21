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

    // Propiedad para acceder y modificar el valor de defensa
    public int ValorDefensa
    {
        get { return valordefensa; }
        set { valordefensa = value; }
    }

    // Constructor que inicializa los valores de ataque y defensa
    public ItemAtaqueDefensa(int valorAtaque, int valorDefensa)
    {
        this.ValorAtaque = valorAtaque;
        this.ValorDefensa = valorDefensa;
    }

    // Método para mostrar las estadísticas del ítem
    public void MostrarStats()
    {
        Console.WriteLine($"El ataque de su item es: {this.ValorAtaque}" +
                          $"La defensa de su item es: {this.ValorDefensa}");
    }
}