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
        //Arriba
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(-90,-90,0);
            //this.gameObject.transform.Rotate(0, (-90), 0, Space.World);
            rb.velocity = new Vector3(0, 0, velocidad);
        }
        //Izquierda
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(-90, 180, 0);
            //this.gameObject.transform.Rotate(0, 180, 0, Space.World);
            rb.velocity = new Vector3(-velocidad, 0, 0);
        }
        //Abajo
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(-90, 90, 0);
            //this.gameObject.transform.Rotate(0, 90, 0, Space.World);
            rb.velocity = new Vector3(0, 0, -velocidad);
        }
        //Derecha
        if (Input.GetKey(KeyCode.D)) {
            transform.rotation = Quaternion.Euler(-90, 0, 0);
            //this.gameObject.transform.Rotate(0, 0, 0, Space.World);
            rb.velocity = new Vector3(velocidad, 0, 0);
        }
    }
}
