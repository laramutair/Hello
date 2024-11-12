using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Character
{ 
     public Player1(string name, int health) : base(name, health) {}

    //public Player1() : base (name , health){}
    public void Heal(int value){
        Health += value;
        Debug.Log( Name+ " health has become: "+ Health);

    }
}
