using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EspaciadoraSalir : MonoBehaviour
{
    public GameObject PanelDeCarga;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(CargarNivel(1));
        }
    }

    IEnumerator CargarNivel(int nombreNivel){

      AsyncOperation cargar = SceneManager.LoadSceneAsync(nombreNivel);
      PanelDeCarga.SetActive(true);

      while (!cargar.isDone){

         yield return null;

      }
   }
}
