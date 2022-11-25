using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act3 : MonoBehaviour
{
    public int divider;
    public int divisor;

    // Start is called before the first frame update
    void Start()
    {
        IsExact(divider, divisor);
    }
    private void IsExact( int divider1, int divisor2)
    {
        if (divider1 % divisor2 == 0)
        {
            Debug.Log("Es una division exacta");
        }
        else
        {
            Debug.Log("No es una division exacta");
        }
    }
  
}
