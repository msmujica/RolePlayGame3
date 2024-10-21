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
        var baston = new Baston();
        baston.ValorAtaque = 20;

        Assert.AreEqual(20, baston.ValorAtaque);
    }
}