using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Baston))]
public class BastonTest
{

    [TestMethod]
    public void Baston_ValorAtaque()
    {
        // Crea un nuevo objeto baston con 20 de defensa y ataque
        var baston = new Baston(20, 20);

        // Verifica que el valor de Defensa y Ataque del baston sea 20
        Assert.AreEqual(20, baston.ValorAtaque);
        Assert.AreEqual(20, baston.ValorDefensa);
    }
}