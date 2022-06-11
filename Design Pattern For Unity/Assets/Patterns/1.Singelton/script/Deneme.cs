using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        Debug.Log(Singleton.Instance.GetText());
        Debug.Log(GameManager.Instance.GetText());
    }
}
