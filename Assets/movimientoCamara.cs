using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCamara : MonoBehaviour
{
    public GameObject Target;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Target.transform.position;
    }


    void FixedUpdate()
    {
        transform.position = Target.transform.position + offset;
    }
}
