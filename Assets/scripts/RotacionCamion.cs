using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionCamion : MonoBehaviour
{
    Rigidbody rb;
    private bool colisionPuente = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!niveles.pausa)
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }

        }
    }

    private void OnTriggerEnter(Collider col)
    {
       
    }
}
