using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act5 : MonoBehaviour
{
    public int num;

    private void Mult(int num1)
    {
        Debug.Log($"{num1} x 1 = {num1 * 1}");
        Debug.Log($"{num1} x 2 = {num1 * 2}");
        Debug.Log($"{num1} x 3 = {num1 * 3}");
        Debug.Log($"{num1} x 4 = {num1 * 4}");
        Debug.Log($"{num1} x 5 = {num1 * 5}");
        Debug.Log($"{num1} x 6 = {num1 * 6}");
        Debug.Log($"{num1} x 7 = {num1 * 7}");
        Debug.Log($"{num1} x 8 = {num1 * 8}");
        Debug.Log($"{num1} x 9 = {num1 * 9}");
        Debug.Log($"{num1} x 10 = {num1 * 10}");
    }
    void Start()
    {
        Mult(num);
    }
 }
