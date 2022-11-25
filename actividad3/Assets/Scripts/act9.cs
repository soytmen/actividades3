using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act9 : MonoBehaviour
{
    public float base1;
    public float height;

    private void Calculator(float base2, float height1)
    {
        if (base2 < 0 || height1 < 0)
        {
            Debug.Log("The area cannot be calculated");
        }
        else if (base2 == 0 || height1== 0)
        {
            Debug.Log("The area cannot be calculated");
        }
        else
        {
            Debug.Log($"“The area of the triangle is {base2 * height1 / 2}");
        }
    }
    void Start()
    {
        Calculator(base1, height);
    }

    
}
