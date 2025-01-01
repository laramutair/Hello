using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{


public class TypeManagementScript : MonoBehaviour
{
   Cat cat1;
   
    void Start()
    {
       // Type casting
        cat1 = new Cat();  
        Animal animal = cat1;    //Up Casting
        animal.MakeSound();
        animal.Move();

        Cat cat2= animal as Cat;   //Down Casting

        cat2.MakeSound();
        cat2.Move();

        //Type Checking
         List<ICanFight> list=new List<ICanFight>(){new Cat(), new Warrior()};
         foreach(ICanFight canFight in list)
         {
            canFight.Attack();

            if(canFight is Cat)
              Debug.Log("The object is a Cat.");
            else if( canFight is Warrior)
              Debug.Log("The object is a Warrior.");
              
         }
        
    }

  
    void Update()
    {
        
    }
}

public interface ICanFight
{
    public void Attack();
}

public class Animal
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal sound");

    }

    public void Move()
    {
        Debug.Log("Animal moves");
    }
} 

public class Cat : Animal ,  ICanFight
{
        public override void MakeSound()
        {
            Debug.Log("Meow");
        }

        public void Move()
        {
            Debug.Log("Cat runs quickly!");
        }
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }

 }

 public class Warrior:ICanFight
 {
    public void Attack()
    {
        Debug.Log("Warrior attacks with a sword!");
    }
 }
}
