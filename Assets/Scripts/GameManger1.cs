using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player1 player = new Player1 ("Subhi", 80);
        Enemy enemy = new Enemy("Zarifeh", 100);

        player.Heal(15);
        enemy.Attack(player, 20);
        
    }

   
}
