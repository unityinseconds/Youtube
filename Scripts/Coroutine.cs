using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called once befoe the first execution of Update after the MonoBehaviour is created

    IEnumerator Example()
    { 
           Debug.Log("Coroutine started");
              yield return new WaitForSeconds(2);
             Debug.Log("Coroutine ended after 2 seconds");
    }

    void Start()
    {
        StartCoroutine(Example());
    }

}
