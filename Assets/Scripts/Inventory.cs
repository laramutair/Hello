using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
   private List<string> items=new List<string>();

   public void AddItem(string item)
   {
     items.Add(item);
   }

   public void ShowItem()
   {
    for(int i=0 ; i<items.Count; i++)
    {
        Debug.Log(items[i]);
    }
   }
   
   public static Inventory operator + (Inventory item1, Inventory item2)
   {
     
       Inventory combine = new Inventory();
       for(int i=0; i<item1.items.Count ; i++)
       {
        combine.AddItem(item1.items[i]);
          
       }

       for(int i=0; i<item2.items.Count ; i++)
       {
        combine.AddItem(item2.items[i]);
          
       }

       return combine; 
   }
    
}
