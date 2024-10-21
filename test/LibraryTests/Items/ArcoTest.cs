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
        var hacha = new Hacha(20);

        Assert.AreEqual(20, hacha.ValorAtaque);
    }
}