using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act4 : MonoBehaviour
{
    public Vector3 Pos = new Vector3(0, 0, 0);

    void Start()
    {
        Movment (Pos);
    }
    private void Movment(Vector3 position)
    {
        transform.position=position;
    } 
    
}