using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
public class CustomObject 
{
   int ID;
   string name;

   public CustomObject(int Id , string name)
   {
    this.ID = Id;
    this.name = name;
   }

    public override string ToString()
    {
       return $"Object [ ID: {ID}, Name: {name} ]";
    }

    // public override bool Equals(object obj)
    // {
    //     CustomObject customObject1= obj as CustomObject;  //UnBoxing Cast
    //     if(customObject1 == null) 
    //        return false;
    //     else if( this.ID == customObject1.ID && this.name == customObject1.name)
    //        return true;
    //     else 
    //        return false;

    // }


    public static bool   operator ==(CustomObject c1 , CustomObject c2)
    {
        if( !c1.Equals(null) && !c2.Equals(null))
        {
            if(c1.ID.Equals(c2.ID) && c1.name.Equals(c2.name))
               return true;
           
        }
        return false;
    }

    public static bool   operator !=(CustomObject c1 , CustomObject c2)
    {
       if( !c1.Equals(null) && !c2.Equals(null))
        {
            if(c1.ID.Equals(c2.ID) && c1.name.Equals(c2.name))
               return false;
        }
        return true;
    }




}
}
