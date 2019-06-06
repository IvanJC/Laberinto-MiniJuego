using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamion : MonoBehaviour
{

    Rigidbody rb;
    public float velocidad;
    private bool moving = false;

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
            //Arriba
            if (Input.GetKey(KeyCode.W))
            {

                rb.velocity = new Vector3(0, 0, -velocidad);
            }
            //Izquierda
            if (Input.GetKey(KeyCode.A))
            {

                //this.gameObject.transform.Rotate(0, 180, 0, Space.World);
                rb.velocity = new Vector3(velocidad, 0, 0);
            }
            //Abajo
            if (Input.GetKey(KeyCode.S))
            {

                //this.gameObject.transform.Rotate(0, 90, 0, Space.World);
                rb.velocity = new Vector3(0, 0, velocidad);
            }
            //Derecha
            if (Input.GetKey(KeyCode.D))
            {

                //this.gameObject.transform.Rotate(0, 0, 0, Space.World);
                rb.velocity = new Vector3(-velocidad, 0, 0);
            }
        }
    }
}
