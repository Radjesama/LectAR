using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeleccionarNivel : MonoBehaviour
{

   public GameObject PanelDeCarga;

   public void seleccionarNivel(int nombreNivel){

    StartCoroutine(CargarNivel(nombreNivel));

   }

   IEnumerator CargarNivel(int nombreNivel){

      AsyncOperation cargar = SceneManager.LoadSceneAsync(nombreNivel);
      PanelDeCarga.SetActive(true);

      while (!cargar.isDone){

         yield return null;

      }
   }
}
