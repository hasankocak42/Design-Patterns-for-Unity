using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bu class� kal�tarak kolay bir �ekilde yeni singleton nesneleri olu�turabiliriz.
//Bunun i�in generic yap�da olu�turmam�z gerekiyor.
//Polimorfizm

public class MonoSingleton<T> : MonoBehaviour where T: MonoSingleton<T>
{
    
    private static T instance = null;

    public static T Instance
    {
        get
        {
            if (instance==null)
            {
                //Sahnede bu instance tipinde bir obje varsa onu buluyoruz.
                instance = FindObjectOfType(typeof(T)) as T;

                //E�er sahnede obje yoksa bir obje olu�turabiliriz.
                if (instance==null)
                {
                instance = new GameObject("MonoSingletonCreated").AddComponent<T>();

                }
                
            }
            return instance;
        }
    }
}
