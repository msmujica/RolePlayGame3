using NUnit.Framework;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests;

public class ItemsTests
{
    public void Espada_ValorAtaque()
    {
        var espada = new Espada();
        espada.ValorAtaque = 20;

        Assert.AreEqual(20, espada.ValorAtaque);
    }


    public void Casco_ValorDefensa()
    {
        var casco = new Casco();
        casco.ValorDefensa = 20;


        Assert.AreEqual(20, casco.ValorDefensa);
    }
    
}