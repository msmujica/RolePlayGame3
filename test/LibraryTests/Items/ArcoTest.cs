using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Arco))]
public class ArcoTest
{

    [TestMethod]
    public void ArcoCreateTest()
    {
        // Crea un nuevo objeto Hacha con 20 de ataque
        var hacha = new Hacha(20);

        // Verifica que el valor de ataque del hacha sea 20
        Assert.AreEqual(20, hacha.ValorAtaque);
    }
}