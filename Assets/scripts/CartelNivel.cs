using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartelNivel : MonoBehaviour
{
    public GameObject mensajeNivel;

    void Start()
    {
        if(niveles.nivelActual == 1)
        {
            mensajeNivel = Instantiate(mensajeNivel, transform);
            niveles.pausa = true;
        }

        Invoke("DestruirMensajeNivel", 4f);

    }

    
    void DestruirMensajeNivel()
    {
        Destroy(mensajeNivel);
        niveles.pausa = false;
    }
}
