using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    [SerializeField] private float puntos;
    [SerializeField] private PuntajeTemporal puntajeT;
    [SerializeField] private PuntajeAgarrados puntaje;
    public AudioSource exito, final;
    public GameObject objMarcador, felicitaciones, manos, palabras;

    public void AgregarSecundario(){
        puntajeT.SumarPuntos();
        float p = puntajeT.getPuntaje();

        if(p == puntos){
            puntaje.SumarPuntos();
            objMarcador.GetComponent<SiguientePalabra>().Siguiente();
            puntajeT.PerderPuntos();
            palabras.SetActive(false);
        }

        if(puntaje.getPuntaje() != 4){
                exito.Play();
        }
        else{
            objMarcador.SetActive(false);
            manos.SetActive(false);
            felicitaciones.SetActive(true);
            final.Play();
        }
    }
}
