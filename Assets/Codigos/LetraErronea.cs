using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraErronea : MonoBehaviour
{
    public Transform inicial;
    public AudioSource error;

    private void OnTriggerEnter(Collider objeto){

        if(objeto.tag == "Respawn"){
            
            gameObject.SetActive(false);
            gameObject.transform.position = inicial.position;
            error.Play();
            gameObject.SetActive(true);

        }
        
    }
}
