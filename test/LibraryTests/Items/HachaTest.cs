using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Hacha))]
public class HachaTest
{
    [TestMethod]
    public void Hacha_ValorAtaque()
    {
        var hacha = new Hacha(20);

        Assert.AreEqual(20, hacha.ValorAtaque);
    }
}