using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationOffset = 0.01f;
    void Update()
    {
        this.transform.Rotate(rotationOffset * Vector3.back);
    }
}
