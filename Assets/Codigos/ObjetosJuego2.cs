using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ObjetosJuego2 : MonoBehaviour
{
    //public Transform inicial;
    [SerializeField] private PuntajeAgarrados puntaje;
    public AudioSource audio;
    public AudioSource final;
    public GameObject felicitaciones, manos, marcador, erroneo1, erroneo2, erroneo3;

    private void OnTriggerEnter(Collider objeto){

        if(objeto.tag != "Player" & objeto.tag == "Respawn"){
            
            puntaje.SumarPuntos();
            gameObject.SetActive(false);
            float puntos = puntaje.getPuntaje();

            if(puntos != 2){
                audio.Play();
            }  

            if(puntos == 2){
                if(erroneo1 != null && erroneo2 != null && erroneo3 !=null){
                    erroneo1.SetActive(false);
                    erroneo2.SetActive(false);
                    erroneo3.SetActive(false);
                }
                
                marcador.SetActive(false);
                manos.SetActive(false);
                felicitaciones.SetActive(true);
                final.Play();
            }    
               
        }
        else{
            if(objeto.tag != "Player" & objeto.tag != "Respawn"){

                //this.transform.position = inicial.position;

            }
        }
        

    }


    
}
