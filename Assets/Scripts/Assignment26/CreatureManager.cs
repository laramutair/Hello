using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment26
{
public class CreatureManager : MonoBehaviour
{
   
    void Start()
    {
        List<Creature> creatures = new List<Creature>(){new Kangaroo() , new Duck()};
        List<IRunnable> runnables = new List<IRunnable> (){new Kangaroo(), new Duck()};
        List<IJumpable> jumpables = new List<IJumpable> (){new Kangaroo()};
        List<ISwimmable> swimmables = new List<ISwimmable> (){new Duck()};


        foreach(Creature creature in creatures)
        {
            creature.Speak();
        }

        foreach(IRunnable runnable in runnables)
        {
            runnable.Run();
        }

        foreach(IJumpable jumpable in jumpables)
        {
            jumpable.Jump();
        }

        foreach(ISwimmable swimmable in swimmables)
        {
            swimmable.Swim();
        }

       

    }

   
}
}
