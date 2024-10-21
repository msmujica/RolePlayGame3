using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Armadura))]
public class ArmaduraTest
{
    [TestMethod]
    public void Armadura_ValorDefensa()
    {
        var armadura = new Armadura();
        armadura.ValorDefensa = 20;

        Assert.AreEqual(20, armadura.ValorDefensa);
    }
}