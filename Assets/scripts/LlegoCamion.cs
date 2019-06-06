using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlegoCamion : MonoBehaviour
{
    public GameObject nivel1, nivel2, nivel3;
    GameObject camion;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("LLegaste");
        camion = other.gameObject;
        Invoke("SiguienteNivel", 1f);
    }

    void SiguienteNivel() {
        if (nivel1.activeSelf)
        {
            nivel1.SetActive(false);
            nivel2.SetActive(true);
            camion.transform.position = new Vector3(-24,6,24);
            //Llegada poner en ubi
        }
        else if (nivel2.activeSelf)
        {
            nivel2.SetActive(false);
            nivel3.SetActive(true);
            camion.transform.position = new Vector3(24, 6, 24);
            //Llegada poner en ubi
        }
        else {
            //Muestra pantalla inicio
            //
        }
    }
}
