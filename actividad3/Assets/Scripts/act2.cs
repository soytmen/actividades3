using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act2 : MonoBehaviour
{
    public int randomNumber;

    private bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            Debug.Log("Es par");
            return true;
        }
        else
        {
            Debug.Log("No es par");
            return false;
        }
    }
    void Start()
    {
        IsEven(randomNumber);
    }

    
}
