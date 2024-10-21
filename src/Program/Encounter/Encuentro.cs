using System;
using System.Collections;
using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public class Encuentro
{
    private List<Character> heroes = new List<Character>();
    private List<Character> enemigos = new List<Character>();

    public List<Character> Heroes
    {
        get { return heroes; }
        set { heroes = value; }
    }

    public List<Character> Enemigos
    {
        get { return enemigos; }
        set { enemigos = value; }
    }

    public Encuentro(List<Character> heroes, List<Character> enemigos)
    {
        this.Heroes = heroes;
        this.Enemigos = enemigos;
    }
// Método que empieza el encuentro
    public void doEncounter()
    {
        // Mientras haya héroes y enemigos vivos, seguimos peleando
        while (HeroesVivos() && EnemigosVivo())
        {
            AtacarEnemigo(); // Los enemigos atacan
            AtacarHeroe();   // Los héroes contraatacan
            CurarHeroe();    // Los héroes se curan si pueden
        }

        // Checamos quién ganó al final
        if (HeroesVivos())
        {
            Console.WriteLine("¡Los héroes han ganado!");
        }
        else
        {
            Console.WriteLine("¡Los enemigos han ganado!");
        }
    }
    
    // Método que verifica si queda algún héroe vivo
    public bool HeroesVivos()
    {
        foreach (var heroe in this.Heroes)
        {
            if (heroe.Alive)
            {
                return true; // Si hay un héroe vivo, regresamos true
            }
        }
        return false; // Si no, regresamos false
    }

    // Método que checa si quedan enemigos vivos
    public bool EnemigosVivo()
    {
        foreach (var enemigo in this.Enemigos)
        {
            if (enemigo.Alive)
            {
                return true; // Si hay un enemigo vivo, regresamos true
            }
        }
        return false; // Si no, regresamos false
    }

    // Los enemigos atacan a los héroes
    public void AtacarEnemigo()
    {
        int heroeCount = this.Heroes.Count; // Contamos cuántos héroes hay
        int index = 0; // Índice para ciclar a través de los héroes
        foreach (var enemigo in this.Enemigos)
        {
            if (enemigo.Alive) // Solo si el enemigo está vivo
            {
                foreach (var heroes in this.Heroes)
                {
                    if (heroes.Alive) // Solo si el héroe está vivo
                    {
                        // Hacemos que el enemigo ataque a un héroe
                        Character heroe = this.Heroes[index % heroeCount];
                        Console.WriteLine($"{enemigo.Name} ataca a {heroe.Name} con ⚔️ {enemigo.AttackValuesWithItem()}");
                        heroe.ReceiveAttack(enemigo.AttackValuesWithItem()); // El héroe recibe el ataque

                        index++; // Aumentamos el índice para el próximo héroe
                    }
                }
            }
        }
    }

    // Los héroes atacan a los enemigos
    public void AtacarHeroe()
    {
        foreach (var heroe in this.Heroes)
        {
            if (heroe.Alive) // Solo si el héroe está vivo
            {
                foreach (var enemigo in this.Enemigos)
                {
                    if (enemigo.Alive) // Solo si el enemigo está vivo
                    {
                        Console.WriteLine($"{heroe.Name} ataca a {enemigo.Name} con ⚔️ {heroe.AttackValuesWithItem()}");
                        enemigo.ReceiveAttack(heroe.AttackValuesWithItem()); // El enemigo recibe el ataque

                        // Si el enemigo muere, el héroe gana EXP
                        if (!enemigo.Alive)
                        {
                            heroe.agregarEXP(enemigo.EXP);
                            Console.WriteLine($"{heroe.Name} ha derrotado a {enemigo.Name} y ganado {enemigo.EXP} EXP!");
                        }
                    }
                }
            }
        }
    }

    // Los héroes se curan si tienen suficiente EXP
    public void CurarHeroe()
    {
        foreach (var heroe in this.Heroes)
        {
            if (heroe.Alive && heroe.EXP >= 5) // Si el héroe está vivo y tiene al menos 5 EXP
            {
                heroe.Cure(); // El héroe se cura
                heroe.EXP -= 5; // Resta 5 EXP
                Console.WriteLine($"{heroe.Name} se ha curado por tener 5 o más EXP.");
            }
        }
    }
}