using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Player 
{
    public string playerName;
    public int health;
    static int playerCount=0;

    public void InitializePlayer(string name, int initialHealth){
        playerName = name;
        health = initialHealth;
         playerCount++;
    }

    public void Heal(int value){
        health+=value;
        Debug.Log(playerName +" health has become: " + health);
    }
    public void Heal(bool fullRestore){
        if( fullRestore == true)
          Debug.Log(playerName +" health has become: " + health);;
    }
    public static void ShowPlayerCount(){
        Debug.Log("Player Count is: " + playerCount);
    }



}

