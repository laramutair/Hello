using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // Testing for part one of Assignment 18.
        GameContainer<string> test = new GameContainer<string>("Healing potion "); 
        Debug.Log("Stored item: "+test.GetItem());
        Debug.Log(GameUtils.DescribeItem("Healing potion"));

        // Testing for part one of Assignment 18.

        Inventory item1= new Inventory();
        item1.AddItem("Healing Potion");
        item1.AddItem("Strength Potion");
;


        Inventory item2 =new Inventory ();
        item2.AddItem("Elixir");
        item2.AddItem("Elixir Dark");

        Inventory combinedInventory = item1 + item2;

        
        combinedInventory.ShowItem();

        
    }

    
}
