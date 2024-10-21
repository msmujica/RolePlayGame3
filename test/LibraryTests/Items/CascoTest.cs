using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Casco))]
public class CascoTest
{

    [TestMethod]
    public void Casco_ValorAtaque()
    {
        var casco = new Casco(20);

        Assert.AreEqual(20, casco.ValorDefensa);
    }
}