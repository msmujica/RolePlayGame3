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
        var espada = new Espada();
        espada.ValorAtaque = 20;

        Assert.AreEqual(20, espada.ValorAtaque);
    }
}