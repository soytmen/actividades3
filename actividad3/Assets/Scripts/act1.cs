using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act1 : MonoBehaviour
{
    public string RandomLetter;

    // Start is called before the first frame update
    void Start()
    {
        IsVowel(RandomLetter);
    }
    private bool IsVowel(string letter)
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u"){
            Debug.Log("es una vocal");
            return true;
        }
        else {
            Debug.Log("es una consonante");
            return false;
        }

    }
}

    
