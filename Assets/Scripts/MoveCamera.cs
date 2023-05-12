using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float moveOffset = 1.0f;

    void Update()
    {
        this.transform.position += moveOffset * Vector3.back;
    }
}
