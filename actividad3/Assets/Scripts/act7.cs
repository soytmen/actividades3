using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act7 : MonoBehaviour
{
    public float num;

    public float AbsoluteNum(float num1)
    {
        if (num1 < 0)
        {
            return (num1 * -1);
        }
        else
        {
            return num1;
        }
    }
    void Start()
    {
        AbsoluteNum(num);
    }

  
}
