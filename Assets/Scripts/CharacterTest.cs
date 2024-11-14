using System.Collections;
using System.Collections.Generic;
using Assignment16;
using UnityEngine;
namespace Assignment16
{
public class CharacterTest : MonoBehaviour
{
     Character1[] characters;

    void Start()
    {
            characters = new Character1[2];
            characters[0] = new Soldier(); 
            characters[1] = new Officer(" Lara ", 95, new Position(10, 10, 20));

             for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            Character1 soldier = characters[0];
            Character1 officer = characters[1];

            Debug.Log(soldier.Health);

            officer.Attack(10,soldier);

            Debug.Log(soldier.Health);




       

        
    }

    
}
}
