using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RoleplayGame.Program.Characters;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace LibraryTests.Characters;

[TestClass]
[TestSubject(typeof(Wizard))]
public class WizardTest
{
    // Este método verifica la correcta creación de un Wizard
    [TestMethod]
    public void CrearWizard()
    {
        // Se define el nombre del Wizard
        string nombre = "Gandalf";
        // Se define su salud
        int salud = 100;
        // Se define su valor de ataque
        int valorAtaque = 80;
        // Se define su valor de defensa
        int valorDefensa = 50;

        List<IMagicalItem> itemsMagicos = new List<IMagicalItem>();
        {
            new Spell("Bola de fuego", 50, 20);

        }
        
        List<IItem> itemsNormales = new List<IItem>();
        {
            new Baston(100,400);

        }
        // Se crea una nueva instancia de Wizard
        Wizard gandalf = new Wizard(nombre, salud, valorAtaque, valorDefensa, itemsMagicos, itemsNormales);

        // Se verifica que el nombre del Wizard sea igual al previsto
        Assert.AreEqual(nombre, gandalf.Name);
        // Se verifica que la salud del Wizard sea correcta
        Assert.AreEqual(salud, gandalf.Health);
        // Se verifica que el valor de ataque del Wizard sea correcto
        Assert.AreEqual(valorAtaque, gandalf.AttackValue);
        // Se verifica que el valor de defensa del Wizard sea correcto
        Assert.AreEqual(valorDefensa, gandalf.DefenseValue);
    }
}
