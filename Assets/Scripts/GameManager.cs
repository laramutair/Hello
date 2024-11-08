using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();
        p1.InitializePlayer("Lara", 100);
        p2.InitializePlayer("Lamar", 50);
        p2.Heal(10);
        p2.Heal(true);
        Player.ShowPlayerCount();





        
    }

    
}
