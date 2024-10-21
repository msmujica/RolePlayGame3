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
        // Crea un nuevo objeto Armadura con 20 de defensa
        var armadura = new Armadura(20);

        // Verifica que el valor de Defensa de Armadura sea 20
        Assert.AreEqual(20, armadura.ValorDefensa);
    }
}