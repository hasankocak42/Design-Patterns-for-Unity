using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bu classý kalýtarak kolay bir þekilde yeni singleton nesneleri oluþturabiliriz.
//Bunun için generic yapýda oluþturmamýz gerekiyor.
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

                //Eðer sahnede obje yoksa bir obje oluþturabiliriz.
                if (instance==null)
                {
                instance = new GameObject("MonoSingletonCreated").AddComponent<T>();

                }
                
            }
            return instance;
        }
    }
}
