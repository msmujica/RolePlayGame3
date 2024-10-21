using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Items;

[TestClass]
[TestSubject(typeof(Casco))]
public class CascoTest
{

    [TestMethod]
    public void Casco_ValorDefensa()
    {
        // Crea un nuevo objeto Casco con 20 de casco
        var casco = new Casco(20);
        
        // Verifica que el valor de Defensa de Casco sea 20
        Assert.AreEqual(20, casco.ValorDefensa);
    }
}