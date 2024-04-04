using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetrasJuego : MonoBehaviour
{
    [SerializeField] private Puntos puntaje;

    private void OnTriggerEnter(Collider objeto){

        if(objeto.tag != "Player" & objeto.tag == "Respawn"){
            
            puntaje.AgregarSecundario();
            gameObject.SetActive(false);               
        }
        

    }
}
