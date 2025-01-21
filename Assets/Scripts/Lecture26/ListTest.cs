using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    
    void Start()
    {
        // LaraList<int> laraList = new LaraList<int>(){1 , 2 , 3 ,4,5,6,7,8,9,10};
        LaraList<int> laraList = new LaraList<int>(){1 };



        // for(int i=0 ; i < laraList.Count ; i++)
        // {
        //     Debug.Log(laraList[i]);
        // }

        foreach(var num in laraList)
        {
            Debug.Log(num);
        }
    }

   
}

public class LaraList<T> : IEnumerable<T>
{
    T [] _value = new T[5];

    int capacity = 5;
    int _count;

    public int Count 
    {
        get {return _count;}
        private set { _count=value;}
    }

    public T this [int index]
    {
        get { return _value[index];}
        set { _value [index] = value;}
    }

    public IEnumerator<T> GetEnumerator()
    {
       return new LaraListEnumurator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public  void Add(T item)
    {
       if(Count >= capacity)
       {
            T [] Temp = new T[capacity *2];
            _value.CopyTo(Temp,0);
            _value = Temp;
       }
       _value[Count++]=item;
    }


    private class LaraListEnumurator : IEnumerator<T>
    { LaraList<T> Lara;
      int index =-1;
        public LaraListEnumurator (LaraList<T> lara)
        {
           Lara = lara;
        }
        public T Current
        {
            get { return Lara._value[index]; }
        }
        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
           return (++index) < Lara.Count;
        }

        public void Reset()
        {
             index =-1;
        }
    }
}
