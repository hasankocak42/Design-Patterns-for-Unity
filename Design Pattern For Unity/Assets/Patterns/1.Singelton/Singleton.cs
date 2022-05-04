using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private string text;
    private static Singleton instance = null;

    public static Singleton Instance
    {
        
        get
        {
            

            if (instance == null)
            {
                instance = new GameObject("SingeltonCreated").AddComponent<Singleton>();
            }
            return instance;
        }
        
    }

    private void OnEnable()
    {
        
        instance = this;
        text = "Deneme Singleton";
    }
    public string GetText()
    {
        return text;
    }

}
