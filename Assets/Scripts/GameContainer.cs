using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Class 1: Game Container 
public class GameContainer<T> 
{
    T item;

    public GameContainer (T item)
    {
        this.item=item ;

    }

    public void SetItem(T item){
        this.item=item;
    }
    
    public T GetItem(){
        return item;
    }
}

//Class 2: Game Utils
public class GameUtils
{
    public static string  DescribeItem<T>(T something)
    {
        return "This item is " + something+".";

    }
}

