using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using Ucu.Poo.RoleplayGame.Program.Items;

namespace Ucu.Poo.RoleplayGame.Program.Characters;

// Character es una clase abstracta, lo que significa que no se puede instanciar directamente.
// Todas las clases que hereden de Character tendrán estos atributos y métodos básicos.
public abstract class Character
{
    // Atributos privados del personaje
    private string name;
    private int health;
    private int attackValue;
    private int defenseValue;
    private int exp;
    private bool alive;
    private List<IItem> items = new List<IItem>(); // Lista de ítems que puede llevar el personaje

    // Propiedades para acceder a los atributos privados
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int EXP { get; set; }
    public bool Alive { get; set; }
    public List<IItem> Items { get; set; }

    // Constructor de Character: inicializa el nombre, salud, ataque, defensa, experiencia y si está vivo.
    public Character(string name, int health, int attackValue, int defenseValue, List<IItem> items)
    {
        this.Name = name;
        this.Health = health;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
        this.EXP = 2; // Los personajes empiezan con 2 de experiencia.
        this.Alive = true; // Todos los personajes comienzan vivos.
        this.Items = items; // Los ítems que tiene el personaje.
    }

    // Este método calcula el valor total de ataque, sumando el valor de ataque del personaje y sus ítems.
    public virtual int AttackValuesWithItem()
    {
        int value = this.AttackValue;
        foreach (IItem item in this.Items)
        {
            if (item is IAtaque) // Si el ítem es de ataque, se le suma el valor de ataque del ítem.
            {
                value += (item as IAtaque).ValorAtaque;
            }
        }
        return value;
    }

    // Similar al método anterior, pero para la defensa, sumando el valor de defensa del personaje y los ítems.
    public virtual int DefenseValueWithItem() 
    {
        int value = this.DefenseValue;
        foreach (IItem item in this.Items)
        {
            if (item is IDefensa) // Si el ítem es de defensa, se le suma el valor de defensa del ítem.
            {
                value += (item as IDefensa).ValorDefensa;
            }
        }
        return value;
    }

    // Este método se usa para recibir un ataque. Si el poder del ataque es mayor que la defensa del personaje, 
    // el personaje pierde salud. Si la salud llega a 0 o menos, el personaje muere.
    public void ReceiveAttack(int power)
    {
        if (this.DefenseValueWithItem() < power)
        {
            this.Health -= power - this.DefenseValueWithItem();
            if (this.Health <= 0)
            {
                this.Alive = false;
                Console.WriteLine($"{this.Name} ha muerto."); // Mensaje de que el personaje ha muerto.
            }
        }
        else
        {
            Console.WriteLine("Ataque nulo;"); // Si la defensa es mayor o igual al poder, el ataque no tiene efecto.
        }
    }

    // Método para curar al personaje. Cura 20 puntos de salud, pero no puede superar los 100 de salud.
    public void Cure()
    {
        if ((this.Health + 20) > 100)
        {
            this.Health = 100;
        }
        else
        {
            this.Health += 20;
        }
    }

    // Método para agregar ítems a la lista del personaje, siempre que esté vivo.
    public void AddItem(IItem item)
    {
        if (this.Alive)
        {
            this.items.Add(item);   
        }
    }

    // Método para quitar ítems de la lista del personaje, siempre que esté vivo.
    public void RemoveItem(IItem item)
    {
        if (this.Alive)
        {
            this.items.Remove(item);   
        }
    }

    // Método para aumentar la experiencia del personaje.
    public void agregarEXP(int value)
    {
        this.EXP += value;
    }
}
