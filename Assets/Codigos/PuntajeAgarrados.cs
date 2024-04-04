using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntajeAgarrados : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI texto;

    private void Start(){
        texto = GetComponent<TextMeshProUGUI>();
        puntos = 0;
    }

    private void Update(){
        texto.text = puntos.ToString("0");
    }

    public void SumarPuntos(){
        puntos += 1;
    }

    public void PerderPuntos(){
        puntos = 0;
    }

    public float getPuntaje(){
        return this.puntos;
    }

}
