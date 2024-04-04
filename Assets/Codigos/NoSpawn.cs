using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSpawn : MonoBehaviour
{
    [SerializeField] private PuntajeAgarrados puntaje;
    public GameObject uno, dos, tres;
    private bool primero, segundo, tercero;
    float puntos;

    public void Excepciones(){
        
        puntos = puntaje.getPuntaje();
        Debug.Log(puntos);

        if (puntos > 0){

            primero = uno.activeSelf;
            segundo = dos.activeSelf;
            tercero = tres.activeSelf;

        }
    }

    public void Actividad(){

        if (puntos > 0){

            uno.SetActive(primero);
            dos.SetActive(segundo);
            tres.SetActive(tercero);

        }
    }
}
