using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoErroneo : MonoBehaviour
{
    private Transform inicial;
    public AudioSource audio;
    public GameObject respawn;

    private void OnTriggerEnter(Collider objeto){

        if(objeto.tag == "Respawn"){
            
            gameObject.SetActive(false);
            respawn.GetComponent<Spawn>().Aparecer();
            audio.Play();
            gameObject.SetActive(true);

        }
        
    }

}
