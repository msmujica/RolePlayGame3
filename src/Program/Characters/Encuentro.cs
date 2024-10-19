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

    public void doEncounter()
    {
        while (HeroesVivos() && EnemigosVivo())
        {
            AtacarEnemigo();

            AtacarHeroe();

            CurarHeroe();
        }

        // Verificar el resultado final
        if (HeroesVivos())
        {
            Console.WriteLine("¡Los héroes han ganado!");
        }
        else
        {
            Console.WriteLine("¡Los enemigos han ganado!");
        }
    }
    
    public bool HeroesVivos()
    {
        foreach (var heroe in this.Heroes)
        {
            if (heroe.Alive)
            {
                return true;
            }
        }
        return false;
    }

    public bool EnemigosVivo()
    {
        foreach (var enemigo in this.Enemigos)
        {
            if (enemigo.Alive)
            {
                return true;
            }
        }
        return false;
    }

    public void AtacarEnemigo()
    {
        int heroeCount = this.Heroes.Count;
        int index = 0;
        foreach (var enemigo in this.Enemigos)
        {
            if (enemigo.Alive)
            {
                foreach (var heroes in this.Heroes)
                {
                    if (heroes.Alive)
                    {
                        // Ciclar sobre los héroes
                        Character heroe = this.Heroes[index % heroeCount];
                        Console.WriteLine($"{enemigo.Name} ataca a {heroe.Name} con ⚔️ {enemigo.AttackValuesWithItem()}");
                        heroe.ReceiveAttack(enemigo.AttackValuesWithItem());

                        index++;
                    }
                }
            }
        }
    }

    public void AtacarHeroe()
    {
        foreach (var heroe in this.Heroes)
        {
            if (heroe.Alive)
            {
                foreach (var enemigo in this.Enemigos)
                {
                    if (enemigo.Alive)
                    {
                        Console.WriteLine($"{heroe.Name} ataca a {enemigo.Name} con ⚔️ {heroe.AttackValuesWithItem()}");
                        enemigo.ReceiveAttack(heroe.AttackValuesWithItem());

                        // Si el enemigo muere, el héroe gana los VP
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

    public void CurarHeroe()
    {
        foreach (var heroe in this.Heroes)
        {
            if (heroe.Alive && heroe.EXP >= 5)
            {
                heroe.Cure();
                heroe.EXP -= 5;
                Console.WriteLine($"{heroe.Name} se ha curado por tener 5 o más EXP.");
            }
        }
    }

}