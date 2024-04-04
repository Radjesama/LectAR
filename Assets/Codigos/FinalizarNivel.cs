using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizarNivel : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(audio.isPlaying){
            Debug.Log("Llevo: " + time + " de " + clip.length);
            time += Time.deltaTime;
        }
        if(time >= 6){
            SceneManager.LoadScene(1);
        }
    }
}
