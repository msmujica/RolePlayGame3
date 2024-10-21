using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Espada))]
public class EspadaTest
{
    [TestMethod]
    public void Espada_ValorAtaque()
    {
        // Crea un nuevo objeto Espada con 20 de daño
        var espada = new Espada(20);
        
        // Verifica que el valor de Ataque de Espada sea 20
        Assert.AreEqual(20, espada.ValorAtaque);
    }
}