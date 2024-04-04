using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguientePalabra : MonoBehaviour
{
    public GameObject controlador;

    public void Siguiente(){
        
        GameObject siguienteObjeto = controlador.GetComponent<SpawnCuatro>().ObtenerObjetoSiguiente();

        if (siguienteObjeto != null) {
            
            siguienteObjeto.SetActive(true);
        }
        else{
            
            Debug.Log("No hay más objetos disponibles");
        }
    }
}
