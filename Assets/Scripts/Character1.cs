using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class Character1 
{
    public string name;
    private int health;
    protected Position position;

    public int Health
    {
        get{ return health;}
        set{
            if (value<=100 && value>=0) 
               health = value;
        }

    }

    public Character1(string name , int health , Position position)
    {
        this.name = name;
        this. health = health;
        this.position=position;

    }
    public Character1():this("No name",100,new Position(0,0,0))
    {

    }

    public virtual void DisplayInfo()
    {
        Debug.Log("The name is: "+name+", the health is: "+ Health);
        position.PrintPosition();
    }
    public void Attack(int damage, Character target)
    {
        target.Health-=damage;
        Debug.Log(name+" health has become: "+ target.Health);

    }
    public void Attack(int damage, Character target , string attackType)
    {
        Attack( damage,  target);   //Apply the DRY principle
        Debug.Log("The attack type is: "+ attackType);

    }
}
}