using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act6 : MonoBehaviour
{
    public float num1;
    public float num2;

    private float IsLarger(float number1, float number2)
    {
        if (number1 > number2)
        {
            return number2;
        }
        else
        {
            return number1;
        }
        
    }
    void Start()
    {
        IsLarger(num1, num2);
    }
}
