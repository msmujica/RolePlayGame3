using System.Collections;
using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

public class Encuentro
{
    private ArrayList heroes;

    public ArrayList Heroes
    {
        get { return heroes; }
        set { heroes = value; }
    }
    private ArrayList enemigos;

    public ArrayList Enemigos
    {
        get { return enemigos; }
        set { enemigos = value; }
    }

    public Encuentro(ArrayList Losheroes, ArrayList Losenemigos)
    {
        this.Heroes = Losheroes;
        this.Enemigos = Losenemigos;
    }

    public void doEncounter()
    {
        
    }

    public void AtacarEnemigo()
    {
        
    }

    public void AtacarHeroe()
    {
        
    }

    public void CurarHeroe()
    {
        
    }

}