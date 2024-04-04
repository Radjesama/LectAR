using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCuatro : MonoBehaviour
{
    private static List<GameObject> objetos = new List<GameObject>();
    private static int indiceActual = 0;
    public GameObject objeto1, objeto2, objeto3, objeto4;
    public GameObject puntaje;

    public void Iniciar()
    {
        CrearListaObjetos();
        OrdenarObjetosAleatoriamente();
    }

    private void CrearListaObjetos()
    {
        // Agregar los 4 objetos a la lista
        objetos.Add(objeto1);
        objetos.Add(objeto2);
        objetos.Add(objeto3);
        objetos.Add(objeto4);
    }

    private void OrdenarObjetosAleatoriamente()
    {
        // Mezclar los objetos en forma aleatoria sin repetirse
        int n = objetos.Count;
        while (n > 1)
        {
            n--;
            int randomIndex = Random.Range(0, n + 1);
            GameObject temp = objetos[randomIndex];
            objetos[randomIndex] = objetos[n];
            objetos[n] = temp;
        }
    }

    public GameObject ObtenerObjetoSiguiente()
    {
        // Obtener el siguiente objeto en el orden aleatorio
        if (indiceActual < objetos.Count)
        {
            GameObject objeto = objetos[indiceActual];
            indiceActual++;
            return objeto;
        }
        else
        {
            // Si ya se han entregado todos los objetos, regresar null
            return null;
        }
    }

    public void ObtenerPrimerObjeto()
    {
        GameObject objeto = null;
        indiceActual = 0;

        if(!puntaje.activeSelf){
            objeto = objetos[0];
            indiceActual++;
            objeto.SetActive(true);
            Debug.Log("Deberia mostrarte el primer objeto");
            Debug.Log("El indice actual es: "+ indiceActual);
        }
    }

}
