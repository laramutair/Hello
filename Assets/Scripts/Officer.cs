using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
public class Officer : Character1
{
   public Officer(string name, int health, Position position) : base(name, health, position) 
     {

     }
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }

}
}