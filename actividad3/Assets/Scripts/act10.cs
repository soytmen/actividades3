using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act10 : MonoBehaviour
{
    public Vector3 Dimensions = new (1, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        Scale(Dimensions);
    }

    private void Scale(Vector3 scale)
    {
        transform.localScale = Dimensions;
    }
}
