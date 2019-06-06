using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class manejadorEscena : MonoBehaviour
{
    public void CargarNivel(string pNombreNivel)
    {
        SceneManager.LoadScene(pNombreNivel);
    }
}
